using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;
using Toci.Architects.Training.Properties;

namespace Toci.Architects.Training.anaxagore78.Homework.PeselValidator
{
    public class ValidatorOfPeselValidatorsAnaxagore78
    {

        public void ValidateAllValidators()
        {
            IReflectionAggregator aggregator = new ReflectionAggregatorAnaxagore78();
            Dictionary<string, IPeselValidator> validators = aggregator.GetAllPeselValidators();
            string fileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Resources\pesel.csv";
            List<string> peseList = GetPeselsList(fileName);

            Parallel.ForEach(validators, (validator) =>
            {
                foreach (var pesel in peseList)
                {
                    try
                    {

                        Console.WriteLine(validator.Key + " => " + pesel + " =" + validator.Value.IsPeselValid(pesel));
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine("Błąd przy sprawdzaniu: " + pesel + " => " + exc.Message);
                    }
                }

            });

            //foreach (var line in (Resources.pesel))
            //{

            //    Console.WriteLine(line);
            //}
        }

        private static List<string> GetPeselsList(string fileName)
        {
            List<string> lista = File.ReadAllLines(fileName).ToList();
            //using (StreamReader sr = new StreamReader(fileName))
            //{
            //    for (int i = 0; i < .Length; i++)
            //    {
            //        string pesel = sr.ReadLine();
            //        lista.Add(pesel);
            //    }
            //}
            return lista;
        }
    }
}
