namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            //int num = stack[2];

            Console.WriteLine("Total items: " + stack.Count);
            foreach (int i in stack)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");


            int num = stack.Pop();
            Console.WriteLine("num = " + num);

            Console.WriteLine("Total items: " + stack.Count);
            foreach (int i in stack)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");


            num = stack.Peek();
            Console.WriteLine("num = " + num);

            Console.WriteLine("Total items: " + stack.Count);
            foreach (int i in stack)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");
        }
    }
}
