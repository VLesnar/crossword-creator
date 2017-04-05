using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Crossword Creator
 * Veronica Lesnar
 * Created on: April 4, 2017
 * Last updated on: April 4, 2017
 * Word -
 *      Properties: length, horizontal, possibleWords
 *      Methods: CastToStringBuilder(string), CastToString(StringBuilder) */

namespace CrosswordCreator
{
    public class Word
    {
        public int length   // The length of the word
        {
            get; set;
        }

        public bool horizontal  // If the word is placed horizontally or vertically
        {
            get; set;
        }

        public List<string> possibleWords   // List of all possible words for that spot
        {
            get; set;
        }

        public List<Cell> associatedCells
        {
            get; set;
        }

        // Default Constructor
        public Word()
        {
            length = 0;
            horizontal = true;
            possibleWords = new List<string>();
            associatedCells = new List<Cell>();
        }
        
        // Constructor - Takes an int for length of word and a bool to indicate if the word is
        // horizontal or vertical
        public Word(int len, bool hor)
        {
            length = len;
            horizontal = hor;
            possibleWords = new List<string>();
            associatedCells = new List<Cell>();
        }

        public StringBuilder CastToStringBuilder(string word)
        {
            return new StringBuilder(word);
        }

        public string CastToString(StringBuilder word)
        {
            return word.ToString();
        }
    }
}
