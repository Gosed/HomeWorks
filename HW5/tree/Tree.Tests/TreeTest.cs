using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using tree;

namespace Tree.Tests
{
    [TestClass]
    class TreeTest
    {
        [TestMethod]
        public void SumTest()
        {
            Summ sum = new Summ();
            sum.Number = -1;
            sum.Operation = '+';
            NumberClass num1 = new NumberClass();
            num1.Number = 8;
            num1.Operation = 'x';
            num1.LeftBranch = null;
            num1.RightBranch = null;
            NumberClass num2 = new NumberClass();
            num2.Number = 7;
            num2.Operation = 'x';
            num2.LeftBranch = null;
            num2.RightBranch = null;
            sum.LeftBranch = num1;
            sum.RightBranch = num2;
            Assert.AreEqual(15, sum.CountBranches());
        }

        [TestMethod]
        public void DifferenceTest()
        {
            Substruction dif = new Substruction();
            dif.Number = -1;
            dif.Operation = '-';
            NumberClass num1 = new NumberClass();
            num1.Number = 8;
            num1.Operation = 'x';
            num1.LeftBranch = null;
            num1.RightBranch = null;
            NumberClass num2 = new NumberClass();
            num2.Number = 7;
            num2.Operation = 'x';
            num2.LeftBranch = null;
            num2.RightBranch = null;
            dif.Left = num1;
            dif.Right = num2;
            Assert.AreEqual(1, dif.CountBranches());
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            Multiplication mul = new Multiplication();
            mul.Number = -1;
            mul.Operation = '*';
            NumberClass num1 = new NumberClass();
            num1.Number = 8;
            num1.Operation = 'x';
            num1.LeftBranch = null;
            num1.RightBranch = null;
            NumberClass num2 = new NumberClass();
            num2.Number = 7;
            num2.Operation = 'x';
            num2.LeftBranch = null;
            num2.RightBranch = null;
            mul.LeftBranch = num1;
            mul.RightBranch = num2;
            Assert.AreEqual(56, mul.CountBranches());
        }

        [TestMethod]
        public void DivisionTest()
        {
            Division div = new Division();
            div.Number = -1;
            div.Operation = '/';
            NumberClass num1 = new NumberClass();
            num1.Number = 8;
            num1.Operation = 'x';
            num1.LeftBranch = null;
            num1.RightBranch = null;
            NumberClass num2 = new NumberClass();
            num2.Number = 7;
            num2.Operation = 'x';
            num2.LeftBranch = null;
            num2.RightBranch = null;
            div.LeftBranch = num1;
            div.RightBranch = num2;
            Assert.AreEqual(1, div.CountBranches());
        }
    }
}
