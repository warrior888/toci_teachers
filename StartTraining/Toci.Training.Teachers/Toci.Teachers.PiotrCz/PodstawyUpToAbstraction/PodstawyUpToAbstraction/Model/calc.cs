namespace PodstawyUpToAbstraction.Model
{
    public class calc
    {
        public const int STALA_MOJA = 5;
        private int _test = 10;

        public calc()
        {
            _test = 20;
        }

        public calc(int param1)
        {
            _test = 20;
        }

        public int Sum(int x1, int x2)
        {
            return x1 + x2;
        }
        public int Substruck(int x1, int x2)
        {
            return x1 + x2;
        }
    }
}