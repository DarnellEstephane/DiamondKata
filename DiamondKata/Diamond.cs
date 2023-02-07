using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondKata
{
    public class Diamond
    {
        const char LETTER_A = 'A'; 
        const char SPACE = ' ';

        public static string Create(char midPoint)
        {
            string topValue = string.Empty;
            string bottomValue = string.Empty;

            if (char.IsLetter(midPoint))
            {
                //Ensure the leeter is uppercase as they have a different value to lowercase chars
                midPoint = char.ToUpper(midPoint);

                //Begin building the diamond
                for (char currentLetter = LETTER_A; currentLetter <= midPoint; currentLetter++)
                {
                    //As each line is the same between the top and bottom for each letter, only need to build it once
                    string currentLine = BuildLine(currentLetter, midPoint);

                    //Add the line to the bottom of the to half
                    topValue += currentLine;

                    //Ignore the midpoint on the bottomValue so we don't print that row twice
                    if (currentLetter != midPoint)
                    {
                        //Add the line to the top of the bottom half
                        bottomValue = currentLine + bottomValue;
                    }
                }
            }

            return topValue + bottomValue;
        }

        private static string BuildLine(char currentLetter, char midPoint)
        {
            //Get the start and end padding for the line
            string padding = GetPadding(currentLetter, midPoint);

            //Create the start
            string line = padding + currentLetter.ToString();

            //Add the middle space and second letter, if not an A
            if (currentLetter != LETTER_A)
            {
                //Get the middle 
                string middleSpace = GetMiddleSpacing(currentLetter);

                line += middleSpace + currentLetter.ToString();
            }

            //End the line with
            line += padding + "\n";

            return line;
        }

        private static string GetPadding(char currentLetter, char midPoint)
        {
            //Number of spaces needed to get from the start of the string to the first letter
            int numberOfSpaces = midPoint - currentLetter;

            return new string(SPACE, numberOfSpaces);
        }

        private static string GetMiddleSpacing(char currentLetter)
        {
            //Number of spaces needed to get from the first letter back to the start of the string
            int numberOfSpaces = currentLetter - LETTER_A;

            //Double the spaces to match the indentations then minus one to keep it inline with the diamond
            numberOfSpaces = (numberOfSpaces * 2) - 1;

            return new string(SPACE, numberOfSpaces);
        }
    }
}
