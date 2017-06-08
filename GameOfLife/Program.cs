using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = 20;
            var cols = 20;

            var seedMatrix = Services.GenerateSeed(rows, cols);

            var newGrid = Grid.CreateTheGrid(seedMatrix);
            //var nextGenGrid = Grid.GetNextGenGrid(newGrid);

            Grid.showGrid(newGrid);
            //Grid.showGrid(nextGenGrid);
            Console.ReadKey();
        }
    }
}
