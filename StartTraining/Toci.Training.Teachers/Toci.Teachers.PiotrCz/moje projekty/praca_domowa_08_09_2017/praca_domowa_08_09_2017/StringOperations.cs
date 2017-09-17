namespace praca_domowa_08_09_2017
{
    public abstract class StringOperations
    {
        public abstract string Substring(string candidate, int start, int length);
      
        public abstract string Getname();

        public abstract string GlueBeginingEnd(string candidate);

        public abstract int CountOccurences(string candidate, char needle);

        public abstract int LetterPositionInString(string candidate, char needle, char replace);

        public abstract string StringReplace(string candidate, string needle, string replace);
    }
}