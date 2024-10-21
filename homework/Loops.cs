using System;

namespace homework
{
    public class Loops
    {
        public void LoopDemo()
        {
            Console.WriteLine("For Loop (0 to 4):");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("While Loop (5 to 9):");
            int j = 5;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("Do-While Loop (10 to 14):");
            int k = 10;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 15);
        }
    }
}
