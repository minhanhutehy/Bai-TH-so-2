using System;
class Stack
{
    private int top;
    private int[] s;
    public Stack()
    {
        top = -1;
        s = new int[20];
    }
    public Stack(int n)
    {
        top = -1;
        s = new int[n];
    }
    public bool Full()
    {
        return top == s.Length - 1;
    }
    public bool Empty()
    {
        return top == -1;
    }
    public void Push(int x)
    {
        if (Full()) Console.WriteLine("Stack day");
        else s[++top] = x;
    }
    public int Pop()
    {
        if (Empty()) throw new Exception("Stack rong");
        else
        {
            int x = s[top--];
            return x;
        }
    }
}
class App
{
    static void Main()
    {
        int n;
        Stack t = new Stack();
        Console.Write("Nhap vao so nguyen n:"); n = int.Parse(Console.ReadLine());
        while (n != 0)
        {
            t.Push(n % 2);
            n = n / 2;
        }
        Console.Write("So nhi phan tuong ung:");
        while (!t.Empty())
            Console.Write(t.Pop());
        Console.ReadKey();
    }
}
