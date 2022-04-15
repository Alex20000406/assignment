using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int number;
            int largest = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter" + count + "num:");
                number = Int32.Parse(Console.ReadLine());
                
                if (i == 0) { largest = number; }
                else
                {
                    if (largest < number)
                    {
                        largest = number;
                    }
                }
                count += 1;
            }
            Console.WriteLine(largest);
        }
    }
}

