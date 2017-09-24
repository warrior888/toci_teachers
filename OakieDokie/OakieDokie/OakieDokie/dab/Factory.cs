using System;
using System.Collections.Generic;

namespace OakieDokie.dab
{
    public class Factory
    {
        public string ChosenPath;

        public void AcceptPath(string path)
        {
            // if not exist create

            ChosenPath = path;
        }

        public Dictionary<whatToInstalEnum, Func<bool>> GetElements()
        {
            InstallBase jm = new JoinMe { TociInstallsDirectory = ChosenPath};
            InstallBase mm = new Mumble { TociInstallsDirectory = ChosenPath};

            return new Dictionary<whatToInstalEnum, Func<bool>>
            {
                {whatToInstalEnum.JoinMe , () => jm.Install()},
                {whatToInstalEnum.Mumble , () => mm.Install()},
            };
        }
    }
}