

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using 称重客户端New;

namespace 称重客户端New
{
  public partial class Setting : Form
  {
    
   
    public Setting()
    {
      this.InitializeComponent();
      this.Load += new EventHandler(this.SetUp_Load);
    }

   

    private void SetUp_Load(object sender, EventArgs e)
    {
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(Environment.CurrentDirectory + "//config.xml");
        foreach (XmlElement childNode in xmlDocument.SelectSingleNode("function").ChildNodes)
        {
          if (childNode.Name == "com")
            this.textBox1.Text = childNode.GetAttribute("PortName");
          if (childNode.Name == "URL")
            this.textBox2.Text = childNode.GetAttribute("url");
        }
        xmlDocument.Save(Environment.CurrentDirectory + "//config.xml");
      }
      catch
      {
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(Environment.CurrentDirectory + "//config.xml");
        foreach (XmlElement childNode in xmlDocument.SelectSingleNode("function").ChildNodes)
        {
          if (childNode.Name == "com")
            childNode.SetAttribute("PortName", this.textBox1.Text);
          if (childNode.Name == "URL")
          {
            childNode.SetAttribute("url", this.textBox2.Text);
            login.URL = childNode.GetAttribute("url");
          }
        }
        xmlDocument.Save(Environment.CurrentDirectory + "//config.xml");
        int num = (int) MessageBox.Show("修改成功！");
        this.Close();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("修改失败：" + ex.Message);
      }
    }
  }
}
