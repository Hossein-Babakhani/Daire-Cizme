using System;

namespace Daire_Çizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle:");
            int radius = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < radius*2+1; i++)
            {
                for (int j = 0; j < radius * 2 + 1; j++)
                {
                    if((i- radius)* (i - radius)+(j- radius)* (j - radius)<= radius* radius)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
