namespace ConsoleApp1
{
    internal class HangmanWord
    {
        List<string> _Words;
        string _Word;
        HangmanPaint _HangmanPaint;
        List<char> _GuessedLetters;

        public HangmanWord(List<string> words)
        {
            _Words = words;
            _HangmanPaint = new HangmanPaint();
            _GuessedLetters = new List<char>();
        }

        public void Play()
        {
            ChooseWord();
            _HangmanPaint.ShowWord(_Word);
            while (true)
            {
                if (_HangmanPaint.HasLost())
                {
                    _HangmanPaint.ShowLoosingMessage();
                    break;
                }
                else if (_HangmanPaint.HasWon())
                {
                    _HangmanPaint.ShowWinningMessage();
                    break;
                }
                EnterLetter();
            }

        }

        private void ChooseWord()
        {
            Random r = new Random();
            int n = r.Next(0, 4);
            _Word = _Words[n];
        }

        private void EnterLetter()
        {
            Console.Write("Enter letter: ");
            char letter;
            bool b = char.TryParse(Console.ReadLine(), out letter);
            if (!b)
            {
                throw new Exception("Invalid character");
            }
            if (_Word.Contains(letter))
            {
                _GuessedLetters.Add(letter);
            }
            else
            {
                _HangmanPaint.ShowMistake();
            }
            _HangmanPaint.RewriteWordWithCorrectLetters(_GuessedLetters, _Word);
        }

    }
}
