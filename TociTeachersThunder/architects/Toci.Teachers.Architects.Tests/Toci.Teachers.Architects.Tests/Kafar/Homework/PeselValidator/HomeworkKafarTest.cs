using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
            
            string[] file = File.ReadAllLines(
                @"..\..\..\..\Toci.Teachers.Architects.Tests\Toci.Teachers.Architects.Tests\Kafar\Homework\data\pesel.txt");

            

            foreach (KeyValuePair<string, IPeselValidator> item in instanceOfPeselValidatorKafar.GetAllPeselValidators())
            {
                int count = 0;
                int records = 0;
                double efficiency = 0;

                foreach (string line in file)
                {
                    string[] data = line.Split();
                    bool check = data[1] == "1";
                    DateTime start = DateTime.Now;

                    if (item.Value.IsPeselValid(data[0]) == check)
                    {
                        count++;
                    }
                    
                    TimeSpan duration = DateTime.Now - start;

                    efficiency += duration.TotalMilliseconds;

                    records++;
                }

                resultDictionary.Add(item.Key, records - count);  // słownik zawierający liczbę błędnych weryfikacji
                
                timeOfExecutionDictionary.Add(item.Key, efficiency); // słownik zawierający czas wykonania weryfikcji 100 peseli

                efficiency = efficiency/records;
                averageEfficiencyDictionary.Add(item.Key, efficiency);  // słownik zawierający średni czas wykonania pojedynczej weryfikacji peselu

                
            }
        }
    }
}