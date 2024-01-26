using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HangmanPaint
    {
        int _NumberOfMistakes;
        const int MaxNumberOfMistakes = 6;
        int _GuessedLetters;
        int _TotalLetters;


        public void ShowWinningMessage()
        {
            Console.WriteLine("You won, nice");
        }

        public void ShowLoosingMessage()
        {
            Console.WriteLine("You lost, looser");
        }

        public void RewriteWordWithCorrectLetters(List<char> guessedLetters, string word)
        {
            _GuessedLetters = 0;
            int length = word.Length;
            for (int i = 0; i < length; i++)
            {
                if (guessedLetters.Contains(word[i]))
                {
                    Console.Write("{0} ", word[i]);
                    _GuessedLetters++;
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();
        }

        public void ShowMistake()
        {
            _NumberOfMistakes++;
            switch (_NumberOfMistakes)
            {
                case 1:
                    Console.WriteLine("Oops head on hanger");
                    break;
                case 2:
                    Console.WriteLine("Oops left hand on hanger");
                    break;
                case 3:
                    Console.WriteLine("Oops right hand on hanger");
                    break;
                case 4:
                    Console.WriteLine("Oops body on hanger");
                    break;
                case 5:
                    Console.WriteLine("Oops left leg on hanger");
                    break;
                case 6:
                    Console.WriteLine("Oops right leg on hanger");
                    break;
            }
        }

        public bool HasLost()
        {
            if (MaxNumberOfMistakes == _NumberOfMistakes)
                return true;
            return false;
        }

        public bool HasWon()
        {
            if (_GuessedLetters == _TotalLetters)
            {
                return true;
            }
            return false;
        }

        public void ShowWord(string word)
        {
            _TotalLetters = word.Length;
            for (int i = 0; i < _TotalLetters; i++)
            {
                Console.Write("_ ");
            }
            Console.WriteLine();
        }


    }
}
