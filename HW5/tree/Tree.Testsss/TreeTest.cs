using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tree.Testsss
{
    [TestClass]
    public class TreeTest
    {
        [TestMethod]
        public void SumTest()
        {
            tree.Summ sum = new tree.Summ();
            sum.Number = -1;
            sum.Operation = '+';
            tree.NumberClass num1 = new tree.NumberClass();
            num1.Number = 8;
            num1.Operation = 'x';
            num1.LeftBranch = null;
            num1.RightBranch = null;
            tree.NumberClass num2 = new tree.NumberClass();
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
            tree.Substruction dif = new tree.Substruction();
            dif.Number = -1;
            dif.Operation = '-';
            tree.NumberClass num1 = new tree.NumberClass();
            num1.Number = 8;
            num1.Operation = 'x';
            num1.LeftBranch = null;
            num1.RightBranch = null;
            tree.NumberClass num2 = new tree.NumberClass();
            num2.Number = 7;
            num2.Operation = 'x';
            num2.LeftBranch = null;
            num2.RightBranch = null;
            dif.LeftBranch = num1;
            dif.RightBranch = num2;
            Assert.AreEqual(1, dif.CountBranches());
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            tree.Multiplication mul = new tree.Multiplication();
            mul.Number = -1;
            mul.Operation = '*';
            tree.NumberClass num1 = new tree.NumberClass();
            num1.Number = 8;
            num1.Operation = 'x';
            num1.LeftBranch = null;
            num1.RightBranch = null;
            tree.NumberClass num2 = new tree.NumberClass();
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
            tree.Division div = new tree.Division();
            div.Number = -1;
            div.Operation = '/';
            tree.NumberClass num1 = new tree.NumberClass();
            num1.Number = 8;
            num1.Operation = 'x';
            num1.LeftBranch = null;
            num1.RightBranch = null;
            tree.NumberClass num2 = new tree.NumberClass();
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
