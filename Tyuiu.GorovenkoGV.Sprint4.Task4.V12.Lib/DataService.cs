using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GorovenkoGV.Sprint4.Task4.V12.Lib
{
    public class DataService : ISprint4Task4V12
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (rows % 2 == 0)
                    {
                        rows = 1;
                    }
                    if (columns % 2 == 0)
                    {
                        columns = 1;
                    }
                }
            }
            return rows;
        }  
            
    }
}
