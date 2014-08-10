using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codekataBowlingGame;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ExampleScore()
        {
            BowlingGame game = new BowlingGame();

            game.roll(1);
            game.roll(4);
            game.roll(4);
            game.roll(5);
            game.roll(6);
            game.roll(4);
            game.roll(5);
            game.roll(5);
            game.roll(10);
            game.roll(0);
            game.roll(1);
            game.roll(7);
            game.roll(3);
            game.roll(6);
            game.roll(4);
            game.roll(10);
            game.roll(2);
            game.roll(8);
            game.roll(6);

            Assert.AreEqual(133, game.score());
        }

        [TestMethod]
        public void PerfectGame()
        {
            BowlingGame game = new BowlingGame();

            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);

            Assert.AreEqual(300, game.score());
        }

        [TestMethod]
        public void GutterGame()
        {
            BowlingGame game = new BowlingGame();

            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);
            game.roll(0);

            Assert.AreEqual(0, game.score());
        }
    }
}
