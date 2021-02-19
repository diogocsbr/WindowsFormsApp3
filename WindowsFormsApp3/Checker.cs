using System.Net;
using WindowsFormsApp3.Properties;

namespace WindowsFormsApp3
{
    public class Checker
    {
        public static string CheckerUpdater()
        {
            WebClient wc = new WebClient();
            string version_Program = "1.0";
            string Body = wc.DownloadString("https://pastebin.com/raw/fYNM8s4Y");

            if (Body.Contains(version_Program))
            {
                return "true";
            }
            else
            {
                return Body;
            }

        }
        
        public static void UpdaterV()
        {
            if (CheckerUpdater() != "true")
            {
                Alerta alertaNitro = new Alerta();
                alertaNitro.ShowWindowNitroAlert();
            }
        }
    }
}