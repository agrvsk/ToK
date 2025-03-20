using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Acappella
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int A = Convert.ToInt32(numbers[0]);
            int B = Convert.ToInt32(numbers[1]);
        
            int[] rows = new int[A];

            for (int i=0; i<A; i++) 
            {
                rows[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(rows);


            int cnt = 0;
            for (int i=0; i<A ; i++) 
            {
                int nr = rows[i];
                for (int j = i + 1; j < A; j++) 
                {
                    if (rows[j] > nr + B)
                        break;
                    i++;
                }
                cnt++;
            }

            Console.WriteLine( cnt );

        }
    }
}
