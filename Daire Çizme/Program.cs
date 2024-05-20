using System;

namespace Daire_Çizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Çemberin yarıçapını girin:");
            int yarıçap = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < yarıçap*2+1; i++)
            {
                for (int j = 0; j < yarıçap * 2 + 1; j++)
                {
                    if((i- yarıçap)* (i - yarıçap)+(j- yarıçap)* (j - yarıçap)<= yarıçap* yarıçap)
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
