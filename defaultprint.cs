

using BarcodeLib;
using Cobainsoft.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using Newtonsoft.Json;
using SpeechLib;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using ThoughtWorks.QRCode.Codec;

namespace 称重客户端New
{
  public partial class defaultprint : Form
  {
    private string TOKEN = "";
    private string ID = "";
    private string URL = "";
    private int TYPE = 0;
    private string tips = "";
    private string voice = "";
    private defaultprint.myDelegate mydelegate = (defaultprint.myDelegate) null;
    private Font printFont7 = new Font("Arial", 7f);
    private Font printFont8 = new Font("Arial", 8f);
    private Font printFont8_bold = new Font("Arial", 8f, FontStyle.Bold);
    private Font printFont9_bold = new Font("Arial", 9f, FontStyle.Bold);
    private Font printFont9 = new Font("Arial", 9f);
    private Font printFont10 = new Font("Arial", 10f);
    private Font printFont11 = new Font("Arial", 11f);
    private Font printFont15 = new Font("Arial", 15f);
    private Font printFont11_bold = new Font("Arial", 11f, FontStyle.Bold);
    private Font printFont18 = new Font("Arial", 18f, FontStyle.Bold);
    private Pen Dash_pen = new Pen(Color.Black)
    {
      DashStyle = DashStyle.Dash,
      DashPattern = new float[2]{ 10f, 10f }
    };
    private Pen Solid_pan = new Pen(Color.Black)
    {
      DashStyle = DashStyle.Solid
    };
    private StringFormat stringformat_center = new StringFormat()
    {
      Alignment = StringAlignment.Center
    };
    private StringFormat stringformat_left = new StringFormat()
    {
      Alignment = StringAlignment.Near
    };
    private Brush brush = Brushes.Black;
    private string list_info = "";
    private string barcode_value1 = "";
    private string barcode_value2 = "";
    private int print_type_value = 0;
   
    private TextReader streamToPrint;
    private SpVoice spVoice;

    public defaultprint(int type)
    {
      this.InitializeComponent();
      this.URL = userdata.URL;
      this.TOKEN = userdata.TOKEN;
      this.ID = userdata.ID;
      this.TYPE = type;
      this.Load += new EventHandler(this.defaultprint_Load);
      this.FormClosed += new FormClosedEventHandler(this.defaultprint_FormClosed);
    }

    public defaultprint(string token, string id, string url, int type)
    {
      this.URL = url;
      this.TOKEN = token;
      this.ID = id;
      this.TYPE = type;
      this.InitializeComponent();
      this.Load += new EventHandler(this.defaultprint_Load);
      this.FormClosed += new FormClosedEventHandler(this.defaultprint_FormClosed);
    }

    

    private void defaultprint_FormClosed(object sender, FormClosedEventArgs e)
    {
    }

    private void defaultprint_Load(object sender, EventArgs e)
    {
      switch (this.TYPE)
      {
        case 0:
          this.Text = "首次打印";
          break;
        case 1:
          this.Text = "重复打印";
          break;
      }
      this.ouya.Visible = false;
      this.spVoice = (SpVoice) new SpVoiceClass();
      this.ouya.Parent = (Control) this.panel;
      this.EMS.Parent = (Control) this.panel;
      this.zhongtong.Parent = (Control) this.panel;
      this.zhonghua.Parent = (Control) this.panel;
      this.jingji.Parent = (Control) this.panel;
    }

    private void OMS_NO_TextChanged(object sender, EventArgs e)
    {
      if (this.OMS_NO.Text.Trim().Length >= 0)
        return;
      this.OMS_NO.Text = "请输入或扫描EAX OMS订单号";
    }

    private void ErQ(string txt, PictureBox pic)
    {
      QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
      qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
      qrCodeEncoder.QRCodeScale = 2;
      qrCodeEncoder.QRCodeVersion = 8;
      qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
      string content = txt;
      pic.Image = (Image) qrCodeEncoder.Encode(content);
      this.Invalidate();
    }

    private void ErQ1(string txt, PictureBox pic)
    {
      QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
      qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
      qrCodeEncoder.QRCodeScale = 2;
      qrCodeEncoder.QRCodeVersion = 4;
      qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
      string content = txt;
      pic.Image = (Image) qrCodeEncoder.Encode(content);
      this.Invalidate();
    }

    private void defaultprint_KeyPress(object Sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      try
      {
        this.ouya_logo2.Image = (Image) null;
        this.ouya_list1.Items.Clear();
        this.ouya_city.Text = "";
        this.ouya_in_name.Text = "";
        this.ouya_in_tel.Text = "";
        this.ouya_in_address.Text = "";
        this.ouya_out_name.Text = "";
        this.ouya_out_tel.Text = "";
        this.ouya_out_address.Text = "";
        this.panel.Visible = false;
      }
      catch (Exception ex)
      {
      }
      e.Handled = true;
      try
      {
        this.OMS_NO.Focus();
      }
      catch (Exception ex)
      {
      }
      if (this.OMS_NO.Text.Trim().Length > 0)
      {
        string str1 = this.OMS_NO.Text.Trim();
        string str2 = "";
        string end;
        try
        {
          HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(this.URL + "batch/print_order_label");
          httpWebRequest.Timeout = 10000;
          ASCIIEncoding asciiEncoding = new ASCIIEncoding();
          string s = string.Format("order_number={0}&batch_id={1}&is_repate={2}", (object) str1, (object) this.ID, (object) this.TYPE);
          byte[] bytes = asciiEncoding.GetBytes(s);
          httpWebRequest.Method = "POST";
          httpWebRequest.Headers.Set("access-token", this.TOKEN);
          httpWebRequest.ContentType = "application/x-www-form-urlencoded";
          httpWebRequest.ContentLength = (long) s.Length;
          Stream requestStream = httpWebRequest.GetRequestStream();
          requestStream.Write(bytes, 0, bytes.Length);
          requestStream.Close();
          HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
          end = new StreamReader(response.GetResponseStream()).ReadToEnd();
          response.Close();
        }
        catch (Exception ex)
        {
          this.ex.Text = "获取数据失败";
          new Thread(new ParameterizedThreadStart(this.MyTest))
          {
            IsBackground = true
          }.Start((object) "获取数据失败");
          return;
        }
        try
        {
          foreach (XmlNode childNode in JsonConvert.DeserializeXmlNode(end, "ROOT").SelectSingleNode("ROOT").ChildNodes)
          {
            if (childNode.Name.Equals("status_id"))
              str2 = childNode.InnerText;
            else if (childNode.Name.Equals("tips"))
              this.tips = childNode.InnerText;
            else if (childNode.Name.Equals("voice"))
              this.voice = childNode.InnerText;
          }
        }
        catch (Exception ex)
        {
          this.ex.Text = "获取数据失败";
          new Thread(new ParameterizedThreadStart(this.MyTest))
          {
            IsBackground = true
          }.Start((object) "获取数据失败");
          return;
        }
        switch (str2)
        {
          case "0":
            this.OMS_NO.SelectAll();
            break;
          case "1":
            this.OMS_NO.SelectAll();
            this.ex.Text = "";
            this.voice = "";
            try
            {
              this.panel.Visible = true;
              int num = 1;
              string str3 = "";
              string str4 = "";
              string str5 = "";
              string txt1 = "";
              string txt2 = "";
              string str6 = "";
              string str7 = "";
              string str8 = "";
              string str9 = "";
              string str10 = "";
              string str11 = "";
              string str12 = "";
              string str13 = "";
              string str14 = "";
              string str15 = "";
              string str16 = "";
              string str17 = "";
              string str18 = "";
              string str19 = "";
              string str20 = "";
              string str21 = "";
              ListBox listBox1 = new ListBox();
              ListBox listBox2 = new ListBox();
              Image image1 = (Image) null;
              Image image2 = (Image) null;
              foreach (XmlNode childNode1 in JsonConvert.DeserializeXmlNode(end, "ROOT1", true).SelectSingleNode("ROOT1").ChildNodes)
              {
                if (childNode1.Name.Equals("data"))
                {
                  foreach (XmlNode childNode2 in childNode1.ChildNodes)
                  {
                    if (childNode2.Name.Equals("addressee_city"))
                      str5 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("addressee_district"))
                      str16 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("quantity"))
                      str14 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("addressee_province"))
                      str15 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("actual_weight"))
                      str11 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("insured_value"))
                      str13 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("tempate_format_id"))
                      num = Convert.ToInt32(childNode2.InnerXml);
                    else if (childNode2.Name.Equals("created_datetime"))
                      str12 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("addressee_postcode"))
                      str10 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("order_number"))
                      txt1 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("addressee"))
                      str9 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("addressee_tel"))
                      str7 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("addressee_address"))
                      str4 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("sender"))
                      str8 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("sender_tel"))
                      str6 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("sender_address"))
                      str3 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("express_no"))
                      txt2 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("global_name"))
                      str17 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("global_number"))
                      str18 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("payment_method"))
                      str20 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("personal_items"))
                      str19 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("ems_type_id"))
                      str21 = childNode2.InnerXml;
                    else if (childNode2.Name.Equals("items"))
                    {
                      string str22 = "";
                      string str23 = "";
                      string str24 = "";
                      foreach (XmlNode childNode3 in childNode2.ChildNodes)
                      {
                        if (childNode3.Name.Equals("product_name"))
                          str22 = childNode3.InnerText;
                        else if (childNode3.Name.Equals("quantity"))
                          str23 = childNode3.InnerText;
                        else if (childNode3.Name.Equals("total_weight"))
                          str24 = childNode3.InnerText;
                      }
                      listBox1.Items.Add((object) string.Format("商品名称：{0}; 数量：{1}; 重量：{2}", (object) str22, (object) str23, (object) str24));
                      listBox2.Items.Add((object) string.Format("{0}; (数量：{1})", (object) str22, (object) str23));
                    }
                    else if (childNode2.Name.Equals("express_company"))
                    {
                      try
                      {
                        image1 = Image.FromStream(WebRequest.Create(childNode2.InnerXml).GetResponse().GetResponseStream());
                      }
                      catch (Exception ex)
                      {
                        image1 = Image.FromFile("logo.gif");
                      }
                    }
                    else if (childNode2.Name.Equals("print_label_logo"))
                    {
                      try
                      {
                        image2 = Image.FromStream(WebRequest.Create(childNode2.InnerXml).GetResponse().GetResponseStream());
                      }
                      catch (Exception ex)
                      {
                         
                         MessageBox.Show(ex.Message);
                        image2 = Image.FromFile("logo.gif");
                      }
                    }
                  }
                }
              }
              this.barcode_value1 = txt1;
              this.barcode_value2 = txt2;
              this.print_type_value = num;
              switch (num)
              {
                case 1:
                  try
                  {
                    this.ouya_list1.Items.Clear();
                  }
                  catch (Exception ex)
                  {
                  }
                  this.ouya.Visible = true;
                  this.zhonghua.Visible = false;
                  this.zhongtong.Visible = false;
                  this.ouya.BringToFront();
                  this.jingji.SendToBack();
                  this.jingji.Visible = false;
                  this.zhonghua.SendToBack();
                  this.zhongtong.SendToBack();
                  this.ouya.Show();
                  this.BarCode128(txt1, this.ouya_bc1);
                  this.ouya_bc1_value.Text = txt1;
                  this.BarCode128(txt2, this.ouya_bc2);
                  this.ouya_bc2_value.Text = txt2;
                  this.ouya_city.Text = str5;
                  this.ErQ1(txt1, this.ouya_brq1);
                  this.ouya_in_address.Text = str4;
                  this.ouya_in_name.Text = str9;
                  this.ouya_in_tel.Text = str7;
                  for (int index = 0; index <= listBox1.Items.Count - 1; ++index)
                  {
                    this.ouya_list1.Items.Add(listBox1.Items[index]);
                    this.ouya_list1.Items.Add((object) "   ");
                    defaultprint defaultprint = this;
                    string str22 = defaultprint.list_info + listBox1.Items[index].ToString() + "\n";
                    defaultprint.list_info = str22;
                  }
                  this.ouya_logo1.Image = image1;
                  this.ouya_logo2.Image = image2;
                  this.ouya_out_address.Text = str3;
                  this.ouya_out_name.Text = str8;
                  this.ouya_out_tel.Text = str6;
                  break;
                case 2:
                  try
                  {
                    this.jingji_list1.Items.Clear();
                  }
                  catch (Exception ex)
                  {
                  }
                  this.ouya.Visible = false;
                  this.zhonghua.Visible = false;
                  this.zhongtong.Visible = false;
                  this.zhonghua.SendToBack();
                  this.jingji.Visible = true;
                  this.ouya.SendToBack();
                  this.zhongtong.SendToBack();
                  this.jingji.BringToFront();
                  this.jingji.Show();
                  this.BarCode128(txt2, this.jingji_bc1);
                  this.BarCode128(txt1, this.jingji_bc2);
                  this.BarCode128(txt2, this.jingji_bc3);
                  this.BarCode128(txt1, this.jingji_bc4);
                  this.jingji_bc1_value.Text = txt2;
                  this.jingji_bc2_value.Text = txt1;
                  this.jingji_bc3_value.Text = txt2;
                  this.jingji_bc4_value.Text = txt1;
                  this.ErQ(txt2, this.jingji_erq1);
                  this.jingji_city.Text = str16;
                  this.jingji_in_address1.Text = str4;
                  this.jingji_in_address2.Text = str4;
                  this.jingji_in_name.Text = str9;
                  this.jingji_in_name2.Text = str9;
                  this.jingji_in_tel1.Text = str7;
                  this.jingji_in_tel2.Text = "";
                  this.jingji_in_tel3.Text = str7;
                  for (int index = 0; index <= listBox1.Items.Count - 1; ++index)
                  {
                    this.jingji_list1.Items.Add(listBox2.Items[index]);
                    this.jingji_list1.Items.Add((object) "   ");
                    defaultprint defaultprint = this;
                    string str22 = defaultprint.list_info + listBox2.Items[index].ToString() + "\n";
                    defaultprint.list_info = str22;
                  }
                  switch (str21)
                  {
                    case "2":
                      this.jingji_logo1.Text = "经济快递";
                      break;
                    case "1":
                      this.jingji_logo1.Text = "标准快递";
                      break;
                  }
                  this.jingji_out_address1.Text = str3;
                  this.jingji_out_address2.Text = str3;
                  this.jingji_out_name1.Text = str8;
                  this.jingji_out_name2.Text = str8;
                  this.jingji_out_tel1.Text = str6;
                  this.jingji_out_tel2.Text = str6;
                  this.jingji_weight.Text = str11.Replace("/0", "");
                  this.jingji_weight1.Text = "重量(KG):" + str11.Replace("/0", "");
                  this.jingji_quantity.Text = "件数:" + str14;
                  this.jingji_money.Text = str13;
                  break;
                case 3:
                  try
                  {
                    this.zhongtong_list1.Items.Clear();
                  }
                  catch (Exception ex)
                  {
                  }
                  this.ouya.Visible = false;
                  this.zhonghua.Visible = false;
                  this.zhongtong.Visible = true;
                  this.jingji.SendToBack();
                  this.jingji.Visible = false;
                  this.ouya.SendToBack();
                  this.zhonghua.SendToBack();
                  this.zhongtong.BringToFront();
                  this.zhongtong.Show();
                  this.zhongtong_bc1.Text = txt1;
                  this.BarCode128(txt2, this.zhongtong_bc2);
                  this.zhongtong_bc2_value.Text = txt2;
                  this.BarCode128(txt2, this.zhongtong_bc3);
                  this.zhongtong_bc3_value.Text = txt2;
                  this.zhongtong_in_address.Text = str4;
                  this.zhongtong_in_address1.Text = str4;
                  this.zhongtong_in_diqu.Text = str15;
                  this.zhongtong_in_name.Text = str9;
                  this.zhongtong_in_name1.Text = str9;
                  this.zhongtong_in_tel.Text = str7;
                  this.zhongtong_in_tel1.Text = str7;
                  this.zhongtong_in_xian.Text = str16;
                  for (int index = 0; index <= listBox1.Items.Count - 1; ++index)
                  {
                    this.zhongtong_list1.Items.Add(listBox1.Items[index]);
                    this.zhongtong_list1.Items.Add((object) "   ");
                    defaultprint defaultprint = this;
                    string str22 = defaultprint.list_info + listBox1.Items[index].ToString() + "\n";
                    defaultprint.list_info = str22;
                  }
                  this.zhongtong_out_address.Text = str3;
                  this.zhongtong_out_address1.Text = str3;
                  this.zhongtong_out_name.Text = str8;
                  this.zhongtong_out_name1.Text = str8;
                  this.zhongtong_out_tel.Text = str6;
                  this.zhongtong_out_tel1.Text = str6;
                  this.zhongtong_time.Text = str12;
                  break;
                case 4:
                  this.ouya.Visible = false;
                  this.zhonghua.Visible = true;
                  this.zhongtong.Visible = false;
                  this.jingji.SendToBack();
                  this.jingji.Visible = false;
                  this.ouya.SendToBack();
                  this.zhongtong.SendToBack();
                  this.zhonghua.BringToFront();
                  this.zhonghua.Show();
                  this.BarCode128(txt2, this.zhonghua_bc1);
                  this.BarCode128(txt1, this.zhonghua_bc2);
                  this.zhonghua_bc1_value.Text = txt2;
                  this.zhonghua_bc2_value.Text = txt1;
                  this.zhonghua_count.Text = str14;
                  this.zhonghua_in_name.Text = str9;
                  this.zhonghua_in_tel.Text = str7;
                  this.zhonghua_out_name.Text = str8;
                  this.zhonghua_weight.Text = str11.Replace("/0", "KG");
                  this.zhonghua_person_items.Text = str19;
                  this.zhonghua_in_address.Text = str4;
                  break;
              }
            }
            catch (Exception ex)
            {
            }
            try
            {
              this.printDialog1.Document = this.printDocument1;
              this.printDocument1.Print();
              break;
            }
            catch (Exception ex)
            {
              break;
            }
          case "-2":
            this.ex.Text = this.tips;
            this.OMS_NO.SelectAll();
            break;
          case "-3":
            this.ex.Text = this.tips;
            this.OMS_NO.SelectAll();
            break;
          case "-4":
            this.ex.Text = this.tips;
            this.OMS_NO.SelectAll();
            break;
          case "-5":
            this.ex.Text = this.tips;
            this.OMS_NO.SelectAll();
            break;
          case "-6":
            this.ex.Text = this.tips;
            this.OMS_NO.SelectAll();
            break;
          case "-7":
            this.ex.Text = this.tips;
            this.OMS_NO.SelectAll();
            break;
          default:
            this.OMS_NO.SelectAll();
            break;
        }
        new Thread(new ParameterizedThreadStart(this.MyTest))
        {
          IsBackground = true
        }.Start((object) this.voice);
      }
      else
      {
        this.ex.Text = "订单号不能为空";
        new Thread(new ParameterizedThreadStart(this.MyTest))
        {
          IsBackground = true
        }.Start((object) "订单号不能为空");
      }
    }

    public void MyTest(object spkstr)
    {
      try
      {
        this.spVoice.Speak(spkstr.ToString(), SpeechVoiceSpeakFlags.SVSFDefault);
      }
      catch (Exception ex)
      {
      }
    }

    public void MyEvent()
    {
      this.BeginInvoke((Delegate) this.mydelegate);
    }

    public void print_ouya(Graphics g)
    {
      g.DrawLine(this.Solid_pan, new Point(0, 60), new Point(400, 60));
      g.DrawLine(this.Solid_pan, new Point(0, 144), new Point(400, 144));
      g.DrawLine(this.Solid_pan, new Point(0, 214), new Point(400, 214));
      g.DrawLine(this.Solid_pan, new Point(0, 288), new Point(400, 288));
      g.DrawLine(this.Solid_pan, new Point(0, 351), new Point(400, 351));
      g.DrawLine(this.Solid_pan, new Point(45, 60), new Point(45, 214));
      g.DrawImage(this.ouya_logo1.Image, new Rectangle(12, 13, 100, 35));
      g.DrawImage(this.ouya_bc1.Image, new Rectangle(118, 7, 270, 40));
      g.DrawString(this.ouya_bc1_value.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(116, 48, 270, 12), this.stringformat_center);
      g.DrawString("收件人", this.printFont8, this.brush, (RectangleF) new Rectangle(5, 74, 27, 56), this.stringformat_center);
      g.DrawString("发件人", this.printFont8, this.brush, (RectangleF) new Rectangle(5, 154, 27, 56), this.stringformat_center);
      g.DrawString("姓名：" + this.ouya_in_name.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(58, 70, 240, 12), this.stringformat_left);
      g.DrawString("电话：" + this.ouya_in_tel.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(58, 86, 240, 12), this.stringformat_left);
      g.DrawString("地址：" + this.ouya_in_address.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(58, 103, 240, 30), this.stringformat_left);
      g.DrawString(this.ouya_city.Text, this.printFont15, this.brush, (RectangleF) new Rectangle(308, 72, 80, 54), this.stringformat_center);
      g.DrawString("姓名：" + this.ouya_out_name.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(58, 155, 140, 12), this.stringformat_left);
      g.DrawString("电话：" + this.ouya_out_tel.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(211, 155, 140, 12), this.stringformat_left);
      g.DrawString("地址：" + this.ouya_out_address.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(58, 172, 200, 30), this.stringformat_left);
      g.DrawImage(this.ouya_logo2.Image, new Rectangle(12, 232, 100, 35));
      g.DrawImage(this.ouya_bc2.Image, new Rectangle(116, 222, 200, 50));
      g.DrawString(this.ouya_bc2_value.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(116, 274, 200, 12), this.stringformat_center);
      g.DrawImage(this.ouya_brq1.Image, new Rectangle(321, 219, 73, 67));
      g.DrawString(this.label8.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(13, 297, 245, 15), this.stringformat_left);
      g.DrawString(this.label18.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(13, 322, 185, 15), this.stringformat_left);
      g.DrawString("签收：", this.printFont11, this.brush, (RectangleF) new Rectangle(253, 302, 69, 20), this.stringformat_left);
      g.DrawString("明细：", this.printFont8, this.brush, (RectangleF) new Rectangle(13, 361, 45, 14), this.stringformat_left);
      g.DrawString(this.list_info, this.printFont8, this.brush, (RectangleF) new Rectangle(60, 361, 328, 84), this.stringformat_left);
      g.DrawString(this.label11.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(19, 453, 197, 14), this.stringformat_left);
      g.DrawRectangle(this.Solid_pan, new Rectangle(19, 478, 15, 15));
      g.DrawRectangle(this.Solid_pan, new Rectangle(19, 498, 15, 15));
      g.DrawString(this.label12.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(38, 478, 200, 12), this.stringformat_left);
      g.DrawString(this.label13.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(38, 498, 200, 12), this.stringformat_left);
      g.DrawString(this.label14.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(19, 527, 350, 12), this.stringformat_left);
      g.DrawString(this.label15.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(19, 543, 350, 12), this.stringformat_left);
      g.DrawString(this.label16.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(19, 564, 350, 12), this.stringformat_left);
      g.DrawString(this.label17.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(19, 579, 350, 12), this.stringformat_left);
    }

    public void print_zhongtong(Graphics g)
    {
      g.DrawLine(this.Solid_pan, new Point(0, 57), new Point(400, 57));
      g.DrawLine(this.Solid_pan, new Point(0, 93), new Point(400, 93));
      g.DrawLine(this.Solid_pan, new Point(0, 119), new Point(400, 119));
      g.DrawLine(this.Solid_pan, new Point(0, 182), new Point(400, 182));
      g.DrawLine(this.Solid_pan, new Point(0, 243), new Point(400, 243));
      g.DrawLine(this.Solid_pan, new Point(0, 295), new Point(400, 295));
      g.DrawLine(this.Solid_pan, new Point(0, 337), new Point(400, 337));
      g.DrawLine(this.Solid_pan, new Point(0, 395), new Point(400, 395));
      g.DrawLine(this.Solid_pan, new Point(0, 453), new Point(400, 453));
      g.DrawLine(this.Solid_pan, new Point(0, 510), new Point(400, 510));
      g.DrawLine(this.Solid_pan, new Point(29, 119), new Point(29, 243));
      g.DrawLine(this.Solid_pan, new Point(29, 395), new Point(29, 510));
      g.DrawImage(this.zhongtong_logo1.Image, new Rectangle(7, 8, 100, 33));
      g.DrawString(this.zhongtong_bc1.Text, this.printFont15, this.brush, (RectangleF) new Rectangle(121, 8, 270, 45), this.stringformat_center);
      g.DrawString(this.zhongtong_in_diqu.Text, this.printFont11, this.brush, (RectangleF) new Rectangle(66, 63, 262, 25), this.stringformat_center);
      g.DrawString(this.zhongtong_in_xian.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(31, 99, 177, 147), this.stringformat_center);
      g.DrawString(this.zhongtong_time.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(254, 99, 80, 12), this.stringformat_center);
      g.DrawString("收件", this.printFont8, this.brush, (RectangleF) new Rectangle(8, 141, 15, 27), this.stringformat_center);
      g.DrawString("寄件", this.printFont8, this.brush, (RectangleF) new Rectangle(8, 197, 15, 27), this.stringformat_center);
      g.DrawString("姓名：" + this.zhongtong_in_name.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(32, 126, 140, 14), this.stringformat_left);
      g.DrawString("电话：" + this.zhongtong_in_tel.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(199, 126, 140, 14), this.stringformat_left);
      g.DrawString("地址：" + this.zhongtong_in_address.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(32, 146, 350, 30), this.stringformat_left);
      g.DrawString("发件人：" + this.zhongtong_out_name.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(32, 188, 140, 14), this.stringformat_left);
      g.DrawString("电话：" + this.zhongtong_out_tel.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(199, 188, 140, 14), this.stringformat_left);
      g.DrawString("地址：" + this.zhongtong_out_address.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(32, 208, 350, 30), this.stringformat_left);
      g.DrawImage(this.zhongtong_bc2.Image, new Rectangle(65, 247, 270, 32));
      g.DrawString(this.zhongtong_bc2_value.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(65, 282, 270, 12), this.stringformat_center);
      g.DrawString(this.label79.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(22, 299, 234, 14), this.stringformat_left);
      g.DrawString(this.label62.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(22, 319, 234, 14), this.stringformat_left);
      g.DrawString(this.label78.Text, this.printFont11, this.brush, (RectangleF) new Rectangle(262, 304, 69, 20), this.stringformat_center);
      g.DrawImage(this.zhongtong_logo2.Image, new Rectangle(7, 349, 100, 33));
      g.DrawImage(this.zhongtong_bc3.Image, new Rectangle(117, 344, 270, 38));
      g.DrawString(this.zhongtong_bc3_value.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(117, 383, 270, 12), this.stringformat_center);
      g.DrawString("收件", this.printFont8, this.brush, (RectangleF) new Rectangle(8, 407, 15, 27), this.stringformat_center);
      g.DrawString("寄件", this.printFont8, this.brush, (RectangleF) new Rectangle(8, 461, 15, 27), this.stringformat_center);
      g.DrawString("姓名：" + this.zhongtong_in_name1.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(32, 401, 140, 14), this.stringformat_left);
      g.DrawString("电话：" + this.zhongtong_in_tel1.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(199, 401, 140, 14), this.stringformat_left);
      g.DrawString("地址：" + this.zhongtong_in_address1.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(32, 418, 350, 30), this.stringformat_left);
      g.DrawString("发件人：" + this.zhongtong_out_name1.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(32, 459, 140, 14), this.stringformat_left);
      g.DrawString("电话：" + this.zhongtong_out_tel1.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(199, 459, 140, 14), this.stringformat_left);
      g.DrawString("地址：" + this.zhongtong_out_address1.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(32, 475, 350, 30), this.stringformat_left);
      g.DrawString("明细：：", this.printFont8, this.brush, (RectangleF) new Rectangle(6, 517, 41, 12), this.stringformat_left);
      g.DrawString(this.list_info, this.printFont8, this.brush, (RectangleF) new Rectangle(53, 517, 331, 72), this.stringformat_left);
    }

    public void print_zhonghua(Graphics g)
    {
      g.DrawImage(this.zhonghua_logo1.Image, new Rectangle(6, 35, 108, 43));
      g.DrawString(this.label2.Text, this.printFont11_bold, this.brush, (RectangleF) new Rectangle(167, 10, 170, 23), this.stringformat_center);
      g.DrawImage(this.zhonghua_bc1.Image, new Rectangle(121, 34, 270, 50));
      g.DrawString(this.zhonghua_bc1_value.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(121, 85, 270, 11), this.stringformat_center);
      g.DrawString("寄件人：" + this.zhonghua_out_name.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(30, 137, 250, 14), this.stringformat_left);
      g.DrawString("收件人：" + this.zhonghua_in_name.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(30, 164, 250, 14), this.stringformat_left);
      g.DrawString("电话：" + this.zhonghua_in_tel.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(30, 191, 250, 14), this.stringformat_left);
      g.DrawString(this.zhonghua_in_address.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(30, 212, 337, 35), this.stringformat_left);
      g.DrawImage(this.zhonghua_bc2.Image, new Rectangle(80, 253, 270, 50));
      g.DrawString(this.zhonghua_bc2_value.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(80, 303, 270, 11), this.stringformat_center);
      g.DrawString("件数：" + this.zhonghua_count.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(30, 318, 100, 14), this.stringformat_left);
      g.DrawString("重量：" + this.zhonghua_weight.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(30, 342, 100, 14), this.stringformat_left);
      g.DrawString("内装物品：" + this.zhonghua_person_items.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(30, 365, 100, 14), this.stringformat_left);
      g.DrawString(this.label110.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(30, 386, 250, 14), this.stringformat_left);
      g.DrawRectangle(this.Solid_pan, new Rectangle(30, 409, 15, 15));
      g.DrawString(this.label116.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(48, 409, 250, 14), this.stringformat_left);
      g.DrawRectangle(this.Solid_pan, new Rectangle(30, 429, 15, 15));
      g.DrawString(this.label116.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(48, 429, 29, 14), this.stringformat_left);
      g.DrawString(this.label115.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(30, 451, 350, 14), this.stringformat_left);
      g.DrawString(this.label114.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(30, 470, 250, 14), this.stringformat_left);
      g.DrawString(this.label117.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(30, 488, 250, 14), this.stringformat_left);
      g.DrawString(this.label113.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(30, 510, 257, 14), this.stringformat_left);
      g.DrawString(this.label112.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(30, 530, 257, 14), this.stringformat_left);
    }

    public Graphics print_ems(Graphics g)
    {
      g.DrawLine(this.Dash_pen, new Point(7, 7), new Point(393, 7));
      g.DrawLine(this.Dash_pen, new Point(7, 7), new Point(7, 593));
      g.DrawLine(this.Dash_pen, new Point(393, 7), new Point(393, 593));
      g.DrawLine(this.Dash_pen, new Point(7, 593), new Point(393, 593));
      g.DrawLine(this.Dash_pen, new Point(134, 7), new Point(134, 89));
      g.DrawLine(this.Dash_pen, new Point(7, 89), new Point(393, 89));
      g.DrawLine(this.Dash_pen, new Point(203, 89), new Point(203, 148));
      g.DrawLine(this.Dash_pen, new Point(7, 149), new Point(393, 149));
      g.DrawLine(this.Dash_pen, new Point(7, 215), new Point(393, 215));
      g.DrawLine(this.Dash_pen, new Point(166, 215), new Point(166, 270));
      g.DrawLine(this.Dash_pen, new Point(7, 270), new Point(393, 270));
      g.DrawLine(this.Dash_pen, new Point(7, 352), new Point(393, 352));
      g.DrawLine(this.Dash_pen, new Point(7, 362), new Point(393, 362));
      g.DrawLine(this.Dash_pen, new Point(7, 420), new Point(393, 420));
      g.DrawLine(this.Dash_pen, new Point(165, 420), new Point(165, 486));
      g.DrawLine(this.Dash_pen, new Point(7, 486), new Point(393, 486));
      g.DrawLine(this.Dash_pen, new Point(7, 567), new Point(287, 567));
      g.DrawLine(this.Dash_pen, new Point(287, 486), new Point(287, 593));
      g.DrawImage(this.jingji_bc1.Image, new Rectangle(140, 14, 250, 54));
      g.DrawString(this.barcode_value2, this.printFont8, this.brush, (RectangleF) new Rectangle(140, 70, 250, 17), this.stringformat_center);
      g.DrawImage(this.jingji_bc2.Image, new Rectangle(13, 275, 270, 26));
      g.DrawString(this.barcode_value1, this.printFont8, this.brush, (RectangleF) new Rectangle(66, 302, 215, 11), this.stringformat_center);
      g.DrawImage(this.jingji_bc3.Image, new Rectangle(13, 366, 270, 42));
      g.DrawString(this.barcode_value2, this.printFont8, this.brush, (RectangleF) new Rectangle(13, 408, 268, 11), this.stringformat_center);
      g.DrawImage(this.jingji_bc4.Image, new Rectangle(13, 517, 270, 36));
      g.DrawString(this.barcode_value1, this.printFont8, this.brush, (RectangleF) new Rectangle(13, 555, 271, 11), this.stringformat_center);
      g.DrawImage(this.jingji_logo2.Image, new Rectangle(280, 368, 110, 40));
      g.DrawImage(this.jingji_erq1.Image, new Rectangle(290, 491, 100, 99));
      g.DrawString(this.jingji_logo1.Text, this.printFont18, this.brush, (RectangleF) new Rectangle(8, 35, 126, 54), this.stringformat_center);
      g.DrawString("寄件：", this.printFont8, this.brush, (RectangleF) new Rectangle(9, 93, 42, 14), this.stringformat_center);
      g.DrawString(this.jingji_out_name1.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(50, 92, 140, 15), this.stringformat_left);
      g.DrawString(this.jingji_out_tel1.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(50, 105, 140, 15), this.stringformat_left);
      g.DrawString(this.jingji_out_address1.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(10, 118, 192, 30), this.stringformat_left);
      g.DrawString(this.jingji_city.Text, this.printFont18, this.brush, (RectangleF) new Rectangle(207, 105, 126, 58), this.stringformat_center);
      g.DrawString("收件：", this.printFont8, this.brush, (RectangleF) new Rectangle(9, 152, 42, 14), this.stringformat_left);
      g.DrawString(this.jingji_in_name.Text, this.printFont9_bold, this.brush, (RectangleF) new Rectangle(50, 154, 140, 16), this.stringformat_left);
      g.DrawString(this.jingji_in_tel1.Text + this.jingji_in_tel2.Text, this.printFont9_bold, this.brush, (RectangleF) new Rectangle(200, 154, 140, 16), this.stringformat_center);
      g.DrawString(this.jingji_in_address1.Text, this.printFont9_bold, this.brush, (RectangleF) new Rectangle(50, 177, 339, 38), this.stringformat_center);
      g.DrawString("付款方式：", this.printFont8, this.brush, (RectangleF) new Rectangle(9, 218, 67, 15), this.stringformat_center);
      g.DrawString("计费重量(KG)：" + this.jingji_weight.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(9, 235, 160, 14), this.stringformat_left);
      g.DrawString("保价金额(元)：" + this.jingji_money.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(9, 251, 160, 14), this.stringformat_left);
      g.DrawString("收件人\\代收人：", this.printFont8, this.brush, (RectangleF) new Rectangle(170, 218, 95, 12), this.stringformat_center);
      g.DrawString("签收时间      年   月   日   时", this.printFont8, this.brush, (RectangleF) new Rectangle(170, 232, 191, 12), this.stringformat_left);
      g.DrawString("快件送达收件人地址经收件人或收件人允许的代收人签字视为送达", this.printFont8, this.brush, (RectangleF) new Rectangle(170, 245, 216, 24), this.stringformat_left);
      g.DrawString(this.jingji_weight1.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(286, 275, 106, 15), this.stringformat_center);
      g.DrawString(this.jingji_quantity.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(286, 295, 106, 15), this.stringformat_center);
      g.DrawString("订单号：", this.printFont8, this.brush, (RectangleF) new Rectangle(9, 301, 60, 14), this.stringformat_left);
      g.DrawString("配送信息：" + this.list_info, this.printFont8, this.brush, (RectangleF) new Rectangle(9, 314, 395, 36), this.stringformat_left);
      g.DrawString("寄件：" + this.jingji_out_name2.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(9, 423, 150, 12), this.stringformat_center);
      g.DrawString(this.jingji_out_tel2.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(50, 441, 80, 14), this.stringformat_left);
      g.DrawString(this.jingji_out_address2.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(9, 459, 148, 24), this.stringformat_left);
      g.DrawString("收件：" + this.jingji_in_name2.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(169, 423, 120, 12), this.stringformat_left);
      g.DrawString(this.jingji_in_tel3.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(169, 441, 120, 12), this.stringformat_left);
      g.DrawString(this.jingji_in_address2.Text, this.printFont8, this.brush, (RectangleF) new Rectangle(169, 459, 200, 24), this.stringformat_left);
      g.DrawString("备注：收货前请确认包装是否完整，有无破损。如有问题，请拒绝签收", this.printFont8, this.brush, (RectangleF) new Rectangle(9, 491, 266, 28), this.stringformat_left);
      g.DrawString("网址: www.ems.com.cn", this.printFont8, this.brush, (RectangleF) new Rectangle(9, 573, 125, 12), this.stringformat_left);
      g.DrawString("客服电话 :11183", this.printFont8, this.brush, (RectangleF) new Rectangle(173, 573, 95, 12), this.stringformat_left);
      return g;
    }

    private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
    {
      switch (this.print_type_value)
      {
        case 1:
          this.print_ouya(e.Graphics);
          break;
        case 2:
          this.print_ems(e.Graphics);
          break;
        case 3:
          this.print_zhongtong(e.Graphics);
          break;
        case 4:
          this.print_zhonghua(e.Graphics);
          break;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.mydelegate = new defaultprint.myDelegate(this.MyTest2);
      new Thread(new ThreadStart(this.MyEvent))
      {
        IsBackground = true
      }.Start();
    }

    public void MyTest2()
    {
      new printmail(this.TOKEN, this.URL).Show();
      this.Close();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      int num = (int) new PrintDialog()
      {
        Document = this.printDocument1
      }.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.BarCode128("990000019096", this.jingji_bc1);
      this.BarCode128("NL160308000015", this.jingji_bc2);
      this.BarCode128("NL160308000015", this.jingji_bc3);
      this.BarCode128("990000019096", this.jingji_bc4);
    }

    public void BarCode128(string txt, PictureBox pic)
    {
      BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
      int int32_1 = Convert.ToInt32(pic.Width);
      int int32_2 = Convert.ToInt32(pic.Height);
      barcode.Alignment = AlignmentPositions.CENTER;
      pic.Image = barcode.Encode(BarcodeLib.TYPE.CODE128, txt, Color.Black, Color.White, int32_1, int32_2);
    }

    private delegate void myDelegate();

    private void printPreviewDialog1_Load(object sender, EventArgs e)
    {

    }

   

  }
}
