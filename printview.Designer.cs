using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System;
using System.Drawing.Printing;
using Cobainsoft.Windows.Forms;
namespace 称重客户端New
{
    partial class printview
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(printview));
            this.pageSetupDialog1 = new PageSetupDialog();
            this.printDialog1 = new PrintDialog();
            this.printDocument1 = new PrintDocument();
            this.printPreviewDialog1 = new PrintPreviewDialog();
            this.pictureBox1 = new PictureBox();
            this.barcodeControl2 = new BarcodeControl();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.SuspendLayout();
            this.printDialog1.UseEXDialog = true;
            this.printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            this.printPreviewDialog1.ClientSize = new Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.pictureBox1.Location = new Point(279, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.barcodeControl2.AddOnCaption = (string)null;
            this.barcodeControl2.AddOnData = (string)null;
            this.barcodeControl2.BackColor = Color.White;
            this.barcodeControl2.BarcodeType = BarcodeType.CODE39;
            this.barcodeControl2.Data = "000000";
            this.barcodeControl2.Font = new Font("Arial", 9f);
            this.barcodeControl2.ForeColor = Color.Black;
            this.barcodeControl2.HorizontalAlignment = BarcodeHorizontalAlignment.Center;
            this.barcodeControl2.InvalidDataAction = InvalidDataAction.DisplayInvalid;
            this.barcodeControl2.Location = new Point(279, 28);
            this.barcodeControl2.LowerTopTextBy = 0.0f;
            this.barcodeControl2.Name = "barcodeControl2";
            this.barcodeControl2.RaiseBottomTextBy = 0.0f;
            this.barcodeControl2.Size = new Size(218, 59);
            this.barcodeControl2.TabIndex = 3;
            this.AutoScaleDimensions = new SizeF(6f, 12f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(520, 370);
            this.Controls.Add((Control)this.barcodeControl2);
            this.Controls.Add((Control)this.pictureBox1);
            this.Name = "printview";
            this.Text = "printview";
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PictureBox pictureBox1;
        private Cobainsoft.Windows.Forms.BarcodeControl barcodeControl2;
    }
}