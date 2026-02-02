namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            //int num = queue[2];

            Console.WriteLine("Total items = " + queue.Count);
            foreach(int i in queue)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");

            int num = queue.Dequeue();
            Console.WriteLine("num = " + num);

            Console.WriteLine("Total items = " + queue.Count);
            foreach (int i in queue)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");


            num = queue.Peek();
            Console.WriteLine("num = " + num);

            Console.WriteLine("Total items = " + queue.Count);
            foreach (int i in queue)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");

            MyMethod();
        }

        /// <summary>
        /// this is my method
        /// </summary>
        static void MyMethod()
        {

        }
    }
}
