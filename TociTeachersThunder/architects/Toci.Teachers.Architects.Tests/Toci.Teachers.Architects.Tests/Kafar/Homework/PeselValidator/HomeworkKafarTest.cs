using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Architects.Training.GhostRider.Generics;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;
using Toci.Architects.Training.Kafar.Homework.PeselValidator;
using Toci.Architects.Training.Piotrek.Homework.PeselValidator;

namespace Toci.Teachers.Architects.Tests.Kafar.Homework.PeselValidator
{
    [TestClass]
    public class HomeworkKafarTest
    {
        [TestMethod]
        public void PeselValidatorTest()
        {
            PeselValidatorKafar peselValidatorKafarTest = new PeselValidatorKafar();
            bool check = peselValidatorKafarTest.IsPeselValid("92072210625");
        }

        [TestMethod]
        public void AllPeselValidatorsTest()
        {
            PeselValidatorKafar instanceOfPeselValidatorKafar = new PeselValidatorKafar();
            Dictionary<string, int> resultDictionary = new Dictionary<string, int>();
            Dictionary<string, double> averageEfficiencyDictionary = new Dictionary<string, double>();
            Dictionary<string, double> timeOfExecutionDictionary = new Dictionary<string, double>();
            Dictionary<string, Exception> exceptionsDictionary = new Dictionary<string, Exception>();

            string path = @"..\..\..\..\Toci.Teachers.Architects.Tests\Toci.Teachers.Architects.Tests\Kafar\Homework\data\pesel.txt";

            //string path = @"..\..\..\..\Toci.Teachers.Architects.Trainings\Toci.Teachers.Architects.Trainings\Resources\pesel.csv"; // plik Arka
            

            string[] file = File.ReadAllLines(path);


            //instanceOfPeselValidatorKafar.ExtendPeselDatabase(path, file);
            //instanceOfPeselValidatorKafar.RemovePeselValidationFromDatabase(path, file);

            foreach (KeyValuePair<string, IPeselValidator> item in instanceOfPeselValidatorKafar.GetAllPeselValidators())
            {
                int count = 0;
                int records = 0;
                double efficiency = 0;
                try
                {
                    foreach (string line in file)
                    {
                        string[] data = line.Split(); // dzieli każdą linię pliku na stringi
                        bool check = data[1] == "1"; // przypisuje do zmiennej check wartość true jeśli po peselu w pliku jest 1, lub false w innym przypadku
                        DateTime start = DateTime.Now;

                        if (item.Value.IsPeselValid(data[0]) == check)
                        {
                            count++;
                        }

                        TimeSpan duration = DateTime.Now - start;

                        efficiency += duration.TotalMilliseconds; // dodaje do efficiency z poprzedniej iteracji czas trwania walidacji peselu obecnej iteracji

                        records++; // liczy ilość walidowanych peseli
                    }

                }
                catch (Exception e)
                {
                    exceptionsDictionary.Add(item.Key, e);
                }
                

                resultDictionary.Add(item.Key, records - count);  // słownik zawierający liczbę błędnych weryfikacji
                
                timeOfExecutionDictionary.Add(item.Key, efficiency); // słownik zawierający czas (w milisekundach) wykonania weryfikcji 1000 peseli

                efficiency = efficiency/records;
                averageEfficiencyDictionary.Add(item.Key, efficiency);  // słownik zawierający średni czas (w milisekundach) wykonania pojedynczej weryfikacji peselu

            }
        }
    }
}