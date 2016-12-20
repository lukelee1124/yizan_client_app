using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace 称重客户端New
{
    public partial class login : Form
    {
        public static string URL = (string)null;
        private string path = Environment.CurrentDirectory + "//config.xml";
        private string id = "0";
        private string tips = "登录失败";
        private string token = "";
        private string userstring = "";
        private string pwdstring = "";
        private string RememberPwd = "false";
        private login.CryptInfo cryptInfo = new login.CryptInfo();
        private login.DecryptInfo decryptInfo = new login.DecryptInfo();
        private string print = "0";
        private login.myDelegate mydelegate = (login.myDelegate)null;


        public login()
        {
            this.InitializeComponent();
            this.Load += new EventHandler(this.login_Load);
        }

        private void login_Load(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(Environment.CurrentDirectory + "//config.xml");
                foreach (XmlElement childNode in xmlDocument.SelectSingleNode("function").ChildNodes)
                {
                    if (childNode.Name == "URL")
                        login.URL = childNode.GetAttribute("url");
                    else if (childNode.Name == "UserName")
                    {
                        try
                        {
                            this.userstring = this.decryptInfo.GetDecrypte(childNode.InnerText.Trim());
                        }
                        catch (Exception ex)
                        {
                            this.userstring = "";
                        }
                    }
                    else if (childNode.Name == "UserPwd")
                    {
                        try
                        {
                            this.pwdstring = this.decryptInfo.GetDecrypte(childNode.InnerText.Trim());
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    else if (childNode.Name == "RememberPwd")
                        this.RememberPwd = childNode.InnerText;
                }
                xmlDocument.Save(Environment.CurrentDirectory + "//config.xml");
            }
            catch
            {
                int num = (int)MessageBox.Show("初始化配置文件失败");
                Environment.Exit(0);
            }
            if (!this.RememberPwd.Equals("True"))
                return;
            this.user.Text = this.userstring;
            this.pwd.Text = this.pwdstring;
            this.cx1.Checked = true;
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        private void cancle_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void setinfo()
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(Environment.CurrentDirectory + "//config.xml");
                foreach (XmlElement childNode in xmlDocument.SelectSingleNode("function").ChildNodes)
                {
                    if (childNode.Name == "UserName")
                        childNode.InnerText = this.cryptInfo.GetEncrypt(this.user.Text.Trim());
                    else if (childNode.Name == "UserPwd")
                        childNode.InnerText = this.cryptInfo.GetEncrypt(this.pwd.Text.Trim());
                    else if (childNode.Name == "RememberPwd")
                        childNode.InnerText = this.RememberPwd;
                }
                xmlDocument.Save(Environment.CurrentDirectory + "//config.xml");
            }
            catch
            {
            }
        }

        public void MyTest()
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(login.URL + "user/login");
                httpWebRequest.Timeout = 10000;
                ASCIIEncoding asciiEncoding = new ASCIIEncoding();
                string s = string.Format("username={0}&password={1}", (object)this.user.Text.Trim(), (object)this.pwd.Text.Trim());
                byte[] bytes = asciiEncoding.GetBytes(s);
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.ContentLength = (long)s.Length;
                Stream requestStream = httpWebRequest.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                string end = new StreamReader(response.GetResponseStream()).ReadToEnd();
                response.Close();
                foreach (XmlNode childNode in JsonConvert.DeserializeXmlNode(end, "ROOT").SelectSingleNode("ROOT").ChildNodes)
                {
                    if (childNode.Name.Equals("status_id"))
                        this.id = childNode.InnerText;
                    else if (childNode.Name.Equals("tips"))
                        this.tips = childNode.InnerText;
                    else if (childNode.Name.Equals("token"))
                        this.token = childNode.InnerText;
                    else if (childNode.Name.Equals("print"))
                        this.print = childNode.InnerText;
                }
                switch (this.id)
                {
                    case "1":
                        if (this.cx1.Checked)
                        {
                            this.setinfo();
                        }
                        else
                        {
                            this.user.Text = "";
                            this.pwd.Text = "";
                            this.setinfo();
                        }
                        userdata.TOKEN = this.token;
                        userdata.URL = login.URL;
                        userdata.STATE = this.print;

                        new Thread((ThreadStart)(() => Application.Run((Form)new change())))
                        {
                            ApartmentState = ApartmentState.STA
                        }.Start();




                        this.Close();
                        this.Dispose();
                        break;
                    case "-1":
                        int num1 = (int)MessageBox.Show(this.tips);
                        break;
                    case "-2":
                        int num2 = (int)MessageBox.Show(this.tips);
                        break;
                    case "-3":
                        int num3 = (int)MessageBox.Show(this.tips);
                        break;
                    case "-4":
                        int num4 = (int)MessageBox.Show(this.tips);
                        break;
                    case "-5":
                        int num5 = (int)MessageBox.Show(this.tips);
                        break;
                    case "-6":
                        int num6 = (int)MessageBox.Show(this.tips);
                        break;
                    case "0":
                        int num7 = (int)MessageBox.Show(this.tips);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                int num = (int)MessageBox.Show(this.tips);
            }
            this.lg.Enabled = true;
        }

        private void lg_Click(object sender, EventArgs e)
        {
            this.lg.Enabled = false;
            /*this.mydelegate = new login.myDelegate(this.MyTest);
            new Thread(new ThreadStart(this.MyEvent))
            {
                IsBackground = true
            }.Start();*/
            this.MyTest();
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.lg_Click(sender, (EventArgs)e);
        }

        public void MyEvent()
        {
            this.BeginInvoke((Delegate)this.mydelegate);
        }

        private string Encrypt(string text)
        {
            Rijndael rijndael = Rijndael.Create();
            byte[] numArray1 = new byte[32]
      {
        (byte) 166,
        (byte) 125,
        (byte) 225,
        (byte) 63,
        (byte) 53,
        (byte) 14,
        (byte) 225,
        (byte) 169,
        (byte) 131,
        (byte) 165,
        (byte) 98,
        (byte) 170,
        (byte) 122,
        (byte) 174,
        (byte) 121,
        (byte) 152,
        (byte) 167,
        (byte) 51,
        (byte) 73,
        byte.MaxValue,
        (byte) 230,
        (byte) 174,
        (byte) 191,
        (byte) 141,
        (byte) 141,
        (byte) 32,
        (byte) 138,
        (byte) 73,
        (byte) 49,
        (byte) 58,
        (byte) 18,
        (byte) 64
      };
            byte[] numArray2 = new byte[16]
      {
        (byte) 248,
        (byte) 139,
        (byte) 1,
        (byte) 251,
        (byte) 8,
        (byte) 133,
        (byte) 154,
        (byte) 164,
        (byte) 190,
        (byte) 69,
        (byte) 40,
        (byte) 86,
        (byte) 3,
        (byte) 66,
        (byte) 246,
        (byte) 25
      };
            rijndael.Key = numArray1;
            rijndael.IV = numArray2;
            MemoryStream memoryStream = new MemoryStream();
            ICryptoTransform transform = (ICryptoTransform)new ToBase64Transform();
            CryptoStream cryptoStream = new CryptoStream((Stream)new CryptoStream((Stream)memoryStream, transform, CryptoStreamMode.Write), rijndael.CreateEncryptor(), CryptoStreamMode.Write);
            UTF8Encoding utF8Encoding = new UTF8Encoding();
            byte[] bytes = utF8Encoding.GetBytes(text);
            cryptoStream.Write(bytes, 0, bytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] numArray3 = new byte[memoryStream.Length];
            memoryStream.Position = 0L;
            memoryStream.Read(numArray3, 0, (int)memoryStream.Length);
            return utF8Encoding.GetString(numArray3);
        }

        private void cx1_CheckedChanged(object sender, EventArgs e)
        {
            this.RememberPwd = this.cx1.Checked.ToString();
        }

        private void setup_Click(object sender, EventArgs e)
        {
            int num = (int)new Setting().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = (int)new printview().ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num = (int)new printview().ShowDialog();
        }



        private delegate void myDelegate();

        internal class CryptInfo
        {
            public string GetEncrypt(string text)
            {
                return this.Encrypt(text);
            }

            private string Encrypt(string text)
            {
                Rijndael rijndael = Rijndael.Create();
                byte[] numArray1 = new byte[32]
        {
          (byte) 166,
          (byte) 125,
          (byte) 225,
          (byte) 63,
          (byte) 53,
          (byte) 14,
          (byte) 225,
          (byte) 169,
          (byte) 131,
          (byte) 165,
          (byte) 98,
          (byte) 170,
          (byte) 122,
          (byte) 174,
          (byte) 121,
          (byte) 152,
          (byte) 167,
          (byte) 51,
          (byte) 73,
          byte.MaxValue,
          (byte) 230,
          (byte) 174,
          (byte) 191,
          (byte) 141,
          (byte) 141,
          (byte) 32,
          (byte) 138,
          (byte) 73,
          (byte) 49,
          (byte) 58,
          (byte) 18,
          (byte) 64
        };
                byte[] numArray2 = new byte[16]
        {
          (byte) 248,
          (byte) 139,
          (byte) 1,
          (byte) 251,
          (byte) 8,
          (byte) 133,
          (byte) 154,
          (byte) 164,
          (byte) 190,
          (byte) 69,
          (byte) 40,
          (byte) 86,
          (byte) 3,
          (byte) 66,
          (byte) 246,
          (byte) 25
        };
                rijndael.Key = numArray1;
                rijndael.IV = numArray2;
                MemoryStream memoryStream = new MemoryStream();
                ICryptoTransform transform = (ICryptoTransform)new ToBase64Transform();
                CryptoStream cryptoStream = new CryptoStream((Stream)new CryptoStream((Stream)memoryStream, transform, CryptoStreamMode.Write), rijndael.CreateEncryptor(), CryptoStreamMode.Write);
                UTF8Encoding utF8Encoding = new UTF8Encoding();
                byte[] bytes = utF8Encoding.GetBytes(text);
                cryptoStream.Write(bytes, 0, bytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] numArray3 = new byte[memoryStream.Length];
                memoryStream.Position = 0L;
                memoryStream.Read(numArray3, 0, (int)memoryStream.Length);
                return utF8Encoding.GetString(numArray3);
            }
        }

        internal class DecryptInfo
        {
            public string GetDecrypte(string text)
            {
                return this.Decrypt(text);
            }

            private string Decrypt(string text)
            {
                Rijndael rijndael = Rijndael.Create();
                byte[] numArray1 = new byte[32]
        {
          (byte) 166,
          (byte) 125,
          (byte) 225,
          (byte) 63,
          (byte) 53,
          (byte) 14,
          (byte) 225,
          (byte) 169,
          (byte) 131,
          (byte) 165,
          (byte) 98,
          (byte) 170,
          (byte) 122,
          (byte) 174,
          (byte) 121,
          (byte) 152,
          (byte) 167,
          (byte) 51,
          (byte) 73,
          byte.MaxValue,
          (byte) 230,
          (byte) 174,
          (byte) 191,
          (byte) 141,
          (byte) 141,
          (byte) 32,
          (byte) 138,
          (byte) 73,
          (byte) 49,
          (byte) 58,
          (byte) 18,
          (byte) 64
        };
                byte[] numArray2 = new byte[16]
        {
          (byte) 248,
          (byte) 139,
          (byte) 1,
          (byte) 251,
          (byte) 8,
          (byte) 133,
          (byte) 154,
          (byte) 164,
          (byte) 190,
          (byte) 69,
          (byte) 40,
          (byte) 86,
          (byte) 3,
          (byte) 66,
          (byte) 246,
          (byte) 25
        };
                rijndael.Key = numArray1;
                rijndael.IV = numArray2;
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream((Stream)new CryptoStream((Stream)memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write), (ICryptoTransform)new FromBase64Transform(), CryptoStreamMode.Write);
                UTF8Encoding utF8Encoding = new UTF8Encoding();
                byte[] bytes = utF8Encoding.GetBytes(text);
                cryptoStream.Write(bytes, 0, bytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] numArray3 = new byte[memoryStream.Length];
                memoryStream.Position = 0L;
                memoryStream.Read(numArray3, 0, (int)memoryStream.Length);
                return utF8Encoding.GetString(numArray3);
            }
        }
    }
}
