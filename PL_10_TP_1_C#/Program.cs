using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(new ThreadStart(Method1));
        Thread thread2 = new Thread(new ThreadStart(Method2));
        Thread thread3 = new Thread(new ThreadStart(Method3));
        Thread thread4 = new Thread(new ThreadStart(Method4));
        
        thread1.Start();
        thread2.Start();
        thread3.Start();
        thread4.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();
        thread4.Join();

        Console.WriteLine("All threads completed.");
    }

    static void Method1()
    {
        Console.WriteLine("Executing Method1 on thread: " + Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(1000);
    }

    static void Method2()
    {
        Console.WriteLine("Executing Method2 on thread: " + Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(1000);
    }

    static void Method3()
    {
        Console.WriteLine("Executing Method3 on thread: " + Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(1000);
    }

    static void Method4()
    {
        Console.WriteLine("Executing Method4 on thread: " + Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(1000);
    }
}