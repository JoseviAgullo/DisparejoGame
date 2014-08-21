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
            game.roll("Juan", "Sol");
            game.roll("Pepe", "Águila");

            String winner = game.showWinner();

            Assert.AreEqual("Pepe", winner);
        }
    }
}
