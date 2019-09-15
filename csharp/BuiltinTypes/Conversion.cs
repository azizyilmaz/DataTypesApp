namespace BuiltinTypes
{
    public class Conversion
    {
        public static void Main(string[] args)
        {
            object left = (int)1;
            object right = (int)1;
            var comparison1 = left == right;
            var comparison2 = left.Equals(right);
            var comparison3 = (int)left == (int)right;

            object boxedInt = (int)1;
            long unboxedInt = (long)(int)boxedInt;
        }
    }
}
