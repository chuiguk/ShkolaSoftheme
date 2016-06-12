using System;

namespace HW14
{
    class Lottery
    {
        int[] _winNumbers;
        public Lottery()
        {
            _winNumbers = new int[6];
            var numberGenerator = new Random();
            for (int i = 0; i < _winNumbers.Length; i++)
            {
                _winNumbers[i] = numberGenerator.Next(1, 9);
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < _winNumbers.Length && index >= 0)
                {
                    return _winNumbers[index];
                }
                else
                { throw new ArgumentOutOfRangeException();}
            }
        }

        public void Guess(string numbers)
        {
            bool win = true;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (Convert.ToInt32(numbers[i]) != this[i])
                {
                    win = false;
                }
            }
            if (win)
            {
                Console.WriteLine("Congratulations! You won!");
            }
            else
            {
                string winNumbers = null;
                foreach (var number in _winNumbers)
                {
                    winNumbers += number;
                }
                Console.WriteLine("Sorry, you lose. The right numbers was: {0}", winNumbers);
            }
        }
        

    }
}
