using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace OakieDokie.dab
{
    public class JoinMe : InstallBase
    {
        protected override void SetNames()
        {
            DirectoryName = "JoinMe";
            FileName = "join.me.msi";
            FileDwnlName = "join.me.toci.msi";
        }
    }
}