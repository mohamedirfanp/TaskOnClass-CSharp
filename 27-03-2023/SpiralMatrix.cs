using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnCSharp._27_03_2023
{
	internal class SpiralMatrix
	{

		public void SpiralMatrixTraversal()
		{
            int[,] matrix = new int[,]
			{
				{1,2,3,4 },
				{5,6,7,8 },
				{9,10,11,12},
			};

			int row = matrix.GetLength(0);
			int col = matrix.GetLength(1);

			int[] spiral_matrix = new int[matrix.Length];
			int spiral_len = 0;
			int curr_row = 0;
			int curr_col = col-1;
			int idx = 0;

            
            while (spiral_len < matrix.Length - 1)
			{ 

				// Left to Right
				for(int i = 0; i<=curr_col;i++)
				{
					spiral_matrix[idx] = matrix[curr_row,i];
					idx ++;
					spiral_len++;
				}

				curr_row++;

				// Right top to Right bottom
				for(int i = curr_row;i< row;i++)
				{
					//spiral_matrix.Append(matrix[i, curr_col]);
					spiral_matrix[idx] = matrix[i, curr_col];
					idx++;
					spiral_len++;
				}
				curr_col--;

				// bottom right to bottom left
				for (int i = curr_col; i >= 0; i--)
				{
					//spiral_matrix.Append(matrix[row-1,i]);
					//Console.WriteLine(matrix[row,i]);
					spiral_matrix[idx] = matrix[0,0];
					idx++;
					spiral_len++;
				}


				//bottom left to top left
				for (int i = row - 1; i >= 0; i--)
				{
					//spiral_matrix.Append(matrix[i,0]);
					spiral_matrix[idx] = matrix[i, 0];
					idx++;
					spiral_len++;
				}

			}

			foreach(int i in spiral_matrix)
			{
				Console.WriteLine(i);

			}


		}
	}
}
