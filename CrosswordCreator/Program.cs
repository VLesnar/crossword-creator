﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrosswordCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid();
            grid.CreateGrid();
            Console.ReadLine();
        }
    }
}
