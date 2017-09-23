using System;
using System.Collections.Generic;

namespace OakieDokie.dab
{
    public class Factory
    {
        private static Dictionary<whatToInstalEnum, Func<Iinstal>> instalationDictionary = new Dictionary<whatToInstalEnum, Func<Iinstal>>()
        {
            {whatToInstalEnum.JoinMe , () => new JoinMe().instal()},
        };
    }
}