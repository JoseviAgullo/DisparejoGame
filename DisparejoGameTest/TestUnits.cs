using DisparejoGame;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DisparejoGameTest
{
    [TestClass]
    public class TestUnits
    {
        private Game game;

        [TestInitialize]
        public void setUp()
        {
            game = new Game();
        }
        
        [TestMethod]
        public void TestNormalGame()
        {         
            game.roll("Paco", "Sol");
            game.roll("Juan", "Sol");
            game.roll("Pepe", "Águila");

            String winner = game.showWinner();

            Assert.AreEqual("El ganador es Pepe", winner);
        }

        [TestMethod]
        public void TestDrawGame()
        {
            game.roll("Paco", "Sol");
            game.roll("Juan", "Sol");
            game.roll("Pepe", "Sol");

            String winner = game.showWinner();

            Assert.AreEqual("No hay ganador, las monedas son iguales", winner);
        }

        [TestMethod]
        public void TestNormalGameMixedOrder()
        {
            game.roll("Paco", "Sol");
            game.roll("Pepe", "Águila");
            game.roll("Juan", "Sol");
            
            String winner = game.showWinner();

            Assert.AreEqual("El ganador es Pepe", winner);
        }
    }
}
