using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System;
namespace 称重客户端New
{
    partial class Token
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Token));
            this.lb = new ListBox();
            this.select = new Button();
            this.cancle = new Button();
            this.back = new Button();
            this.pictureBox1 = new PictureBox();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.SuspendLayout();
            this.lb.BackColor = Color.White;
            this.lb.BorderStyle = BorderStyle.None;
            this.lb.Font = new Font("宋体", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte)134);
            this.lb.FormattingEnabled = true;
            this.lb.HorizontalScrollbar = true;
            this.lb.ItemHeight = 20;
            this.lb.Location = new Point(30, 67);
            this.lb.Name = "lb";
            this.lb.Size = new Size(434, 320);
            this.lb.TabIndex = 3;
            this.lb.DoubleClick += new EventHandler(this.lb_DoubleClick);
            this.select.BackColor = Color.Transparent;
            this.select.Cursor = Cursors.Hand;
            this.select.FlatAppearance.BorderSize = 0;
            this.select.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.select.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.select.FlatStyle = FlatStyle.Flat;
            this.select.Image = (Image)resources.GetObject("select.Image");
            this.select.Location = new Point(253, 396);
            this.select.Name = "select";
            this.select.Size = new Size(212, 30);
            this.select.TabIndex = 6;
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new EventHandler(this.select_Click);
            this.cancle.BackColor = Color.Transparent;
            this.cancle.Cursor = Cursors.Hand;
            this.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancle.FlatAppearance.BorderSize = 0;
            this.cancle.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.cancle.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.cancle.FlatStyle = FlatStyle.Flat;
            this.cancle.Image = (Image)resources.GetObject("cancle.Image");
            this.cancle.Location = new Point(31, 396);
            this.cancle.Name = "cancle";
            this.cancle.Size = new Size(216, 30);
            this.cancle.TabIndex = 7;
            this.cancle.UseVisualStyleBackColor = false;
            this.cancle.Click += new EventHandler(this.cancel_Click);
            this.back.BackColor = Color.Transparent;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.back.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.back.FlatStyle = FlatStyle.Flat;
            this.back.Image = (Image)resources.GetObject("back.Image");
            this.back.Location = new Point(430, 431);
            this.back.Name = "back";
            this.back.Size = new Size(35, 30);
            this.back.TabIndex = 9;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new EventHandler(this.back_Click_1);
            this.pictureBox1.BackColor = Color.Transparent;
            this.pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(367, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(118, 21);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            this.CancelButton = (IButtonControl)this.cancle;
            this.ClientSize = new Size(490, 467);
            this.Controls.Add((Control)this.pictureBox1);
            this.Controls.Add((Control)this.back);
            this.Controls.Add((Control)this.cancle);
            this.Controls.Add((Control)this.select);
            this.Controls.Add((Control)this.lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.KeyPreview = true;
            this.MaximumSize = new Size(500, 500);
            this.Name = "Token";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "选择批次";
            this.KeyDown += new KeyEventHandler(this.Token_KeyDown);
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private ListBox lb;
        private Button select;
        private Button cancle;
        private Button back;
        private PictureBox pictureBox1;
    }
}