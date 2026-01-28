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


            //if (AreEqual(5, 5))
            if (AreEqual<int>(5, 5))
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");
        }

        // standard, non-generic method
        static bool AreEqual(object value1, object value2)
        {
            return value1.Equals(value2);
        }

        // generic method
        static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
