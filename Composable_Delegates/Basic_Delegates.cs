using System;

namespace BasicDelegates
{
    //Setting a delegate
    public delegate void MyDelegate(int arg1, int arg2);

    class Program
    {
        // Creating some basic functions
        static void Func1(int a, int b)
        {
            Console.WriteLine("Soma:" + (a + b));
        }
        static void Func2(int a, int b)
        {
            Console.WriteLine("Multi:" + (a * b));
        }
        static void Func3(int a, int b)
        {
            Console.WriteLine("Div:" + (a / b));
        }

        //Main Code 
        static void Main(string[] args)
        {
            //Initializing my delegate variable
            MyDelegate f1 = Func1;
            MyDelegate f2 = Func2;
            MyDelegate f3 = Func3;
            MyDelegate f1f2f3 = f1 + f2 + f3;

            f1f2f3(10, 10);
            Console.ReadKey();


        }
    }
}
