using System;
using System.Collections.Generic;

namespace Forming_a_Magic_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowOne = new int[] { 4, 6, 2 };
            int[] rowTwo = new int[] { 4, 5, 7 };
            int[] rowThree = new int[] { 6, 1, 6 };
            int[][] data = new int[3][];

            // data[0] = rowOne;
            // data[1] = rowTwo;
            // data[2] = rowThree;
            data[0] = new int[3];
            data[1] = new int[3];
            data[2] = new int[3];

            data[0][0] = 4;
            data[0][1] = 6;
            data[0][2] = 2;

            data[1][0] = 4;
            data[1][1] = 5;
            data[1][2] = 7;

            data[2][0] = 6;
            data[2][1] = 1;
            data[2][2] = 6;

            formingMagicSquare(data);
        }
        // Complete the formingMagicSquare function below.
        public static int formingMagicSquare(int[][] s)
        {
            Console.WriteLine("Inside of the function");
            List<int> newData = new List<int>();

            int index = 0;
            Dictionary<int, int> cache = new Dictionary<int, int>();

            cache.Add(0, -1);
            cache.Add(1, -1);
            cache.Add(2, -1);
            cache.Add(3, -1);
            cache.Add(4, -1);
            cache.Add(5, -1);
            cache.Add(6, -1);
            cache.Add(7, -1);
            cache.Add(8, -1);
            cache.Add(9, -1);

            // Make one Array. 
            for (int i = 0; i < s.Length; i++)
            {
                int[] row = s[i];
                for (int j = 0; j < row.Length; j++)
                {
                    //newData[index] = row[j];
                    newData.Add(row[j]);
                    cache[row[j]] = index; 
                    index++;
                }
            }

            for (int i = 0; i < newData.Count; i++)
            {
                int firstRow = newData[0] + newData[1] + newData[2];
                int secondRow = newData[3] + newData[4] + newData[5];
                int thirdRow = newData[6] + newData[7] + newData[8];
                int firstColumn = newData[0] + newData[3] + newData[6];
                int secondColumn = newData[1] + newData[4] + newData[7];
                int thirdColumn = newData[2] + newData[5] + newData[8];
                int firstDiagonal = newData[0] + newData[4] + newData[8];
                int secondDiagonal = newData[2] + newData[4] + newData[6];    

                if(i == 0)
                {
                   if(firstRow == 15 && firstColumn == 15 && firstDiagonal == 15)
                    {
                        continue; 
                    } 
                   else
                    {
                        //check for the one that needs repair but go through each scenario. 

                    }
                }
                else if (i == 1)
                {

                }
                else if (i == 2)
                {

                }
                else if (i == 3)
                {

                }
                else if (i == 4)
                {

                }
                else if (i == 5)
                {

                }
                else if (i == 6)
                {

                }
                else if (i == 7)
                {

                }
                else if (i == 8)
                {

                }

                Console.WriteLine(newData[i]);
            }

         

            return 1;


        }
    }
}
