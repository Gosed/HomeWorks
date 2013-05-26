using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCalculator;

namespace Calc
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void ExecuteOperationTest()
        {
            StackCalc.ArrayStack arrayStack = new StackCalc.ArrayStack(25);
            StackCalc.Calc calculator = new StackCalc.Calc(arrayStack);
            string str = "6 6+3/";
            Assert.AreEqual(calculator.ExecuteOperation(str), 4);
            StackCalc.ListStack pointerStack = new StackCalc.ListStack();
            StackCalc.Calculator calculator1 = new StackCalc.Calculator(pointerStack);
            str = "6 6-3*";
            Assert.AreEqual(calculator.ExecuteOperation(str), 0);
        }
    }
}
