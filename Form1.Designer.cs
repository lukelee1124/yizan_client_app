using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System;
namespace 称重客户端New
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this._serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ex = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.remark = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.面单号 = new System.Windows.Forms.Label();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.tx1 = new System.Windows.Forms.TextBox();
            this.ec1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer10 = new System.Windows.Forms.SplitContainer();
            this.tx2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.dt1 = new System.Windows.Forms.DataGridView();
            this.numble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlachNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.Quanty = new System.Windows.Forms.Label();
            this.TotalWt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.clear = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.outexcle = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.splitContainer11.Panel1.SuspendLayout();
            this.splitContainer11.Panel2.SuspendLayout();
            this.splitContainer11.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            this.splitContainer10.Panel1.SuspendLayout();
            this.splitContainer10.Panel2.SuspendLayout();
            this.splitContainer10.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.SuspendLayout();
            // 
            // _serialPort1
            // 
            this._serialPort1.DiscardNull = true;
            this._serialPort1.PortName = "COM3";
            this._serialPort1.ReceivedBytesThreshold = 12;
            this._serialPort1.RtsEnable = true;
            // 
            // ex
            // 
            this.ex.BackColor = System.Drawing.Color.Transparent;
            this.ex.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ex.ForeColor = System.Drawing.Color.Red;
            this.ex.Location = new System.Drawing.Point(6, 0);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(493, 50);
            this.ex.TabIndex = 99;
            this.ex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1018, 739);
            this.splitContainer1.TabIndex = 99;
            // 
            // splitContainer7
            // 
            this.splitContainer7.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.ex);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer7.Panel2.Controls.Add(this.remark);
            this.splitContainer7.Size = new System.Drawing.Size(1018, 50);
            this.splitContainer7.SplitterDistance = 502;
            this.splitContainer7.TabIndex = 99;
            this.splitContainer7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(383, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 21);
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // remark
            // 
            this.remark.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remark.Location = new System.Drawing.Point(-1, 9);
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(510, 41);
            this.remark.TabIndex = 98;
            this.remark.Paint += new System.Windows.Forms.PaintEventHandler(this.remark_Paint);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer8);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1018, 685);
            this.splitContainer2.SplitterDistance = 100;
            this.splitContainer2.TabIndex = 99;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.面单号);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.splitContainer11);
            this.splitContainer8.Size = new System.Drawing.Size(1018, 100);
            this.splitContainer8.SplitterDistance = 219;
            this.splitContainer8.TabIndex = 99;
            // 
            // 面单号
            // 
            this.面单号.AutoSize = true;
            this.面单号.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.面单号.Location = new System.Drawing.Point(36, 33);
            this.面单号.Name = "面单号";
            this.面单号.Size = new System.Drawing.Size(143, 52);
            this.面单号.TabIndex = 97;
            this.面单号.Text = "面单号";
            // 
            // splitContainer11
            // 
            this.splitContainer11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer11.Location = new System.Drawing.Point(0, 0);
            this.splitContainer11.Name = "splitContainer11";
            // 
            // splitContainer11.Panel1
            // 
            this.splitContainer11.Panel1.Controls.Add(this.tx1);
            // 
            // splitContainer11.Panel2
            // 
            this.splitContainer11.Panel2.Controls.Add(this.ec1);
            this.splitContainer11.Panel2.Controls.Add(this.back);
            this.splitContainer11.Size = new System.Drawing.Size(795, 100);
            this.splitContainer11.SplitterDistance = 500;
            this.splitContainer11.TabIndex = 99;
            // 
            // tx1
            // 
            this.tx1.BackColor = System.Drawing.SystemColors.Control;
            this.tx1.Location = new System.Drawing.Point(4, 30);
            this.tx1.Name = "tx1";
            this.tx1.Size = new System.Drawing.Size(494, 47);
            this.tx1.TabIndex = 0;
            this.tx1.TextChanged += new System.EventHandler(this.tx1_TextChanged);
            // 
            // ec1
            // 
            this.ec1.BackColor = System.Drawing.Color.Transparent;
            this.ec1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ec1.ForeColor = System.Drawing.Color.Transparent;
            this.ec1.Location = new System.Drawing.Point(81, 42);
            this.ec1.Name = "ec1";
            this.ec1.Size = new System.Drawing.Size(20, 20);
            this.ec1.TabIndex = 96;
            this.ec1.Visible = false;
            this.ec1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(223, 24);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(57, 57);
            this.back.TabIndex = 87;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer9);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1018, 581);
            this.splitContainer3.SplitterDistance = 100;
            this.splitContainer3.TabIndex = 99;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.splitContainer10);
            this.splitContainer9.Size = new System.Drawing.Size(1018, 100);
            this.splitContainer9.SplitterDistance = 220;
            this.splitContainer9.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(55, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 52);
            this.label1.TabIndex = 95;
            this.label1.Text = "重量";
            // 
            // splitContainer10
            // 
            this.splitContainer10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer10.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer10.Location = new System.Drawing.Point(0, 0);
            this.splitContainer10.Name = "splitContainer10";
            // 
            // splitContainer10.Panel1
            // 
            this.splitContainer10.Panel1.Controls.Add(this.tx2);
            // 
            // splitContainer10.Panel2
            // 
            this.splitContainer10.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer10.Size = new System.Drawing.Size(794, 100);
            this.splitContainer10.SplitterDistance = 500;
            this.splitContainer10.TabIndex = 99;
            // 
            // tx2
            // 
            this.tx2.BackColor = System.Drawing.SystemColors.Control;
            this.tx2.Location = new System.Drawing.Point(3, 27);
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(494, 47);
            this.tx2.TabIndex = 1;
            this.tx2.Text = "0";
            this.tx2.TextChanged += new System.EventHandler(this.tx2_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(34, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(224, 35);
            this.checkBox1.TabIndex = 94;
            this.checkBox1.Text = "手动修改/Manual";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dt);
            this.splitContainer4.Panel2.Controls.Add(this.clear);
            this.splitContainer4.Panel2.Controls.Add(this.stop);
            this.splitContainer4.Panel2.Controls.Add(this.start);
            this.splitContainer4.Panel2.Controls.Add(this.outexcle);
            this.splitContainer4.Size = new System.Drawing.Size(1018, 477);
            this.splitContainer4.SplitterDistance = 724;
            this.splitContainer4.TabIndex = 99;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.dt1);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer5.Panel2MinSize = 100;
            this.splitContainer5.Size = new System.Drawing.Size(724, 477);
            this.splitContainer5.SplitterDistance = 373;
            this.splitContainer5.TabIndex = 99;
            // 
            // dt1
            // 
            this.dt1.AllowUserToAddRows = false;
            this.dt1.AllowUserToDeleteRows = false;
            this.dt1.AllowUserToResizeColumns = false;
            this.dt1.AllowUserToResizeRows = false;
            this.dt1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numble,
            this.BlachNO,
            this.weight,
            this.time});
            this.dt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dt1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dt1.Location = new System.Drawing.Point(0, 0);
            this.dt1.MultiSelect = false;
            this.dt1.Name = "dt1";
            this.dt1.ReadOnly = true;
            this.dt1.RowHeadersVisible = false;
            this.dt1.RowTemplate.Height = 23;
            this.dt1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dt1.Size = new System.Drawing.Size(724, 373);
            this.dt1.TabIndex = 93;
            this.dt1.TabStop = false;
            // 
            // numble
            // 
            this.numble.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.numble.DefaultCellStyle = dataGridViewCellStyle1;
            this.numble.FillWeight = 15F;
            this.numble.HeaderText = "序号";
            this.numble.Name = "numble";
            this.numble.ReadOnly = true;
            // 
            // BlachNO
            // 
            this.BlachNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.BlachNO.DefaultCellStyle = dataGridViewCellStyle2;
            this.BlachNO.FillWeight = 35F;
            this.BlachNO.HeaderText = "单号";
            this.BlachNO.Name = "BlachNO";
            this.BlachNO.ReadOnly = true;
            // 
            // weight
            // 
            this.weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.weight.DefaultCellStyle = dataGridViewCellStyle3;
            this.weight.FillWeight = 15F;
            this.weight.HeaderText = "重量";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F);
            this.time.DefaultCellStyle = dataGridViewCellStyle4;
            this.time.FillWeight = 30F;
            this.time.HeaderText = "时间";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.label2);
            this.splitContainer6.Panel1.Controls.Add(this.Quanty);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.TotalWt);
            this.splitContainer6.Panel2.Controls.Add(this.label4);
            this.splitContainer6.Panel2.Controls.Add(this.label3);
            this.splitContainer6.Size = new System.Drawing.Size(724, 100);
            this.splitContainer6.SplitterDistance = 354;
            this.splitContainer6.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 46);
            this.label2.TabIndex = 86;
            this.label2.Text = "数量：";
            // 
            // Quanty
            // 
            this.Quanty.AutoSize = true;
            this.Quanty.BackColor = System.Drawing.Color.Transparent;
            this.Quanty.Font = new System.Drawing.Font("宋体", 30F);
            this.Quanty.ForeColor = System.Drawing.Color.Black;
            this.Quanty.Location = new System.Drawing.Point(165, 30);
            this.Quanty.Name = "Quanty";
            this.Quanty.Size = new System.Drawing.Size(37, 40);
            this.Quanty.TabIndex = 85;
            this.Quanty.Text = "0";
            // 
            // TotalWt
            // 
            this.TotalWt.AutoSize = true;
            this.TotalWt.BackColor = System.Drawing.Color.Transparent;
            this.TotalWt.Font = new System.Drawing.Font("宋体", 30F);
            this.TotalWt.ForeColor = System.Drawing.Color.Black;
            this.TotalWt.Location = new System.Drawing.Point(172, 35);
            this.TotalWt.Name = "TotalWt";
            this.TotalWt.Size = new System.Drawing.Size(37, 40);
            this.TotalWt.TabIndex = 83;
            this.TotalWt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(4, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 46);
            this.label4.TabIndex = 84;
            this.label4.Text = "重量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(306, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 46);
            this.label3.TabIndex = 82;
            this.label3.Text = "kg";
            // 
            // dt
            // 
            this.dt.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 26F);
            this.dt.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dt.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.dt.Location = new System.Drawing.Point(34, 10);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(223, 38);
            this.dt.TabIndex = 92;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Image = ((System.Drawing.Image)(resources.GetObject("clear.Image")));
            this.clear.Location = new System.Drawing.Point(45, 305);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(293, 93);
            this.clear.TabIndex = 99;
            this.clear.TabStop = false;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Transparent;
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.FlatAppearance.BorderSize = 0;
            this.stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.Location = new System.Drawing.Point(45, 218);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(293, 93);
            this.stop.TabIndex = 99;
            this.stop.TabStop = false;
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
            this.start.Location = new System.Drawing.Point(45, 132);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(293, 93);
            this.start.TabIndex = 99;
            this.start.TabStop = false;
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // outexcle
            // 
            this.outexcle.BackColor = System.Drawing.Color.Transparent;
            this.outexcle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outexcle.FlatAppearance.BorderSize = 0;
            this.outexcle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.outexcle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.outexcle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outexcle.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outexcle.Image = ((System.Drawing.Image)(resources.GetObject("outexcle.Image")));
            this.outexcle.Location = new System.Drawing.Point(45, 54);
            this.outexcle.Name = "outexcle";
            this.outexcle.Size = new System.Drawing.Size(293, 93);
            this.outexcle.TabIndex = 99;
            this.outexcle.TabStop = false;
            this.outexcle.UseVisualStyleBackColor = false;
            this.outexcle.Click += new System.EventHandler(this.outexcle_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 739);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OMS称重客户端";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            this.splitContainer8.Panel2.ResumeLayout(false);
            this.splitContainer8.ResumeLayout(false);
            this.splitContainer11.Panel1.ResumeLayout(false);
            this.splitContainer11.Panel1.PerformLayout();
            this.splitContainer11.Panel2.ResumeLayout(false);
            this.splitContainer11.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel1.PerformLayout();
            this.splitContainer9.Panel2.ResumeLayout(false);
            this.splitContainer9.ResumeLayout(false);
            this.splitContainer10.Panel1.ResumeLayout(false);
            this.splitContainer10.Panel1.PerformLayout();
            this.splitContainer10.Panel2.ResumeLayout(false);
            this.splitContainer10.Panel2.PerformLayout();
            this.splitContainer10.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            this.splitContainer6.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Label ex;
        private System.Windows.Forms.Timer timer1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer7;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer5;
        private SplitContainer splitContainer6;
        private SplitContainer splitContainer8;
        private Label 面单号;
        private Label remark;
        private SplitContainer splitContainer9;
        private Label label1;
        private SplitContainer splitContainer10;
        private TextBox tx2;
        private Panel ec1;
        private CheckBox checkBox1;
        private DataGridView dt1;
        private Label label2;
        private Label Quanty;
        private Label TotalWt;
        private Label label4;
        private Label label3;
        private Button back;
        private Button clear;
        private Button stop;
        private Button start;
        private Button outexcle;
        private DateTimePicker dt;
        private SplitContainer splitContainer11;
        private TextBox tx1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn numble;
        private DataGridViewTextBoxColumn BlachNO;
        private DataGridViewTextBoxColumn weight;
        private DataGridViewTextBoxColumn time;
    }
}