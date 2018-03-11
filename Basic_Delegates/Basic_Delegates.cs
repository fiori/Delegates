using System;

namespace BasicDelegates
{
    //Setting a delegate
    public delegate int MyDelegate(int arg1, int arg2);

    class Program
    {
        // Creating some basic functions
        static int Func1(int a, int b)
        {
            return (a + b);
        }
        static int Func2(int a, int b)
        {
            return (a * b);
        }
        static int Func3(int a, int b)
        {
            return (a / b);
        }

        //Main Code 
        static void Main(string[] args)
        {
            //Initializing my delegate variable
            MyDelegate f = null;
            
            //Initializing my variable to give the user a choice, later used inside the switch
            int Choice = 0;

            //Message that shows to the user
            Console.WriteLine("1: For Sum \n2: For Multi\n3: For Div");
            
            //User input that is stored insided the variable Choice
            Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    f = Func1;
                    break;
                case 2:
                    f = Func2;
                    break;
                case 3:
                    f = Func3;
                    break;
                default:
                    break;
            }

            //If choice is less than 1 or bigger than 3 then, show the message wrong number
            if (Choice < 1 || Choice > 3)
            {
                Console.WriteLine("Wrong Number.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Insert the First Number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert the Second Number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                //Here is where the delegate shines. Using the variable we created named F and we pass the functions. 
                //If the choice was 1 the f is going to execute the following code:
                //Console.WriteLine("The Total amount is:" + Func1(num1, num2).ToString());
                //If the choice was 2 the f is going to execute the following code:
                //Console.WriteLine("The Total amount is:" + Func2(num1, num2).ToString());
                //If the choice was 3 the f is going to execute the following code:
                //Console.WriteLine("The Total amount is:" + Func3(num1, num2).ToString());
                //Instead of writting all this code, we use a delegate
                Console.WriteLine("The Total amount is:" + f(num1, num2).ToString());
                Console.ReadKey();
            }

        }
    }
}
