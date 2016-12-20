namespace 称重客户端New
{
  internal class Listitemdata
  {
    private string id = string.Empty;
    private string batchNumber = string.Empty;
    private string ladingNumber = string.Empty;
    private string datetime = string.Empty;
    private string Remark = string.Empty;

    public string ID
    {
      get
      {
        return this.id;
      }
      set
      {
        this.id = value;
      }
    }

    public string BatchNumber
    {
      get
      {
        return this.batchNumber;
      }
      set
      {
        this.batchNumber = value;
      }
    }

    public string LadingNumber
    {
      get
      {
        return this.ladingNumber;
      }
      set
      {
        this.ladingNumber = value;
      }
    }

    public string DateTime
    {
      get
      {
        return this.datetime;
      }
      set
      {
        this.datetime = value;
      }
    }

    public string RemarkS
    {
      get
      {
        return this.Remark;
      }
      set
      {
        this.Remark = value;
      }
    }

    public Listitemdata()
    {
    }

    public Listitemdata(string sid, string sbatchNumber, string sladingNumber, string sdatetime)
    {
      this.id = sid;
      this.batchNumber = sbatchNumber;
      this.ladingNumber = sladingNumber;
      this.datetime = sdatetime;
    }

    public override string ToString()
    {
      return this.ID;
    }
  }
}
