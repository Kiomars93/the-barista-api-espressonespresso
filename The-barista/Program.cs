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

            var espresso = new Espresso
            {
                
            };

        }
    }

    public interface IBevarage
    {
        List<string> Ingredients { get; }
        string CupType { get; }
        void AddWater();
        void AddBeans(int amount, string sort);
        void AddMilk();
        void Validate();
        void ToBaverage();
    }


    public class Espresso : IBevarage
    {
        private int _amount;
        private string _sort;

        public List<string> Ingredients => throw new NotImplementedException();

        public string CupType => throw new NotImplementedException();

        public void AddBeans(int amount, string sort)
        {
            _amount = amount;
            _sort = sort; // Arabica and Robusta
        }
        public void AddMilk()
        {

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
