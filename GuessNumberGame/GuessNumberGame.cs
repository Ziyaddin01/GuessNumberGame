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
            throw new NotImplementedException();
        }

        private void MachineGuesses()
        {
            throw new NotImplementedException();
        }
    }
}
