

namespace 称重客户端New
{
  internal class userdata
  {
    private static string url;
    private static string token;
    private static string state;
    private static string id;

    public static string URL
    {
      get
      {
        return userdata.url;
      }
      set
      {
        userdata.url = value;
      }
    }

    public static string TOKEN
    {
      get
      {
        return userdata.token;
      }
      set
      {
        userdata.token = value;
      }
    }

    public static string STATE
    {
      get
      {
        return userdata.state;
      }
      set
      {
        userdata.state = value;
      }
    }

    public static string ID
    {
      get
      {
        return userdata.id;
      }
      set
      {
        userdata.id = value;
      }
    }
  }
}
