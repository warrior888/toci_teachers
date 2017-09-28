using System;
using System.Collections.Generic;

namespace TOCI.Dab
{
    public static class Factory
    {
        private static Dictionary<whatToInstalEnum, Func<Iinstal>> instalationDictionary = new Dictionary<whatToInstalEnum, Func<Iinstal>>()
        {
            {whatToInstalEnum.JoinMe , () => new JoinMe().instal()},
        };

        /*public static Iinstal CreateProviceValidator(whatToInstalEnum item)
        {
            instalationDictionary[item]();
        }*/
    }
}