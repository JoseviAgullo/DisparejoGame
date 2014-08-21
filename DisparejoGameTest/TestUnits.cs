using DisparejoGame;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DisparejoGameTest
{
    [TestClass]
    public class TestUnits
    {
        [TestMethod]
        public void TestRoll()
        {
            Game game = new Game();

            game.roll("Paco", "Sol");

            game.showWinner();
        }
    }
}
