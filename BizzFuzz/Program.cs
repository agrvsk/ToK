// See https://aka.ms/new-console-template for more information
using System;

namespace BizzFuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
                // Se https://open.kattis.com/problems/fizzbuzz
                //Console.WriteLine("Ange fyra nummer enl. [a b c d]:");

                String[] numbers = Console.ReadLine().Split();

                //if (numbers == null || numbers.Length < 4)
                //{
                //    throw new Exception("Ange fyra siffror!");
                //}

                long A = Convert.ToInt64(numbers[0]);
                long B = Convert.ToInt64(numbers[1]);
                long C = Convert.ToInt64(numbers[2]);
                long D = Convert.ToInt64(numbers[3]);

                //long E = (D % C == 0) ? D : C*D;

            //if (A < 1) throw new Exception("A måste vara större än 0");
            //if (A > B) throw new Exception("B måste vara större än A");
            //if (B > 1E+18) throw new Exception("B får ej vara större än 10^18.");
            //if (C < 1) throw new Exception("C måste vara större än 0");
            //if (D > B) throw new Exception("D måste vara midre än B");


                long cnt = 0;
                for (long i = A; i <= B; i++)
                {
                    if ( (C == 1 || i % C == 0) 
                    && i % D == 0) 
                    {
                        cnt++;
                    }
                }
                Console.WriteLine(cnt);
            //}
            //catch (System.Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}





    
