using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    // Adds the file class

/* Crossword Creator
 * Veronica Lesnar
 * Created on: March 28, 2017
 * Last updated on: March 28, 2017
 * Grid -
 *      Properties:
 *      Methods: */

namespace CrosswordCreator
{
    public class Grid
    {
        public int col  // Determines the number of cells in a column
        {
            get; set;
        }

        public int row  // Determines the number of cells in a row
        {
            get; set;
        }

        public List<Cell> cells;

        public void CreateGrid()
        {
            StreamReader input = null;
            string text = "";

            try
            {
                using (input = new StreamReader("grid.txt"))
                {
                    text = input.ReadToEnd();
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ioe.Message);
            }
            finally
            {
                input.Close();
            }
            Console.WriteLine(text);

            text = text.Replace("\r", String.Empty);
            text = text.Replace("\n", String.Empty);

            StringBuilder strBuilder = new StringBuilder(text);

            col = int.Parse(strBuilder[0].ToString());
            row = int.Parse(strBuilder[1].ToString());

            Console.WriteLine(col + " " + row);

            cells = new List<Cell>();

            int count = 2;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if(!(count >= 22)) { 
                        char l = strBuilder[count];
                        if (l == '.')
                        {
                            cells.Add(new Cell(i, j, Cell.Status.empty));
                            count++;
                        }
                        else if (l == '/')
                        {
                            cells.Add(new Cell(i, j, Cell.Status.black));
                            count++;
                        }
                    }
                }
            }

            int count2 = 0;
            foreach(Cell cell in cells)
            {
                Console.WriteLine(count2 + " Column: " + cell.col + " Row: " + cell.row + " Status: " + cell.status);
                count2++;
            }
        }
    }
}
