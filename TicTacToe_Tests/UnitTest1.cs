using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToe;
using TicTacToe.Classes;

namespace TicTacToe_Tests
{
    [TestClass]
    public class UnitTest1 : Game
    {
        [TestInitialize]
        
        [TestMethod]
        public void DisplayPlayerOneIcon_ShouldDisplayIcon()
        {
            Run();
            choice = int.Parse(array[choice]);
            array[choice] = "1";
            string expected = PlayerOne.PlayerOneIcon();
            string actual = array[choice];
            Assert.AreEqual(expected, actual);
        }
    }
}
