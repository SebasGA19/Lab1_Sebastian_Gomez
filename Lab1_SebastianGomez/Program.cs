using System;
using System.Numerics;

namespace Lab1_SebastianGomez
{
    class Program
    {
        static void Main()
        {
            BigInteger A, B, C, D, E;
            BigInteger acum = 0, acum1;
            for (int k = 0; k < 101; k++)
            {
                // Sumatoria del fibonacci
                int n = int.Parse(Console.ReadLine());
                if (n <= -1)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    if (n == 1)
                    {
                        C = 0;
                        acum = C;
                    }
                    else if (n == 2)
                    {
                        C = 1;
                        acum = C;
                    }
                    else
                    {
                        acum = 1;
                        C = 0;
                        A = 0; B = 1;
                        for (int i = 3; i <= n; i++)
                        {
                            C = A + B;

                            A = B;
                            B = C;
                            acum = acum + C;

                        }
                    }
                    // Sumatoria del numero pentagonal
                    D = 0;
                    for (int j = 0; j <= n; j++)
                    {
                        acum1 = (j * (3 * j - 1)) / 2;
                        D = acum1 + D;
                    }

                    // Producto
                    E = D * acum;
                    Console.WriteLine(E);
                }
                
            }
            
        }
    }
}
