

using Cobainsoft.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace 称重客户端New
{
  public partial class printview : Form
  {
    
    

    public printview()
    {
      this.InitializeComponent();
      this.BarCode("530305436986");
      this.ErQ("530305436986");
    }


   

    private void BarCode(string txt)
    {
      this.barcodeControl2.BarcodeType = BarcodeType.CODE128A;
      this.barcodeControl2.Data = txt;
      this.barcodeControl2.TextPosition = BarcodeTextPosition.Below;
      this.barcodeControl2.CopyRight = (string) null;
      this.Invalidate();
    }

    private void ErQ(string txt)
    {
      QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
      qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
      qrCodeEncoder.QRCodeScale = 2;
      qrCodeEncoder.QRCodeVersion = 10;
      qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
      string content = txt;
      this.pictureBox1.Image = (Image) qrCodeEncoder.Encode(content);
      this.Invalidate();
    }
  }
}
