using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalc
{
    public class Calc
    {
        private StackInterface stack;


        public Calc()
        {
            stack = new ListStack();  //I don't know what is wrong
            //stack = new ArrayStack();
        }


        public void Push(int tmp)
        {
            stack.Push(tmp);
        }

        public void Summ()
        {
            int tmp1 = stack.Pop();
            int tmp2 = stack.Pop();
            stack.Push(tmp1 + tmp2);
        }

        public void difference()
        {
            int tmp1 = stack.Pop();
            int tmp2 = stack.Pop();
            stack.Push(tmp1 - tmp2);
        }

        public void Multiply()
        {
            int tmp1 = stack.Pop();
            int tmp2 = stack.Pop();
            stack.Push(tmp1 * tmp2);
        }

        public void Divide()
        {
            int tmp1 = stack.Pop();
            int tmp2 = stack.Pop();
            stack.Push(tmp1 / tmp2);
        }

        public int Result()
        {
            return stack.Pop();
        }
    }
}
