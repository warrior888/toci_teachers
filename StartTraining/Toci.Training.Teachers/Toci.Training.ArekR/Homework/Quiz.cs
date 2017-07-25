using System;
using System.Collections.Generic;
using System.Linq;

namespace Toci.Training.ArekR.Homework
{
    public class Quiz
    {

            static Quiz()
            {
                var questionsAndAnswers = PrepareQuestions(); // w tej metodzie przygotowujemy pytania i odpowiedzi
                Console.WriteLine("To jest krótki quiz o krwi. ArekVersion 1.0.0.0");
                int score = 0;
                // tablica, na ktorej losujemy kolejnosc odpowiedzi;

                for (int i = 0; i < questionsAndAnswers.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(questionsAndAnswers[i].Question);
                    DisplayShuffledAnswers(questionsAndAnswers[i].AnswersList);

                    score = CheckAnswer(questionsAndAnswers[i].AnswersList, score);

                    #region inna wersja testu - pyta o odp tylko raz i od razu podaje prawidłową odp
                    // score = CheckAnswerV2(questionsAndAnswers[i].AnswersList, score);
                    #endregion
                }

                #region pytania i odpowiedzi
                ////Pytanie 1 - powstawanie komórek krwi, hematopoeza
                //Console.WriteLine("1. Gdzie znajdują się komórki krwiotwórcze?" +
                //                  "\na) w wątrobie" +
                //                  "\nb) w sercu" +
                //                  "\nc) w szpiku" +
                //                  "\nd) w śledzionie");
                //String ans1 = Console.ReadLine();


                //if (ans1 == "c") score++; //score nabija się tylko, jeśli pierwsza odp jest poprawna

                //for (; ans1 != "c";)
                //{
                //    Console.WriteLine("Źle, spróbuj ponownie");
                //    ans1 = Console.ReadLine();
                //}
                //if (ans1 == "c")
                //{
                //    Console.WriteLine("Dobrze");
                //}

                ////Pytanie 2
                //Console.WriteLine("2. Erytropoetyna, hormon pobudzający komórki macierzyste do produkcji erytrocytów, jest wydzielana przez:" +
                //                 "\na) nerki" +
                //                 "\nb) serce" +
                //                 "\nc) szpik kostny" +
                //                 "\nd) tarczycę");
                //String ans2 = Console.ReadLine();


                //if (ans2 == "a") score++;

                //for (; ans2 != "a";)
                //{
                //    Console.WriteLine("Źle, spróbuj ponownie");
                //    ans2 = Console.ReadLine();
                //}
                //if (ans2 == "a")
                //{
                //    Console.WriteLine("Dobrze");
                //}


                ////Pytanie 3 - rodzaje komórek krwi, ich liczba i stosunek procentowy
                //Console.WriteLine("3. W prawidłowym rozmazie krwi najmniej jest:" +
                //                  "\na) monocytów" +
                //                  "\nb) bazofili" +
                //                  "\nc) trombocytów" +
                //                  "\nd) eozynofili");
                //String ans3 = Console.ReadLine();


                //if (ans3 == "b") score++;

                //for (; ans3 != "b";)
                //{
                //    Console.WriteLine("Źle, spróbuj ponownie");
                //    ans3 = Console.ReadLine();
                //}
                //if (ans3 == "b")
                //{
                //    Console.WriteLine("Dobrze");
                //}

                ////Pytanie 4
                //Console.WriteLine("4. Eozynofil to inaczej:" +
                //                  "\na) granulocyt kwasochłonny" +
                //                  "\nb) granulocyt obojętnochłonny" +
                //                  "\nc) agranulocyt" +
                //                  "\nd) granulocyt zasadochłonny");
                //String ans4 = Console.ReadLine();


                //if (ans4 == "a") score++;

                //for (; ans4 != "a";)
                //{
                //    Console.WriteLine("Źle, spróbuj ponownie");
                //    ans4 = Console.ReadLine();
                //}
                //if (ans4 == "a")
                //{
                //    Console.WriteLine("Dobrze");
                //}

                ////Pytanie 5 - funkcje poszczególnych komórek
                //Console.WriteLine("5. Komórki produkujące przeciwciała to:" +
                //                  "\na) Limfocyty B" +
                //                  "\nb) Limfocyty Tc" +
                //                  "\nc) Limfocyty Th" +
                //                  "\nd) Limfocyty Treg");
                //String ans5 = Console.ReadLine();


                //if (ans5 == "a") score++;

                //for (; ans5 != "a";)
                //{
                //    Console.WriteLine("Źle, spróbuj ponownie");
                //    ans5 = Console.ReadLine();
                //}
                //if (ans5 == "a")
                //{
                //    Console.WriteLine("Dobrze");
                //}

                ////Pytanie 6
                //Console.WriteLine("6. Zdolności do fagocytozy NIE posiadają:" +
                //                  "\na) monocyty" +
                //                  "\nb) bazofile" +
                //                  "\nc) trombocyty" +
                //                  "\nd) neutrofile");
                //String ans6 = Console.ReadLine();


                //if (ans6 == "c") score++;

                //for (; ans6 != "c";)
                //{
                //    Console.WriteLine("Źle, spróbuj ponownie");
                //    ans6 = Console.ReadLine();
                //}
                //if (ans6 == "c")
                //{
                //    Console.WriteLine("Dobrze");
                //}

                ////Pytanie 7 - parametry na wyniku morfologii, czynniki wpływające na wynik
                //Console.WriteLine("7. MCV na wyniku morfologii krwi oznacza:" +
                //                  "\na) liczbę erytrocytów/ml" +
                //                  "\nb) średnią masę hemoglobiny w erytrocycie" +
                //                  "\nc) liczbę leukocytów/ml" +
                //                  "\nd) średnią objętość erytrocytów");
                //String ans7 = Console.ReadLine();


                //if (ans7 == "d") score++;

                //for (; ans7 != "d";)
                //{
                //    Console.WriteLine("Źle, spróbuj ponownie");
                //    ans7 = Console.ReadLine();
                //}
                //if (ans7 == "d")
                //{
                //    Console.WriteLine("Dobrze");
                //}

                ////Pytanie 8
                //Console.WriteLine("8. MCV może być podwyższone z powodu:" +
                //                  "\na) niedoboru żelaza" +
                //                  "\nb) odwodnienia hipertonicznego" +
                //                  "\nc) przewodnienia hipertonicznego" +
                //                  "\nd) niedoboru witaminy B12");
                //String ans8 = Console.ReadLine();


                //if (ans8 == "d") score++;

                //for (; ans8 != "d";)
                //{
                //    Console.WriteLine("Źle, spróbuj ponownie");
                //    ans8 = Console.ReadLine();
                //}
                //if (ans8 == "d")
                //{
                //    Console.WriteLine("Dobrze");
                //}

                ////Pytanie 9 - czas życia komórek krwi, produkty rozpadu, funkcje wątroby
                //Console.WriteLine("9. Produktem metabolizmu hemoglobiny jest:" +
                //                  "\na) mioglobina" +
                //                  "\nb) lipaza" +
                //                  "\nc) bilirubina" +
                //                  "\nd) amylaza");
                //String ans9 = Console.ReadLine();


                //if (ans9 == "c") score++;

                //for (; ans9 != "c";)
                //{
                //    Console.WriteLine("Źle, spróbuj ponownie");
                //    ans9 = Console.ReadLine();
                //}
                //if (ans9 == "c")
                //{
                //    Console.WriteLine("Dobrze");
                //}

                ///* inna wersja testu - pyta o odp tylko raz i od razu podaje prawidłową
                //if (ans9 == "c") {
                //    score++;
                //    Console.WriteLine("Dobrze!");
                //} else {
                //    Console.WriteLine("Źle, poprawna odpowiedź to c.");
                //}
                //*/ 
                #endregion

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("KONIEC. Twój wynik to: " + score + "/" + questionsAndAnswers.Count); // Twoj wynik na rzeczywista ilosc pytan
                Console.ReadLine();
            }

            private static int CheckAnswerV2(List<AnswerEntityArek> answers, int score)
            {
                var isCorrect = false; // wartosc logiczna czy odpowiedz jest prawidlowa
                while (!isCorrect) // wykonuj do czasu udzielenia prawidlowej odpowiedzi , czyli tak dlugo jak wartosc isCorrect jest rowna false
                {
                    var response = Console.ReadKey(); //odzytujemy klawisz wcisniety przez uzytkownika

                    // LINQ-  tu sprawdzamy jaka wartosc ma wlasciowsc IsCorrectAnswer dla odpowiedzi o wartosci Key - czyli klawisza wcisnietego przez uzytkownika
                    isCorrect = answers.Where(
                            answ => answ.Key.Equals(response.KeyChar.ToString())).Select(answ => answ.IsCorrectAnswer)
                        .FirstOrDefault();

                    #region to samo bez LINQ
                    //foreach (var answer in answers)
                    //{
                    //    if (answer.Key.Equals(response.KeyChar.ToString()))
                    //    {
                    //        isCorrect = answer.IsCorrectAnswer;
                    //    }
                    //} 
                    #endregion

                    if (isCorrect)
                    {
                        score++;
                        Console.WriteLine("Dobrze!");
                    }
                    else
                    {
                        //LINQ tu wyciagamy info jaki klucz z tablicy [a,b,c,d...] byl przypisany do prawidlowej odpowiedzi
                        Console.WriteLine("Źle, poprawna odpowiedź to: " + answers.Where(ans => ans.IsCorrectAnswer).Select(ans => ans.Key)
                                              .FirstOrDefault());
                        //* to samo bez uzycia LINQ */
                        #region to samo bez uzycia LINQ
                        //foreach (var answer in answers)
                        //{
                        //    if (answer.IsCorrectAnswer)
                        //    {
                        //        Console.WriteLine("Źle, poprawna odpowiedź to: " + answer.Key);
                        //    }
                        //} 
                        #endregion
                    }
                }
                return score;
            }

            private static int CheckAnswer(List<AnswerEntityArek> answers, int score)
            {
                var isCorrect = false; // wartosc logiczna czy odpowiedz jest prawidlowa
                var loop = 0; //zmienna loop liczy razy uzytkownik odpowiedzial na dane pytanie, wartosc zerowana dla kazdego pytania
                Console.WriteLine();
                while (!isCorrect) // wykonuj do czasu udzielenia prawidlowej odpowiedzi , czyli tak dlugo jak wartosc isCorrect jest rowna false
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Twoja odpowiedz to: ");
                    ConsoleKeyInfo response = Console.ReadKey(); //odzytujemy klawisz wcisniety przez uzytkownika
                    isCorrect = answers.Where(
                            answ => answ.Key.Equals(response.KeyChar.ToString())).Select(answ => answ.IsCorrectAnswer)
                        .FirstOrDefault(); // tu sprawdzamy jaka wartosc ma wlasciowsc IsCorrectAnswer dla odpowiedzi o wartosci Key - czyli klawisza wybranego przez uzytkownika

                    #region to samo bez LINQ

                    //    //foreach (var answer in answers)
                    //    //{
                    //    //    if (answer.Key.Equals(response.KeyChar.ToString()))
                    //    //    {
                    //    //        isCorrect = answer.IsCorrectAnswer;
                    //    //    }
                    //    //} 

                    #endregion


                    if (isCorrect && loop.Equals(0))
                        score++; //score nabija się tylko, jeśli pierwsza odp jest poprawna , 
                    if (isCorrect)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\r\nOdpowiedź poprawna");
                        break; // jesli isCorrect ==true przejdz do kolejnego pytania
                    }
                    loop++; // zwieksz o 1 jesli odpowiedz jest nieprawidlowa  na dane pytanie
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\nŹle, spróbuj ponownie");
                }
                return score;
            }

            private static void DisplayShuffledAnswers(List<AnswerEntityArek> answers)
            {
                char keyValue = 'a'; //pierwszy klucz dla odpowiedzi , dla kolejnych bedzie postinkrementacja czyli b, c, itd
                //inicjalizujemy liste  liczbami calkowitymi  od 0 , lista bedzie zawierala tyle elementow ile jest odpowiedzi na dane pytanie
                List<int> indxList = Enumerable.Range(0, answers.Count).ToList();
                new Random().Shuffle(indxList); //losowa kolejnosc
                foreach (int indx in indxList)
                {
                    answers[indx].Key = keyValue++.ToString();
                    // tu przypisujemy kazdej odpowiedzi klucz  :  1. odp => a , 2.odp =>b itd
                    Console.WriteLine("\t" + answers[indx].Key + ")" +
                                      answers[indx].Answer); // wyswietlamy odpowiedzi w losowej kolejnosci
                }
            }

            private static List<QuestionAnswerEntityArek> PrepareQuestions()
            {
                List<QuestionAnswerEntityArek> questionsAndAnswers = new List<QuestionAnswerEntityArek>
                {
                    new QuestionAnswerEntityArek
                    {
                        Question = "1.Gdzie znajdują się komórki krwiotwórcze ? ",
                        AnswersList = new List<AnswerEntityArek>
                        {
                            new AnswerEntityArek {Answer = "w wątrobie"},
                            new AnswerEntityArek {Answer = "w sercu"},
                            new AnswerEntityArek
                            {
                                Answer = "w szpiku",
                                IsCorrectAnswer = true  // tak zaznaczamy prawidlowa odpowiedz
                            },
                            new AnswerEntityArek {Answer = "w śledzionie"}
                        }
                    },
                    new QuestionAnswerEntityArek
                    {
                        Question =
                            "2. Erytropoetyna, hormon pobudzający komórki macierzyste do produkcji erytrocytów, jest wydzielana przez: ",
                        AnswersList = new List<AnswerEntityArek>
                        {
                            new AnswerEntityArek {Answer = "nerki", IsCorrectAnswer = true},
                            new AnswerEntityArek {Answer = "serce"},
                            new AnswerEntityArek {Answer = "szpik kostny"},
                            new AnswerEntityArek {Answer = "tarczycę"}
                        }
                    }
                };
                return questionsAndAnswers;
            }
        }

        static class RandomExtensions
        {
            public static void Shuffle<T>(this Random rng, List<T> collection)
            {
                int n = collection.Count;
                while (n > 1)
                {
                    int k = rng.Next(n--);
                    T temp = collection[n];
                    collection[n] = collection[k];
                    collection[k] = temp;
                }
            }
        }
    
}