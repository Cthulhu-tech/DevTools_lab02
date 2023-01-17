using System;
using System.Collections;
using System.Collections.Generic;

namespace ProgramStack {
    public class Program
    {
        private static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>(5);

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Push(50);

            myStack.PrintStack();

        }

    }
    /// <summary>
    /// Hello this is **Stack** from *ProgramStack*
    /// </summary>
    public class Stack<T>
    {
        private readonly int MAX;
        private int top = -1;
        private T[] stack;
        /// <summary>
        /// This is a constructor
        /// </summary>
        /// <param name="Max">The value of the class</param>
        public Stack(int Max)
        {
            this.MAX = Max;
            this.stack = new T[this.MAX];
        }
        /// <summary>
        /// This is a push function (add element)
        /// </summary>
        /// <param name="data">The value of the stack</param>
        /// <returns>A bool</returns>
        public bool Push(T data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }
        /// <summary>
        /// This is a pop function (delete element and return this)
        /// </summary>
        /// <param name="data">The value of the stack</param>
        /// <returns>A you type</returns>
        public T Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return stack[top];
            }
            else
            {
                T value = stack[top--];
                return value;
            }
        }
        /// <summary>
        /// This is a PrintStack function (print all element in stack)
        /// </summary>
        /// <param name="data">The value of the stack</param>
        /// <returns>A you type</returns>
        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
            }
            Console.WriteLine("Items in the Stack are :");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}