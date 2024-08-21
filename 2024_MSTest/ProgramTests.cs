using System;
using System.Collections.Generic;
using _2024_PracLesson;

namespace _2024_PracLesson.Tests
{
    [TestClass]
    public class ProgramTests
    {
        #region ---=== Test Fruit Class ===---

        [TestMethod]
        public void Fruit_Construction_ReturnsCorrectName()
        {
            Fruit fruit = new Fruit("Apple", "Red");
            string expected = "Apple";
            string result = fruit.Name;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Fruit_Construction_ReturnsCorrectColor()
        {
            Fruit fruit = new Fruit("Apple", "Red");
            string expected = "Red";
            string result = fruit.Color;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Fruit_ToString_ReturnsCorrectFormat()
        {
            Fruit fruit = new Fruit("Apple", "Red");
            string expected = "Name: Apple, Color: Red";
            string result = fruit.ToString();
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region ---=== Test Citrus Class ===---
        [TestMethod]
        public void Citrus_IsAFruit()
        {
            bool expected = true;
            bool result = new Citrus("Lemon", "Yellow", 53.2) is Fruit;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Citrus_Construction_ReturnsCorrectName()
        {
            Citrus fruit = new Citrus("Lemon", "Yellow", 53.2);
            string expected = "Lemon";
            string result = fruit.Name;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Citrus_Construction_ReturnsCorrectColor()
        {
            Citrus fruit = new Citrus("Lemon", "Yellow", 53.2);
            string expected = "Yellow";
            string result = fruit.Color;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Citrus_Construction_ReturnsCorrectVitaminC()
        {
            Citrus fruit = new Citrus("Lemon", "Yellow", 53.2);
            double expected = 53.2;
            double result = fruit.VitaminC;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Citrus_ToString_ReturnsCorrectFormat()
        {
            Citrus citrus = new Citrus("Lemon", "Yellow", 53.2);
            string expected = "Name: Lemon, Color: Yellow, VitaminC: 53,2";
            string result = citrus.ToString();
            Assert.AreEqual(expected, result);
        }


        #endregion

    }
}
