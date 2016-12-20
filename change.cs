

using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace 称重客户端New
{
  public partial class change : Form
  {
   
    private string TOKEN = "";
    private string URL = "";
    private string PRINT = "";
    private change.myDelegate mydelegate = (change.myDelegate) null;
    
    private string tips;
    private string id;

    public change(string token, string url, string print)
    {
      this.InitializeComponent();
      this.Load += new EventHandler(this.change_Load);
    }

    public change()
    {
      this.TOKEN = userdata.TOKEN;
      this.URL = userdata.URL;
      this.PRINT = userdata.STATE;
      this.InitializeComponent();
      this.Load += new EventHandler(this.change_Load);
    }

    

    private void change_Load(object sender, EventArgs e)
    {
      if (userdata.STATE.Equals("1"))
        this.button2.Visible = true;
      else
        this.button2.Visible = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.mydelegate = new change.myDelegate(this.MyTest1);
      new Thread(new ThreadStart(this.MyEvent))
      {
        IsBackground = true
      }.Start();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.mydelegate = new change.myDelegate(this.MyTest);
      new Thread(new ThreadStart(this.MyEvent))
      {
        IsBackground = true
      }.Start();
    }

    public void MyTest1()
    {
      new Thread((ThreadStart) (() => Application.Run((Form) new Token())))
      {
        ApartmentState = ApartmentState.STA
      }.Start();
      this.Close();
      this.Dispose();
    }

    public void MyEvent()
    {
      this.BeginInvoke((Delegate) this.mydelegate);
    }

    public void MyTest()
    {
      try
      {
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(this.URL + "batch/check_user_print");
        httpWebRequest.Timeout = 10000;
        ASCIIEncoding asciiEncoding = new ASCIIEncoding();
        string s = string.Format("");
        byte[] bytes = asciiEncoding.GetBytes(s);
        httpWebRequest.Method = "POST";
        httpWebRequest.Headers.Set("access-token", this.TOKEN);
        httpWebRequest.ContentType = "application/x-www-form-urlencoded";
        httpWebRequest.ContentLength = (long) s.Length;
        Stream requestStream = httpWebRequest.GetRequestStream();
        requestStream.Write(bytes, 0, bytes.Length);
        requestStream.Close();
        HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
        string end = new StreamReader(response.GetResponseStream()).ReadToEnd();
        response.Close();
        foreach (XmlNode childNode in JsonConvert.DeserializeXmlNode(end, "ROOT").SelectSingleNode("ROOT").ChildNodes)
        {
          if (childNode.Name.Equals("status_id"))
            this.id = childNode.InnerText;
          else if (childNode.Name.Equals("tips"))
            this.tips = childNode.InnerText;
        }
        switch (this.id)
        {
          case "1":
            new Thread((ThreadStart) (() => Application.Run((Form) new printmail())))
            {
              ApartmentState = ApartmentState.STA
            }.Start();
            this.Close();
            this.Dispose();
            break;
          case "-1":
            int num = (int) MessageBox.Show(this.tips);
            break;
        }
      }
      catch
      {
        int num = (int) MessageBox.Show(this.tips);
      }
    }

    private delegate void myDelegate();
  }
}
