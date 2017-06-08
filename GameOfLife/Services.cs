﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Services
    {
        public static int[,] GenerateSeed(int rows, int cols)
        {
            var matrix = new int[rows, cols];
            var random = new Random();

            for (var row = 1; row < rows - 1; row++)
            {
                for (var col = 1; col < cols - 1; col++)
                {
                    matrix[row, col] = (int)Math.Round(random.NextDouble());
                }
            }
            return matrix;
        }

        public static string WelcomeMessage()
        {
            var msg = "Welcome to the Game of Life: Press or Hold ::Return:: to run simulation or Press ::Q:: at any time to Quit.";
            return msg;
        }
    }
}
