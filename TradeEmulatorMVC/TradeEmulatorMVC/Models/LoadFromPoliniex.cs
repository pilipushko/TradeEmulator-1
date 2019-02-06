namespace QuickType
{
    using System.IO;
    using System.Net;
    using System.Text;

    public static class LoadFromPoliniex
    {
        public static void GetStringHtml(string url, string fullnamelocation)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            StreamWriter sw = new StreamWriter(fullnamelocation, false, Encoding.UTF8);
            sw.WriteLine(webClient.DownloadString(url));
            sw.Close();
        }
    }
}
