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
            var stillPlaying = true;

            var seedMatrix = Services.GenerateSeed(rows, cols);

            //Create our new grid
            var newGrid = Grid.CreateTheGrid(seedMatrix);
            //Create the next gen grid
            var nextGenGrid = Grid.GetNextGenGrid(newGrid);
            var nxtnxtGenGrid = Grid.GetNextGenGrid(nextGenGrid);

            //Show the current grid
            Grid.showGrid(newGrid);

            //Show the nextgen grid. 
            Grid.showGrid(nextGenGrid);

            while (stillPlaying == true)
            {
                Grid.GetNextGenGrid(nxtnxtGenGrid);
                Grid.showGrid(nxtnxtGenGrid);
            }


            Console.ReadKey();
        }
    }
}
