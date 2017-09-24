using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace OakieDokie.dab
{
    public class JoinMe : Iinstal
    {
        public Iinstal instal()
        {
            string path = "c:\\TOCI\\joinme";

            Directory.CreateDirectory(path);
            WebClient wc = new WebClient();
            wc.DownloadFile("http://vps458649.ovh.net/join.me.toci.msi", "c:\\TOCI\\joinme\\join.me.msi");


            Process.Start("c:\\TOCI\\joinme\\join.me.msi");

            return null;
        }
    }
}