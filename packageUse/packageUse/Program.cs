using Wintellect.PowerCollections;

internal class Program
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

internal class Stack<T>
{
    private readonly int MAX;
    private int top = 0;
    private T[] stack;

    public Stack(int Max)
    {
        this.top = -1;
        this.MAX = Max;
        this.stack = new T[this.MAX];
    }
    internal bool Push(T data)
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
    internal T Pop()
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
    internal void PrintStack()
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

