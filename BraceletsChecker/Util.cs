using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraceletsChecker
{
    public class Util
    {

        private const char ROUNDSTARTINGBRACKET = '(';
        private const char ROUNDCLOSINGBRACKET = ')';


        private const char STRAIGHTSTARTINGBRACKET = '[';
        private const char STRAIGHTCLOSINGBRACKET = ']';


        public static bool CorrectlyFormedBraceletsLine(string line)
        {
            Stack<char> startCharactersStack = new Stack<char>();
            char lastcharacter = ' ';
            foreach(char character in line)
            {
                if ((character == ROUNDSTARTINGBRACKET) || (character == STRAIGHTSTARTINGBRACKET))
                {
                    startCharactersStack.Push(character);
                }
                else if (character == ROUNDCLOSINGBRACKET)
                {   
                    if (startCharactersStack.Count == 0)
                    {
                        return false;
                    }                    
                    else if (startCharactersStack.Pop() != ROUNDSTARTINGBRACKET)
                    {
                        return false;
                    }
                }
                else if (character == STRAIGHTCLOSINGBRACKET)
                {
                    if (startCharactersStack.Count == 0)
                    {
                        return false;
                    }
                    if (startCharactersStack.Pop() != STRAIGHTSTARTINGBRACKET)
                    {
                        return false;
                    }
                }
                lastcharacter = character;
            }

            if ((lastcharacter == ROUNDCLOSINGBRACKET) || (lastcharacter == STRAIGHTCLOSINGBRACKET))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
