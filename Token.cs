

using Newtonsoft.Json;
using 称重客户端New;
using System;
using System.Collections.Generic;
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
  public partial class Token : Form
  {
    private string token = "";
    private string URL = "";
    private List<Listitemdata> list = new List<Listitemdata>();
   
    private string id;
    private string tips;
    private XmlNode data;
   

    public Token()
    {
      this.InitializeComponent();
      this.token = userdata.TOKEN;
      this.URL = userdata.URL;
      this.Load += new EventHandler(this.Token_Load);
    }

    public Token(string token, string url)
    {
      this.InitializeComponent();
      this.token = token;
      this.URL = url;
      this.Load += new EventHandler(this.Token_Load);
    }

    private void Token_Load(object sender, EventArgs e)
    {
      try
      {
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(this.URL + "batch/index");
        ASCIIEncoding asciiEncoding = new ASCIIEncoding();
        httpWebRequest.Method = "GET";
        httpWebRequest.Headers.Set("access-token", this.token);
        HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
        string end = new StreamReader(response.GetResponseStream()).ReadToEnd();
        response.Close();
        try
        {
          Console.Out.WriteLine(end.ToString());
          foreach (XmlNode childNode1 in JsonConvert.DeserializeXmlNode(end, "ROOT", true).SelectSingleNode("ROOT").ChildNodes)
          {
            if (childNode1.Name.Equals("status_id"))
              this.id = childNode1.InnerText;
            else if (childNode1.Name.Equals("tips"))
              this.tips = childNode1.InnerText;
            else if (childNode1.Name.Equals("data"))
            {
              foreach (XmlNode childNode2 in childNode1.ChildNodes)
              {
                Listitemdata listitemdata = new Listitemdata();
                List<string> stringList = new List<string>();
                foreach (XmlNode childNode3 in childNode2.ChildNodes)
                {
                  if (childNode3.Name.Equals("id"))
                    listitemdata.ID = childNode3.InnerXml;
                  else if (childNode3.Name.Equals("batchNumber"))
                    listitemdata.BatchNumber = childNode3.InnerXml;
                  else if (childNode3.Name.Equals("ladingNumber"))
                    listitemdata.LadingNumber = childNode3.InnerXml;
                  else if (childNode3.Name.Equals("datetime"))
                    listitemdata.DateTime = childNode3.InnerXml;
                  else if (childNode3.Name.Equals("remark"))
                    listitemdata.RemarkS = childNode3.InnerXml;
                }
                this.lb.Items.Add((object) ("批次号码： " + listitemdata.BatchNumber + " " + listitemdata.RemarkS));
                try
                {
                  this.lb.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                }
                this.list.Add(listitemdata);
              }
            }
          }
        }
        catch (Exception ex)
        {
        }
      }
      catch
      {
      }
    }

    private void cancel_Click(object sender, EventArgs e)
    {
      Environment.Exit(0);
    }

    private void select_Click(object sender, EventArgs e)
    {
      if (this.lb.SelectedIndex <= -1)
        return;
      userdata.ID = this.list[this.lb.SelectedIndex].ID;
      string rmk = this.list[this.lb.SelectedIndex].RemarkS;
      new Thread((ThreadStart) (() => Application.Run((Form) new Form1(rmk))))
      {
        ApartmentState = ApartmentState.STA
      }.Start();
      this.Close();
      this.Dispose();
    }

    private void Token_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.select.Enabled = false;
      this.select_Click(sender, (EventArgs) e);
      this.select.Enabled = true;
    }

    private void lb_DoubleClick(object sender, EventArgs e)
    {
      if (this.lb.SelectedIndex <= -1)
        return;
      userdata.ID = this.list[this.lb.SelectedIndex].ID;
      string rmk = this.list[this.lb.SelectedIndex].RemarkS;
      new Thread((ThreadStart) (() => Application.Run((Form) new Form1(rmk))))
      {
        ApartmentState = ApartmentState.STA
      }.Start();
      this.Close();
      this.Dispose();
    }

    private void back_Click_1(object sender, EventArgs e)
    {
      new Thread((ThreadStart) (() => Application.Run((Form) new change())))
      {
        ApartmentState = ApartmentState.STA
      }.Start();
      this.Close();
      this.Dispose();
    }

   

    
  }
}
