using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Grid
    {
        public static int[,] CreateTheGrid(int[,] seedData)
        {
            var rows = seedData.GetUpperBound(0) + 1;
            var columns = seedData.GetUpperBound(1) + 1;
            var grid = new int[rows, columns];

            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    grid[row, column] = seedData[row, column];
                }
            }
            return grid;
        }
    }
}
