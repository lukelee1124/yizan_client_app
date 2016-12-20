using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System;
using System.Drawing.Printing;
namespace 称重客户端New
{
    partial class printmail
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(printmail));
            this.listbox1 = new ListBox();
            this.button1 = new Button();
            this.button2 = new Button();
            this.label1 = new Label();
            this.printDialog1 = new PrintDialog();
            this.printDocument1 = new PrintDocument();
            this.back = new Button();
            this.pictureBox1 = new PictureBox();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.SuspendLayout();
            this.listbox1.BackColor = Color.White;
            this.listbox1.Font = new Font("宋体", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte)134);
            this.listbox1.FormattingEnabled = true;
            this.listbox1.HorizontalScrollbar = true;
            this.listbox1.ItemHeight = 20;
            this.listbox1.Location = new Point(30, 65);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new Size(435, 324);
            this.listbox1.TabIndex = 0;
            this.listbox1.MouseDoubleClick += new MouseEventHandler(this.listbox1_MouseDoubleClick);
            this.button1.BackColor = Color.Transparent;
            this.button1.BackgroundImageLayout = ImageLayout.Stretch;
            this.button1.Cursor = Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Image = (Image)resources.GetObject("button1.Image");
            this.button1.Location = new Point(31, 395);
            this.button1.Name = "button1";
            this.button1.Size = new Size(215, 30);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.BackColor = Color.Transparent;
            this.button2.Cursor = Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Image = (Image)resources.GetObject("button2.Image");
            this.button2.Location = new Point(252, 395);
            this.button2.Name = "button2";
            this.button2.Size = new Size(214, 30);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.Transparent;
            this.label1.Font = new Font("宋体", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte)134);
            this.label1.ForeColor = Color.White;
            this.label1.Location = new Point(1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择批次";
            this.printDialog1.UseEXDialog = true;
            this.back.BackColor = Color.Transparent;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.back.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.back.FlatStyle = FlatStyle.Flat;
            this.back.Image = (Image)resources.GetObject("back.Image");
            this.back.Location = new Point(431, 429);
            this.back.Name = "back";
            this.back.Size = new Size(35, 30);
            this.back.TabIndex = 4;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new EventHandler(this.back_Click);
            this.pictureBox1.BackColor = Color.Transparent;
            this.pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(360, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(118, 21);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            this.ClientSize = new Size(484, 461);
            this.Controls.Add((Control)this.pictureBox1);
            this.Controls.Add((Control)this.back);
            this.Controls.Add((Control)this.listbox1);
            this.Controls.Add((Control)this.label1);
            this.Controls.Add((Control)this.button2);
            this.Controls.Add((Control)this.button1);
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "printmail";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "打印菜单";
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private ListBox listbox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private PrintDialog printDialog1;
        private PrintDocument printDocument1;
        private Button back;
        private PictureBox pictureBox1;
       
    }
}