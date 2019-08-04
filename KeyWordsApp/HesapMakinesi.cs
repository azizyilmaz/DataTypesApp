namespace KeyWordsApp
{
    class HesapMakinesi
    {
        static HesapMakinesi()
        {
            Pi = 3.1415;
        }
        public static double Pi = 3.14;
        public void PiDegistir(double x)
        {
            Pi = x;
        }
        public static double Toplama(double x, double y)
        {
            return x + y;
        }
        public double Topla(double a, double b)
        {
            return Toplama(a, b);
        }
    }
}
