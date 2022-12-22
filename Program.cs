using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the beginning: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the end: ");
            double n2 = double.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("please restart the program and enter numbers correctly");
            }
            else
            { 
            if (n1 < 2)
            {
                n1 = 2;
            }
                for (double i = n1; i <= n2; i++)
                {
                    double sum = 0;
                    for (double a = 1; a < i; a++)
                    {
                        if (i % a == 0)
                        {
                            sum += a;
                        }
                    }
                    if (sum == i)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
