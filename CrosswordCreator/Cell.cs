using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Crossword Creator
 * Veronica Lesnar
 * Created on: April 4, 2017
 * Last updated on: April 4, 2017
 * Cell -
 *      Enum: Status
 *      Properties: letter, col, row    */

namespace CrosswordCreator
{
    public class Cell
    {
        public enum Status { letter, empty, black };    // If a cell has a letter (0),
                                                        // is empty (1), or is black (2)

        public char letter  // Holds the cell's letter
        {
            get; set;
        }

        public int col  // Determines what column the cell is in
        {
            get; set;
        }

        public int row  // Determines what row the cell is in
        {
            get; set;
        }

        public Status status    // Determines if the cell has a letter is empty or is black
        {
            get; set;
        }

        // Default Constructor
        public Cell()
        {
            letter = ' ';
            col = 0;
            row = 0;
            status = Status.empty;
        }

        // Constructor - Takes two ints for position (col, row) and Status of the cell; Used for
        // general Cell construction
        public Cell(int c, int r, Status stat)
        {
            letter = ' ';
            col = c;
            row = r;
            status = stat;
        }

        // Constructor - Take a char for a letter, two ints for position (col, row), and Status of
        // the cell; Used when a word is in place (determined word in grid)
        public Cell(char let, int c, int r, Status stat)
        {
            letter = letter;
            col = c;
            row = r;
            status = stat;
        }
    }
}
