using System;
using System.Collections.Generic;

namespace OakieDokie.dab
{
    public class Factory
    {
        public static Dictionary<whatToInstalEnum, Func<Iinstal>> instalationDictionary = new Dictionary<whatToInstalEnum, Func<Iinstal>>()
        {
            {whatToInstalEnum.JoinMe , () => new JoinMe().instal()},
        };
    }
}