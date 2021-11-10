using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToe;
using TicTacToe.Classes;

namespace TicTacToe_Tests
{
    [TestClass]
    public class UnitTest1 : Game
    {

        [TestMethod]
        public void DisplayPlayerOneIcon_ShouldDisplayIcon()
        {
            choice = 1;
            string expected = PlayerOne.PlayerOneIcon();
            string actual = array[0].ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
