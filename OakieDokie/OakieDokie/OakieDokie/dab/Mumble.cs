using System.Diagnostics;
using System.IO;
using System.Net;

namespace OakieDokie.dab
{
    public class Mumble : InstallBase
    {
        protected override void SetNames()
        {
            DirectoryName = "Mumble";
            FileName = "mumble.msi";
            FileDwnlName = "mumble.toci.msi";
        }
    }
}