using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Traininig.Leon
{
    public class QuizeAnswers : QuizeQuestion
    {
        // Nie wiadomo w jakiej kolejności będą budowane obiekty klas, dlatego QuizeQuestions
        // może zaistnieć po próbie budowy QuizeAnswer, a do budowy QuizeAnswer potrzebujemy
        // QuizeQuestions.Lenght.
        // Nie znamy długości tablicy, która jeszcze nie istnieje.

        // string[][] QuizeAnswer = new string[QuizeQuestions.Length][];
        
        // Konstruktory z kolei wywoływane są przy tworzeniu obiektu klasy, a rzeczy stworzyć obiekt to
        // muszą istnieć wszystkie pola klasy. Dlatego budując QuizeAnswer w konstruktorze mamy już długość
        // QuizeQuestions, ponieważ ta tablica została zbudowana wcześniej.
        QuizeAnswers()
        {
            string[][] QuizeAnswer = new string[QuizeQuestions.Length][];
        }

    }
}
