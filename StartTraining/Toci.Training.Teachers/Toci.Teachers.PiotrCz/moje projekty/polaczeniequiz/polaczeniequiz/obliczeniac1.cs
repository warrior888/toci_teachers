using System;

namespace polaczeniequiz
{
    public class obliczeniac1 : wyswietlenia
    {

       public string goodanswear1 = "goodanswear";
       
        public int MyType { get; set; }

        public obliczeniac1()
        {
            for (int i = 0; i < quizquestions.Length; i++)

                if (question1 == i)

                {

                    Console.WriteLine(quizquestions[i]);
                    string goodanswear1 = Console.ReadLine();
                    
                    }

        }
    }
}
        

       