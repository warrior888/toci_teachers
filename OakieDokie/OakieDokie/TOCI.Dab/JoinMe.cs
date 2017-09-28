using System.Net;

namespace TOCI.Dab
{
    public class JoinMe : Iinstal
    {
        public Iinstal instal()
        {
            WebClient wc = new WebClient();
            wc.DownloadFile("http://vps458649.ovh.net/join.me.toci.msi", "C:\\xampp\\test.join.me.msi");
            return null;
        }
    }
}