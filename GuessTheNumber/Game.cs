using System;

namespace GuessTheNumber
{
    public class Game
    {
        private int TargetNumber;
        private readonly Player HumanPlayer;
        private readonly Player AIPlayer;

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

        //Este constructor es para poder hacer el test
        public Game(int targetNumber, Player humanPlayer, Player aiPlayer)
        {
            this.TargetNumber = targetNumber;
            this.HumanPlayer = humanPlayer;
            this.AIPlayer = aiPlayer;
        }

    }


}
