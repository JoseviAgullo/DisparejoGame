using DisparejoGame;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DisparejoGameTest
{
    [TestClass]
    public class TestUnits
    {
        [TestMethod]
        public void TestNormalGame()
        {
            Game game = new Game();

            game.roll("Paco", "Sol");
            game.roll("Juan", "Sol");
            game.roll("Pepe", "Águila");

            String winner = game.showWinner();

            Assert.AreEqual("Pepe", winner);
        }

        [TestMethod]
        public void TestDrawGame()
        {
            Game game = new Game();

            game.roll("Paco", "Sol");
            game.roll("Juan", "Sol");
            game.roll("Pepe", "Sol");

            String winner = game.showWinner();

            Assert.AreEqual("Nadie", winner);
        }
    }
}
