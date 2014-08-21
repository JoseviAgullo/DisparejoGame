using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisparejoGame
{
    public class Game
    {
        List<Roll> rolls = new List<Roll>();
        

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
            string nameResult = "";
            List<Roll> matchesSol = new List<Roll>();
            List<Roll> matchesAguila = new List<Roll>();

            matchesSol = rolls.FindAll(s => s.Coin.Equals("Sol"));
            matchesAguila = rolls.FindAll(s => s.Coin.Equals("Águila"));

            if (matchesSol.Count() == 1)
            {
                nameResult = rolls.Find(s => s.Coin.Equals("Sol")).Name;
            }
            else if (matchesAguila.Count() == 1)
            {
                nameResult = rolls.Find(s => s.Coin.Equals("Águila")).Name;
            }
            else
                nameResult = "Nadie";
                
            
            return nameResult;
        }
    }
}
