namespace W26Week4IntroToGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // boxing - value type -> ref type
            int i = 5;
            object o = i;

            o = "hello";


            // unboxing - ref type -> value type
            if (o is int)
                i = (int)o;
        }
    }
}
