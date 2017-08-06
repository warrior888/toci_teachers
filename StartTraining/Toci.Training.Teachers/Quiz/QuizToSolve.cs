using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Quiz
{   
    public class QuizToSolve
    {
        public string QuizName { get; set; }
        public Dictionary<string, string> QuestionsAndAnswer { get; private set; }

        private string[] _rightAnswers;

        public QuizToSolve(Uri filePath)
        {
            AddQuiz(filePath.ToString());
        }

        private void AddQuiz(string filePath)
        {
            try
            {
                using (Stream readStream = File.OpenRead(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(QuizToSolve));
                    QuizToSolve temp = (QuizToSolve) serializer.Deserialize(readStream);        // TODO: Dodać szablon xml

                    QuizName = temp.QuizName;
                    QuestionsAndAnswer = temp.QuestionsAndAnswer;
                    _rightAnswers = temp._rightAnswers;
                }
            }
            catch (System.IO.FileLoadException e)       // TODO: Obsłużyć wyjątek
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}