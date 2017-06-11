using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using Toci.Architects.Training.GhostRider.BasicGenerics;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;
using Toci.Architects.Training.Interfaces.GhostRider.Inheritance;

namespace Toci.Architects.Training.Kafar.Homework.PeselValidator
{
    public class PeselValidatorKafar : IPeselValidator, IReflectionAggregator
    {
        public string Name()
        {
            return "Kafar";
        }

        public bool IsPeselValid(string pesel)
        {
            long peselNumber;

            if (!long.TryParse(pesel, out peselNumber))
            {
                return false;
            } // próbujemy parsować pesel na typ long

            if (pesel.Trim().Length != 11)                         
            {
                return false;
            } // sprawdzamy, czy pesel ma 11 znaków

            if (!DateValidator(pesel))
            {
                return false;
            } // sprawdzamy logiczność daty w peselu

            int[] weight = {9, 7, 3, 1}; // tworzymy tabelę z wagami do obliczeń
            int ckecksum = 0;

            for (int i = 0; i < 10; i++)
            {
                ckecksum = ckecksum + int.Parse(pesel.Substring(i, 1)) * weight[i%4];
            } // obliczamy sumę iloczynów (znak w stringu) * waga

            if (int.Parse(pesel.Substring(10, 1)) != ckecksum %10)
            {
                return false;
            }   // sprawdzamy czy dzielenie modulo 10 sumy kontrolnej da nam cyfrę kontrolną peselu
            
            return true; // jeśli weryfikacja przebiegła pomyślnie, zwracamy true
        }

        public bool DateValidator(string pesel)
        {
            int month = int.Parse(pesel.Substring(2, 2));
            if (month == 0 || (month > 12 && month < 21) || (month > 32 && month < 41) || (month > 52 && month < 61) || (month > 72 && month < 81) || month > 92)
            {
                return false;
            } // sprawdzamy logiczność miesiąca daty urodzenia

            int day = int.Parse(pesel.Substring(4, 2));
            if (day > 31)
            {
                return false;
            } // sprawdzamy logiczność dnia daty urodzenia; UPROSZCZONE - przyjąłem, że każdy miesiąc ma 31 dni

            return true;
        }

        public Dictionary<string, IPeselValidator> GetAllPeselValidators()
        {
            Dictionary<string, IPeselValidator> testPeselValidators = new Dictionary<string, IPeselValidator>();

            Type[] allTypesInAssembly = Assembly.GetExecutingAssembly().GetTypes();
            Type seekedForType = typeof(IPeselValidator);

            IEnumerable<Type> derivingTypes = allTypesInAssembly.Where(m => seekedForType.IsAssignableFrom(m));

            foreach (var derivingType in derivingTypes)
            {
                IPeselValidator item = (IPeselValidator)Activator.CreateInstance(derivingType);
                testPeselValidators.Add(item.Name(), item);
            }

            return testPeselValidators;
        }

        public void ExtendPeselDatabase(string path, string[] file)
        {
            int count = 0;

            foreach (string line in file)
            {
                if (!(line.Contains(" ")) && IsPeselValid(line))
                {
                    file[count] = file[count].Insert(line.Length, " 1");
                } 
                else if (!(line.Contains(" ")) && (IsPeselValid(line) == false))
                {
                    file[count] = file[count].Insert(line.Length, " 0");
                }
                count++;
            }
            
            File.WriteAllLines(path, file);
        } // metoda dodająca 1 przy poprawnych peselach oraz 0 przy niepoprawnych w bazie danych

        public void RemovePeselValidationFromDatabase(string path, string[] file)
        {
            int count = 0;

            foreach (string line in file)
            {
                if (line.Contains(" "))
                {
                    file[count] = file[count].Remove(line.Length - 2, 2);
                }
                count++;
            }

            File.WriteAllLines(path, file);
        } // metoda usuwająca walidację peseli w bazie danych
    }
}