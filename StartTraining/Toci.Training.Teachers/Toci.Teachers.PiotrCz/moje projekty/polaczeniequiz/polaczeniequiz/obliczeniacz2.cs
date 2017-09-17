using System;



namespace polaczeniequiz
{
    public class obliczenia2 : obliczeniac1
    {
        
    
        private string quizAnswear = "quickAnswear";
        public int MyType1 { get; set; }
        public obliczenia2()
   
        {
            for (int j = 0; j < goodanswear1.Length; j++)

                if (goodanswear1.Length == quizAnswear.Length)

                {

                    Console.WriteLine("You have one point");
                }
                else if (quizAnswear.Length != goodanswear1.Length)
                {
                    Console.WriteLine("Inncorect answear, please try agin");
                    string exelent = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You have five point");
                }
        }
    }
}  