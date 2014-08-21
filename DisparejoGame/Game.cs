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
        List<string> kindCoin = new List<string>();
        

        static void Main(string[] args)
        {
            
        }

        public void roll(String name, String coin)
        {
            Roll tmpRoll = new Roll();
            tmpRoll.Name = name;
            tmpRoll.Coin = coin;
            rolls.Add(tmpRoll);
        }

        public void rollRandom(String name)
        {
            kindCoin.Add("Sol");
            kindCoin.Add("Águila");

            Random index = new Random();

            this.roll(name, kindCoin[index.Next(0, 1)]);
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
