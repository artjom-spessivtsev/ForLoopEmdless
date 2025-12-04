namespace ForLoopEmdless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loop endless");

            //kasutae for loopi
            ushort i = 0;

            // kui on 10 rida konsoolis, siislõpetab ära
            //VIHJE: kasutage break-1

            for (; ; )
            {
                Console.WriteLine("i väärtus on: {0}", i);
                i++;
                if (i > 10)               
                {
                    break;
                }
            }
        }
    }
}
