namespace MontionUntity
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CmbAvailableDevice = new System.Windows.Forms.ComboBox();
            this.BX_RefreshDevice = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BX_Stop = new System.Windows.Forms.Button();
            this.Negivate = new System.Windows.Forms.Button();
            this.BX_Positive = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BX_SetParmerter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Mode_Homeing = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.Mode_Continues = new System.Windows.Forms.RadioButton();
            this.Mode_P2P = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Mode_T = new System.Windows.Forms.RadioButton();
            this.Modle_S = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.BX_VelHigh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BX_Dec = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BX_ACC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BX_Vel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BX_Distance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BX_CurrentDeviceNum = new System.Windows.Forms.Label();
            this.BX_Operator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbAxes = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BX_openDevice = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbAvailableDevice
            // 
            this.CmbAvailableDevice.FormattingEnabled = true;
            this.CmbAvailableDevice.Location = new System.Drawing.Point(13, 13);
            this.CmbAvailableDevice.Name = "CmbAvailableDevice";
            this.CmbAvailableDevice.Size = new System.Drawing.Size(649, 20);
            this.CmbAvailableDevice.TabIndex = 0;
            this.CmbAvailableDevice.SelectedIndexChanged += new System.EventHandler(this.deviceSelected);
            // 
            // BX_RefreshDevice
            // 
            this.BX_RefreshDevice.Location = new System.Drawing.Point(681, 12);
            this.BX_RefreshDevice.Name = "BX_RefreshDevice";
            this.BX_RefreshDevice.Size = new System.Drawing.Size(75, 23);
            this.BX_RefreshDevice.TabIndex = 1;
            this.BX_RefreshDevice.Text = "刷新设备";
            this.BX_RefreshDevice.UseVisualStyleBackColor = true;
            this.BX_RefreshDevice.Click += new System.EventHandler(this.BX_RefreshDevice_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 474);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.BX_SetParmerter);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.BX_VelHigh);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.BX_Dec);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.BX_ACC);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.BX_Vel);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.BX_Distance);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.BX_CurrentDeviceNum);
            this.tabPage1.Controls.Add(this.BX_Operator);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CmbAxes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "单轴操作";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(390, 292);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 98);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(66, 59);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "命令速度";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(66, 28);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "当前状态";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BX_Stop);
            this.groupBox4.Controls.Add(this.Negivate);
            this.groupBox4.Controls.Add(this.BX_Positive);
            this.groupBox4.Location = new System.Drawing.Point(390, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // BX_Stop
            // 
            this.BX_Stop.Location = new System.Drawing.Point(9, 68);
            this.BX_Stop.Name = "BX_Stop";
            this.BX_Stop.Size = new System.Drawing.Size(75, 23);
            this.BX_Stop.TabIndex = 2;
            this.BX_Stop.Text = "停止";
            this.BX_Stop.UseVisualStyleBackColor = true;
            this.BX_Stop.Click += new System.EventHandler(this.BX_Stop_Click);
            // 
            // Negivate
            // 
            this.Negivate.Location = new System.Drawing.Point(102, 26);
            this.Negivate.Name = "Negivate";
            this.Negivate.Size = new System.Drawing.Size(75, 23);
            this.Negivate.TabIndex = 1;
            this.Negivate.Text = "反向";
            this.Negivate.UseVisualStyleBackColor = true;
            this.Negivate.Click += new System.EventHandler(this.Negivate_Click);
            // 
            // BX_Positive
            // 
            this.BX_Positive.Location = new System.Drawing.Point(7, 26);
            this.BX_Positive.Name = "BX_Positive";
            this.BX_Positive.Size = new System.Drawing.Size(75, 23);
            this.BX_Positive.TabIndex = 0;
            this.BX_Positive.Text = "正向";
            this.BX_Positive.UseVisualStyleBackColor = true;
            this.BX_Positive.Click += new System.EventHandler(this.BX_Positive_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(390, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 107);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "配置";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(129, 69);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = ">>>轴状态";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 69);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = ">>>轴设置";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(129, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = ">>>外部驱动";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = ">>>Homeing";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BX_SetParmerter
            // 
            this.BX_SetParmerter.Location = new System.Drawing.Point(6, 420);
            this.BX_SetParmerter.Name = "BX_SetParmerter";
            this.BX_SetParmerter.Size = new System.Drawing.Size(75, 23);
            this.BX_SetParmerter.TabIndex = 21;
            this.BX_SetParmerter.Text = "设置参数";
            this.BX_SetParmerter.UseVisualStyleBackColor = true;
            this.BX_SetParmerter.Click += new System.EventHandler(this.BX_SetParmerter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Mode_Homeing);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.Mode_Continues);
            this.groupBox2.Controls.Add(this.Mode_P2P);
            this.groupBox2.Location = new System.Drawing.Point(6, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 60);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运动模式";
            // 
            // Mode_Homeing
            // 
            this.Mode_Homeing.AutoSize = true;
            this.Mode_Homeing.Location = new System.Drawing.Point(128, 22);
            this.Mode_Homeing.Name = "Mode_Homeing";
            this.Mode_Homeing.Size = new System.Drawing.Size(65, 16);
            this.Mode_Homeing.TabIndex = 3;
            this.Mode_Homeing.Text = "Homeing";
            this.Mode_Homeing.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = ">>>查看范围";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Mode_Continues
            // 
            this.Mode_Continues.AutoSize = true;
            this.Mode_Continues.Location = new System.Drawing.Point(73, 20);
            this.Mode_Continues.Name = "Mode_Continues";
            this.Mode_Continues.Size = new System.Drawing.Size(47, 16);
            this.Mode_Continues.TabIndex = 1;
            this.Mode_Continues.Text = "连续";
            this.Mode_Continues.UseVisualStyleBackColor = true;
            // 
            // Mode_P2P
            // 
            this.Mode_P2P.AutoSize = true;
            this.Mode_P2P.Checked = true;
            this.Mode_P2P.Location = new System.Drawing.Point(7, 21);
            this.Mode_P2P.Name = "Mode_P2P";
            this.Mode_P2P.Size = new System.Drawing.Size(41, 16);
            this.Mode_P2P.TabIndex = 0;
            this.Mode_P2P.TabStop = true;
            this.Mode_P2P.Text = "P2P";
            this.Mode_P2P.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Mode_T);
            this.groupBox1.Controls.Add(this.Modle_S);
            this.groupBox1.Location = new System.Drawing.Point(7, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 60);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "速度类型";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = ">>>查看范围";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Mode_T
            // 
            this.Mode_T.AutoSize = true;
            this.Mode_T.Checked = true;
            this.Mode_T.Location = new System.Drawing.Point(73, 20);
            this.Mode_T.Name = "Mode_T";
            this.Mode_T.Size = new System.Drawing.Size(47, 16);
            this.Mode_T.TabIndex = 1;
            this.Mode_T.TabStop = true;
            this.Mode_T.Text = "梯形";
            this.Mode_T.UseVisualStyleBackColor = true;
            // 
            // Modle_S
            // 
            this.Modle_S.AutoSize = true;
            this.Modle_S.Location = new System.Drawing.Point(7, 21);
            this.Modle_S.Name = "Modle_S";
            this.Modle_S.Size = new System.Drawing.Size(41, 16);
            this.Modle_S.TabIndex = 0;
            this.Modle_S.Text = "S形";
            this.Modle_S.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(283, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "PPU";
            // 
            // BX_VelHigh
            // 
            this.BX_VelHigh.Location = new System.Drawing.Point(66, 249);
            this.BX_VelHigh.Name = "BX_VelHigh";
            this.BX_VelHigh.Size = new System.Drawing.Size(199, 21);
            this.BX_VelHigh.TabIndex = 17;
            this.BX_VelHigh.Text = "100000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "运行速度";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "PPU";
            // 
            // BX_Dec
            // 
            this.BX_Dec.Location = new System.Drawing.Point(60, 193);
            this.BX_Dec.Name = "BX_Dec";
            this.BX_Dec.Size = new System.Drawing.Size(205, 21);
            this.BX_Dec.TabIndex = 14;
            this.BX_Dec.Text = "100000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "减速度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "PPU";
            // 
            // BX_ACC
            // 
            this.BX_ACC.Location = new System.Drawing.Point(60, 147);
            this.BX_ACC.Name = "BX_ACC";
            this.BX_ACC.Size = new System.Drawing.Size(205, 21);
            this.BX_ACC.TabIndex = 11;
            this.BX_ACC.Text = "10000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "加速度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "PPU";
            // 
            // BX_Vel
            // 
            this.BX_Vel.Location = new System.Drawing.Point(60, 100);
            this.BX_Vel.Name = "BX_Vel";
            this.BX_Vel.Size = new System.Drawing.Size(205, 21);
            this.BX_Vel.TabIndex = 8;
            this.BX_Vel.Text = "10000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "初速度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "PPU";
            // 
            // BX_Distance
            // 
            this.BX_Distance.Location = new System.Drawing.Point(60, 52);
            this.BX_Distance.Name = "BX_Distance";
            this.BX_Distance.Size = new System.Drawing.Size(205, 21);
            this.BX_Distance.TabIndex = 5;
            this.BX_Distance.Text = "100000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "距离";
            // 
            // BX_CurrentDeviceNum
            // 
            this.BX_CurrentDeviceNum.AutoSize = true;
            this.BX_CurrentDeviceNum.Location = new System.Drawing.Point(441, 21);
            this.BX_CurrentDeviceNum.Name = "BX_CurrentDeviceNum";
            this.BX_CurrentDeviceNum.Size = new System.Drawing.Size(41, 12);
            this.BX_CurrentDeviceNum.TabIndex = 3;
            this.BX_CurrentDeviceNum.Text = "label2";
            // 
            // BX_Operator
            // 
            this.BX_Operator.Location = new System.Drawing.Point(312, 16);
            this.BX_Operator.Name = "BX_Operator";
            this.BX_Operator.Size = new System.Drawing.Size(75, 23);
            this.BX_Operator.TabIndex = 2;
            this.BX_Operator.Text = "On";
            this.BX_Operator.UseVisualStyleBackColor = true;
            this.BX_Operator.Click += new System.EventHandler(this.BX_Operator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "操作轴";
            // 
            // CmbAxes
            // 
            this.CmbAxes.FormattingEnabled = true;
            this.CmbAxes.Location = new System.Drawing.Point(7, 16);
            this.CmbAxes.Name = "CmbAxes";
            this.CmbAxes.Size = new System.Drawing.Size(252, 20);
            this.CmbAxes.TabIndex = 0;
            this.CmbAxes.SelectedIndexChanged += new System.EventHandler(this.axisSelected);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "多轴运动";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BX_openDevice
            // 
            this.BX_openDevice.Location = new System.Drawing.Point(681, 41);
            this.BX_openDevice.Name = "BX_openDevice";
            this.BX_openDevice.Size = new System.Drawing.Size(75, 23);
            this.BX_openDevice.TabIndex = 3;
            this.BX_openDevice.Text = "打开";
            this.BX_openDevice.UseVisualStyleBackColor = true;
            this.BX_openDevice.Click += new System.EventHandler(this.BX_openDevice_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 527);
            this.Controls.Add(this.BX_openDevice);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BX_RefreshDevice);
            this.Controls.Add(this.CmbAvailableDevice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbAvailableDevice;
        private System.Windows.Forms.Button BX_RefreshDevice;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BX_VelHigh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BX_Dec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BX_ACC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BX_Vel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BX_Distance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BX_CurrentDeviceNum;
        private System.Windows.Forms.Button BX_Operator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbAxes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Mode_T;
        private System.Windows.Forms.RadioButton Modle_S;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton Mode_Continues;
        private System.Windows.Forms.RadioButton Mode_P2P;
        private System.Windows.Forms.RadioButton Mode_Homeing;
        private System.Windows.Forms.Button BX_SetParmerter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Negivate;
        private System.Windows.Forms.Button BX_Positive;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BX_openDevice;
        private System.Windows.Forms.Button BX_Stop;
        private System.Windows.Forms.Timer timer1;
    }
}

