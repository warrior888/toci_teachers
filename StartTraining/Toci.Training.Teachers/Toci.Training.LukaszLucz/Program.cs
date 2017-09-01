using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.LukaszLucz
{
    class CandidateForAnObjectInstance
    {

        public string QuizQuestion;
    }

    class QuizAnswer
    {
        public string Answer;
        public bool IsanswerCorrect;
    }

    class QuizQuestion
    {
        public string Question;
        public QuizAnswer[] Answers;
    }

    class Program
    {
        //QuizQuestion[] questions = new QuizQuestion[10];    

        public static QuizQuestion[] GetQuizQuestions()
        {
            // fill my object with questions
            return new QuizQuestion[10];
        }

        public static QuizAnswer[] ShuffleAnswers(QuizQuestion question)
        {
            // todo shuffle
            
            return question.Answers;
        }

        public static void ShowQuestions()
        {
            
        }
        
        static void Main(string[] args)
        {
            /// Pierwsza aplikacja consolowa dla Toci...




        }
    }
}
