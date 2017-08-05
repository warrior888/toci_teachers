using System.Collections;

namespace Toci.Training.WojciechSeweryn
{
    public class MoneyValue
    {
        private Hashtable Digits = new Hashtable
        {
            {0, "zero"},
            {1, "jeden"},
            {2, "dwa"},
            {3, "trzy"},
            {4, "cztery"},
            {5, "pięć"},
            {6, "sześć"},
            {7, "siedem"},
            {8, "osiem"},
            {9, "dziewięć"}
        };

        private Hashtable Teen = new Hashtable
        {
            {0, "dziesięć"},
            {1, "jedenaście"},
            {2, "dwanaście"},
            {3, "trzynaście"},
            {4, "czternaście"},
            {5, "piętnaście"},
            {6, "szesnaście"},
            {7, "siedemnaście"},
            {8, "osiemnaście"},
            {9, "dziewiętnąście"}
        };

        private Hashtable Dozens = new Hashtable
        {
            {0, ""},
            {1, "dziesięć"},
            {2, "dwadzieścia"},
            {3, "trzydzieści"},
            {4, "czterdzieści"},
            {5, "pięcdziesiąt"},
            {6, "sześćdziesiąt"},
            {7, "siedemdziesiąt"},
            {8, "osiemdziesiąt"},
            {9, "dziewięcdziesiąt"}
        };

        private Hashtable Hundreds = new Hashtable
        {
            {0, ""},
            {1, "sto"},
            {2, "dwieście"},
            {3, "trzysta"},
            {4, "czterysta"},
            {5, "pięćset"},
            {6, "sześćset"},
            {7, "siedemset"},
            {8, "osiemset"},
            {9, "dziewięćset"}
        };


        // 123456789
        // sto dzadziescia trzy miliony czterysta piecdziesiat szesc tysiecy siedemset osiemdziesiat dziewiec zlotych

        public string Tripple(string moneyCandidate) // 123 -> sto dwadziescia trzy
        {
            string result = "";
            int triple_100 = int.Parse(moneyCandidate[0].ToString());
            int triple_10 = int.Parse(moneyCandidate[1].ToString());
            int triple_1 = int.Parse(moneyCandidate[2].ToString());

            if (Hundreds.ContainsKey(triple_100)) result += Hundreds[triple_100].ToString() + " ";
            result += Double(moneyCandidate[1].ToString() + moneyCandidate[2].ToString());
            /*
            if (triple_10 != 1)
            {
                if (Dozens.ContainsKey(triple_10)) result += Dozens[triple_10].ToString() + " ";
                if (Digits.ContainsKey(triple_1)) result += Digits[triple_1].ToString();
            }
            else // przypadek dla Teen (x - naście)
            {
                if (Teen.ContainsKey(triple_1)) result += Teen[triple_1].ToString();
            }
            */
            return result;
        }

        public string Double(string moneyCandidate)
        {
            string result = "";
            int double_10 = int.Parse(moneyCandidate[0].ToString());
            int double_1 = int.Parse(moneyCandidate[1].ToString());

            if (double_10 != 1)
            {
                if (Dozens.ContainsKey(double_10)) result += Dozens[double_10].ToString() + " ";
                if (Digits.ContainsKey(double_1)) result += Digits[double_1].ToString();
            }
            else // przypadek dla Teen (x - naście)
            {
                if (Teen.ContainsKey(double_1)) result += Teen[double_1].ToString();
            }
            return result;
        }

        public string GetMoneyValue(string money)
        {
            string result = "";
            int moneyInt = int.Parse(money); // 123 456 789
            int moneyMilions = moneyInt / 1000000; // 123
            int moneyTousands = (moneyInt - moneyMilions * 1000000) / 1000; // (123 456 789 - 123 000 000) / 1000
            int moneyHundreds = (moneyInt - moneyMilions * 1000000 - moneyTousands * 1000);

            string textMilions = "";
            string textTousands = "";
            string textHundreds = "";

            if (moneyMilions != 0) textMilions = Tripple(moneyMilions.ToString()) + " mln. ";
            if (moneyTousands != 0) textTousands = Tripple(moneyTousands.ToString()) + " tyś. ";
            if (moneyHundreds > 100) textHundreds = Tripple(moneyHundreds.ToString());
            if (moneyHundreds < 100 && moneyHundreds >= 10) textHundreds = Double(moneyHundreds.ToString());
            if (moneyHundreds < 10 && moneyHundreds != 0) textHundreds = Digits[moneyHundreds].ToString();
            if (moneyHundreds == 0) textHundreds = Digits[0].ToString();

            result = textMilions + textTousands + textHundreds + " złotych";

            return string.Empty;
        }
    }
}