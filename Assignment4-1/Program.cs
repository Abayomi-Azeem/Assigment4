namespace Assignment4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int det = 0;
            int[,] fourDimArray = new int[4, 4]
            {
                {1,1,1,-1 },
                { 1,1,-1,1},
                { 1,-1,1,1},
                {-1,1,1,1 },
            };

            int A11 = fourDimArray[0, 0];
            int A12 = fourDimArray[0, 1];
            int A13 = fourDimArray[0, 2];
            int A14 = fourDimArray[0, 3];
            int A21 = fourDimArray[1, 0];
            int A22 = fourDimArray[1, 1];
            int A23 = fourDimArray[1, 2];
            int A24 = fourDimArray[1, 3];
            int A31 = fourDimArray[2, 0];
            int A32 = fourDimArray[2, 1];
            int A33 = fourDimArray[2, 2];
            int A34 = fourDimArray[2, 3];
            int A41 = fourDimArray[3, 0];
            int A42 = fourDimArray[3, 1];
            int A43 = fourDimArray[3, 2];
            int A44 = fourDimArray[3, 3];

            int detArray = A11 * A22 * A33 * A44 + A11 * A23 * A34 * A42 + A11 * A24 * A32 * A43
                            - A11 * A24 * A33 * A42 - A11 * A23 * A32 * A44 - A11 * A22 * A34 * A43
                            - A12 * A21 * A33 * A44 - A13 * A21 * A34 * A42 - A14 * A21 * A32 * A43
                           + A14 * A21 * A33 * A42 + A13 * A21 * A32 * A44 + A12 * A21 * A34 * A43
                           + A12 * A23 * A31 * A44 + A13 * A24 * A31 * A42 + A14 * A22 * A31 * A43
                           - A14 * A23 * A31 * A42 - A13 * A22 * A31 * A44 - A12 * A24 * A31 * A43
                           - A12 * A23 * A34 * A41 - A13 * A24 * A32 * A41 - A14 * A22 * A33 * A41
                           + A14 * A23 * A32 * A41 + A13 * A22 * A34 * A41 + A12 * A24 * A33 * A41;
            Console.WriteLine(detArray);
            for (int i = 0; i < 4; i++)
            {
                det = det + (fourDimArray[0, i] * (fourDimArray[1, (i + 1) % 4] * fourDimArray[2, (i + 2) % 4] * fourDimArray[3, (i + 3) % 4] - fourDimArray[1, (i + 3) % 4] * fourDimArray[2, (i + 2) % 4] * fourDimArray[3, (i + 1) % 4]));
                Console.Write("\nThe Determinant of the matrix is: {0}\n\n", det);
            }
        }
    }
                            
    }

