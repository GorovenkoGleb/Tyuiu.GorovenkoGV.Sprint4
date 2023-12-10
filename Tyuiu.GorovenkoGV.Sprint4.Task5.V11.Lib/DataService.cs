using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GorovenkoGV.Sprint4.Task5.V11.Lib
{
    public class DataService : ISprint4Task5V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int n = 1;

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                        continue;
                    }
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = count;
                        continue;
                    }
                }
            }
            return matrix;
        }
    }
}
