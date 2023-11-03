using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tests
{
    [TestClass()]
    public class CanonTests
    {
        [TestMethod()]
        public void MoveLeftTest()
        {
            Canon canon = new Canon();
            canon.x = 3; 

            // Act
            canon.MoveLeft();

            // Assert
            Assert.AreEqual(1, canon.x);
        }

        [TestMethod()]
        public void MoveRightTest()
        {
            // Arrange
            Canon canon = new Canon();
            canon.x = Console.WindowWidth - 17; // Setting an initial value less than Console.WindowWidth - 15

            // Act
            canon.MoveRight();

            // Assert
            Assert.AreEqual(Console.WindowWidth - 15, canon.x);
        }
    }
}