using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnCSharp._28_03_2023
{
	internal class RotateMatrix
	{

		public void RotateGivenMatrix()
		{
			int[,] matrix =
			{
				{ 1, 2, 3},
				{ 4, 5, 6 },
				{ 7, 8, 9},
			};

            int[,] cpy_matrix = matrix;


			int row = matrix.GetLength(0);
			int col = matrix.GetLength(1);


            // 90 deg
            Console.WriteLine("The 90 Deg Matrix ");
            // Transpose
            matrix = TransposeMatrix(row, col, matrix);
			// Reverse
			matrix = Reverse(row, col, matrix);
            // Print
            PrintMatrix(row, col, matrix);

            // 180 deg
            Console.WriteLine("The 180 Deg Matrix");
            // Transpose
            matrix = TransposeMatrix(row,col, matrix);
            // Reverse
            matrix = Reverse(row, col, matrix);
            // Print
            PrintMatrix(row, col, matrix);

            // 270 Deg
            Console.WriteLine("The 270 Deg Matrix");
            // Transpose
            matrix = TransposeMatrix(row, col, matrix);
            // Reverse
            matrix = Reverse(row, col, matrix);

            // Print
            PrintMatrix(row, col, matrix );

        }

		public int[,] TransposeMatrix(int row, int col, int[,] matrix)
		{
            for(int r = 0; r < row; r++)
			{
                for (int c = 0; c < r; c++)
                {
                    int temp = matrix[r, c];
                    matrix[r, c] = matrix[c, r];
                    matrix[c, r] = temp;
                }
            }
			return matrix;
        }


		public int[,] Reverse(int row,int col,int[,] matrix)
        { 
            int lptr = 0;
            int rptr = col - 1;
            for (int r = 0; r < row; r++)
            {
                lptr = 0;
                rptr = col - 1;
                while (lptr < rptr)
                {
                    int temp = matrix[r, lptr];
                    matrix[r, lptr] = matrix[r, rptr];
                    matrix[r, rptr] = temp;
                    lptr++;
                    rptr--;
                }
            }
			return matrix;

        }

        public void PrintMatrix(int row, int col,int[,] matrix)
        {
            for(int r = 0; r < row; r++)
            {
                for(int c=0; c < col; c++)
                {
                    Console.Write(matrix[r,c] + " ");
                }
                Console.WriteLine();
            }
        }
	}
}