using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stack.Tests
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void PushTest()
        {
            StackClass stack = new StackClass(); 
            stack.Push(7);
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void PopTest()
        {
            StackClass stack = new StackClass(); 
            stack.Pop(56);
            stack.Push(4);
            stack.Pop(4);
            Assert.IsTrue(stack.IsEmpty());
            stack.Push(4);
            stack.Pop(48);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void PrintTest()
        {
            StackClass stack = new StackClass();
            stack.Print();
        }
    }
}
