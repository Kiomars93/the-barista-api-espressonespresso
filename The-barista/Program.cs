using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace The_barista
{
    public class Program
    {
        public static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Hello!");
        }
    }

    public interface IBevarage
    {
        void AddWater();
        void AddBeans(int amount, string sort);
        void Validate();
        void ToBaverage();
    }


    public class Espresso : IBevarage
    {
        private int _amount;
        private string _sort;

        public void AddBeans(int amount, string sort)
        {
            _amount = amount;
            _sort = sort; // Arabica and Robusta
        }

        public void AddWater()
        {
        }

        public void ToBaverage()
        {
            throw new NotImplementedException();
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ExampleTest()
        {
            using FakeConsole console = new FakeConsole("First input", "Second input");
            Program.Main();
            Assert.AreEqual("Hello!", console.Output);
        }
    }
}
