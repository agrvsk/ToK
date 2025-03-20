using System;

namespace _2048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] spelplan = new int[4,4];
            for (int row = 0; row < 4; row++) 
            {
                string[] numbers = Console.ReadLine().Split();
                for (int col = 0; col < 4; col++)
                {
                    spelplan[row,col] = Convert.ToInt16(numbers[col]);
                }
            }

            //   0,  1,     2, or    3
            //left, up, right, or down
            int direction = Convert.ToInt16(Console.ReadLine());


            switch (direction) 
            {
                case 0: 
                    for (int row = 0; row < 4; row++) //VÄNSTER
                        {
                        for (int col = 0; col < 3; col++) // Loop inkluderar ej sista kolumnen 
                            {
                            //LIKA SLÅS IHOP (0 HOPPAS ÖVER)
                            if (spelplan[row, col] != 0)
                            {
                                for (int testCol = col + 1; testCol <= 3; testCol++)
                                {
                                    if (spelplan[row, testCol] == 0) continue;
                                    if (spelplan[row, testCol] != spelplan[row, col]) break;

                                    spelplan[row, col] = spelplan[row, col] * 2;
                                    spelplan[row, testCol] = 0;
                                    break;
                                }
                            }
                            //SKIFTA NOLLORNA ÅT HÖGER
                            for (int testCol = col; testCol < 3; testCol++)
                            {
                                    if (spelplan[row, testCol] == 0)
                                    {
                                        spelplan[row, testCol] = spelplan[row, testCol + 1];
                                        spelplan[row, testCol + 1] = 0;
                                    }
                            }
                            
                            }
                           
                        }
                        break;
                case 1: 
                    for (int col = 0; col < 4; col++)  //UPP
                    {
                        for (int row = 0; row < 3; row++) // inkluderar ej sista raden
                        {
                            //LIKA SLÅS IHOP
                            if (spelplan[row, col] != 0)
                            {
                                for (int testRow = row + 1 ; testRow <= 3; testRow++)
                                {
                                    if (spelplan[testRow, col] == 0) continue;
                                    if (spelplan[testRow, col] != spelplan[row, col]) break;

                                    spelplan[row, col] = spelplan[row, col] * 2;
                                    spelplan[testRow, col] = 0;
                                    break;
                                }
                            }

                            //SKIFTA NOLLOR NEDÅT
                            for (int testRow = row; testRow < 3 ; testRow++)
                            {
                                if (spelplan[testRow, col] == 0)
                                {
                                    spelplan[testRow, col] = spelplan[testRow+1, col];
                                    spelplan[testRow + 1, col] = 0;
                                }
                            }



                        }
                    }
                        break;
                case 2:
                    for (int row = 0; row < 4; row++) //HÖGER
                    {
                        for (int col = 3; col > 0; col--) //Ej första kolumnen
                        {
                            //LIKA SLÅS IHOP (0 HOPPAS ÖVER)
                            if (spelplan[row, col] != 0)
                            {
                                for (int testCol = col - 1; testCol >= 0; testCol--)
                                {
                                    if (spelplan[row, testCol] == 0) continue;
                                    if (spelplan[row, testCol] != spelplan[row, col]) break;

                                    spelplan[row, col] = spelplan[row, col] * 2;
                                    spelplan[row, testCol] = 0;
                                    break;
                                }
                            }

                            //SKIFTA NOLLORNA ÅT VÄNSTER
                            for (int testCol = col; testCol > 0; testCol--)
                            {
                                if (spelplan[row, testCol] == 0)
                                {
                                    spelplan[row, testCol] = spelplan[row, testCol - 1];
                                    spelplan[row, testCol - 1] = 0;
                                }
                            }

                        }

                    }
                    break;

                case 3:
                    for (int col = 0; col < 4; col++)  //NER
                    {
                        //int ihopslagen = -1;
                        for (int row = 3; row > 0; row--) //SKIFTAR UPPIFRÅN OCH NER inkluderar ej rad 4
                        {
                            //LIKA SLÅS IHOP
                            if (spelplan[row, col] != 0)
                            {
                                for (int testRow = row - 1; testRow >= 0; testRow--)
                                {
                                    if (spelplan[testRow, col] == 0) continue;
                                    if (spelplan[testRow, col] != spelplan[row, col]) break;

                                    spelplan[row, col] = spelplan[row, col] * 2;
                                    spelplan[testRow, col] = 0;
                                    break;
                                }
                            }


                            //SKIFTA NOLLORNA UPPÅT
                            for (int testRow = row; testRow > 0; testRow--)
                            {
                                if (spelplan[testRow, col] == 0)
                                {
                                    spelplan[testRow, col] = spelplan[testRow - 1, col];
                                    spelplan[testRow - 1, col] = 0;

                                }
                            }

                        }
                    }
                    break;
            }

            String utskrift="";
            for (int row = 0; row < 4; row++) {
                for (int col = 0; col < 4; col++) {
                    if(col == 0)   utskrift  = "";
                    else           utskrift += " ";
                    utskrift += spelplan[row,col];
                }
                Console.WriteLine(utskrift);
            }
        }
    }
}
