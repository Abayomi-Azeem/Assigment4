namespace Assigment4
{
    internal class Program
    {

        public int[,] TwoDimensionalDotMul(int[,] arr1, int[,] arr2)
        {
            int[,] arr3 = new int[3, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr3[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        arr3[i, j] = arr3[i, j] + (arr1[i, k] * arr2[k, j]);
                    }
                }
            }
            return arr3;
        }
        static void Main(string[] args)
        {
            //Using Matrix Multiplication
            int[,] dimx1 = new int[,] { { 2, 5, 1 }, { 6, 2, 5 }, { 6, 9, 2 } };
            int[,] dimx2 = new int[,] { { 9, 1, 3 }, { 2, 4, 8 }, { 2, 1, 5 } };
            int[,] dimx3 = new int[,] { { 6, 1, 4 }, { 5, 7, 1 }, { 3, 7, 4 } };

            int[,] dimy1 = new int[,] { { 0, 3, 1 }, { 7, 2, 4 }, { 9, 2, 3 } };
            int[,] dimy2 = new int[,] { { 5, 1, 8 }, { 6, 3, 1 }, { 1, 7, 4 } };
            int[,] dimy3 = new int[,] { { 4, 6, 2 }, { 0, 8, 5 }, { 2, 5, 0 } };

            int[][,] arr1 = new int[3][,]
            {
                dimx1,
                dimx2,
                dimx3
            };
            int[][,] arr2 = new int[3][,]
            {
                dimy1,
                dimy2,
                dimy3
            };
            var twoDimCalc = new Program();
            int[][,] arr3 = new int[3][,]
            {
                twoDimCalc.TwoDimensionalDotMul(dimx1, dimy1),
                twoDimCalc.TwoDimensionalDotMul(dimx2, dimy2),
                twoDimCalc.TwoDimensionalDotMul(dimx3, dimy3),
            };


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine(arr3[i][j, k]);
                    }
                }
            }
                

            //Using Array Multiplication

            int[,,] myArray = new int[3, 3, 3]
            {
                { {2,5,1}, {6,2,5}, {6,9,2} },
                { {9,1,3}, {2,4,8}, {2,1,5} },
                { {6,1,4}, {5,7,1}, {3,7,4} }
            };

            int[,,] arrayTwo = new int[3, 3, 3]
            {
                { {0,3,1}, {7,2,4}, {9,2,3} },
                { {5,1,8}, {6,3,1}, {1,7,4} },
                { {4,6,2}, {0,8,5}, {2,5,0} }

            };
            int[,,] result = new int[3, 3, 3];
            Console.WriteLine("\n\n\n\n");
            for (int x = 0; x < myArray.GetLength(0); x++)
            {
                for (int y = 0; y < myArray.GetLength(1); y++)
                {
                    for (int z = 0; z < myArray.GetLength(2); z++)
                    {
                        result[x, y, z] += myArray[x, y, z] * arrayTwo[x, y, z];
                        
                        Console.WriteLine(result[x, y, z]);

                    }
                }





            }
        }
    }
}