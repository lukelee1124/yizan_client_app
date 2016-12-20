

using Newtonsoft.Json;
using 称重客户端New;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace 称重客户端New
{
  public partial class printmail : Form
  {
    private string TOKEN = "";
    private string URL = "";
    private string id = "0";
    private string tips = "";
    private List<Listitemdata> list = new List<Listitemdata>();
    private int type = 0;
    
    public printmail()
    {
      this.TOKEN = userdata.TOKEN;
      this.URL = userdata.URL;
      this.InitializeComponent();
      this.Load += new EventHandler(this.printmail_Load);
    }

    public printmail(string token, string url)
    {
      this.TOKEN = token;
      this.URL = url;
      this.InitializeComponent();
      this.Load += new EventHandler(this.printmail_Load);
      this.FormClosing += new FormClosingEventHandler(this.printmail_FormClosing);
    }



    

    private void printmail_FormClosing(object sender, FormClosingEventArgs e)
    {
      Environment.Exit(0);
    }

    private void printmail_Load(object sender, EventArgs e)
    {
      try
      {
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(this.URL + "batch/forwad_batch_list");
        ASCIIEncoding asciiEncoding = new ASCIIEncoding();
        httpWebRequest.Method = "POST";
        httpWebRequest.Headers.Set("access-token", this.TOKEN);
        HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
        string end = new StreamReader(response.GetResponseStream()).ReadToEnd();
        response.Close();
        try
        {
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
                  else if (childNode3.Name.Equals("datetime"))
                    listitemdata.DateTime = childNode3.InnerXml;
                  else if (childNode3.Name.Equals("remark"))
                    listitemdata.RemarkS = childNode3.InnerXml;
                }
                this.listbox1.Items.Add((object) ("批次号码： " + listitemdata.BatchNumber + " " + listitemdata.RemarkS));
                try
                {
                  this.listbox1.SelectedIndex = 0;
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

    private void button1_Click(object sender, EventArgs e)
    {
      this.type = 0;
      if (this.listbox1.SelectedIndex <= -1)
        return;
      userdata.ID = this.list[this.listbox1.SelectedIndex].ID;
      string remarkS = this.list[this.listbox1.SelectedIndex].RemarkS;
      int num = (int) new defaultprint(this.type).ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.type = 1;
      if (this.listbox1.SelectedIndex <= -1)
        return;
      userdata.ID = this.list[this.listbox1.SelectedIndex].ID;
      string remarkS = this.list[this.listbox1.SelectedIndex].RemarkS;
      int num = (int) new defaultprint(this.type).ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      int num = (int) new PrintDialog()
      {
        Document = this.printDocument1
      }.ShowDialog();
    }

    private void listbox1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (this.listbox1.SelectedIndex <= -1)
        return;
      userdata.ID = this.list[this.listbox1.SelectedIndex].ID;
      string remarkS = this.list[this.listbox1.SelectedIndex].RemarkS;
      int num = (int) new defaultprint(this.type).ShowDialog();
    }

    private void back_Click(object sender, EventArgs e)
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
