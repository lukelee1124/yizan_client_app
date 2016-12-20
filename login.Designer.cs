using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System;
namespace 称重客户端New
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.user = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.lg = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.cx1 = new System.Windows.Forms.CheckBox();
            this.setup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user.Location = new System.Drawing.Point(137, 130);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(261, 31);
            this.user.TabIndex = 0;
            // 
            // pwd
            // 
            this.pwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwd.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwd.Location = new System.Drawing.Point(137, 196);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(261, 31);
            this.pwd.TabIndex = 1;
            // 
            // lg
            // 
            this.lg.BackColor = System.Drawing.Color.Transparent;
            this.lg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lg.BackgroundImage")));
            this.lg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lg.FlatAppearance.BorderSize = 0;
            this.lg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lg.Location = new System.Drawing.Point(93, 298);
            this.lg.Name = "lg";
            this.lg.Size = new System.Drawing.Size(312, 47);
            this.lg.TabIndex = 8;
            this.lg.UseVisualStyleBackColor = false;
            this.lg.Click += new System.EventHandler(this.lg_Click);
            // 
            // cancle
            // 
            this.cancle.BackColor = System.Drawing.Color.Transparent;
            this.cancle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancle.BackgroundImage")));
            this.cancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancle.FlatAppearance.BorderSize = 0;
            this.cancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancle.Location = new System.Drawing.Point(57, 372);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(194, 34);
            this.cancle.TabIndex = 9;
            this.cancle.UseVisualStyleBackColor = false;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // cx1
            // 
            this.cx1.AutoSize = true;
            this.cx1.BackColor = System.Drawing.Color.Transparent;
            this.cx1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cx1.Location = new System.Drawing.Point(96, 256);
            this.cx1.Name = "cx1";
            this.cx1.Size = new System.Drawing.Size(148, 24);
            this.cx1.TabIndex = 2;
            this.cx1.Text = "记住登录信息";
            this.cx1.UseVisualStyleBackColor = false;
            this.cx1.CheckedChanged += new System.EventHandler(this.cx1_CheckedChanged);
            // 
            // setup
            // 
            this.setup.BackColor = System.Drawing.Color.Transparent;
            this.setup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("setup.BackgroundImage")));
            this.setup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.setup.FlatAppearance.BorderSize = 0;
            this.setup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.setup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.setup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setup.Location = new System.Drawing.Point(257, 372);
            this.setup.Name = "setup";
            this.setup.Size = new System.Drawing.Size(183, 34);
            this.setup.TabIndex = 10;
            this.setup.UseVisualStyleBackColor = false;
            this.setup.Click += new System.EventHandler(this.setup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(363, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = " 版本:4.6.18";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(371, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 21);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.cancle;
            this.ClientSize = new System.Drawing.Size(494, 471);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setup);
            this.Controls.Add(this.cx1);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.lg);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OMS客户端登录";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox user;
        private TextBox pwd;
        private Button lg;
        private Button cancle;
        private CheckBox cx1;
        private Button setup;
        private Label label1;
        private PictureBox pictureBox1;
    }
}

