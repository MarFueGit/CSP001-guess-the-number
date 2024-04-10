using System;

namespace GuessTheNumber
{
    public class Game
    {
        public int TargetNumber { get; private set; }
        public Player HumanPlayer { get; private set; }
        public Player AIPlayer { get; private set; }

        private bool win = false;

        public Game()
        {
            RandomNumberGenerator();
            HumanPlayer = new HumanPlayer("Mary");
            AIPlayer = new AIPlayer("Computadora");
        }

        private void RandomNumberGenerator() => TargetNumber = new Random().Next(1, 100);

        public void StartGame()
        {
            while (!win)
            {
                if (CheckGuess(HumanPlayer.MakeGuess()))
                {
                    Console.WriteLine($"{HumanPlayer.Name} ha ganado \n");
                    break;
                }

                if (CheckGuess(AIPlayer.MakeGuess()))
                {
                    Console.WriteLine($"{AIPlayer.Name} ha ganado \n");
                    break;
                }
            }
        }

        public bool CheckGuess(int guess)
        {
            if (guess == TargetNumber)
            {
                win = true;
                return true;
            }

            Console.WriteLine($"Intenta con otro número! Uno {(guess > TargetNumber ? "menor" : "mayor")} \n");
            return false;
        }
    }
}
