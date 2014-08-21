using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisparejoGame
{
    public class Game
    {
        List<Roll> rolls;

        static void Main(string[] args)
        {
        }

        public void roll(String name, String result)
        {
            Roll tmpRoll = new Roll();
            tmpRoll.Name = name;
            tmpRoll.Coin = result;
            rolls.Add(tmpRoll);
        }

        public String showWinner()
        {
            return "Pepe";
        }
    }
}
