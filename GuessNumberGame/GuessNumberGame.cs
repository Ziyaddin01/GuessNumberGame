using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    public enum GuessingPlayer
    {
        Human,
        Machine 
    }
    public class GuessNumberGame
    {
        private readonly int max;
        private readonly int maxTries;
        private readonly GuessingPlayer guessingPlayer;

        public GuessNumberGame(int max = 100, int maxTries = 5, GuessingPlayer guessingPlayer = GuessingPlayer.Human)
        {
            this.max = max;
            this.maxTries = maxTries;
            this.guessingPlayer = guessingPlayer;
        }

        public void Start()
        {
            if(guessingPlayer == GuessingPlayer.Human)
            {
                HumanGuesses();
            }
            else
            {
                MachineGuesses();
            }
        }

        private void HumanGuesses()
        {
            Random rand = new Random();
            int guessedNumber = rand.Next(0, max);

            int lastGuess = -1;
            int tries = 0;
            while(lastGuess != guessedNumber && tries < maxTries)
            {
                Console.WriteLine("Guess the number!");
                lastGuess = int.Parse(Console.ReadLine());

                if(lastGuess == guessedNumber)
                {
                    Console.WriteLine("Congrats! You guessed the number!");
                    break;
                }
                else if(lastGuess < guessedNumber)
                {
                    Console.WriteLine("My number is greater!");
                }
                else
                {
                    Console.WriteLine("My number is less!");
                }
                tries++;

                if(tries == maxTries)
                {
                    Console.WriteLine("You lost!");
                }
            }

        }

        private void MachineGuesses()
        {
            throw new NotImplementedException();
        }
    }
}
