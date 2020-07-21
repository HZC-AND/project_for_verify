namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Form1_Load = new System.Windows.Forms.GroupBox();
            this.rbnHex = new System.Windows.Forms.RadioButton();
            this.rbnChar = new System.Windows.Forms.RadioButton();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.btnCheckCOM = new System.Windows.Forms.Button();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.cbxCOMPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxRecvData = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCleanDate = new System.Windows.Forms.Button();
            this.tbxSendData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDataLength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxRssi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_x = new System.Windows.Forms.TextBox();
            this.tbx_y = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxToInt32 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartMessage = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.batch_label = new System.Windows.Forms.Label();
            this.getMaxBatch = new System.Windows.Forms.Button();
            this.danger_signal = new System.Windows.Forms.Label();
            this.Form1_Load.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "奇偶校验";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "数据位";
            // 
            // Form1_Load
            // 
            this.Form1_Load.Controls.Add(this.rbnHex);
            this.Form1_Load.Controls.Add(this.rbnChar);
            this.Form1_Load.Controls.Add(this.btnOpenCom);
            this.Form1_Load.Controls.Add(this.btnCheckCOM);
            this.Form1_Load.Controls.Add(this.cbxDataBits);
            this.Form1_Load.Controls.Add(this.cbxParity);
            this.Form1_Load.Controls.Add(this.cbxStopBits);
            this.Form1_Load.Controls.Add(this.cbxBaudRate);
            this.Form1_Load.Controls.Add(this.cbxCOMPort);
            this.Form1_Load.Controls.Add(this.label1);
            this.Form1_Load.Controls.Add(this.label5);
            this.Form1_Load.Controls.Add(this.label2);
            this.Form1_Load.Controls.Add(this.label4);
            this.Form1_Load.Controls.Add(this.label3);
            this.Form1_Load.Location = new System.Drawing.Point(25, 12);
            this.Form1_Load.Name = "Form1_Load";
            this.Form1_Load.Size = new System.Drawing.Size(444, 109);
            this.Form1_Load.TabIndex = 5;
            this.Form1_Load.TabStop = false;
            this.Form1_Load.Text = "串口设置";
            this.Form1_Load.Enter += new System.EventHandler(this.Form1_Load_Enter_1);
            // 
            // rbnHex
            // 
            this.rbnHex.AutoSize = true;
            this.rbnHex.Location = new System.Drawing.Point(272, 79);
            this.rbnHex.Name = "rbnHex";
            this.rbnHex.Size = new System.Drawing.Size(65, 16);
            this.rbnHex.TabIndex = 13;
            this.rbnHex.TabStop = true;
            this.rbnHex.Text = "HEX显示";
            this.rbnHex.UseVisualStyleBackColor = true;
            // 
            // rbnChar
            // 
            this.rbnChar.AutoSize = true;
            this.rbnChar.Location = new System.Drawing.Point(171, 79);
            this.rbnChar.Name = "rbnChar";
            this.rbnChar.Size = new System.Drawing.Size(71, 16);
            this.rbnChar.TabIndex = 12;
            this.rbnChar.TabStop = true;
            this.rbnChar.Text = "字符显示";
            this.rbnChar.UseVisualStyleBackColor = true;
            // 
            // btnOpenCom
            // 
            this.btnOpenCom.Location = new System.Drawing.Point(345, 47);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(75, 23);
            this.btnOpenCom.TabIndex = 11;
            this.btnOpenCom.Text = "打开串口";
            this.btnOpenCom.UseVisualStyleBackColor = true;
            this.btnOpenCom.Click += new System.EventHandler(this.btnOpenCom_Click);
            // 
            // btnCheckCOM
            // 
            this.btnCheckCOM.Location = new System.Drawing.Point(345, 14);
            this.btnCheckCOM.Name = "btnCheckCOM";
            this.btnCheckCOM.Size = new System.Drawing.Size(75, 23);
            this.btnCheckCOM.TabIndex = 10;
            this.btnCheckCOM.Text = "串口检测";
            this.btnCheckCOM.UseVisualStyleBackColor = true;
            this.btnCheckCOM.Click += new System.EventHandler(this.btnCheckCOM_Click);
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Location = new System.Drawing.Point(228, 47);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(94, 20);
            this.cbxDataBits.TabIndex = 9;
            // 
            // cbxParity
            // 
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Location = new System.Drawing.Point(228, 14);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(94, 20);
            this.cbxParity.TabIndex = 8;
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Location = new System.Drawing.Point(53, 76);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(106, 20);
            this.cbxStopBits.TabIndex = 7;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(53, 44);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(106, 20);
            this.cbxBaudRate.TabIndex = 6;
            // 
            // cbxCOMPort
            // 
            this.cbxCOMPort.FormattingEnabled = true;
            this.cbxCOMPort.Location = new System.Drawing.Point(53, 14);
            this.cbxCOMPort.Name = "cbxCOMPort";
            this.cbxCOMPort.Size = new System.Drawing.Size(106, 20);
            this.cbxCOMPort.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxRecvData);
            this.groupBox2.Location = new System.Drawing.Point(25, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 119);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据接收";
            // 
            // tbxRecvData
            // 
            this.tbxRecvData.Location = new System.Drawing.Point(12, 20);
            this.tbxRecvData.Multiline = true;
            this.tbxRecvData.Name = "tbxRecvData";
            this.tbxRecvData.Size = new System.Drawing.Size(416, 77);
            this.tbxRecvData.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.btnCleanDate);
            this.groupBox3.Controls.Add(this.tbxSendData);
            this.groupBox3.Location = new System.Drawing.Point(25, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 115);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据发送";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(345, 59);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送数据";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCleanDate
            // 
            this.btnCleanDate.Location = new System.Drawing.Point(345, 20);
            this.btnCleanDate.Name = "btnCleanDate";
            this.btnCleanDate.Size = new System.Drawing.Size(75, 23);
            this.btnCleanDate.TabIndex = 1;
            this.btnCleanDate.Text = "清空数据";
            this.btnCleanDate.UseVisualStyleBackColor = true;
            this.btnCleanDate.Click += new System.EventHandler(this.btnCleanDate_Click);
            // 
            // tbxSendData
            // 
            this.tbxSendData.Location = new System.Drawing.Point(12, 20);
            this.tbxSendData.Multiline = true;
            this.tbxSendData.Name = "tbxSendData";
            this.tbxSendData.Size = new System.Drawing.Size(310, 67);
            this.tbxSendData.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "数据位数";
            // 
            // tbxDataLength
            // 
            this.tbxDataLength.Location = new System.Drawing.Point(78, 392);
            this.tbxDataLength.Name = "tbxDataLength";
            this.tbxDataLength.Size = new System.Drawing.Size(70, 21);
            this.tbxDataLength.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "rssi值";
            // 
            // tbxRssi
            // 
            this.tbxRssi.Location = new System.Drawing.Point(211, 392);
            this.tbxRssi.Name = "tbxRssi";
            this.tbxRssi.Size = new System.Drawing.Size(79, 21);
            this.tbxRssi.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "坐标X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "坐标Y";
            // 
            // tbx_x
            // 
            this.tbx_x.Location = new System.Drawing.Point(78, 429);
            this.tbx_x.Name = "tbx_x";
            this.tbx_x.Size = new System.Drawing.Size(70, 21);
            this.tbx_x.TabIndex = 14;
            // 
            // tbx_y
            // 
            this.tbx_y.Location = new System.Drawing.Point(210, 429);
            this.tbx_y.Name = "tbx_y";
            this.tbx_y.Size = new System.Drawing.Size(79, 21);
            this.tbx_y.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "rssi十进制";
            // 
            // tbxToInt32
            // 
            this.tbxToInt32.Location = new System.Drawing.Point(386, 392);
            this.tbxToInt32.Name = "tbxToInt32";
            this.tbxToInt32.Size = new System.Drawing.Size(83, 21);
            this.tbxToInt32.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(488, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 178);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "0，0节点";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(22, 17);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(168, 150);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "rssi";
            this.columnHeader2.Width = 58;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "rssi十进制";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView2);
            this.groupBox4.Location = new System.Drawing.Point(718, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 178);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "0，1节点";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(21, 17);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(168, 150);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "序号";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "rssi";
            this.columnHeader4.Width = 48;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "rssi十进制";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "导出数据1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(783, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "导出数据2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 697);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(935, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel1.Text = "版本2.0";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Location = new System.Drawing.Point(315, 432);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 12);
            this.ErrorMessage.TabIndex = 28;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chart1);
            this.groupBox5.Location = new System.Drawing.Point(14, 466);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(496, 218);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "图形显示";
            this.groupBox5.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint);
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 17);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(490, 198);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ChartMessage
            // 
            this.ChartMessage.AutoSize = true;
            this.ChartMessage.Location = new System.Drawing.Point(516, 466);
            this.ChartMessage.Name = "ChartMessage";
            this.ChartMessage.Size = new System.Drawing.Size(35, 12);
            this.ChartMessage.TabIndex = 30;
            this.ChartMessage.Text = "label";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chart2);
            this.groupBox6.Location = new System.Drawing.Point(557, 235);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(350, 215);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "0,0点信号";
            this.groupBox6.Paint += new System.Windows.Forms.PaintEventHandler(this.paint_RSSI_0);
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 17);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(344, 195);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chart3);
            this.groupBox7.Location = new System.Drawing.Point(560, 466);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(347, 215);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "0,1点信号";
            this.groupBox7.Paint += new System.Windows.Forms.PaintEventHandler(this.paint_RSSI_1);
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(3, 17);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(341, 195);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "chart3";
            // 
            // batch_label
            // 
            this.batch_label.AutoSize = true;
            this.batch_label.Location = new System.Drawing.Point(492, 435);
            this.batch_label.Name = "batch_label";
            this.batch_label.Size = new System.Drawing.Size(47, 12);
            this.batch_label.TabIndex = 33;
            this.batch_label.Text = "label11";
            // 
            // getMaxBatch
            // 
            this.getMaxBatch.Location = new System.Drawing.Point(379, 427);
            this.getMaxBatch.Name = "getMaxBatch";
            this.getMaxBatch.Size = new System.Drawing.Size(90, 23);
            this.getMaxBatch.TabIndex = 34;
            this.getMaxBatch.Text = "获取最大批次";
            this.getMaxBatch.UseVisualStyleBackColor = true;
            this.getMaxBatch.Click += new System.EventHandler(this.getMaxBatch_Click);
            // 
            // danger_signal
            // 
            this.danger_signal.AutoSize = true;
            this.danger_signal.Location = new System.Drawing.Point(486, 395);
            this.danger_signal.Name = "danger_signal";
            this.danger_signal.Size = new System.Drawing.Size(53, 12);
            this.danger_signal.TabIndex = 35;
            this.danger_signal.Text = "危险信号";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(935, 719);
            this.Controls.Add(this.danger_signal);
            this.Controls.Add(this.getMaxBatch);
            this.Controls.Add(this.batch_label);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.ChartMessage);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxToInt32);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_y);
            this.Controls.Add(this.tbx_x);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxRssi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxDataLength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Form1_Load);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HZC_串口程序";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Form1_Load.ResumeLayout(false);
            this.Form1_Load.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Form1_Load;
        private System.Windows.Forms.RadioButton rbnHex;
        private System.Windows.Forms.RadioButton rbnChar;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.Button btnCheckCOM;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.ComboBox cbxCOMPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxRecvData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxSendData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCleanDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDataLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxRssi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_x;
        private System.Windows.Forms.TextBox tbx_y;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxToInt32;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label ChartMessage;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label batch_label;
        private System.Windows.Forms.Button getMaxBatch;
        private System.Windows.Forms.Label danger_signal;
    }
}

