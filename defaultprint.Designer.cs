using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System;
using System.Drawing.Printing;
using Microsoft.VisualBasic.PowerPacks;
using Cobainsoft.Windows.Forms;
using System.Drawing.Drawing2D;
namespace 称重客户端New
{
    partial class defaultprint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(defaultprint));
            this.OMS_NO = new System.Windows.Forms.TextBox();
            this.ouya = new System.Windows.Forms.Panel();
            this.zhongtong = new System.Windows.Forms.Panel();
            this.jingji = new System.Windows.Forms.Panel();
            this.zhonghua = new System.Windows.Forms.Panel();
            this.zhonghua_bc2_value = new System.Windows.Forms.Label();
            this.zhonghua_bc1_value = new System.Windows.Forms.Label();
            this.zhonghua_bc2 = new System.Windows.Forms.PictureBox();
            this.zhonghua_bc1 = new System.Windows.Forms.PictureBox();
            this.zhonghua_in_address = new System.Windows.Forms.Label();
            this.zhonghua_person_items = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zhonghua_weight = new System.Windows.Forms.Label();
            this.zhonghua_count = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label117 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.zhonghua_in_tel = new System.Windows.Forms.Label();
            this.zhonghua_in_name = new System.Windows.Forms.Label();
            this.zhonghua_out_name = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.zhonghua_logo1 = new System.Windows.Forms.PictureBox();
            this.jingji_bc4_value = new System.Windows.Forms.Label();
            this.jingji_bc3_value = new System.Windows.Forms.Label();
            this.jingji_bc2_value = new System.Windows.Forms.Label();
            this.jingji_bc1_value = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.jingji_quantity = new System.Windows.Forms.Label();
            this.jingji_weight1 = new System.Windows.Forms.Label();
            this.jingji_bc4 = new System.Windows.Forms.PictureBox();
            this.jingji_bc3 = new System.Windows.Forms.PictureBox();
            this.jingji_bc2 = new System.Windows.Forms.PictureBox();
            this.jingji_bc1 = new System.Windows.Forms.PictureBox();
            this.label52 = new System.Windows.Forms.Label();
            this.jingji_erq1 = new System.Windows.Forms.PictureBox();
            this.jingji_logo = new System.Windows.Forms.PictureBox();
            this.jingji_logo1 = new System.Windows.Forms.Label();
            this.jingji_in_address2 = new System.Windows.Forms.Label();
            this.jingji_in_tel3 = new System.Windows.Forms.Label();
            this.jingji_in_name2 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.jingji_out_address2 = new System.Windows.Forms.Label();
            this.jingji_out_tel2 = new System.Windows.Forms.Label();
            this.jingji_out_name2 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.jingji_logo2 = new System.Windows.Forms.PictureBox();
            this.jingji_list1 = new System.Windows.Forms.ListBox();
            this.jingji_info = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.jingji_money = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.jingji_weight = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.jingji_money_type = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.jingji_in_address1 = new System.Windows.Forms.Label();
            this.jingji_in_tel2 = new System.Windows.Forms.Label();
            this.jingji_in_tel1 = new System.Windows.Forms.Label();
            this.jingji_in_name = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.jingji_out_address1 = new System.Windows.Forms.Label();
            this.jingji_out_tel1 = new System.Windows.Forms.Label();
            this.jingji_city = new System.Windows.Forms.Label();
            this.jingji_out_name1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.shapeContainer4 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape39 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape38 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape37 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape36 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape34 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape33 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape32 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape31 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape30 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape29 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape28 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape27 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape26 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape21 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape_bottom = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape_right = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape_left = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape_top = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.zhongtong_bc3_value = new System.Windows.Forms.Label();
            this.zhongtong_bc2_value = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.zhongtong_bc1 = new System.Windows.Forms.Label();
            this.zhongtong_bc3 = new System.Windows.Forms.PictureBox();
            this.zhongtong_bc2 = new System.Windows.Forms.PictureBox();
            this.zhongtong_logo2 = new System.Windows.Forms.PictureBox();
            this.zhongtong_time = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.zhongtong_out_tel1 = new System.Windows.Forms.Label();
            this.zhongtong_out_name1 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.zhongtong_out_address1 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.zhongtong_in_tel1 = new System.Windows.Forms.Label();
            this.zhongtong_in_name1 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.zhongtong_in_address1 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.zhongtong_out_tel = new System.Windows.Forms.Label();
            this.zhongtong_out_name = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.zhongtong_out_address = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.zhongtong_in_tel = new System.Windows.Forms.Label();
            this.zhongtong_in_name = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.lable5 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.收件 = new System.Windows.Forms.Label();
            this.zhongtong_in_xian = new System.Windows.Forms.Label();
            this.zhongtong_in_diqu = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.zhongtong_in_address = new System.Windows.Forms.Label();
            this.zhongtong_list1 = new System.Windows.Forms.ListBox();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.zhongtong_logo1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape25 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape24 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape23 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape22 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape20 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape19 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape15 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape13 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape14 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape16 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape17 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape18 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ouya_bc2_value = new System.Windows.Forms.Label();
            this.ouya_bc1_value = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.ouya_bc2 = new System.Windows.Forms.PictureBox();
            this.ouya_bc1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ouya_out_address = new System.Windows.Forms.Label();
            this.ouya_out_tel = new System.Windows.Forms.Label();
            this.ouya_out_name = new System.Windows.Forms.Label();
            this.ouya_in_address = new System.Windows.Forms.Label();
            this.ouya_in_tel = new System.Windows.Forms.Label();
            this.ouya_in_name = new System.Windows.Forms.Label();
            this.ouya_city = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ouya_list1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ouya_brq1 = new System.Windows.Forms.PictureBox();
            this.ouya_logo2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.ouya_logo1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.EMS = new System.Windows.Forms.Panel();
            this.ems_remarks_no = new System.Windows.Forms.Label();
            this.ems_remarks = new System.Windows.Forms.Label();
            this.ems_bc2 = new Cobainsoft.Windows.Forms.BarcodeControl();
            this.ems_in_address1 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.ems_in_tel1 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.ems_in_name1 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.ems_out_address1 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.ems_actual_weight2 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.ems_out_name1 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.ems_list1 = new System.Windows.Forms.ListBox();
            this.ems_insured_value = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.ems_actual_weight1 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.ems_out_address = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.ems_out_tel = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.ems_out_name = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ems_in_postcode = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.ems_in_city = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.ems_time = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.ems_in_address = new System.Windows.Forms.Label();
            this.ems_in_tel = new System.Windows.Forms.Label();
            this.ems_in_name = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.ems_bc1 = new Cobainsoft.Windows.Forms.BarcodeControl();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape10 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape9 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape11 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape12 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.ex = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ouya.SuspendLayout();
            this.zhongtong.SuspendLayout();
            this.jingji.SuspendLayout();
            this.zhonghua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zhonghua_bc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhonghua_bc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhonghua_logo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jingji_bc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jingji_bc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jingji_bc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jingji_bc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jingji_erq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jingji_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jingji_logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhongtong_bc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhongtong_bc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhongtong_logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhongtong_logo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouya_bc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouya_bc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouya_brq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouya_logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouya_logo1)).BeginInit();
            this.EMS.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OMS_NO
            // 
            this.OMS_NO.BackColor = System.Drawing.SystemColors.Control;
            this.OMS_NO.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OMS_NO.Location = new System.Drawing.Point(312, 12);
            this.OMS_NO.MaxLength = 30;
            this.OMS_NO.Name = "OMS_NO";
            this.OMS_NO.Size = new System.Drawing.Size(400, 26);
            this.OMS_NO.TabIndex = 0;
            this.OMS_NO.Text = "请输入或扫描EAX OMS订单号";
            this.OMS_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OMS_NO.TextChanged += new System.EventHandler(this.OMS_NO_TextChanged);
            // 
            // ouya
            // 
            this.ouya.BackColor = System.Drawing.Color.White;
            this.ouya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ouya.Controls.Add(this.zhongtong);
            this.ouya.Controls.Add(this.ouya_bc2_value);
            this.ouya.Controls.Add(this.ouya_bc1_value);
            this.ouya.Controls.Add(this.label36);
            this.ouya.Controls.Add(this.ouya_bc2);
            this.ouya.Controls.Add(this.ouya_bc1);
            this.ouya.Controls.Add(this.label18);
            this.ouya.Controls.Add(this.ouya_out_address);
            this.ouya.Controls.Add(this.ouya_out_tel);
            this.ouya.Controls.Add(this.ouya_out_name);
            this.ouya.Controls.Add(this.ouya_in_address);
            this.ouya.Controls.Add(this.ouya_in_tel);
            this.ouya.Controls.Add(this.ouya_in_name);
            this.ouya.Controls.Add(this.ouya_city);
            this.ouya.Controls.Add(this.label17);
            this.ouya.Controls.Add(this.label16);
            this.ouya.Controls.Add(this.label15);
            this.ouya.Controls.Add(this.label14);
            this.ouya.Controls.Add(this.label13);
            this.ouya.Controls.Add(this.label12);
            this.ouya.Controls.Add(this.checkBox2);
            this.ouya.Controls.Add(this.checkBox1);
            this.ouya.Controls.Add(this.label11);
            this.ouya.Controls.Add(this.ouya_list1);
            this.ouya.Controls.Add(this.label10);
            this.ouya.Controls.Add(this.label9);
            this.ouya.Controls.Add(this.label8);
            this.ouya.Controls.Add(this.ouya_brq1);
            this.ouya.Controls.Add(this.ouya_logo2);
            this.ouya.Controls.Add(this.label7);
            this.ouya.Controls.Add(this.label6);
            this.ouya.Controls.Add(this.label5);
            this.ouya.Controls.Add(this.label4);
            this.ouya.Controls.Add(this.label3);
            this.ouya.Controls.Add(this.lable2);
            this.ouya.Controls.Add(this.label1);
            this.ouya.Controls.Add(this.lable1);
            this.ouya.Controls.Add(this.ouya_logo1);
            this.ouya.Controls.Add(this.shapeContainer1);
            this.ouya.Location = new System.Drawing.Point(0, 0);
            this.ouya.Name = "ouya";
            this.ouya.Size = new System.Drawing.Size(400, 600);
            this.ouya.TabIndex = 1;
            this.ouya.Visible = false;
            // 
            // zhongtong
            // 
            this.zhongtong.BackColor = System.Drawing.Color.White;
            this.zhongtong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zhongtong.Controls.Add(this.jingji);
            this.zhongtong.Controls.Add(this.zhongtong_bc3_value);
            this.zhongtong.Controls.Add(this.zhongtong_bc2_value);
            this.zhongtong.Controls.Add(this.label34);
            this.zhongtong.Controls.Add(this.zhongtong_bc1);
            this.zhongtong.Controls.Add(this.zhongtong_bc3);
            this.zhongtong.Controls.Add(this.zhongtong_bc2);
            this.zhongtong.Controls.Add(this.zhongtong_logo2);
            this.zhongtong.Controls.Add(this.zhongtong_time);
            this.zhongtong.Controls.Add(this.label84);
            this.zhongtong.Controls.Add(this.zhongtong_out_tel1);
            this.zhongtong.Controls.Add(this.zhongtong_out_name1);
            this.zhongtong.Controls.Add(this.label87);
            this.zhongtong.Controls.Add(this.label89);
            this.zhongtong.Controls.Add(this.label90);
            this.zhongtong.Controls.Add(this.zhongtong_out_address1);
            this.zhongtong.Controls.Add(this.label92);
            this.zhongtong.Controls.Add(this.zhongtong_in_tel1);
            this.zhongtong.Controls.Add(this.zhongtong_in_name1);
            this.zhongtong.Controls.Add(this.label95);
            this.zhongtong.Controls.Add(this.label96);
            this.zhongtong.Controls.Add(this.label97);
            this.zhongtong.Controls.Add(this.label98);
            this.zhongtong.Controls.Add(this.label99);
            this.zhongtong.Controls.Add(this.zhongtong_in_address1);
            this.zhongtong.Controls.Add(this.label74);
            this.zhongtong.Controls.Add(this.zhongtong_out_tel);
            this.zhongtong.Controls.Add(this.zhongtong_out_name);
            this.zhongtong.Controls.Add(this.label80);
            this.zhongtong.Controls.Add(this.label81);
            this.zhongtong.Controls.Add(this.label82);
            this.zhongtong.Controls.Add(this.zhongtong_out_address);
            this.zhongtong.Controls.Add(this.label73);
            this.zhongtong.Controls.Add(this.zhongtong_in_tel);
            this.zhongtong.Controls.Add(this.zhongtong_in_name);
            this.zhongtong.Controls.Add(this.label70);
            this.zhongtong.Controls.Add(this.lable5);
            this.zhongtong.Controls.Add(this.label68);
            this.zhongtong.Controls.Add(this.label65);
            this.zhongtong.Controls.Add(this.收件);
            this.zhongtong.Controls.Add(this.zhongtong_in_xian);
            this.zhongtong.Controls.Add(this.zhongtong_in_diqu);
            this.zhongtong.Controls.Add(this.label62);
            this.zhongtong.Controls.Add(this.zhongtong_in_address);
            this.zhongtong.Controls.Add(this.zhongtong_list1);
            this.zhongtong.Controls.Add(this.label77);
            this.zhongtong.Controls.Add(this.label78);
            this.zhongtong.Controls.Add(this.label79);
            this.zhongtong.Controls.Add(this.zhongtong_logo1);
            this.zhongtong.Controls.Add(this.shapeContainer3);
            this.zhongtong.Location = new System.Drawing.Point(0, 0);
            this.zhongtong.Name = "zhongtong";
            this.zhongtong.Size = new System.Drawing.Size(400, 600);
            this.zhongtong.TabIndex = 47;
            this.zhongtong.Visible = false;
            // 
            // jingji
            // 
            this.jingji.BackColor = System.Drawing.Color.White;
            this.jingji.Controls.Add(this.zhonghua);
            this.jingji.Controls.Add(this.jingji_bc4_value);
            this.jingji.Controls.Add(this.jingji_bc3_value);
            this.jingji.Controls.Add(this.jingji_bc2_value);
            this.jingji.Controls.Add(this.jingji_bc1_value);
            this.jingji.Controls.Add(this.label32);
            this.jingji.Controls.Add(this.jingji_quantity);
            this.jingji.Controls.Add(this.jingji_weight1);
            this.jingji.Controls.Add(this.jingji_bc4);
            this.jingji.Controls.Add(this.jingji_bc3);
            this.jingji.Controls.Add(this.jingji_bc2);
            this.jingji.Controls.Add(this.jingji_bc1);
            this.jingji.Controls.Add(this.label52);
            this.jingji.Controls.Add(this.jingji_erq1);
            this.jingji.Controls.Add(this.jingji_logo);
            this.jingji.Controls.Add(this.jingji_logo1);
            this.jingji.Controls.Add(this.jingji_in_address2);
            this.jingji.Controls.Add(this.jingji_in_tel3);
            this.jingji.Controls.Add(this.jingji_in_name2);
            this.jingji.Controls.Add(this.label60);
            this.jingji.Controls.Add(this.jingji_out_address2);
            this.jingji.Controls.Add(this.jingji_out_tel2);
            this.jingji.Controls.Add(this.jingji_out_name2);
            this.jingji.Controls.Add(this.label58);
            this.jingji.Controls.Add(this.label51);
            this.jingji.Controls.Add(this.label50);
            this.jingji.Controls.Add(this.label39);
            this.jingji.Controls.Add(this.jingji_logo2);
            this.jingji.Controls.Add(this.jingji_list1);
            this.jingji.Controls.Add(this.jingji_info);
            this.jingji.Controls.Add(this.label30);
            this.jingji.Controls.Add(this.label28);
            this.jingji.Controls.Add(this.label26);
            this.jingji.Controls.Add(this.jingji_money);
            this.jingji.Controls.Add(this.label25);
            this.jingji.Controls.Add(this.jingji_weight);
            this.jingji.Controls.Add(this.label24);
            this.jingji.Controls.Add(this.jingji_money_type);
            this.jingji.Controls.Add(this.label23);
            this.jingji.Controls.Add(this.jingji_in_address1);
            this.jingji.Controls.Add(this.jingji_in_tel2);
            this.jingji.Controls.Add(this.jingji_in_tel1);
            this.jingji.Controls.Add(this.jingji_in_name);
            this.jingji.Controls.Add(this.label22);
            this.jingji.Controls.Add(this.jingji_out_address1);
            this.jingji.Controls.Add(this.jingji_out_tel1);
            this.jingji.Controls.Add(this.jingji_city);
            this.jingji.Controls.Add(this.jingji_out_name1);
            this.jingji.Controls.Add(this.label21);
            this.jingji.Controls.Add(this.shapeContainer4);
            this.jingji.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji.Location = new System.Drawing.Point(0, 0);
            this.jingji.Name = "jingji";
            this.jingji.Size = new System.Drawing.Size(400, 600);
            this.jingji.TabIndex = 49;
            this.jingji.Visible = false;
            // 
            // zhonghua
            // 
            this.zhonghua.BackColor = System.Drawing.Color.White;
            this.zhonghua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zhonghua.Controls.Add(this.zhonghua_bc2_value);
            this.zhonghua.Controls.Add(this.zhonghua_bc1_value);
            this.zhonghua.Controls.Add(this.zhonghua_bc2);
            this.zhonghua.Controls.Add(this.zhonghua_bc1);
            this.zhonghua.Controls.Add(this.zhonghua_in_address);
            this.zhonghua.Controls.Add(this.zhonghua_person_items);
            this.zhonghua.Controls.Add(this.label2);
            this.zhonghua.Controls.Add(this.zhonghua_weight);
            this.zhonghua.Controls.Add(this.zhonghua_count);
            this.zhonghua.Controls.Add(this.checkBox4);
            this.zhonghua.Controls.Add(this.checkBox3);
            this.zhonghua.Controls.Add(this.label117);
            this.zhonghua.Controls.Add(this.label116);
            this.zhonghua.Controls.Add(this.label112);
            this.zhonghua.Controls.Add(this.label111);
            this.zhonghua.Controls.Add(this.label113);
            this.zhonghua.Controls.Add(this.label110);
            this.zhonghua.Controls.Add(this.label114);
            this.zhonghua.Controls.Add(this.label109);
            this.zhonghua.Controls.Add(this.label115);
            this.zhonghua.Controls.Add(this.label108);
            this.zhonghua.Controls.Add(this.label107);
            this.zhonghua.Controls.Add(this.zhonghua_in_tel);
            this.zhonghua.Controls.Add(this.zhonghua_in_name);
            this.zhonghua.Controls.Add(this.zhonghua_out_name);
            this.zhonghua.Controls.Add(this.label103);
            this.zhonghua.Controls.Add(this.label102);
            this.zhonghua.Controls.Add(this.label101);
            this.zhonghua.Controls.Add(this.zhonghua_logo1);
            this.zhonghua.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhonghua.Location = new System.Drawing.Point(0, 0);
            this.zhonghua.Name = "zhonghua";
            this.zhonghua.Size = new System.Drawing.Size(400, 600);
            this.zhonghua.TabIndex = 83;
            this.zhonghua.Visible = false;
            // 
            // zhonghua_bc2_value
            // 
            this.zhonghua_bc2_value.Location = new System.Drawing.Point(80, 303);
            this.zhonghua_bc2_value.Name = "zhonghua_bc2_value";
            this.zhonghua_bc2_value.Size = new System.Drawing.Size(270, 11);
            this.zhonghua_bc2_value.TabIndex = 108;
            this.zhonghua_bc2_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zhonghua_bc1_value
            // 
            this.zhonghua_bc1_value.Location = new System.Drawing.Point(121, 85);
            this.zhonghua_bc1_value.Name = "zhonghua_bc1_value";
            this.zhonghua_bc1_value.Size = new System.Drawing.Size(270, 11);
            this.zhonghua_bc1_value.TabIndex = 107;
            this.zhonghua_bc1_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zhonghua_bc2
            // 
            this.zhonghua_bc2.Location = new System.Drawing.Point(80, 253);
            this.zhonghua_bc2.Name = "zhonghua_bc2";
            this.zhonghua_bc2.Size = new System.Drawing.Size(270, 50);
            this.zhonghua_bc2.TabIndex = 106;
            this.zhonghua_bc2.TabStop = false;
            // 
            // zhonghua_bc1
            // 
            this.zhonghua_bc1.Location = new System.Drawing.Point(121, 34);
            this.zhonghua_bc1.Name = "zhonghua_bc1";
            this.zhonghua_bc1.Size = new System.Drawing.Size(270, 50);
            this.zhonghua_bc1.TabIndex = 105;
            this.zhonghua_bc1.TabStop = false;
            // 
            // zhonghua_in_address
            // 
            this.zhonghua_in_address.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhonghua_in_address.Location = new System.Drawing.Point(29, 212);
            this.zhonghua_in_address.Name = "zhonghua_in_address";
            this.zhonghua_in_address.Size = new System.Drawing.Size(337, 35);
            this.zhonghua_in_address.TabIndex = 104;
            // 
            // zhonghua_person_items
            // 
            this.zhonghua_person_items.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhonghua_person_items.Location = new System.Drawing.Point(100, 364);
            this.zhonghua_person_items.Name = "zhonghua_person_items";
            this.zhonghua_person_items.Size = new System.Drawing.Size(250, 12);
            this.zhonghua_person_items.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(167, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 101;
            this.label2.Text = "中國大陸郵件提單";
            // 
            // zhonghua_weight
            // 
            this.zhonghua_weight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhonghua_weight.Location = new System.Drawing.Point(83, 342);
            this.zhonghua_weight.Name = "zhonghua_weight";
            this.zhonghua_weight.Size = new System.Drawing.Size(100, 16);
            this.zhonghua_weight.TabIndex = 100;
            // 
            // zhonghua_count
            // 
            this.zhonghua_count.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhonghua_count.Location = new System.Drawing.Point(84, 318);
            this.zhonghua_count.Name = "zhonghua_count";
            this.zhonghua_count.Size = new System.Drawing.Size(100, 20);
            this.zhonghua_count.TabIndex = 99;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox4.Location = new System.Drawing.Point(31, 429);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 98;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox3.Location = new System.Drawing.Point(31, 409);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 97;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(41, 483);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(215, 12);
            this.label117.TabIndex = 96;
            this.label117.Text = "（未保價貨件每單賠付上限為100美元）";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label116.Location = new System.Drawing.Point(48, 412);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(161, 12);
            this.label116.TabIndex = 95;
            this.label116.Text = "退回寄件人并由寄件人付運費";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(30, 520);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(233, 12);
            this.label112.TabIndex = 50;
            this.label112.Text = "日期：____________年_______月_______日";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(48, 428);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(29, 12);
            this.label111.TabIndex = 94;
            this.label111.Text = "拋棄";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(29, 505);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(257, 12);
            this.label113.TabIndex = 49;
            this.label113.Text = "寄件人簽署：______________________________";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label110.Location = new System.Drawing.Point(28, 386);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(185, 12);
            this.label110.TabIndex = 93;
            this.label110.Text = "若無法投遞時，寄件人之指定事項";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(32, 467);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(215, 12);
            this.label114.TabIndex = 48;
            this.label114.Text = "2、本人已翻閱并同意載運契約一切條款\r\n";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label109.Location = new System.Drawing.Point(28, 365);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(65, 12);
            this.label109.TabIndex = 92;
            this.label109.Text = "內裝物品：";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(32, 451);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(323, 12);
            this.label115.TabIndex = 47;
            this.label115.Text = "1、茲證明本人所填寫資料屬實且無裝寄任何危險及禁寄物品";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label108.Location = new System.Drawing.Point(29, 342);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(41, 12);
            this.label108.TabIndex = 91;
            this.label108.Text = "重量：";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label107.Location = new System.Drawing.Point(29, 318);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(41, 12);
            this.label107.TabIndex = 90;
            this.label107.Text = "件數：";
            // 
            // zhonghua_in_tel
            // 
            this.zhonghua_in_tel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhonghua_in_tel.Location = new System.Drawing.Point(94, 191);
            this.zhonghua_in_tel.Name = "zhonghua_in_tel";
            this.zhonghua_in_tel.Size = new System.Drawing.Size(100, 12);
            this.zhonghua_in_tel.TabIndex = 89;
            // 
            // zhonghua_in_name
            // 
            this.zhonghua_in_name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhonghua_in_name.Location = new System.Drawing.Point(94, 166);
            this.zhonghua_in_name.Name = "zhonghua_in_name";
            this.zhonghua_in_name.Size = new System.Drawing.Size(100, 12);
            this.zhonghua_in_name.TabIndex = 88;
            // 
            // zhonghua_out_name
            // 
            this.zhonghua_out_name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhonghua_out_name.Location = new System.Drawing.Point(94, 136);
            this.zhonghua_out_name.Name = "zhonghua_out_name";
            this.zhonghua_out_name.Size = new System.Drawing.Size(100, 12);
            this.zhonghua_out_name.TabIndex = 87;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label103.Location = new System.Drawing.Point(29, 191);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(41, 12);
            this.label103.TabIndex = 86;
            this.label103.Text = "電話：";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label102.Location = new System.Drawing.Point(29, 164);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(53, 12);
            this.label102.TabIndex = 85;
            this.label102.Text = "收件人：";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label101.Location = new System.Drawing.Point(30, 137);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(53, 12);
            this.label101.TabIndex = 84;
            this.label101.Text = "寄件人：";
            // 
            // zhonghua_logo1
            // 
            this.zhonghua_logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zhonghua_logo1.Image = ((System.Drawing.Image)(resources.GetObject("zhonghua_logo1.Image")));
            this.zhonghua_logo1.Location = new System.Drawing.Point(6, 35);
            this.zhonghua_logo1.Name = "zhonghua_logo1";
            this.zhonghua_logo1.Size = new System.Drawing.Size(108, 43);
            this.zhonghua_logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zhonghua_logo1.TabIndex = 0;
            this.zhonghua_logo1.TabStop = false;
            // 
            // jingji_bc4_value
            // 
            this.jingji_bc4_value.Location = new System.Drawing.Point(12, 555);
            this.jingji_bc4_value.Name = "jingji_bc4_value";
            this.jingji_bc4_value.Size = new System.Drawing.Size(271, 11);
            this.jingji_bc4_value.TabIndex = 139;
            this.jingji_bc4_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jingji_bc3_value
            // 
            this.jingji_bc3_value.Location = new System.Drawing.Point(14, 408);
            this.jingji_bc3_value.Name = "jingji_bc3_value";
            this.jingji_bc3_value.Size = new System.Drawing.Size(268, 11);
            this.jingji_bc3_value.TabIndex = 138;
            this.jingji_bc3_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jingji_bc2_value
            // 
            this.jingji_bc2_value.Location = new System.Drawing.Point(66, 302);
            this.jingji_bc2_value.Name = "jingji_bc2_value";
            this.jingji_bc2_value.Size = new System.Drawing.Size(215, 11);
            this.jingji_bc2_value.TabIndex = 137;
            this.jingji_bc2_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jingji_bc1_value
            // 
            this.jingji_bc1_value.Location = new System.Drawing.Point(140, 70);
            this.jingji_bc1_value.Name = "jingji_bc1_value";
            this.jingji_bc1_value.Size = new System.Drawing.Size(249, 17);
            this.jingji_bc1_value.TabIndex = 136;
            this.jingji_bc1_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.Location = new System.Drawing.Point(15, 300);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(54, 13);
            this.label32.TabIndex = 104;
            this.label32.Text = "订单号：";
            // 
            // jingji_quantity
            // 
            this.jingji_quantity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_quantity.Location = new System.Drawing.Point(286, 295);
            this.jingji_quantity.Name = "jingji_quantity";
            this.jingji_quantity.Size = new System.Drawing.Size(103, 19);
            this.jingji_quantity.TabIndex = 135;
            // 
            // jingji_weight1
            // 
            this.jingji_weight1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_weight1.Location = new System.Drawing.Point(286, 275);
            this.jingji_weight1.Name = "jingji_weight1";
            this.jingji_weight1.Size = new System.Drawing.Size(106, 15);
            this.jingji_weight1.TabIndex = 134;
            // 
            // jingji_bc4
            // 
            this.jingji_bc4.Location = new System.Drawing.Point(12, 517);
            this.jingji_bc4.Name = "jingji_bc4";
            this.jingji_bc4.Size = new System.Drawing.Size(270, 36);
            this.jingji_bc4.TabIndex = 133;
            this.jingji_bc4.TabStop = false;
            // 
            // jingji_bc3
            // 
            this.jingji_bc3.Location = new System.Drawing.Point(13, 366);
            this.jingji_bc3.Name = "jingji_bc3";
            this.jingji_bc3.Size = new System.Drawing.Size(270, 42);
            this.jingji_bc3.TabIndex = 132;
            this.jingji_bc3.TabStop = false;
            // 
            // jingji_bc2
            // 
            this.jingji_bc2.Location = new System.Drawing.Point(13, 275);
            this.jingji_bc2.Name = "jingji_bc2";
            this.jingji_bc2.Size = new System.Drawing.Size(270, 26);
            this.jingji_bc2.TabIndex = 131;
            this.jingji_bc2.TabStop = false;
            // 
            // jingji_bc1
            // 
            this.jingji_bc1.Location = new System.Drawing.Point(140, 14);
            this.jingji_bc1.Name = "jingji_bc1";
            this.jingji_bc1.Size = new System.Drawing.Size(250, 54);
            this.jingji_bc1.TabIndex = 50;
            this.jingji_bc1.TabStop = false;
            // 
            // label52
            // 
            this.label52.Location = new System.Drawing.Point(362, 311);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(27, 39);
            this.label52.TabIndex = 130;
            // 
            // jingji_erq1
            // 
            this.jingji_erq1.Location = new System.Drawing.Point(290, 491);
            this.jingji_erq1.Name = "jingji_erq1";
            this.jingji_erq1.Size = new System.Drawing.Size(100, 99);
            this.jingji_erq1.TabIndex = 49;
            this.jingji_erq1.TabStop = false;
            // 
            // jingji_logo
            // 
            this.jingji_logo.Location = new System.Drawing.Point(8, 8);
            this.jingji_logo.Name = "jingji_logo";
            this.jingji_logo.Size = new System.Drawing.Size(125, 22);
            this.jingji_logo.TabIndex = 127;
            this.jingji_logo.TabStop = false;
            // 
            // jingji_logo1
            // 
            this.jingji_logo1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_logo1.Location = new System.Drawing.Point(8, 18);
            this.jingji_logo1.Name = "jingji_logo1";
            this.jingji_logo1.Size = new System.Drawing.Size(126, 54);
            this.jingji_logo1.TabIndex = 125;
            this.jingji_logo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jingji_in_address2
            // 
            this.jingji_in_address2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_in_address2.Location = new System.Drawing.Point(190, 462);
            this.jingji_in_address2.Name = "jingji_in_address2";
            this.jingji_in_address2.Size = new System.Drawing.Size(199, 24);
            this.jingji_in_address2.TabIndex = 119;
            this.jingji_in_address2.Text = "\r\n\r\n\r\n";
            // 
            // jingji_in_tel3
            // 
            this.jingji_in_tel3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_in_tel3.Location = new System.Drawing.Point(213, 444);
            this.jingji_in_tel3.Name = "jingji_in_tel3";
            this.jingji_in_tel3.Size = new System.Drawing.Size(179, 12);
            this.jingji_in_tel3.TabIndex = 122;
            // 
            // jingji_in_name2
            // 
            this.jingji_in_name2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_in_name2.Location = new System.Drawing.Point(215, 423);
            this.jingji_in_name2.Name = "jingji_in_name2";
            this.jingji_in_name2.Size = new System.Drawing.Size(176, 12);
            this.jingji_in_name2.TabIndex = 121;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label60.Location = new System.Drawing.Point(169, 424);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(41, 12);
            this.label60.TabIndex = 120;
            this.label60.Text = "收件：";
            // 
            // jingji_out_address2
            // 
            this.jingji_out_address2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_out_address2.Location = new System.Drawing.Point(13, 459);
            this.jingji_out_address2.Name = "jingji_out_address2";
            this.jingji_out_address2.Size = new System.Drawing.Size(148, 24);
            this.jingji_out_address2.TabIndex = 115;
            this.jingji_out_address2.Text = "\r\n\r\n\r\n";
            // 
            // jingji_out_tel2
            // 
            this.jingji_out_tel2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_out_tel2.Location = new System.Drawing.Point(54, 441);
            this.jingji_out_tel2.Name = "jingji_out_tel2";
            this.jingji_out_tel2.Size = new System.Drawing.Size(80, 14);
            this.jingji_out_tel2.TabIndex = 118;
            // 
            // jingji_out_name2
            // 
            this.jingji_out_name2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_out_name2.Location = new System.Drawing.Point(55, 423);
            this.jingji_out_name2.Name = "jingji_out_name2";
            this.jingji_out_name2.Size = new System.Drawing.Size(106, 14);
            this.jingji_out_name2.TabIndex = 117;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label58.Location = new System.Drawing.Point(10, 423);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(41, 12);
            this.label58.TabIndex = 116;
            this.label58.Text = "寄件：";
            // 
            // label51
            // 
            this.label51.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label51.Location = new System.Drawing.Point(15, 491);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(266, 28);
            this.label51.TabIndex = 113;
            this.label51.Text = "备注：收货前请确认包装是否完整，有无破损。如有问题，请拒绝签收\r\n";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label50.Location = new System.Drawing.Point(173, 573);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(95, 12);
            this.label50.TabIndex = 112;
            this.label50.Text = "客服电话 :11183";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label39.Location = new System.Drawing.Point(16, 573);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(125, 12);
            this.label39.TabIndex = 111;
            this.label39.Text = "网址: www.ems.com.cn";
            // 
            // jingji_logo2
            // 
            this.jingji_logo2.Image = ((System.Drawing.Image)(resources.GetObject("jingji_logo2.Image")));
            this.jingji_logo2.Location = new System.Drawing.Point(280, 368);
            this.jingji_logo2.Name = "jingji_logo2";
            this.jingji_logo2.Size = new System.Drawing.Size(110, 40);
            this.jingji_logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jingji_logo2.TabIndex = 110;
            this.jingji_logo2.TabStop = false;
            // 
            // jingji_list1
            // 
            this.jingji_list1.BackColor = System.Drawing.Color.White;
            this.jingji_list1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jingji_list1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_list1.FormattingEnabled = true;
            this.jingji_list1.ItemHeight = 12;
            this.jingji_list1.Location = new System.Drawing.Point(76, 314);
            this.jingji_list1.Name = "jingji_list1";
            this.jingji_list1.Size = new System.Drawing.Size(307, 36);
            this.jingji_list1.TabIndex = 84;
            // 
            // jingji_info
            // 
            this.jingji_info.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_info.Location = new System.Drawing.Point(9, 314);
            this.jingji_info.Name = "jingji_info";
            this.jingji_info.Size = new System.Drawing.Size(65, 12);
            this.jingji_info.TabIndex = 108;
            this.jingji_info.Text = "配送信息：";
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(169, 245);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(216, 24);
            this.label30.TabIndex = 103;
            this.label30.Text = "快件送达收件人地址经收件人或收件人允许的代收人签字视为送达";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(170, 233);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(191, 12);
            this.label28.TabIndex = 102;
            this.label28.Text = "签收时间      年   月   日   时";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(170, 219);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(95, 12);
            this.label26.TabIndex = 101;
            this.label26.Text = "收件人\\代收人：";
            // 
            // jingji_money
            // 
            this.jingji_money.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_money.Location = new System.Drawing.Point(102, 254);
            this.jingji_money.Name = "jingji_money";
            this.jingji_money.Size = new System.Drawing.Size(60, 14);
            this.jingji_money.TabIndex = 100;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(10, 251);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 12);
            this.label25.TabIndex = 99;
            this.label25.Text = "保价金额(元)：";
            // 
            // jingji_weight
            // 
            this.jingji_weight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_weight.Location = new System.Drawing.Point(104, 236);
            this.jingji_weight.Name = "jingji_weight";
            this.jingji_weight.Size = new System.Drawing.Size(60, 14);
            this.jingji_weight.TabIndex = 98;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(10, 235);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 12);
            this.label24.TabIndex = 97;
            this.label24.Text = "计费重量(KG)：";
            // 
            // jingji_money_type
            // 
            this.jingji_money_type.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_money_type.Location = new System.Drawing.Point(84, 218);
            this.jingji_money_type.Name = "jingji_money_type";
            this.jingji_money_type.Size = new System.Drawing.Size(80, 14);
            this.jingji_money_type.TabIndex = 96;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 9F);
            this.label23.Location = new System.Drawing.Point(11, 218);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 15);
            this.label23.TabIndex = 95;
            this.label23.Text = "付款方式：";
            // 
            // jingji_in_address1
            // 
            this.jingji_in_address1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_in_address1.Location = new System.Drawing.Point(48, 177);
            this.jingji_in_address1.Name = "jingji_in_address1";
            this.jingji_in_address1.Size = new System.Drawing.Size(339, 38);
            this.jingji_in_address1.TabIndex = 94;
            this.jingji_in_address1.Text = "\r\n\r\n";
            // 
            // jingji_in_tel2
            // 
            this.jingji_in_tel2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_in_tel2.Location = new System.Drawing.Point(277, 152);
            this.jingji_in_tel2.Name = "jingji_in_tel2";
            this.jingji_in_tel2.Size = new System.Drawing.Size(98, 20);
            this.jingji_in_tel2.TabIndex = 93;
            this.jingji_in_tel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jingji_in_tel1
            // 
            this.jingji_in_tel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_in_tel1.Location = new System.Drawing.Point(159, 152);
            this.jingji_in_tel1.Name = "jingji_in_tel1";
            this.jingji_in_tel1.Size = new System.Drawing.Size(98, 20);
            this.jingji_in_tel1.TabIndex = 92;
            this.jingji_in_tel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jingji_in_name
            // 
            this.jingji_in_name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_in_name.Location = new System.Drawing.Point(53, 152);
            this.jingji_in_name.Name = "jingji_in_name";
            this.jingji_in_name.Size = new System.Drawing.Size(91, 20);
            this.jingji_in_name.TabIndex = 91;
            this.jingji_in_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(11, 156);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 90;
            this.label22.Text = "收件：";
            // 
            // jingji_out_address1
            // 
            this.jingji_out_address1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_out_address1.Location = new System.Drawing.Point(10, 119);
            this.jingji_out_address1.Name = "jingji_out_address1";
            this.jingji_out_address1.Size = new System.Drawing.Size(192, 28);
            this.jingji_out_address1.TabIndex = 84;
            this.jingji_out_address1.Text = "\r\n\r\n\r\n";
            // 
            // jingji_out_tel1
            // 
            this.jingji_out_tel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_out_tel1.Location = new System.Drawing.Point(56, 106);
            this.jingji_out_tel1.Name = "jingji_out_tel1";
            this.jingji_out_tel1.Size = new System.Drawing.Size(145, 10);
            this.jingji_out_tel1.TabIndex = 89;
            // 
            // jingji_city
            // 
            this.jingji_city.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_city.Location = new System.Drawing.Point(207, 91);
            this.jingji_city.Name = "jingji_city";
            this.jingji_city.Size = new System.Drawing.Size(184, 58);
            this.jingji_city.TabIndex = 88;
            this.jingji_city.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jingji_out_name1
            // 
            this.jingji_out_name1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jingji_out_name1.Location = new System.Drawing.Point(53, 92);
            this.jingji_out_name1.Name = "jingji_out_name1";
            this.jingji_out_name1.Size = new System.Drawing.Size(148, 10);
            this.jingji_out_name1.TabIndex = 87;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(9, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 14);
            this.label21.TabIndex = 86;
            this.label21.Text = "寄件：";
            // 
            // shapeContainer4
            // 
            this.shapeContainer4.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer4.Name = "shapeContainer4";
            this.shapeContainer4.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape39,
            this.lineShape38,
            this.lineShape37,
            this.lineShape36,
            this.lineShape34,
            this.lineShape33,
            this.lineShape32,
            this.lineShape31,
            this.lineShape30,
            this.lineShape29,
            this.lineShape28,
            this.lineShape27,
            this.lineShape26,
            this.lineShape21,
            this.lineShape_bottom,
            this.lineShape_right,
            this.lineShape_left,
            this.lineShape_top});
            this.shapeContainer4.Size = new System.Drawing.Size(400, 600);
            this.shapeContainer4.TabIndex = 126;
            this.shapeContainer4.TabStop = false;
            // 
            // lineShape39
            // 
            this.lineShape39.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape39.Name = "lineShape39";
            this.lineShape39.X1 = 7;
            this.lineShape39.X2 = 287;
            this.lineShape39.Y1 = 567;
            this.lineShape39.Y2 = 567;
            // 
            // lineShape38
            // 
            this.lineShape38.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape38.Name = "lineShape38";
            this.lineShape38.X1 = 287;
            this.lineShape38.X2 = 287;
            this.lineShape38.Y1 = 486;
            this.lineShape38.Y2 = 593;
            // 
            // lineShape37
            // 
            this.lineShape37.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape37.Name = "lineShape37";
            this.lineShape37.X1 = 165;
            this.lineShape37.X2 = 165;
            this.lineShape37.Y1 = 420;
            this.lineShape37.Y2 = 486;
            // 
            // lineShape36
            // 
            this.lineShape36.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape36.Name = "lineShape36";
            this.lineShape36.X1 = 7;
            this.lineShape36.X2 = 393;
            this.lineShape36.Y1 = 486;
            this.lineShape36.Y2 = 486;
            // 
            // lineShape34
            // 
            this.lineShape34.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape34.Name = "lineShape34";
            this.lineShape34.X1 = 7;
            this.lineShape34.X2 = 393;
            this.lineShape34.Y1 = 420;
            this.lineShape34.Y2 = 420;
            // 
            // lineShape33
            // 
            this.lineShape33.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape33.Name = "lineShape33";
            this.lineShape33.X1 = 7;
            this.lineShape33.X2 = 393;
            this.lineShape33.Y1 = 362;
            this.lineShape33.Y2 = 362;
            // 
            // lineShape32
            // 
            this.lineShape32.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape32.Name = "lineShape32";
            this.lineShape32.X1 = 6;
            this.lineShape32.X2 = 392;
            this.lineShape32.Y1 = 352;
            this.lineShape32.Y2 = 352;
            // 
            // lineShape31
            // 
            this.lineShape31.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape31.Name = "lineShape31";
            this.lineShape31.X1 = 166;
            this.lineShape31.X2 = 166;
            this.lineShape31.Y1 = 215;
            this.lineShape31.Y2 = 270;
            // 
            // lineShape30
            // 
            this.lineShape30.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape30.Name = "lineShape30";
            this.lineShape30.X1 = 7;
            this.lineShape30.X2 = 393;
            this.lineShape30.Y1 = 270;
            this.lineShape30.Y2 = 270;
            // 
            // lineShape29
            // 
            this.lineShape29.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape29.Name = "lineShape29";
            this.lineShape29.X1 = 7;
            this.lineShape29.X2 = 393;
            this.lineShape29.Y1 = 215;
            this.lineShape29.Y2 = 215;
            // 
            // lineShape28
            // 
            this.lineShape28.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape28.Name = "lineShape28";
            this.lineShape28.X1 = 203;
            this.lineShape28.X2 = 203;
            this.lineShape28.Y1 = 89;
            this.lineShape28.Y2 = 148;
            // 
            // lineShape27
            // 
            this.lineShape27.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape27.Name = "lineShape27";
            this.lineShape27.X1 = 7;
            this.lineShape27.X2 = 393;
            this.lineShape27.Y1 = 149;
            this.lineShape27.Y2 = 149;
            // 
            // lineShape26
            // 
            this.lineShape26.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape26.Name = "lineShape26";
            this.lineShape26.X1 = 7;
            this.lineShape26.X2 = 393;
            this.lineShape26.Y1 = 89;
            this.lineShape26.Y2 = 89;
            // 
            // lineShape21
            // 
            this.lineShape21.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape21.Name = "lineShape21";
            this.lineShape21.X1 = 134;
            this.lineShape21.X2 = 134;
            this.lineShape21.Y1 = 7;
            this.lineShape21.Y2 = 89;
            // 
            // lineShape_bottom
            // 
            this.lineShape_bottom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape_bottom.Name = "lineShape_bottom";
            this.lineShape_bottom.X1 = 7;
            this.lineShape_bottom.X2 = 393;
            this.lineShape_bottom.Y1 = 593;
            this.lineShape_bottom.Y2 = 593;
            // 
            // lineShape_right
            // 
            this.lineShape_right.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape_right.Name = "lineShape_right";
            this.lineShape_right.X1 = 393;
            this.lineShape_right.X2 = 393;
            this.lineShape_right.Y1 = 7;
            this.lineShape_right.Y2 = 593;
            // 
            // lineShape_left
            // 
            this.lineShape_left.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape_left.Name = "lineShape_left";
            this.lineShape_left.X1 = 7;
            this.lineShape_left.X2 = 7;
            this.lineShape_left.Y1 = 7;
            this.lineShape_left.Y2 = 593;
            // 
            // lineShape_top
            // 
            this.lineShape_top.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape_top.Name = "lineShape_top";
            this.lineShape_top.X1 = 7;
            this.lineShape_top.X2 = 393;
            this.lineShape_top.Y1 = 7;
            this.lineShape_top.Y2 = 7;
            // 
            // zhongtong_bc3_value
            // 
            this.zhongtong_bc3_value.Location = new System.Drawing.Point(120, 383);
            this.zhongtong_bc3_value.Name = "zhongtong_bc3_value";
            this.zhongtong_bc3_value.Size = new System.Drawing.Size(270, 12);
            this.zhongtong_bc3_value.TabIndex = 89;
            this.zhongtong_bc3_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zhongtong_bc2_value
            // 
            this.zhongtong_bc2_value.Location = new System.Drawing.Point(65, 282);
            this.zhongtong_bc2_value.Name = "zhongtong_bc2_value";
            this.zhongtong_bc2_value.Size = new System.Drawing.Size(270, 12);
            this.zhongtong_bc2_value.TabIndex = 88;
            this.zhongtong_bc2_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(348, 517);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(49, 82);
            this.label34.TabIndex = 87;
            // 
            // zhongtong_bc1
            // 
            this.zhongtong_bc1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_bc1.Location = new System.Drawing.Point(121, 8);
            this.zhongtong_bc1.Name = "zhongtong_bc1";
            this.zhongtong_bc1.Size = new System.Drawing.Size(270, 45);
            this.zhongtong_bc1.TabIndex = 50;
            // 
            // zhongtong_bc3
            // 
            this.zhongtong_bc3.Location = new System.Drawing.Point(117, 344);
            this.zhongtong_bc3.Name = "zhongtong_bc3";
            this.zhongtong_bc3.Size = new System.Drawing.Size(270, 38);
            this.zhongtong_bc3.TabIndex = 86;
            this.zhongtong_bc3.TabStop = false;
            // 
            // zhongtong_bc2
            // 
            this.zhongtong_bc2.Location = new System.Drawing.Point(65, 247);
            this.zhongtong_bc2.Name = "zhongtong_bc2";
            this.zhongtong_bc2.Size = new System.Drawing.Size(270, 32);
            this.zhongtong_bc2.TabIndex = 85;
            this.zhongtong_bc2.TabStop = false;
            // 
            // zhongtong_logo2
            // 
            this.zhongtong_logo2.Image = ((System.Drawing.Image)(resources.GetObject("zhongtong_logo2.Image")));
            this.zhongtong_logo2.Location = new System.Drawing.Point(11, 349);
            this.zhongtong_logo2.Name = "zhongtong_logo2";
            this.zhongtong_logo2.Size = new System.Drawing.Size(100, 33);
            this.zhongtong_logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zhongtong_logo2.TabIndex = 22;
            this.zhongtong_logo2.TabStop = false;
            // 
            // zhongtong_time
            // 
            this.zhongtong_time.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_time.Location = new System.Drawing.Point(254, 99);
            this.zhongtong_time.Name = "zhongtong_time";
            this.zhongtong_time.Size = new System.Drawing.Size(80, 12);
            this.zhongtong_time.TabIndex = 83;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(70, 478);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(0, 12);
            this.label84.TabIndex = 82;
            // 
            // zhongtong_out_tel1
            // 
            this.zhongtong_out_tel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_out_tel1.Location = new System.Drawing.Point(248, 458);
            this.zhongtong_out_tel1.Name = "zhongtong_out_tel1";
            this.zhongtong_out_tel1.Size = new System.Drawing.Size(100, 14);
            this.zhongtong_out_tel1.TabIndex = 81;
            // 
            // zhongtong_out_name1
            // 
            this.zhongtong_out_name1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_out_name1.Location = new System.Drawing.Point(94, 459);
            this.zhongtong_out_name1.Name = "zhongtong_out_name1";
            this.zhongtong_out_name1.Size = new System.Drawing.Size(100, 12);
            this.zhongtong_out_name1.TabIndex = 80;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label87.Location = new System.Drawing.Point(35, 476);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(41, 12);
            this.label87.TabIndex = 79;
            this.label87.Text = "地址：";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label89.Location = new System.Drawing.Point(199, 458);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(41, 12);
            this.label89.TabIndex = 78;
            this.label89.Text = "电话：";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label90.Location = new System.Drawing.Point(35, 459);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(53, 12);
            this.label90.TabIndex = 77;
            this.label90.Text = "发件人：";
            // 
            // zhongtong_out_address1
            // 
            this.zhongtong_out_address1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_out_address1.Location = new System.Drawing.Point(89, 475);
            this.zhongtong_out_address1.Name = "zhongtong_out_address1";
            this.zhongtong_out_address1.Size = new System.Drawing.Size(298, 30);
            this.zhongtong_out_address1.TabIndex = 76;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(71, 424);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(0, 12);
            this.label92.TabIndex = 75;
            // 
            // zhongtong_in_tel1
            // 
            this.zhongtong_in_tel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_in_tel1.Location = new System.Drawing.Point(243, 402);
            this.zhongtong_in_tel1.Name = "zhongtong_in_tel1";
            this.zhongtong_in_tel1.Size = new System.Drawing.Size(100, 14);
            this.zhongtong_in_tel1.TabIndex = 74;
            // 
            // zhongtong_in_name1
            // 
            this.zhongtong_in_name1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_in_name1.Location = new System.Drawing.Point(83, 401);
            this.zhongtong_in_name1.Name = "zhongtong_in_name1";
            this.zhongtong_in_name1.Size = new System.Drawing.Size(100, 12);
            this.zhongtong_in_name1.TabIndex = 73;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(35, 418);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(41, 12);
            this.label95.TabIndex = 72;
            this.label95.Text = "地址：";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label96.Location = new System.Drawing.Point(199, 402);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(41, 12);
            this.label96.TabIndex = 71;
            this.label96.Text = "电话：";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label97.Location = new System.Drawing.Point(36, 401);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(41, 12);
            this.label97.TabIndex = 70;
            this.label97.Text = "姓名：";
            // 
            // label98
            // 
            this.label98.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label98.Location = new System.Drawing.Point(5, 461);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(19, 34);
            this.label98.TabIndex = 69;
            this.label98.Text = "发件";
            // 
            // label99
            // 
            this.label99.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label99.Location = new System.Drawing.Point(7, 407);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(15, 27);
            this.label99.TabIndex = 68;
            this.label99.Text = "收件";
            // 
            // zhongtong_in_address1
            // 
            this.zhongtong_in_address1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_in_address1.Location = new System.Drawing.Point(83, 418);
            this.zhongtong_in_address1.Name = "zhongtong_in_address1";
            this.zhongtong_in_address1.Size = new System.Drawing.Size(306, 30);
            this.zhongtong_in_address1.TabIndex = 67;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(71, 219);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(0, 12);
            this.label74.TabIndex = 65;
            // 
            // zhongtong_out_tel
            // 
            this.zhongtong_out_tel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_out_tel.Location = new System.Drawing.Point(243, 188);
            this.zhongtong_out_tel.Name = "zhongtong_out_tel";
            this.zhongtong_out_tel.Size = new System.Drawing.Size(100, 14);
            this.zhongtong_out_tel.TabIndex = 64;
            // 
            // zhongtong_out_name
            // 
            this.zhongtong_out_name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_out_name.Location = new System.Drawing.Point(91, 188);
            this.zhongtong_out_name.Name = "zhongtong_out_name";
            this.zhongtong_out_name.Size = new System.Drawing.Size(100, 12);
            this.zhongtong_out_name.TabIndex = 63;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label80.Location = new System.Drawing.Point(32, 207);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(41, 12);
            this.label80.TabIndex = 62;
            this.label80.Text = "地址：";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label81.Location = new System.Drawing.Point(199, 189);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(41, 12);
            this.label81.TabIndex = 61;
            this.label81.Text = "电话：";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label82.Location = new System.Drawing.Point(32, 188);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(53, 12);
            this.label82.TabIndex = 60;
            this.label82.Text = "发件人：";
            // 
            // zhongtong_out_address
            // 
            this.zhongtong_out_address.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_out_address.Location = new System.Drawing.Point(79, 208);
            this.zhongtong_out_address.Name = "zhongtong_out_address";
            this.zhongtong_out_address.Size = new System.Drawing.Size(307, 30);
            this.zhongtong_out_address.TabIndex = 59;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(72, 165);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(0, 12);
            this.label73.TabIndex = 58;
            // 
            // zhongtong_in_tel
            // 
            this.zhongtong_in_tel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_in_tel.Location = new System.Drawing.Point(244, 125);
            this.zhongtong_in_tel.Name = "zhongtong_in_tel";
            this.zhongtong_in_tel.Size = new System.Drawing.Size(98, 14);
            this.zhongtong_in_tel.TabIndex = 57;
            // 
            // zhongtong_in_name
            // 
            this.zhongtong_in_name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_in_name.Location = new System.Drawing.Point(79, 126);
            this.zhongtong_in_name.Name = "zhongtong_in_name";
            this.zhongtong_in_name.Size = new System.Drawing.Size(100, 12);
            this.zhongtong_in_name.TabIndex = 56;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label70.Location = new System.Drawing.Point(31, 146);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(41, 12);
            this.label70.TabIndex = 55;
            this.label70.Text = "地址：";
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable5.Location = new System.Drawing.Point(199, 126);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(41, 12);
            this.lable5.TabIndex = 54;
            this.lable5.Text = "电话：";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label68.Location = new System.Drawing.Point(32, 126);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(41, 12);
            this.label68.TabIndex = 53;
            this.label68.Text = "姓名：";
            // 
            // label65
            // 
            this.label65.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label65.Location = new System.Drawing.Point(6, 197);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(16, 30);
            this.label65.TabIndex = 52;
            this.label65.Text = "寄件";
            // 
            // 收件
            // 
            this.收件.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.收件.Location = new System.Drawing.Point(8, 141);
            this.收件.Name = "收件";
            this.收件.Size = new System.Drawing.Size(15, 27);
            this.收件.TabIndex = 51;
            this.收件.Text = "收件";
            // 
            // zhongtong_in_xian
            // 
            this.zhongtong_in_xian.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_in_xian.Location = new System.Drawing.Point(31, 99);
            this.zhongtong_in_xian.Name = "zhongtong_in_xian";
            this.zhongtong_in_xian.Size = new System.Drawing.Size(177, 14);
            this.zhongtong_in_xian.TabIndex = 49;
            this.zhongtong_in_xian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zhongtong_in_diqu
            // 
            this.zhongtong_in_diqu.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_in_diqu.Location = new System.Drawing.Point(66, 63);
            this.zhongtong_in_diqu.Name = "zhongtong_in_diqu";
            this.zhongtong_in_diqu.Size = new System.Drawing.Size(262, 25);
            this.zhongtong_in_diqu.TabIndex = 48;
            this.zhongtong_in_diqu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label62.Location = new System.Drawing.Point(21, 319);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(197, 12);
            this.label62.TabIndex = 46;
            this.label62.Text = "信息无误,包装完好,没......(省略)";
            // 
            // zhongtong_in_address
            // 
            this.zhongtong_in_address.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_in_address.Location = new System.Drawing.Point(79, 146);
            this.zhongtong_in_address.Name = "zhongtong_in_address";
            this.zhongtong_in_address.Size = new System.Drawing.Size(301, 30);
            this.zhongtong_in_address.TabIndex = 43;
            // 
            // zhongtong_list1
            // 
            this.zhongtong_list1.BackColor = System.Drawing.Color.White;
            this.zhongtong_list1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zhongtong_list1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhongtong_list1.FormattingEnabled = true;
            this.zhongtong_list1.ItemHeight = 12;
            this.zhongtong_list1.Location = new System.Drawing.Point(53, 517);
            this.zhongtong_list1.Name = "zhongtong_list1";
            this.zhongtong_list1.Size = new System.Drawing.Size(331, 72);
            this.zhongtong_list1.TabIndex = 28;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label77.Location = new System.Drawing.Point(6, 517);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(41, 12);
            this.label77.TabIndex = 27;
            this.label77.Text = "明细：";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label78.Location = new System.Drawing.Point(262, 304);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(69, 20);
            this.label78.TabIndex = 26;
            this.label78.Text = "签收：";
            // 
            // label79
            // 
            this.label79.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label79.Location = new System.Drawing.Point(22, 299);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(234, 16);
            this.label79.TabIndex = 25;
            this.label79.Text = "您对此单的签收,代表您已验货,确认商品";
            // 
            // zhongtong_logo1
            // 
            this.zhongtong_logo1.Image = ((System.Drawing.Image)(resources.GetObject("zhongtong_logo1.Image")));
            this.zhongtong_logo1.Location = new System.Drawing.Point(7, 8);
            this.zhongtong_logo1.Name = "zhongtong_logo1";
            this.zhongtong_logo1.Size = new System.Drawing.Size(100, 33);
            this.zhongtong_logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zhongtong_logo1.TabIndex = 7;
            this.zhongtong_logo1.TabStop = false;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape25,
            this.lineShape24,
            this.lineShape23,
            this.lineShape22,
            this.lineShape20,
            this.lineShape19,
            this.lineShape15,
            this.lineShape13,
            this.lineShape14,
            this.lineShape16,
            this.lineShape17,
            this.lineShape18});
            this.shapeContainer3.Size = new System.Drawing.Size(398, 598);
            this.shapeContainer3.TabIndex = 45;
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape25
            // 
            this.lineShape25.Name = "lineShape25";
            this.lineShape25.X1 = 31;
            this.lineShape25.X2 = 31;
            this.lineShape25.Y1 = 395;
            this.lineShape25.Y2 = 510;
            // 
            // lineShape24
            // 
            this.lineShape24.Name = "lineShape24";
            this.lineShape24.X1 = -3;
            this.lineShape24.X2 = 397;
            this.lineShape24.Y1 = 453;
            this.lineShape24.Y2 = 453;
            // 
            // lineShape23
            // 
            this.lineShape23.Name = "lineShape23";
            this.lineShape23.X1 = 0;
            this.lineShape23.X2 = 400;
            this.lineShape23.Y1 = 182;
            this.lineShape23.Y2 = 182;
            // 
            // lineShape22
            // 
            this.lineShape22.Name = "lineShape22";
            this.lineShape22.X1 = -1;
            this.lineShape22.X2 = 399;
            this.lineShape22.Y1 = 295;
            this.lineShape22.Y2 = 295;
            // 
            // lineShape20
            // 
            this.lineShape20.Name = "lineShape20";
            this.lineShape20.X1 = 0;
            this.lineShape20.X2 = 400;
            this.lineShape20.Y1 = 395;
            this.lineShape20.Y2 = 395;
            // 
            // lineShape19
            // 
            this.lineShape19.Name = "lineShape19";
            this.lineShape19.X1 = -3;
            this.lineShape19.X2 = 397;
            this.lineShape19.Y1 = 337;
            this.lineShape19.Y2 = 337;
            // 
            // lineShape15
            // 
            this.lineShape15.Name = "lineShape15";
            this.lineShape15.X1 = 0;
            this.lineShape15.X2 = 400;
            this.lineShape15.Y1 = 93;
            this.lineShape15.Y2 = 93;
            // 
            // lineShape13
            // 
            this.lineShape13.Name = "lineShape6";
            this.lineShape13.X1 = 0;
            this.lineShape13.X2 = 400;
            this.lineShape13.Y1 = 510;
            this.lineShape13.Y2 = 510;
            // 
            // lineShape14
            // 
            this.lineShape14.Name = "lineShape5";
            this.lineShape14.X1 = 29;
            this.lineShape14.X2 = 29;
            this.lineShape14.Y1 = 119;
            this.lineShape14.Y2 = 243;
            // 
            // lineShape16
            // 
            this.lineShape16.Name = "lineShape3";
            this.lineShape16.X1 = 0;
            this.lineShape16.X2 = 400;
            this.lineShape16.Y1 = 243;
            this.lineShape16.Y2 = 243;
            // 
            // lineShape17
            // 
            this.lineShape17.Name = "lineShape2";
            this.lineShape17.X1 = 0;
            this.lineShape17.X2 = 396;
            this.lineShape17.Y1 = 57;
            this.lineShape17.Y2 = 57;
            // 
            // lineShape18
            // 
            this.lineShape18.Name = "lineShape1";
            this.lineShape18.X1 = 0;
            this.lineShape18.X2 = 400;
            this.lineShape18.Y1 = 119;
            this.lineShape18.Y2 = 119;
            // 
            // ouya_bc2_value
            // 
            this.ouya_bc2_value.Location = new System.Drawing.Point(118, 274);
            this.ouya_bc2_value.Name = "ouya_bc2_value";
            this.ouya_bc2_value.Size = new System.Drawing.Size(200, 12);
            this.ouya_bc2_value.TabIndex = 51;
            this.ouya_bc2_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ouya_bc1_value
            // 
            this.ouya_bc1_value.Location = new System.Drawing.Point(118, 48);
            this.ouya_bc1_value.Name = "ouya_bc1_value";
            this.ouya_bc1_value.Size = new System.Drawing.Size(270, 12);
            this.ouya_bc1_value.TabIndex = 50;
            this.ouya_bc1_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(361, 354);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(38, 90);
            this.label36.TabIndex = 49;
            // 
            // ouya_bc2
            // 
            this.ouya_bc2.Location = new System.Drawing.Point(116, 222);
            this.ouya_bc2.Name = "ouya_bc2";
            this.ouya_bc2.Size = new System.Drawing.Size(200, 50);
            this.ouya_bc2.TabIndex = 48;
            this.ouya_bc2.TabStop = false;
            // 
            // ouya_bc1
            // 
            this.ouya_bc1.Location = new System.Drawing.Point(118, 7);
            this.ouya_bc1.Name = "ouya_bc1";
            this.ouya_bc1.Size = new System.Drawing.Size(270, 40);
            this.ouya_bc1.TabIndex = 47;
            this.ouya_bc1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(12, 322);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 12);
            this.label18.TabIndex = 46;
            this.label18.Text = "无误，包装完好。没......(省略)";
            // 
            // ouya_out_address
            // 
            this.ouya_out_address.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ouya_out_address.Location = new System.Drawing.Point(107, 173);
            this.ouya_out_address.Name = "ouya_out_address";
            this.ouya_out_address.Size = new System.Drawing.Size(281, 30);
            this.ouya_out_address.TabIndex = 44;
            // 
            // ouya_out_tel
            // 
            this.ouya_out_tel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ouya_out_tel.Location = new System.Drawing.Point(258, 155);
            this.ouya_out_tel.Name = "ouya_out_tel";
            this.ouya_out_tel.Size = new System.Drawing.Size(100, 12);
            this.ouya_out_tel.TabIndex = 43;
            // 
            // ouya_out_name
            // 
            this.ouya_out_name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ouya_out_name.Location = new System.Drawing.Point(105, 155);
            this.ouya_out_name.Name = "ouya_out_name";
            this.ouya_out_name.Size = new System.Drawing.Size(100, 12);
            this.ouya_out_name.TabIndex = 42;
            // 
            // ouya_in_address
            // 
            this.ouya_in_address.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ouya_in_address.Location = new System.Drawing.Point(105, 105);
            this.ouya_in_address.Name = "ouya_in_address";
            this.ouya_in_address.Size = new System.Drawing.Size(197, 30);
            this.ouya_in_address.TabIndex = 41;
            // 
            // ouya_in_tel
            // 
            this.ouya_in_tel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ouya_in_tel.Location = new System.Drawing.Point(105, 87);
            this.ouya_in_tel.Name = "ouya_in_tel";
            this.ouya_in_tel.Size = new System.Drawing.Size(150, 12);
            this.ouya_in_tel.TabIndex = 40;
            // 
            // ouya_in_name
            // 
            this.ouya_in_name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ouya_in_name.Location = new System.Drawing.Point(105, 71);
            this.ouya_in_name.Name = "ouya_in_name";
            this.ouya_in_name.Size = new System.Drawing.Size(150, 12);
            this.ouya_in_name.TabIndex = 39;
            // 
            // ouya_city
            // 
            this.ouya_city.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ouya_city.Location = new System.Drawing.Point(308, 72);
            this.ouya_city.Name = "ouya_city";
            this.ouya_city.Size = new System.Drawing.Size(80, 54);
            this.ouya_city.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(20, 579);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(233, 12);
            this.label17.TabIndex = 37;
            this.label17.Text = "日期：____________年_______月_______日";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(20, 564);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(257, 12);
            this.label16.TabIndex = 36;
            this.label16.Text = "寄件人签署：______________________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(19, 543);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(215, 12);
            this.label15.TabIndex = 35;
            this.label15.Text = "2、本人已翻阅并同意载运契约一切条款";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(20, 527);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(323, 12);
            this.label14.TabIndex = 34;
            this.label14.Text = "1、兹证明本人所填写资料属实且无装寄任何危险及禁寄物品";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(38, 498);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 33;
            this.label13.Text = "抛弃";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(38, 478);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 12);
            this.label12.TabIndex = 32;
            this.label12.Text = "退回寄件人并由寄件人付运费";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.Location = new System.Drawing.Point(19, 498);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(19, 478);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(19, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "若无法投递时，寄件人之指定事项：";
            // 
            // ouya_list1
            // 
            this.ouya_list1.BackColor = System.Drawing.Color.White;
            this.ouya_list1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ouya_list1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ouya_list1.FormattingEnabled = true;
            this.ouya_list1.ItemHeight = 12;
            this.ouya_list1.Location = new System.Drawing.Point(60, 360);
            this.ouya_list1.Name = "ouya_list1";
            this.ouya_list1.Size = new System.Drawing.Size(328, 84);
            this.ouya_list1.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(13, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "明细：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(253, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "签收：";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(13, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "您对此单的签收，代表您已验货，确认商品";
            // 
            // ouya_brq1
            // 
            this.ouya_brq1.Location = new System.Drawing.Point(321, 219);
            this.ouya_brq1.Name = "ouya_brq1";
            this.ouya_brq1.Size = new System.Drawing.Size(73, 67);
            this.ouya_brq1.TabIndex = 24;
            this.ouya_brq1.TabStop = false;
            // 
            // ouya_logo2
            // 
            this.ouya_logo2.Location = new System.Drawing.Point(11, 232);
            this.ouya_logo2.Name = "ouya_logo2";
            this.ouya_logo2.Size = new System.Drawing.Size(100, 35);
            this.ouya_logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ouya_logo2.TabIndex = 22;
            this.ouya_logo2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(57, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "地址：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(211, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(57, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(58, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "地址：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(58, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "电话：";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable2.Location = new System.Drawing.Point(58, 70);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(41, 12);
            this.lable2.TabIndex = 10;
            this.lable2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "发件人";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lable1
            // 
            this.lable1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable1.Location = new System.Drawing.Point(5, 74);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(33, 56);
            this.lable1.TabIndex = 8;
            this.lable1.Text = "收件人";
            this.lable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ouya_logo1
            // 
            this.ouya_logo1.Location = new System.Drawing.Point(12, 13);
            this.ouya_logo1.Name = "ouya_logo1";
            this.ouya_logo1.Size = new System.Drawing.Size(100, 35);
            this.ouya_logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ouya_logo1.TabIndex = 7;
            this.ouya_logo1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(398, 598);
            this.shapeContainer1.TabIndex = 45;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 0;
            this.lineShape6.X2 = 400;
            this.lineShape6.Y1 = 351;
            this.lineShape6.Y2 = 351;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 0;
            this.lineShape5.X2 = 400;
            this.lineShape5.Y1 = 288;
            this.lineShape5.Y2 = 288;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 45;
            this.lineShape4.X2 = 45;
            this.lineShape4.Y1 = 60;
            this.lineShape4.Y2 = 214;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 0;
            this.lineShape3.X2 = 400;
            this.lineShape3.Y1 = 214;
            this.lineShape3.Y2 = 214;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 0;
            this.lineShape2.X2 = 396;
            this.lineShape2.Y1 = 60;
            this.lineShape2.Y2 = 60;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 400;
            this.lineShape1.Y1 = 144;
            this.lineShape1.Y2 = 144;
            // 
            // EMS
            // 
            this.EMS.BackColor = System.Drawing.Color.White;
            this.EMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EMS.Controls.Add(this.ems_remarks_no);
            this.EMS.Controls.Add(this.ems_remarks);
            this.EMS.Controls.Add(this.ems_bc2);
            this.EMS.Controls.Add(this.ems_in_address1);
            this.EMS.Controls.Add(this.label55);
            this.EMS.Controls.Add(this.ems_in_tel1);
            this.EMS.Controls.Add(this.label57);
            this.EMS.Controls.Add(this.ems_in_name1);
            this.EMS.Controls.Add(this.label59);
            this.EMS.Controls.Add(this.ems_out_address1);
            this.EMS.Controls.Add(this.label53);
            this.EMS.Controls.Add(this.ems_actual_weight2);
            this.EMS.Controls.Add(this.label43);
            this.EMS.Controls.Add(this.ems_out_name1);
            this.EMS.Controls.Add(this.label38);
            this.EMS.Controls.Add(this.label37);
            this.EMS.Controls.Add(this.ems_list1);
            this.EMS.Controls.Add(this.ems_insured_value);
            this.EMS.Controls.Add(this.label35);
            this.EMS.Controls.Add(this.ems_actual_weight1);
            this.EMS.Controls.Add(this.label33);
            this.EMS.Controls.Add(this.ems_out_address);
            this.EMS.Controls.Add(this.label31);
            this.EMS.Controls.Add(this.ems_out_tel);
            this.EMS.Controls.Add(this.label29);
            this.EMS.Controls.Add(this.ems_out_name);
            this.EMS.Controls.Add(this.label27);
            this.EMS.Controls.Add(this.label20);
            this.EMS.Controls.Add(this.label19);
            this.EMS.Controls.Add(this.ems_in_postcode);
            this.EMS.Controls.Add(this.label49);
            this.EMS.Controls.Add(this.ems_in_city);
            this.EMS.Controls.Add(this.label44);
            this.EMS.Controls.Add(this.label48);
            this.EMS.Controls.Add(this.label47);
            this.EMS.Controls.Add(this.ems_time);
            this.EMS.Controls.Add(this.label46);
            this.EMS.Controls.Add(this.label45);
            this.EMS.Controls.Add(this.ems_in_address);
            this.EMS.Controls.Add(this.ems_in_tel);
            this.EMS.Controls.Add(this.ems_in_name);
            this.EMS.Controls.Add(this.label40);
            this.EMS.Controls.Add(this.label41);
            this.EMS.Controls.Add(this.label42);
            this.EMS.Controls.Add(this.ems_bc1);
            this.EMS.Controls.Add(this.shapeContainer2);
            this.EMS.Location = new System.Drawing.Point(1200, 224);
            this.EMS.Name = "EMS";
            this.EMS.Size = new System.Drawing.Size(400, 600);
            this.EMS.TabIndex = 47;
            this.EMS.Visible = false;
            // 
            // ems_remarks_no
            // 
            this.ems_remarks_no.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_remarks_no.Location = new System.Drawing.Point(200, 565);
            this.ems_remarks_no.Name = "ems_remarks_no";
            this.ems_remarks_no.Size = new System.Drawing.Size(177, 20);
            this.ems_remarks_no.TabIndex = 81;
            // 
            // ems_remarks
            // 
            this.ems_remarks.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_remarks.Location = new System.Drawing.Point(204, 547);
            this.ems_remarks.Name = "ems_remarks";
            this.ems_remarks.Size = new System.Drawing.Size(187, 20);
            this.ems_remarks.TabIndex = 80;
            // 
            // ems_bc2
            // 
            this.ems_bc2.AddOnCaption = null;
            this.ems_bc2.AddOnData = null;
            this.ems_bc2.BackColor = System.Drawing.Color.White;
            this.ems_bc2.BarcodeType = Cobainsoft.Windows.Forms.BarcodeType.CODE39;
            this.ems_bc2.CopyRight = "";
            this.ems_bc2.Data = "000000";
            this.ems_bc2.Font = new System.Drawing.Font("Arial", 9F);
            this.ems_bc2.ForeColor = System.Drawing.Color.Black;
            this.ems_bc2.HorizontalAlignment = Cobainsoft.Windows.Forms.BarcodeHorizontalAlignment.Center;
            this.ems_bc2.InvalidDataAction = Cobainsoft.Windows.Forms.InvalidDataAction.DisplayInvalid;
            this.ems_bc2.Location = new System.Drawing.Point(7, 535);
            this.ems_bc2.LowerTopTextBy = 0F;
            this.ems_bc2.Name = "ems_bc2";
            this.ems_bc2.RaiseBottomTextBy = 0F;
            this.ems_bc2.Size = new System.Drawing.Size(189, 40);
            this.ems_bc2.TabIndex = 47;
            // 
            // ems_in_address1
            // 
            this.ems_in_address1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_in_address1.Location = new System.Drawing.Point(57, 489);
            this.ems_in_address1.Name = "ems_in_address1";
            this.ems_in_address1.Size = new System.Drawing.Size(315, 30);
            this.ems_in_address1.TabIndex = 79;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label55.Location = new System.Drawing.Point(3, 489);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(41, 12);
            this.label55.TabIndex = 78;
            this.label55.Text = "地址：";
            // 
            // ems_in_tel1
            // 
            this.ems_in_tel1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_in_tel1.Location = new System.Drawing.Point(269, 471);
            this.ems_in_tel1.Name = "ems_in_tel1";
            this.ems_in_tel1.Size = new System.Drawing.Size(122, 14);
            this.ems_in_tel1.TabIndex = 77;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label57.Location = new System.Drawing.Point(222, 471);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(41, 12);
            this.label57.TabIndex = 76;
            this.label57.Text = "电话：";
            // 
            // ems_in_name1
            // 
            this.ems_in_name1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_in_name1.Location = new System.Drawing.Point(61, 471);
            this.ems_in_name1.Name = "ems_in_name1";
            this.ems_in_name1.Size = new System.Drawing.Size(85, 12);
            this.ems_in_name1.TabIndex = 75;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label59.Location = new System.Drawing.Point(3, 471);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(53, 12);
            this.label59.TabIndex = 74;
            this.label59.Text = "收件人：";
            // 
            // ems_out_address1
            // 
            this.ems_out_address1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_out_address1.Location = new System.Drawing.Point(60, 425);
            this.ems_out_address1.Name = "ems_out_address1";
            this.ems_out_address1.Size = new System.Drawing.Size(332, 33);
            this.ems_out_address1.TabIndex = 73;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label53.Location = new System.Drawing.Point(3, 424);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(41, 12);
            this.label53.TabIndex = 72;
            this.label53.Text = "地址：";
            // 
            // ems_actual_weight2
            // 
            this.ems_actual_weight2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_actual_weight2.Location = new System.Drawing.Point(269, 403);
            this.ems_actual_weight2.Name = "ems_actual_weight2";
            this.ems_actual_weight2.Size = new System.Drawing.Size(101, 16);
            this.ems_actual_weight2.TabIndex = 71;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label43.Location = new System.Drawing.Point(145, 404);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(119, 12);
            this.label43.TabIndex = 70;
            this.label43.Text = "计费/实际重量（KG）\r\n";
            // 
            // ems_out_name1
            // 
            this.ems_out_name1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_out_name1.Location = new System.Drawing.Point(55, 404);
            this.ems_out_name1.Name = "ems_out_name1";
            this.ems_out_name1.Size = new System.Drawing.Size(89, 16);
            this.ems_out_name1.TabIndex = 69;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(3, 404);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(53, 12);
            this.label38.TabIndex = 68;
            this.label38.Text = "寄件人：";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.Location = new System.Drawing.Point(11, 371);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(353, 12);
            this.label37.TabIndex = 67;
            this.label37.Text = "该件是跨国电商进口邮件，若无法派送，请送往广州江门。谢谢！\r\n";
            // 
            // ems_list1
            // 
            this.ems_list1.BackColor = System.Drawing.Color.White;
            this.ems_list1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_list1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_list1.FormattingEnabled = true;
            this.ems_list1.ItemHeight = 12;
            this.ems_list1.Location = new System.Drawing.Point(8, 280);
            this.ems_list1.Name = "ems_list1";
            this.ems_list1.Size = new System.Drawing.Size(384, 84);
            this.ems_list1.TabIndex = 47;
            // 
            // ems_insured_value
            // 
            this.ems_insured_value.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_insured_value.Location = new System.Drawing.Point(327, 137);
            this.ems_insured_value.Name = "ems_insured_value";
            this.ems_insured_value.Size = new System.Drawing.Size(61, 15);
            this.ems_insured_value.TabIndex = 66;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.Location = new System.Drawing.Point(232, 136);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(89, 12);
            this.label35.TabIndex = 65;
            this.label35.Text = "保价金额(元)：\r\n";
            // 
            // ems_actual_weight1
            // 
            this.ems_actual_weight1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_actual_weight1.Location = new System.Drawing.Point(156, 134);
            this.ems_actual_weight1.Name = "ems_actual_weight1";
            this.ems_actual_weight1.Size = new System.Drawing.Size(77, 12);
            this.ems_actual_weight1.TabIndex = 64;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.Location = new System.Drawing.Point(1, 134);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(149, 12);
            this.label33.TabIndex = 63;
            this.label33.Text = "计费重量/实际重量（KG）:\r\n\r\n";
            // 
            // ems_out_address
            // 
            this.ems_out_address.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_out_address.Location = new System.Drawing.Point(63, 96);
            this.ems_out_address.Name = "ems_out_address";
            this.ems_out_address.Size = new System.Drawing.Size(320, 30);
            this.ems_out_address.TabIndex = 62;
            this.ems_out_address.Text = "\r\n";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(3, 95);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 12);
            this.label31.TabIndex = 61;
            this.label31.Text = "地址：";
            // 
            // ems_out_tel
            // 
            this.ems_out_tel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_out_tel.Location = new System.Drawing.Point(255, 77);
            this.ems_out_tel.Name = "ems_out_tel";
            this.ems_out_tel.Size = new System.Drawing.Size(115, 14);
            this.ems_out_tel.TabIndex = 60;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(214, 76);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 59;
            this.label29.Text = "电话：";
            // 
            // ems_out_name
            // 
            this.ems_out_name.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_out_name.Location = new System.Drawing.Point(62, 77);
            this.ems_out_name.Name = "ems_out_name";
            this.ems_out_name.Size = new System.Drawing.Size(129, 14);
            this.ems_out_name.TabIndex = 58;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(3, 77);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 12);
            this.label27.TabIndex = 57;
            this.label27.Text = "寄件人：";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(167, 248);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(226, 15);
            this.label20.TabIndex = 56;
            this.label20.Text = "签收时间：      年   月   日   时\r\n";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(2, 248);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 14);
            this.label19.TabIndex = 55;
            this.label19.Text = "收件人签名：";
            // 
            // ems_in_postcode
            // 
            this.ems_in_postcode.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_in_postcode.Location = new System.Drawing.Point(268, 186);
            this.ems_in_postcode.Name = "ems_in_postcode";
            this.ems_in_postcode.Size = new System.Drawing.Size(117, 17);
            this.ems_in_postcode.TabIndex = 54;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label49.Location = new System.Drawing.Point(210, 186);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(52, 14);
            this.label49.TabIndex = 53;
            this.label49.Text = "邮编：";
            // 
            // ems_in_city
            // 
            this.ems_in_city.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_in_city.Location = new System.Drawing.Point(264, 164);
            this.ems_in_city.Name = "ems_in_city";
            this.ems_in_city.Size = new System.Drawing.Size(128, 16);
            this.ems_in_city.TabIndex = 38;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label44.Location = new System.Drawing.Point(210, 165);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(52, 14);
            this.label44.TabIndex = 52;
            this.label44.Text = "城市：";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label48.Location = new System.Drawing.Point(272, 53);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(125, 12);
            this.label48.TabIndex = 51;
            this.label48.Text = "网址：www.ems.com.cn";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label47.Location = new System.Drawing.Point(137, 53);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(137, 12);
            this.label47.TabIndex = 50;
            this.label47.Text = "客服电话：0750-3789990";
            // 
            // ems_time
            // 
            this.ems_time.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_time.Location = new System.Drawing.Point(59, 53);
            this.ems_time.Name = "ems_time";
            this.ems_time.Size = new System.Drawing.Size(75, 12);
            this.ems_time.TabIndex = 49;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label46.Location = new System.Drawing.Point(1, 52);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(65, 12);
            this.label46.TabIndex = 48;
            this.label46.Text = "订单时间：";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label45.Location = new System.Drawing.Point(13, 13);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(138, 27);
            this.label45.TabIndex = 47;
            this.label45.Text = "EMS国际件";
            // 
            // ems_in_address
            // 
            this.ems_in_address.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_in_address.Location = new System.Drawing.Point(79, 210);
            this.ems_in_address.Name = "ems_in_address";
            this.ems_in_address.Size = new System.Drawing.Size(304, 30);
            this.ems_in_address.TabIndex = 41;
            // 
            // ems_in_tel
            // 
            this.ems_in_tel.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_in_tel.Location = new System.Drawing.Point(79, 186);
            this.ems_in_tel.Name = "ems_in_tel";
            this.ems_in_tel.Size = new System.Drawing.Size(126, 20);
            this.ems_in_tel.TabIndex = 40;
            // 
            // ems_in_name
            // 
            this.ems_in_name.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ems_in_name.Location = new System.Drawing.Point(76, 164);
            this.ems_in_name.Name = "ems_in_name";
            this.ems_in_name.Size = new System.Drawing.Size(118, 13);
            this.ems_in_name.TabIndex = 39;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label40.Location = new System.Drawing.Point(2, 208);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(52, 14);
            this.label40.TabIndex = 12;
            this.label40.Text = "地址：";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label41.Location = new System.Drawing.Point(2, 186);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(52, 14);
            this.label41.TabIndex = 11;
            this.label41.Text = "电话：";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label42.Location = new System.Drawing.Point(3, 164);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(67, 14);
            this.label42.TabIndex = 10;
            this.label42.Text = "收件人：";
            // 
            // ems_bc1
            // 
            this.ems_bc1.AddOnCaption = null;
            this.ems_bc1.AddOnData = null;
            this.ems_bc1.BackColor = System.Drawing.Color.White;
            this.ems_bc1.BarcodeType = Cobainsoft.Windows.Forms.BarcodeType.CODE39;
            this.ems_bc1.CopyRight = "";
            this.ems_bc1.Data = "000000";
            this.ems_bc1.Font = new System.Drawing.Font("Arial", 9F);
            this.ems_bc1.ForeColor = System.Drawing.Color.Black;
            this.ems_bc1.HorizontalAlignment = Cobainsoft.Windows.Forms.BarcodeHorizontalAlignment.Center;
            this.ems_bc1.InvalidDataAction = Cobainsoft.Windows.Forms.InvalidDataAction.DisplayInvalid;
            this.ems_bc1.Location = new System.Drawing.Point(147, 10);
            this.ems_bc1.LowerTopTextBy = 0F;
            this.ems_bc1.Name = "ems_bc1";
            this.ems_bc1.RaiseBottomTextBy = 0F;
            this.ems_bc1.Size = new System.Drawing.Size(244, 40);
            this.ems_bc1.TabIndex = 5;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape10,
            this.lineShape9,
            this.lineShape8,
            this.lineShape7,
            this.lineShape11,
            this.lineShape12});
            this.shapeContainer2.Size = new System.Drawing.Size(398, 598);
            this.shapeContainer2.TabIndex = 45;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape10
            // 
            this.lineShape10.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape10.Name = "lineShape10";
            this.lineShape10.X1 = 0;
            this.lineShape10.X2 = 396;
            this.lineShape10.Y1 = 392;
            this.lineShape10.Y2 = 392;
            // 
            // lineShape9
            // 
            this.lineShape9.Name = "lineShape9";
            this.lineShape9.X1 = -1;
            this.lineShape9.X2 = 399;
            this.lineShape9.Y1 = 526;
            this.lineShape9.Y2 = 526;
            // 
            // lineShape8
            // 
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = -1;
            this.lineShape8.X2 = 399;
            this.lineShape8.Y1 = 466;
            this.lineShape8.Y2 = 466;
            // 
            // lineShape7
            // 
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 1;
            this.lineShape7.X2 = 397;
            this.lineShape7.Y1 = 157;
            this.lineShape7.Y2 = 157;
            // 
            // lineShape11
            // 
            this.lineShape11.Name = "lineShape2";
            this.lineShape11.X1 = 0;
            this.lineShape11.X2 = 396;
            this.lineShape11.Y1 = 71;
            this.lineShape11.Y2 = 71;
            // 
            // lineShape12
            // 
            this.lineShape12.Name = "lineShape1";
            this.lineShape12.X1 = 0;
            this.lineShape12.X2 = 400;
            this.lineShape12.Y1 = 269;
            this.lineShape12.Y2 = 269;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // ex
            // 
            this.ex.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ex.ForeColor = System.Drawing.Color.Red;
            this.ex.Location = new System.Drawing.Point(148, 41);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(700, 51);
            this.ex.TabIndex = 2;
            this.ex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(730, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 44);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.ouya);
            this.panel.Location = new System.Drawing.Point(312, 95);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(400, 600);
            this.panel.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(796, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // defaultprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.EMS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.OMS_NO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "defaultprint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 北极星称重客户端";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.defaultprint_KeyPress);
            this.ouya.ResumeLayout(false);
            this.ouya.PerformLayout();
            this.zhongtong.ResumeLayout(false);
            this.zhongtong.PerformLayout();
            this.jingji.ResumeLayout(false);
            this.jingji.PerformLayout();
            this.zhonghua.ResumeLayout(false);
            this.zhonghua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zhonghua_bc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhonghua_bc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhonghua_logo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jingji_bc4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jingji_bc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jingji_bc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jingji_bc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jingji_erq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jingji_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jingji_logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhongtong_bc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhongtong_bc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhongtong_logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhongtong_logo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouya_bc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouya_bc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouya_brq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouya_logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouya_logo1)).EndInit();
            this.EMS.ResumeLayout(false);
            this.EMS.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox OMS_NO;
        private Panel ouya;
        private PictureBox ouya_logo1;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label11;
        private ListBox ouya_list1;
        private Label label10;
        private Label label9;
        private Label label8;
        private PictureBox ouya_brq1;
        private PictureBox ouya_logo2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lable2;
        private Label label1;
        private Label lable1;
        private PrintDocument printDocument1;
        private Label ouya_city;
        private Label ouya_in_name;
        private Label ouya_in_address;
        private Label ouya_in_tel;
        private Label ouya_out_address;
        private Label ouya_out_tel;
        private Label ouya_out_name;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private PageSetupDialog pageSetupDialog1;
        private Label ex;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private LineShape lineShape2;
        private LineShape lineShape1;
        private LineShape lineShape3;
        private LineShape lineShape4;
        private LineShape lineShape6;
        private LineShape lineShape5;
        private Label label18;
        private Button button1;
        private Panel EMS;
        private Label label45;
        private Label ems_in_address;
        private Label ems_in_tel;
        private Label ems_in_name;
        private Label ems_in_city;
        private Label label40;
        private Label label41;
        private Label label42;
        private BarcodeControl ems_bc1;
        private ShapeContainer shapeContainer2;
        private LineShape lineShape11;
        private LineShape lineShape12;
        private Label ems_remarks_no;
        private Label ems_remarks;
        private BarcodeControl ems_bc2;
        private Label ems_in_address1;
        private Label label55;
        private Label ems_in_tel1;
        private Label label57;
        private Label ems_in_name1;
        private Label label59;
        private Label ems_out_address1;
        private Label label53;
        private Label ems_actual_weight2;
        private Label label43;
        private Label ems_out_name1;
        private Label label38;
        private Label label37;
        private ListBox ems_list1;
        private Label ems_insured_value;
        private Label label35;
        private Label ems_actual_weight1;
        private Label label33;
        private Label ems_out_address;
        private Label label31;
        private Label ems_out_tel;
        private Label label29;
        private Label ems_out_name;
        private Label label27;
        private Label label20;
        private Label label19;
        private Label ems_in_postcode;
        private Label label49;
        private Label label44;
        private Label label48;
        private Label label47;
        private Label ems_time;
        private Label label46;
        private LineShape lineShape10;
        private LineShape lineShape9;
        private LineShape lineShape8;
        private LineShape lineShape7;
        private Panel zhongtong;
        private Label label84;
        private Label zhongtong_out_tel1;
        private Label zhongtong_out_name1;
        private Label label87;
        private Label label89;
        private Label label90;
        private Label zhongtong_out_address1;
        private Label label92;
        private Label zhongtong_in_tel1;
        private Label zhongtong_in_name1;
        private Label label95;
        private Label label96;
        private Label label97;
        private Label label98;
        private Label label99;
        private Label zhongtong_in_address1;
        private Label label74;
        private Label zhongtong_out_tel;
        private Label zhongtong_out_name;
        private Label label80;
        private Label label81;
        private Label label82;
        private Label zhongtong_out_address;
        private Label label73;
        private Label zhongtong_in_tel;
        private Label zhongtong_in_name;
        private Label label70;
        private Label lable5;
        private Label label68;
        private Label label65;
        private Label 收件;
        private Label zhongtong_in_xian;
        private Label zhongtong_in_diqu;
        private Label label62;
        private Label zhongtong_in_address;
        private ListBox zhongtong_list1;
        private Label label77;
        private Label label78;
        private Label label79;
        private PictureBox zhongtong_logo2;
        private PictureBox zhongtong_logo1;
        private ShapeContainer shapeContainer3;
        private LineShape lineShape20;
        private LineShape lineShape19;
        private LineShape lineShape15;
        private LineShape lineShape13;
        private LineShape lineShape14;
        private LineShape lineShape16;
        private LineShape lineShape17;
        private LineShape lineShape18;
        private LineShape lineShape25;
        private LineShape lineShape24;
        private LineShape lineShape23;
        private LineShape lineShape22;
        private Panel zhonghua;
        private PictureBox zhonghua_logo1;
        private Label label117;
        private Label label116;
        private Label label112;
        private Label label111;
        private Label label113;
        private Label label110;
        private Label label114;
        private Label label109;
        private Label label115;
        private Label label108;
        private Label label107;
        private Label zhonghua_in_tel;
        private Label zhonghua_in_name;
        private Label zhonghua_out_name;
        private Label label103;
        private Label label102;
        private Label label101;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Label zhonghua_weight;
        private Label zhonghua_count;
        private Panel panel;
        private Label zhongtong_time;
        private Label label2;
        private Label zhonghua_person_items;
        private Label zhonghua_in_address;
        private PictureBox pictureBox1;
        private Panel jingji;
        private ListBox jingji_list1;
        private Label jingji_info;
        private Label label32;
        private Label label30;
        private Label label28;
        private Label label26;
        private Label jingji_money;
        private Label label25;
        private Label jingji_weight;
        private Label label24;
        private Label jingji_money_type;
        private Label label23;
        private Label jingji_in_address1;
        private Label jingji_in_tel2;
        private Label jingji_in_tel1;
        private Label jingji_in_name;
        private Label label22;
        private Label jingji_out_address1;
        private Label jingji_out_tel1;
        private Label jingji_city;
        private Label jingji_out_name1;
        private Label label21;
        private Label jingji_in_address2;
        private Label label60;
        private Label jingji_out_address2;
        private Label jingji_out_tel2;
        private Label jingji_out_name2;
        private Label label58;
        private Label label51;
        private Label label50;
        private Label label39;
        private PictureBox jingji_logo2;
        private Label jingji_logo1;
        private PictureBox jingji_logo;
        private ShapeContainer shapeContainer4;
        private LineShape lineShape39;
        private LineShape lineShape38;
        private LineShape lineShape37;
        private LineShape lineShape36;
        private LineShape lineShape34;
        private LineShape lineShape33;
        private LineShape lineShape32;
        private LineShape lineShape31;
        private LineShape lineShape30;
        private LineShape lineShape29;
        private LineShape lineShape28;
        private LineShape lineShape27;
        private LineShape lineShape26;
        private LineShape lineShape21;
        private LineShape lineShape_bottom;
        private LineShape lineShape_right;
        private LineShape lineShape_left;
        private LineShape lineShape_top;
        private PictureBox jingji_erq1;
        private Label label52;
        private PictureBox jingji_bc1;
        private PictureBox jingji_bc2;
        private PictureBox jingji_bc3;
        private PictureBox jingji_bc4;
        private Label jingji_weight1;
        private Label jingji_quantity;
        private PictureBox zhongtong_bc3;
        private PictureBox zhongtong_bc2;
        private Label zhongtong_bc1;
        private PictureBox zhonghua_bc2;
        private PictureBox zhonghua_bc1;
        private PictureBox ouya_bc2;
        private PictureBox ouya_bc1;
        private Label label34;
        private Label label36;
        private Label jingji_in_tel3;
        private Label jingji_in_name2;
        private Label jingji_bc1_value;
        private Label jingji_bc2_value;
        private Label jingji_bc3_value;
        private Label jingji_bc4_value;
        private Label zhonghua_bc2_value;
        private Label zhonghua_bc1_value;
        private Label zhongtong_bc3_value;
        private Label zhongtong_bc2_value;
        private Label ouya_bc2_value;
        private Label ouya_bc1_value;

        
    }
}