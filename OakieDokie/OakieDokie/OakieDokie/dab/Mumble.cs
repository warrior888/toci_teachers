using System.Diagnostics;
using System.IO;
using System.Net;

namespace OakieDokie.dab
{
    public class Mumble : Iinstal
    {
        public Iinstal instal()
        {
            string path = "c:\\TOCI\\mumble";

            Directory.CreateDirectory(path);
            WebClient wc = new WebClient();
            wc.DownloadFile("http://vps458649.ovh.net/mumble-1.2.19.msi", "c:\\TOCI\\mumble\\mumble-1.2.19.msi");


            Process.Start("c:\\TOCI\\mumble\\mumble-1.2.19.msi");

            return null;
        }
    }
}