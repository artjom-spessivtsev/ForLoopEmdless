namespace ForLoopEmdless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loop endless");

            //kasutae for loopi
            ushort i = 0;

            for (; ; )
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
