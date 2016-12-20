
using System.IO.Ports;

namespace 称重解决方案New
{
  internal class SerialPortHelper
  {
    private static SerialPortHelper _serialporthelper = (SerialPortHelper) null;
    private static SerialPort _serialPort;

    public SerialPortHelper()
    {
      if (SerialPortHelper._serialporthelper != null)
        return;
      SerialPortHelper._serialporthelper = new SerialPortHelper();
      this.SetBPraram();
    }

    private void SetBPraram()
    {
      SerialPortHelper._serialPort = new SerialPort();
      SerialPortHelper._serialPort.BaudRate = 9600;
      SerialPortHelper._serialPort.PortName = "COM1";
      SerialPortHelper._serialPort.DataBits = 8;
      SerialPortHelper._serialPort.Parity = Parity.None;
      SerialPortHelper._serialPort.StopBits = StopBits.One;
      if (SerialPortHelper._serialPort.IsOpen)
        return;
      SerialPortHelper._serialPort.Open();
    }
  }
}
