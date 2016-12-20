

using Newtonsoft.Json;
using SpeechLib;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace 称重客户端New
{
  public partial class Form1 : Form
  {
    private string ck1value = "0";
    private string ck2value = "0";
    private string ck3value = "0";
    private bool isshow = true;
    private int no = 1;
    private bool isopen = false;
    private bool auto = true;
    private Hashtable hashtable = new Hashtable();
    private DataTable date = new DataTable();
    private Form1.myDelegate mydelegate = (Form1.myDelegate) null;
    private float paintX = 0.0f;
   
    private string ID;
    private string URL;
    private string TOKEN;
    private string rmk;
    private SpVoice spVoice;
    private string mailnumble;
    private string mailweight;
    private SerialPort _serialPort1;
    

    public string PortName { get; set; }

    public int BaudRate { get; set; }

    public int ReceivedBytesThreshold { get; set; }

    public int DataBits { get; set; }

    public int Parity { get; set; }

    public string Mailnumble
    {
      get
      {
        return this.mailnumble;
      }
      set
      {
        this.mailnumble = value;
      }
    }

    public string Mailweight
    {
      get
      {
        return this.mailweight;
      }
      set
      {
        this.mailweight = value;
      }
    }

    public string tips { get; set; }

    public string voice { get; set; }

    public Form1()
    {
    }

    public Form1(string rmk)
    {
      this.InitializeComponent();
      this.Load += new EventHandler(this.Form1_Load);
      this.FormClosed += new FormClosedEventHandler(this.Form1_FormClosed);
      this.ID = userdata.ID;
      this.URL = userdata.URL;
      this.TOKEN = userdata.TOKEN;
      this.rmk = rmk;
      this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.isshow)
      {
        if (MessageBox.Show("确定要退出吗?", "退出系统", MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
          this.post_data(this.URL + "batch/logout/", string.Format("batchID={0}", (object) this.ID));
          Environment.Exit(0);
        }
        else
          e.Cancel = true;
      }
      e.Cancel = true;
    }

    public bool getcom()
    {
      bool flag;
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(Environment.CurrentDirectory + "//config.xml");
        XmlNodeList childNodes = xmlDocument.SelectSingleNode("function").ChildNodes;
        XmlNodeList xmlNodeList = (XmlNodeList) null;
        foreach (XmlElement xmlElement in childNodes)
        {
          if (xmlElement.Name == "com")
          {
            xmlNodeList = xmlElement.ChildNodes;
            this.PortName = xmlElement.GetAttribute("PortName");
            this.ReceivedBytesThreshold = Convert.ToInt32(xmlElement.GetAttribute("ReceivedBytesThreshold"));
            this.BaudRate = Convert.ToInt32(xmlElement.GetAttribute("BaudRate"));
            this.DataBits = Convert.ToInt32(xmlElement.GetAttribute("DataBits"));
            this.Parity = Convert.ToInt32(xmlElement.GetAttribute("Parity"));
          }
        }
        xmlDocument.Save(Environment.CurrentDirectory + "//config.xml");
        flag = true;
      }
      catch (Exception ex)
      {
        flag = false;
      }
      return flag;
    }

    public bool setport()
    {
      bool flag;
      try
      {
        this._serialPort1.PortName = this.PortName;
        this._serialPort1.ReceivedBytesThreshold = this.ReceivedBytesThreshold;
        this._serialPort1.BaudRate = this.BaudRate;
        this._serialPort1.DataBits = this.DataBits;
        this._serialPort1.Parity = System.IO.Ports.Parity.None;
        if (!this._serialPort1.IsOpen)
          this._serialPort1.Open();
        flag = true;
      }
      catch (Exception ex)
      {
        flag = false;
      }
      return flag;
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      this.timer1.Stop();
      Environment.Exit(0);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      if (!this.getcom())
      {
        int num = (int) MessageBox.Show("端口配置文件读取错误,请修改后重启软件");
      }
      this.tx2.ReadOnly = true;
      this.ec1.Visible = false;
      this.spVoice = (SpVoice) new SpVoiceClass();
      this.dt1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dt1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.timer1.Start();
    }

    private void _serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      if (!this.isopen)
        return;
      if (!this.auto)
        return;
      try
      {
        byte[] numArray = new byte[this._serialPort1.ReadBufferSize + 1];
        int count = this._serialPort1.Read(numArray, 0, this._serialPort1.ReadBufferSize);
        string SerialIn = Encoding.ASCII.GetString(numArray, 0, count);

        this.Invoke(new MethodInvoker(() => 
            {
          if (!SerialIn.StartsWith("wn") || SerialIn.IndexOf("kg") == -1)
            return;
          if (!SerialIn.Substring(SerialIn.IndexOf("wn"), SerialIn.IndexOf("kg") - 2).Equals(this.tx2.Text))
          {
            try
            {
              this.tx2.Text = Convert.ToDouble(SerialIn.Replace("wn", "").Replace("kg", "")).ToString();
            }
            catch (Exception ex)
            {
              this.tx2.Text = "0";
            }
          }
          else
          {
            this._serialPort1.DiscardOutBuffer();
            this._serialPort1.DiscardInBuffer();
          }
        }));
            
            
         
         /*
          this.Invoke((Delegate) (() =>
        {
          if (!SerialIn.StartsWith("wn") || SerialIn.IndexOf("kg") == -1)
            return;
          if (!SerialIn.Substring(SerialIn.IndexOf("wn"), SerialIn.IndexOf("kg") - 2).Equals(this.tx2.Text))
          {
            try
            {
              this.tx2.Text = Convert.ToDouble(SerialIn.Replace("wn", "").Replace("kg", "")).ToString();
            }
            catch (Exception ex)
            {
              this.tx2.Text = "0";
            }
          }
          else
          {
            this._serialPort1.DiscardOutBuffer();
            this._serialPort1.DiscardInBuffer();
          }
        })); */
      }
      catch (TimeoutException ex)
      {
        this._serialPort1.DiscardOutBuffer();
        this._serialPort1.DiscardInBuffer();
      }
    }

    private void tx1_TextChanged(object sender, EventArgs e)
    {
      this.Mailnumble = this.tx1.Text.Trim();
    }

    private void tx2_TextChanged(object sender, EventArgs e)
    {
      this.Mailweight = this.tx2.Text.Trim();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (this.auto)
      {
        this.tx2.ReadOnly = false;
        this.auto = false;
      }
      else
      {
        this.tx2.ReadOnly = true;
        this.auto = true;
      }
    }

    private void start_Click(object sender, EventArgs e)
    {
      try
      {
        if (!this.setport())
        {
          this.ex.Text = this._serialPort1.PortName + "端口被占用或者不存在";
          new Thread(new ParameterizedThreadStart(this.MyTest))
          {
            IsBackground = true
          }.Start((object) (this._serialPort1.PortName + "端口被占用或者不存在"));
        }
        else
        {
          this._serialPort1.DataReceived += new SerialDataReceivedEventHandler(this._serialPort1_DataReceived);
          this.start.Enabled = false;
          this.stop.Enabled = true;
          this.ec1.Visible = true;
          this.isopen = true;
        }
      }
      catch (Exception ex)
      {
        this.ex.Text = this._serialPort1.PortName + "端口被占用或者不存在";
        new Thread(new ParameterizedThreadStart(this.MyTest))
        {
          IsBackground = true
        }.Start((object) (this._serialPort1.PortName + "端口被占用或者不存在"));
      }
    }

    private void stop_Click(object sender, EventArgs e)
    {
      try
      {
        this.isopen = false;
        Application.DoEvents();
        this.ec1.Visible = false;
        this._serialPort1.BreakState = true;
        this._serialPort1.DataReceived -= new SerialDataReceivedEventHandler(this._serialPort1_DataReceived);
        this._serialPort1.Close();
        this.start.Enabled = true;
        this.stop.Enabled = false;
      }
      catch (Exception ex)
      {
        this.isopen = false;
        this.start.Enabled = true;
        this.stop.Enabled = false;
      }
      this.tx2.Text = "0";
    }

    private void clear_Click(object sender, EventArgs e)
    {
      try
      {
        this.Quanty.Text = "0";
        this.TotalWt.Text = "0";
        this.dt1.DataSource = (object) null;
        this.dt1.Rows.Clear();
        this.hashtable.Clear();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("清除失败");
      }
    }

    private void outexcle_Click(object sender, EventArgs e)
    {
      try
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.FileName = this.dt.Value.ToString("yyyy-MM-dd");
        saveFileDialog.Filter = "Miscrosoft Office Excel 97-2003 工作表|*.xls|所有文件(*.*)|*.*";
        saveFileDialog.RestoreDirectory = true;
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
          return;
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(this.URL + "batch/excel/" + this.dt.Value.ToString("yyyy-MM-dd"));
        ASCIIEncoding asciiEncoding = new ASCIIEncoding();
        httpWebRequest.Method = "GET";
        httpWebRequest.Headers.Set("access-token", this.TOKEN);
        httpWebRequest.ContentType = "application/x-www-form-urlencoded";
        using (Stream responseStream = httpWebRequest.GetResponse().GetResponseStream())
        {
          using (FileStream fileStream = System.IO.File.Create(saveFileDialog.FileName))
          {
            byte[] buffer = new byte[102400];
            int count = 1;
            while (count > 0)
            {
              count = responseStream.Read(buffer, 0, 10240);
              fileStream.Write(buffer, 0, count);
            }
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("导出文件时出错,文件可能正被打开!", "系统信息");
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

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
      using (new Pen(Color.Green))
      {
        Rectangle rect = new Rectangle(0, 0, 20, 20);
        using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, Color.Green, Color.Green, LinearGradientMode.Vertical))
          e.Graphics.FillEllipse((Brush) linearGradientBrush, rect);
      }
    }

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = true;
      this.ex.Text = "";
      try
      {
        this.tx1.Focus();
      }
      catch (Exception ex)
      {
      }
      try
      {
        string str = Convert.ToDouble(this.tx2.Text).ToString();
        this.tx2.Text = str;
        this.Mailweight = str;
      }
      catch (Exception ex)
      {
        this.ex.Text = "重量错误";
        this.tx2.Text = "0";
        new Thread(new ParameterizedThreadStart(this.MyTest))
        {
          IsBackground = true
        }.Start((object) "重量错误");
        return;
      }
      if (this._serialPort1.IsOpen)
      {
        if (this.tx1.Text.Trim().Length > 1)
        {
          string str1 = this.tx1.Text.Trim();
          string str2 = "";
          Exception exception1;
          try
          {
            string url = this.URL + "batch/update_weight";
            string str3 = string.Format("orderNo={0}&weight={1}&batchID={2}&uniqueTEL={3}&uniqueAddress={4}&uniqueIDCard={5}", (object) this.tx1.Text.Trim(), (object) this.tx2.Text.Trim(), (object) this.ID, (object) this.ck1value, (object) this.ck2value, (object) this.ck3value);
            try
            {
              foreach (XmlNode childNode in JsonConvert.DeserializeXmlNode(this.post_data(url, str3), "ROOT").SelectSingleNode("ROOT").ChildNodes)
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
            try
            {
              int count1;
              Exception exception2;
              switch (str2)
              {
                case "1":
                  if (this.hashtable.Contains((object) this.tx1.Text.Trim()))
                  {
                    try
                    {
                      this.hashtable.Remove((object) this.Mailnumble);
                      int count2 = this.dt1.Rows.Count;
                      count1 = this.dt1.Rows[0].Cells.Count;
                      for (int index = 0; index < count2; ++index)
                      {
                        if (this.Mailnumble == this.dt1.Rows[index].Cells[1].Value.ToString().Trim())
                        {
                          this.dt1.Rows[index].Cells[2].Value = (object) this.Mailweight;
                          this.dt1.Rows[index].Cells[3].Value = (object) DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                          break;
                        }
                      }
                    }
                    catch (Exception ex)
                    {
                      exception1 = ex;
                      this.hashtable.Add((object) this.Mailnumble, (object) this.Mailweight);
                      break;
                    }
                  }
                  else
                  {
                    try
                    {
                      int index = this.dt1.Rows.Add(new DataGridViewRow());
                      this.dt1.Rows[index].Cells[0].Value = (object) (index + 1);
                      this.dt1.Rows[index].Cells[1].Value = (object) this.Mailnumble;
                      this.dt1.Rows[index].Cells[2].Value = (object) this.Mailweight;
                      this.dt1.Rows[index].Cells[3].Value = (object) DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                      this.dt1.CurrentCell = this.dt1.Rows[index].Cells[0];
                    }
                    catch (Exception ex)
                    {
                    }
                  }
                  try
                  {
                    this.hashtable.Add((object) this.Mailnumble, (object) this.Mailweight);
                    string str4 = "0";
                    foreach (DictionaryEntry dictionaryEntry in this.hashtable)
                      str4 = (Convert.ToDouble(dictionaryEntry.Value) + Convert.ToDouble(str4)).ToString();
                    this.TotalWt.Text = str4;
                    this.Quanty.Text = this.hashtable.Count.ToString();
                  }
                  catch (Exception ex)
                  {
                    exception2 = ex;
                  }
                  this.voice = this.Mailweight;
                  this.tx1.Text = "";
                  break;
                case "-1":
                  this.ex.Text = this.tips;
                  this.tx1.SelectAll();
                  break;
                case "-2":
                  this.ex.Text = this.tips;
                  this.tx1.SelectAll();
                  break;
                case "-3":
                  this.ex.Text = this.tips;
                  this.tx1.SelectAll();
                  break;
                case "-4":
                  this.ex.Text = this.tips;
                  this.tx1.SelectAll();
                  break;
                case "-5":
                  this.ex.Text = this.tips;
                  this.tx1.SelectAll();
                  break;
                case "-6":
                  this.ex.Text = this.tips;
                  this.tx1.SelectAll();
                  break;
                case "-7":
                  this.ex.Text = this.tips;
                  this.tx1.SelectAll();
                  break;
                case "-8":
                  this.ex.Text = this.tips;
                  this.tx1.SelectAll();
                  break;
                case "-9":
                  this.ex.Text = this.tips;
                  this.tx1.SelectAll();
                  break;
                case "-10":
                  this.ex.Text = this.tips;
                  int count3 = this.dt1.Rows.Count;
                  this.ex.Text = "订单号：" + str1 + "   已经称重,是否再次称重?";
                  new Thread(new ParameterizedThreadStart(this.MyTest))
                  {
                    IsBackground = true
                  }.Start((object) "重复称重");
                  if (MessageBox.Show("订单号：" + str1 + "   已经称重,是否再次称重?", "OMS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                  {
                    this.ex.Text = "";
                    string str4 = string.Format("orderNo={0}&weight={1}&batchID={2}&uniqueTEL={3}&uniqueAddress={4}&uniqueIDCard={5}&overWriteWeight={6}", (object) this.tx1.Text.Trim(), (object) this.tx2.Text.Trim(), (object) this.ID, (object) this.ck1value, (object) this.ck2value, (object) this.ck3value, (object) 1);
                    this.post_data(url, str4);
                    if (this.hashtable.Contains((object) this.tx1.Text.Trim()))
                    {
                      try
                      {
                        this.hashtable.Remove((object) this.Mailnumble);
                        int count2 = this.dt1.Rows.Count;
                        count1 = this.dt1.Rows[0].Cells.Count;
                        for (int index = 0; index < count2; ++index)
                        {
                          if (this.Mailnumble == this.dt1.Rows[index].Cells[1].Value.ToString().Trim())
                          {
                            this.dt1.Rows[index].Cells[2].Value = (object) this.Mailweight;
                            this.dt1.Rows[index].Cells[3].Value = (object) DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            break;
                          }
                        }
                      }
                      catch (Exception ex)
                      {
                        int num = (int) MessageBox.Show(ex.ToString());
                        this.hashtable.Add((object) this.Mailnumble, (object) this.Mailweight);
                        break;
                      }
                    }
                    else
                    {
                      try
                      {
                        int index = this.dt1.Rows.Add(new DataGridViewRow());
                        this.dt1.Rows[index].Cells[0].Value = (object) (index + 1);
                        this.dt1.Rows[index].Cells[1].Value = (object) this.Mailnumble;
                        this.dt1.Rows[index].Cells[2].Value = (object) this.Mailweight;
                        this.dt1.Rows[index].Cells[3].Value = (object) DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        this.dt1.CurrentCell = this.dt1.Rows[index].Cells[0];
                      }
                      catch (Exception ex)
                      {
                      }
                    }
                    try
                    {
                      this.hashtable.Add((object) this.Mailnumble, (object) this.Mailweight);
                      string str5 = "0";
                      foreach (DictionaryEntry dictionaryEntry in this.hashtable)
                        str5 = (Convert.ToDouble(dictionaryEntry.Value) + Convert.ToDouble(str5)).ToString();
                      this.TotalWt.Text = str5;
                      this.Quanty.Text = this.hashtable.Count.ToString();
                    }
                    catch (Exception ex)
                    {
                      exception2 = ex;
                    }
                    this.voice = this.Mailweight;
                    this.tx1.Text = "";
                    this.tx1.SelectAll();
                    break;
                  }
                  this.ex.Text = "";
                  return;
                case "-11":
                  this.ex.Text = this.tips;
                  this.tx1.SelectAll();
                  break;
                case "-12":
                  this.ex.Text = this.tips;
                  this.tx1.SelectAll();
                  break;
                case "-13":
                  this.ex.Text = this.tips;
                  this.tx1.SelectAll();
                  break;
              }
              new Thread(new ParameterizedThreadStart(this.MyTest))
              {
                IsBackground = true
              }.Start((object) this.voice);
            }
            catch (Exception ex)
            {
            }
          }
          catch (Exception ex)
          {
            exception1 = ex;
            this.ex.Text = "通讯错误";
            new Thread(new ParameterizedThreadStart(this.MyTest))
            {
              IsBackground = true
            }.Start((object) "通讯错误");
          }
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
      else
      {
        this.ex.Text = "称重通道没有打开";
        new Thread(new ParameterizedThreadStart(this.MyTest))
        {
          IsBackground = true
        }.Start((object) "称重通道没有打开");
      }
    }

    private void remark_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.DrawString(this.rmk, this.remark.Font, Brushes.Yellow, new PointF(this.paintX, 0.0f));
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.paintX = --this.paintX % (float) this.remark.Width;
      this.remark.Invalidate();
    }

    public string post_data(string url, string value)
    {
      string str = "";
      try
      {
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(url);
        httpWebRequest.Timeout = 10000;
        ASCIIEncoding asciiEncoding = new ASCIIEncoding();
        string s = value;
        byte[] bytes = asciiEncoding.GetBytes(s);
        httpWebRequest.Method = "POST";
        httpWebRequest.Headers.Set("access-token", this.TOKEN);
        httpWebRequest.ContentType = "application/x-www-form-urlencoded";
        httpWebRequest.ContentLength = (long) s.Length;
        Stream requestStream = httpWebRequest.GetRequestStream();
        requestStream.Write(bytes, 0, bytes.Length);
        requestStream.Close();
        HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
        str = new StreamReader(response.GetResponseStream()).ReadToEnd();
        response.Close();
      }
      catch (Exception ex)
      {
        this.ex.Text = "数据提交失败";
        new Thread(new ParameterizedThreadStart(this.MyTest))
        {
          IsBackground = true
        }.Start((object) "数据提交失败");
      }
      return str;
    }

    public void post_data(object obj)
    {
      try
      {
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(this.URL + "batch/setlog/");
        httpWebRequest.Timeout = 10000;
        ASCIIEncoding asciiEncoding = new ASCIIEncoding();
        string s = obj.ToString();
        byte[] bytes = asciiEncoding.GetBytes(s);
        httpWebRequest.Method = "POST";
        httpWebRequest.Headers.Set("access-token", this.TOKEN);
        httpWebRequest.ContentType = "application/x-www-form-urlencoded";
        httpWebRequest.ContentLength = (long) s.Length;
        Stream requestStream = httpWebRequest.GetRequestStream();
        requestStream.Write(bytes, 0, bytes.Length);
        requestStream.Close();
        HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
        new StreamReader(response.GetResponseStream()).ReadToEnd();
        response.Close();
      }
      catch (Exception ex)
      {
        this.ex.Text = "数据提交失败";
        new Thread(new ParameterizedThreadStart(this.MyTest))
        {
          IsBackground = true
        }.Start((object) "数据提交失败");
      }
    }

    private void back_Click_1(object sender, EventArgs e)
    {
      this.isshow = false;
      new Thread((ThreadStart) (() => Application.Run((Form) new Token())))
      {
        ApartmentState = ApartmentState.STA
      }.Start();
      this.Close();
      this.Dispose();
    }

    private void Form1_Activated(object sender, EventArgs e)
    {
      this.tx1.Focus();
    }


    
    private delegate void myDelegate();

    private void Form1_Load_1(object sender, EventArgs e)
    {

    }
  }
}
