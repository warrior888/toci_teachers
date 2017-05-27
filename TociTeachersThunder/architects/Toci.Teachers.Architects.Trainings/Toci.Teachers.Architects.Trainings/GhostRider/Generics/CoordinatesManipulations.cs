using System.Collections.Generic;

namespace Toci.Architects.Training.GhostRider.Generics
{
    public class CoordinatesManipulations<TItem, TWhatever>
    {
        public void ModifyCoordinates(int x, int y, TItem item)
        {
            //item.
            Dictionary<string, string> bankNamesMap = new Dictionary<string, string>();

            bankNamesMap.Add("1140", "Mbank");
            bankNamesMap.Add("1060", "Ing");
            // 37x
            if (bankNamesMap.ContainsKey("1060"))
            {
                //bankNamesMap["1060"]
                foreach (var bankMName in bankNamesMap)
                {
                    KeyValuePair<string, string> ss = new KeyValuePair<string, string>();
                    //ss.
                    //bankMName.Value
                }
                //bankNamesMap[""].v

            }

            if ("" == "1140")
            {
                
            }
        }
    }

    public class Test
    {
        public void CoordinatesTest()
        {
            CoordinatesManipulations<Test, int> whatever = new CoordinatesManipulations<Test, int>();
            //CoordinatesManipulations<List<CoordinatesManipulations<string, string>>, int> brainFuck = new CoordinatesManipulations<List<CoordinatesManipulations<string, string>>, int>();
            //CoordinatesManipulations<int> anotherwhatever = new CoordinatesManipulations<int>();
            //anotherwhatever.ModifyCoordinates();
        }
    }
}