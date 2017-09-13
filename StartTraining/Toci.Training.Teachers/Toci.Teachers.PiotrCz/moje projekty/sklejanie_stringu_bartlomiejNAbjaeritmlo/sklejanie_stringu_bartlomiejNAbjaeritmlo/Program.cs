using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklejanie_stringu_bartlomiejNAbjaeritmlo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "bartlomiej";
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
            }

            
            Console.ReadLine();
        }

        public static string Front(string candidate)

            {
                string result = "";
                for (int i = 0; i < candidate.Length; i++)
                {
                    if (candidate.Length == 1)
                    {
                        result = result + candidate[i];
                    }
                    return result;
                }

                public static string Back(string candidate)

                    {
                        for (int j = candidate.Length - 1; j >= 0; j--)
                        {
                            result = result + candidate[j];
                        }
                        return result;
                    }
                }
            }
        }
    }


    

    

