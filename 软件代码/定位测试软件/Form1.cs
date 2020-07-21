using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Aspose.Cells;//添加的引用,操作表格
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using WindowsFormsApplication2.ServiceReference1;

namespace WindowsFormsApplication2
{
    //Form1继承自Form
    public partial class Form1 : Form 
    {
        static int batch = 0;//定义批次变量
        int rssi1 = 0;
        int rssi2 = 0;
        double d1 = -1;
        double d2 = -1;
        double x_last = 0;
        double y_last = 0;
        double x = 0;
        double y = 0;
        Random ran = new Random();
        double c = 4;//两个基站之间的距离、单位M
        int i = 0;//行为预测算法判断错误点计数
        int n0 = 0;//0,0信号采集个数
        int n1 = 0;//0,1信号采集个数
        SerialPort sp = null;//声明一个串口类
        bool isOpen = false;//打开串口标志位
        bool SeriesOpen = false;//图表序列对象建立标志
        bool isSetProperty = false;//属性设置标志位
        bool isHex = false;//十六进制显示标志位

        Series Speed;
        Series RSSI_0;
        Series RSSI_1;

        //private TestservicePortClient service;//WEB服务对象 


        public Form1()
        {
            InitializeComponent();
        }
        private void btnCheckCOM_Click(object sender, EventArgs e)
        {
            bool comExistence = false;//有可用串口标志位
            cbxCOMPort.Items.Clear();//清除当前串口号中的所有串口名称
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
                    comExistence = true;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            if (comExistence)
            {
                cbxCOMPort.SelectedIndex = 0;//使ListBox显示第一个添加的索引

            }
            else
            {
                MessageBox.Show("没有找到可用的端口！", "错误提示");
            }
        }
        private bool CheckPortSetting()//检查串口是否设置
        {
            if (cbxCOMPort.Text.Trim() == "") return false;
            if (cbxBaudRate.Text.Trim() == "") return false;
            if (cbxDataBits.Text.Trim() == "") return false;
            if (cbxParity.Text.Trim() == "") return false;
            if (cbxStopBits.Text.Trim() == "") return false;
            return true;
        }
        private bool CheckSendData()//检查发送数据是否为空
        {
            if (tbxSendData.Text.Trim() == "") return false;
            return true;
        }
        private void SetPortProperty()//设置串口的属性
        {
            sp = new SerialPort();
            sp.PortName = cbxCOMPort.Text.Trim();//设置串口名
            sp.BaudRate = Convert.ToInt32(cbxBaudRate.Text.Trim());//设置串口的波特率
            float f = Convert.ToSingle(cbxStopBits.Text.Trim());//设置停止位
            if (f == 0)
            {
                sp.StopBits = StopBits.None;
            }
            else if (f == 1.5)
            {
                sp.StopBits = StopBits.OnePointFive;
            }
            else if (f == 1)
            {
                sp.StopBits = StopBits.One;
            }
            else if (f == 2)
            {
                sp.StopBits = StopBits.Two;
            }
            else
            {
                sp.StopBits = StopBits.One;
            }
            sp.DataBits = Convert.ToInt16(cbxDataBits.Text.Trim());//设置数据位

            string s = cbxParity.Text.Trim();//设置奇偶校验位
            if (s.CompareTo("无") == 0)
            {
                sp.Parity = Parity.None;
            }
            else if (s.CompareTo("奇校验") == 0)
            {
                sp.Parity = Parity.Odd;
            }
            else if (s.CompareTo("偶校验") == 0)
            {
                sp.Parity = Parity.Even;
            }
            else
            {
                sp.Parity = Parity.None;
            }
            sp.ReadTimeout = -1;//设置超时读取时间
            sp.RtsEnable = true;
            //定义DataReceived事件,当接收到数据后触发事件
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            if (rbnHex.Checked)
            {
                isHex = true;
            }
            else
            {
                isHex = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)//发送串口数据
        {
            if (isOpen)//写串口数据
            {
                try
                {
                    sp.WriteLine(tbxSendData.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("发送数据时发生错误！", "错误提示");
                    return;
                }
            }
            else
            {
                MessageBox.Show("串口没打开","错误提示");
                return;
            }
            if (!CheckSendData())//检测要发送的数据
            {
                MessageBox.Show("请输入要发送的数据！","错误提示");
                return;
            }
        }
        

        private void btnOpenCom_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                if (!CheckPortSetting())//检测串口设置
                {
                    MessageBox.Show("串口未设置！", "错误提示");
                    return;
                }
                if (!isSetProperty)//串口未设置则设置串口
                {
                    SetPortProperty();
                    isSetProperty = true;
                }
                try//打开串口
                {
                    sp.Open();
                    isOpen = true;
                    btnOpenCom.Text = "关闭串口";
                    //串口打开后则相关的串口设置按钮便不可在用
                    cbxCOMPort.Enabled = false;
                    cbxBaudRate.Enabled = false;
                    cbxDataBits.Enabled = false;
                    cbxParity.Enabled = false;
                    cbxStopBits.Enabled = false;
                    rbnChar.Enabled = false;
                    rbnHex.Enabled = false;
                }
                catch (Exception)
                {
                    //打开串口失败后，相应标志位取消
                    isSetProperty = false;
                    isOpen = false;
                    MessageBox.Show("串口无效或已被占用！", "错误提示");
                }
            }
            else
            {
                try//打开串口
                {
                    sp.Close();
                    isOpen = false;
                    isSetProperty = false;
                    btnOpenCom.Text = "打开串口";
                    //关闭串口后，串口设置选项便可以继续使用
                    cbxCOMPort.Enabled = true;
                    cbxBaudRate.Enabled = true;
                    cbxDataBits.Enabled = true;
                    cbxParity.Enabled = true;
                    cbxStopBits.Enabled = true;
                    rbnChar.Enabled = true;
                    rbnHex.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("关闭串口时发生错误","错误提示");
                }
            }
        }
        /// <summary>
        /// 数据接收与处理方法
        /// </summary>
        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(100);//延迟100ms等待接收完数据
            //this.Invoke就是跨线程访问ui的方法
            try
            {
                this.Invoke((EventHandler)
                    (delegate
                    {
                        if (isHex == false)
                        {
                            tbxRecvData.Text += sp.ReadLine();
                        }
                        else
                        {
                            Byte[] ReceivedDate = new Byte[sp.BytesToRead];//创建接收字节数组
                            sp.Read(ReceivedDate, 0, ReceivedDate.Length);//读取所接收到的数据
                            String RecvDataText = null;
                            tbxDataLength.Text = ReceivedDate.Length.ToString();//显示读取数据的位数
                            tbxRssi.Text = ReceivedDate[2].ToString("X2");//显示读取的rssi的值
                            if (ReceivedDate[0].ToString("X2") == "00" && ReceivedDate[1].ToString("X2") == "00")
                            {
                                rssi1 = Convert.ToInt32(tbxRssi.Text, 16);//rssi值转化为10进制值
                                //int rssiTrue1 = ~rssi1 + 1;//对rssi1整形数据按位取反末位加一
                                tbxToInt32.Text = rssi1.ToString();//显示
                                //向ListView中添加数据
                                ListViewItem tem1 = listView1.Items.Add((listView1.Items.Count + 1) + " ");
                                tem1.SubItems.Add(tbxRssi.Text);
                                tem1.SubItems.Add(tbxToInt32.Text);
                                //double d1 = System.Math.Pow(10,(System.Math.Abs(rssi1)-208)/);//距离换算
                                d1 = Math.Pow(Math.E,(201.86-rssi1)/12.87);
                                //调用0，0点RSSI值显示
                                change_chart2(rssi1);
                            }
                            else if(ReceivedDate[0].ToString("X2") == "00" && ReceivedDate[1].ToString("X2") == "01")
                            {
                                rssi2 = Convert.ToInt32(tbxRssi.Text, 16);//rssi值转化为10进制值
                                tbxToInt32.Text = rssi2.ToString();//显示
                                //向ListView中添加数据 
                                ListViewItem tem2 = listView2.Items.Add((listView2.Items.Count+1)+" ");
                                tem2.SubItems.Add(tbxRssi.Text);
                                tem2.SubItems.Add(tbxToInt32.Text);
                                //距离
                                d2 = Math.Pow(Math.E, (201.86 - rssi2) / 12.87);
                                //调用0，1点RSSI值显示
                                change_chart3(rssi2);
                            }
                            if (d1 >= 0 && d2 >=0)
                            {
                                
                                //调用行为预测算法
                                actionForecast();
                                
                                x = (Math.Pow(d1, 2) + Math.Pow(c, 2) - Math.Pow(d2, 2)) / (2 * c);
                                y = d1 * Math.Sqrt(Math.Abs(1 - Math.Pow(x / d1, 2)));//添加了修改，可能出现X>d1的情况导致对负数开平方根报错，所以添加了绝对值函数
                                //x = x * 100;
                                //上传或获取数据
                                //if (service.addRealMonitoringDataUpdateOrInsert(batch.ToString(), "17", "hzc3", ran.Next(10, 50).ToString() + "℃", "run", "1", x.ToString(), y.ToString(), "1", "1", "0", "0", "0", "0", "0").Equals("1"))
                                //{
                                    
                                //    if (!service.addRealMonitoringData(batch.ToString(), "17", "hzc3", ran.Next(10, 50).ToString()+"℃", "run", "1", x.ToString(), y.ToString(), "1", "1", "0", "0", "0", "0", "0").Equals("1"))//将定位点发送回服务器
                                //    {
                                //        danger_signal.Text = "历史表插入数据错误";
                                //    }
                                //}
                                //else
                                //{
                                //    danger_signal.Text = "上传失败";
                                //}
                                //try {
                                //    danger_signal.Text = service.getCommanderOrder("17");//每当发送一次数据时，同时获取对该消防员的指令信息
                                //}
                                //catch (Exception) {
                                //    danger_signal.Text = "此处有错误";
                                //}
                                
                            }
                            else { }
                            for (int i = 0; i < ReceivedDate.Length-1; i++)
                            {
                                // RecvDataText += ("0x" + ReceivedDate[i].ToString("X2") + " ");
                                RecvDataText += ( ReceivedDate[i].ToString("X2") + " ");
                            }
                            tbxRecvData.Text += RecvDataText;
                        }
                        sp.DiscardInBuffer();//丢弃接收缓冲区数据
                    }));
            }
            catch (Exception)
            {
                MessageBox.Show("串口错误！","错误提示");
            }
        }

        private void btnCleanDate_Click(object sender, EventArgs e)
        {
            tbxRecvData.Text = "";
            tbxSendData.Text = "";
        }

        private void Form1_Load_Enter_1(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            for (int i = 0; i < 10; i++)//最大支持到串口10，可根据自己需求增加
            {
                cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
            }
            cbxCOMPort.SelectedIndex = 0;
            //列出常用波特率
            cbxBaudRate.Items.Add("1200");
            cbxBaudRate.Items.Add("2400");
            cbxBaudRate.Items.Add("4800");
            cbxBaudRate.Items.Add("9600");
            cbxBaudRate.Items.Add("19200");
            cbxBaudRate.Items.Add("38400");
            cbxBaudRate.Items.Add("43000");
            cbxBaudRate.Items.Add("56000");
            cbxBaudRate.Items.Add("57600");
            cbxBaudRate.Items.Add("115200");
            cbxBaudRate.SelectedIndex = 5;
            //列出停止位
            cbxStopBits.Items.Add("0");
            cbxStopBits.Items.Add("1");
            cbxStopBits.Items.Add("1.5");
            cbxStopBits.Items.Add("2");
            cbxStopBits.SelectedIndex = 1;
            //列出数据位
            cbxDataBits.Items.Add("8");
            cbxDataBits.Items.Add("7");
            cbxDataBits.Items.Add("6");
            cbxDataBits.Items.Add("5");
            cbxDataBits.SelectedIndex = 0;
            //列出奇偶检验位
            cbxParity.Items.Add("无");
            cbxParity.Items.Add("奇校验");
            cbxParity.Items.Add("偶校验");
            //默认为char显示
            rbnChar.Checked = true;
        }
        //输出Excel格式重要方法
        public void ReportToExcel(ListView list,List<int> ColumnWidth,string ReportTitleName)
        {
            //获取用户选择的Excel文件名称
            string path;
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Excel file(*.xls)|*..xls";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                //获取保存路径
                path = savefile.FileName;
                Workbook wb = new Workbook();
                Worksheet ws = wb.Worksheets[0];
                Cells cell = ws.Cells;
                //定义并获取导出的数据源
                string[,] _ReportDt = new string[list.Items.Count,list.Columns.Count];
                for (int i = 0;i < list.Items.Count;i++)
                {
                    for (int j = 0;j < list.Columns.Count;j++)
                    {
                        _ReportDt[i,j] = list.Items[i].SubItems[j].Text.ToString();
                    }
                }
                //合并第一行单元格
                Range range = cell.CreateRange(0,0,1,list.Columns.Count);
                range.Merge();
                cell["A1"].PutValue(ReportTitleName);//标题
                //设置行高
                cell.SetRowHeight(0,20);
                //设置字体样式
                Style style1 = wb.Styles[wb.Styles.Add()];
                style1.HorizontalAlignment = TextAlignmentType.Center;//文字居中
                style1.Font.Name = "宋体";
                style1.Font.IsBold = true;//设置粗体
                style1.Font.Size = 12;//设置字体大小

                Style style2 = wb.Styles[wb.Styles.Add()];
                style2.HorizontalAlignment = TextAlignmentType.Center;
                style2.Font.Size = 10;

                //给单元格关联样式
                cell["A1"].SetStyle(style1);//报表名字，样式

                //设置excel列名
                for (int i = 0;i < list.Columns.Count;i++)
                {
                    cell[1, i].PutValue(list.Columns[i].Text);
                    cell[1, i].SetStyle(style2);
                }
                //设置单元格内容
                int posStart = 2;
                for (int i = 0;i < list.Items.Count;i++)
                {
                    for (int j = 0;j < list.Columns.Count;j++)
                    {
                        cell[i + posStart, j].PutValue(_ReportDt[i,j].ToString());
                        cell[i + posStart, j].SetStyle(style2);
                    }
                }
                //设置列宽
                for (int i = 0;i<list.Columns.Count;i++)
                {
                    cell.SetColumnWidth(i,Convert.ToDouble(ColumnWidth[i].ToString()));
                }
                //保存excel表格
                wb.Save(path);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>() { 5, 18, 10, 10, 10 };//。。。。。。
            ReportToExcel(listView1,list,"0,0节点rssi值测定");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>() { 5, 18, 10, 10, 10 };//。。。。。。
            ReportToExcel(listView2, list,"0,1节点rssi值测定");
        }
        ///<summary>
        ///根据步长的行为预测算法
        ///</summary>
        void actionForecast()
        {
            //if (Math.Sqrt(Math.Pow(x - x_last, 2) + Math.Pow(y - y_last, 2)) < 1)
            //{
                tbx_x.Text = x.ToString("0.00");
                tbx_y.Text = y.ToString("0.00");
                x_last = x;
                y_last = y;
                try
                {
                    Speed.Points.AddXY(Math.Round(x, 2), Math.Round(y, 2));
                    ChartMessage.Text = "开始";
                }
                catch (Exception)
                {
                    ChartMessage.Text = "无Speed对象";
                }
                if (!ErrorMessage.Equals(""))
                {
                    ErrorMessage.Text = "";
                }
            //}
            //else
            //{
            //    ErrorMessage.Text = "该点不符合行为预测"+i;
            //    i++;
            //}
            ////当判断的错误点个数超过4个，此时人员可能已经走出上一个记录点外5米，改变判断条件
            //if (i > 4)
            //{
            //    if (Math.Sqrt(Math.Pow(x - x_last, 2) + Math.Pow(y - y_last, 2)) < 6)
            //    {
            //        tbx_x.Text = x.ToString("0.00");
            //        tbx_y.Text = y.ToString("0.00");
            //        x_last = x;
            //        y_last = y;
            //        try
            //        {
            //            Speed.Points.AddXY(Math.Round(x, 2), Math.Round(y, 2));
            //            ChartMessage.Text = "开始";
            //        }
            //        catch (Exception)
            //        {
            //            ChartMessage.Text = "无Speed对象";
            //        }
            //        if (!ErrorMessage.Equals(""))
            //        {
            //            ErrorMessage.Text = "";
            //        }

            //    }
            //    i = 0;
            //}
        }
        ///<summary>
        ///质心定位修正算法
        ///</summary>
        void centroidAmendment()
        {
        }
        /// <summary>
        /// Chart图形显示界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupBox5_Enter(object sender, EventArgs e)
        {
            
        }
        private void Paint(object sender, PaintEventArgs e)
        {
                chart1.Series.Clear();
                Speed = new Series("定位点");


                Speed.ChartType = SeriesChartType.Spline;
            //Speed.ChartType = SeriesChartType.Point;

            Speed.IsValueShownAsLabel = false;

                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 0.1;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                //chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
                chart1.ChartAreas[0].AxisX.IsMarginVisible = true;
                chart1.ChartAreas[0].AxisX.Title = "X";
                chart1.ChartAreas[0].AxisX.TitleForeColor = System.Drawing.Color.Crimson;

                chart1.ChartAreas[0].AxisY.Title = "Y";
                chart1.ChartAreas[0].AxisY.TitleForeColor = System.Drawing.Color.Crimson;
                chart1.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Horizontal;

            
            //把series添加到chart上
            chart1.Series.Add(Speed);
        }
        /// <summary>
        /// 0,0点RSSI值显示
        /// </summary>
        private void paint_RSSI_0(object sender, PaintEventArgs e)
        {
            chart2.Series.Clear();
            RSSI_0 = new Series("RSSI");

            RSSI_0.ChartType = SeriesChartType.Spline;
            RSSI_0.IsValueShownAsLabel = true;
            RSSI_0.Color = Color.Red;

            chart2.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            //chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart2.ChartAreas[0].AxisX.IsMarginVisible = true;
            chart2.ChartAreas[0].AxisX.Title = "个数";
            chart2.ChartAreas[0].AxisX.TitleForeColor = System.Drawing.Color.Crimson;

            chart2.ChartAreas[0].AxisY.Title = "RSSI";
            chart2.ChartAreas[0].AxisY.TitleForeColor = System.Drawing.Color.Crimson;
            chart2.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Horizontal;


            chart2.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;//设置滚动条是在外部显示

            chart2.ChartAreas[0].AxisX.ScrollBar.Size = 10;//设置滚动条的宽度

            chart2.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;//滚动条只显示向前的按钮，主要是为了不显示取消显示的按钮

            chart2.ChartAreas[0].AxisX.ScaleView.Size = 10;//设置图表可视区域数据点数，说白了一次可以看到多少个X轴区域

            chart2.ChartAreas[0].AxisX.ScaleView.MinSize = 1;//设置滚动一次，移动几格区域


            //把series添加到chart上
            chart2.Series.Add(RSSI_0);
        }
        void change_chart2(int rssi1)
        {
            try
            {
                RSSI_0.Points.AddXY(n0, rssi1);
                ChartMessage.Text = "开始";
                n0++;
            }
            catch (Exception)
            {
                ChartMessage.Text = "无RSSI_0对象";
            }
            if (!ErrorMessage.Equals(""))
            {
                ErrorMessage.Text = "";
            }
           
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 0,1点RSSI值显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paint_RSSI_1(object sender, PaintEventArgs e)
        {
            chart3.Series.Clear();
            RSSI_1 = new Series("RSSI");

            RSSI_1.ChartType = SeriesChartType.Spline;
            RSSI_1.IsValueShownAsLabel = true;
            RSSI_1.Color = Color.Red;

            chart3.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
            chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            //chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart3.ChartAreas[0].AxisX.IsMarginVisible = true;
            chart3.ChartAreas[0].AxisX.Title = "个数";
            chart3.ChartAreas[0].AxisX.TitleForeColor = System.Drawing.Color.Crimson;

            chart3.ChartAreas[0].AxisY.Title = "RSSI";
            chart3.ChartAreas[0].AxisY.TitleForeColor = System.Drawing.Color.Crimson;
            chart3.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Horizontal;

            chart3.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;//设置滚动条是在外部显示

            chart3.ChartAreas[0].AxisX.ScrollBar.Size = 10;//设置滚动条的宽度
            
            chart3.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;//滚动条只显示向前的按钮，主要是为了不显示取消显示的按钮

            chart3.ChartAreas[0].AxisX.ScaleView.Size = 10;//设置图表可视区域数据点数，说白了一次可以看到多少个X轴区域

            chart3.ChartAreas[0].AxisX.ScaleView.MinSize = 1;//设置滚动一次，移动几格区域


            //把series添加到chart上
            chart3.Series.Add(RSSI_1);
        }
        void change_chart3(int rssi2)
        {
            try
            {
                RSSI_1.Points.AddXY(n1, rssi2);
                ChartMessage.Text = "开始";
                n1++;
            }
            catch (Exception)
            {
                ChartMessage.Text = "无RSSI_1对象";
            }
            if (!ErrorMessage.Equals(""))
            {
                ErrorMessage.Text = "";
            }

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 界面初始化，同时实例化web服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //service = new TestservicePortClient();
        }
        /// <summary>
        /// 获取最大批次数值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getMaxBatch_Click(object sender, EventArgs e)
        {
            //batch = int.Parse(service.getBatchCodeMax());
            //batch++;
            //batch_label.Text = batch.ToString();
        }
    }
}
