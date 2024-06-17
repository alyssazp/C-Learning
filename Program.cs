using System;

namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Basic Calculator");
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Exit");

        
        Console.Write("Enter operation number :");
        int calnum = Convert.ToInt32(Console.ReadLine());

        if (calnum ==5){
            Console.WriteLine("Exiting!");
            return;
        
        }

        Console.Write("Enter first number :");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter another number :");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = MathCalculation(calnum,num1,num2);
        if (!double.IsNaN(result)){
            Console.WriteLine($"Result is {result}");

        } 

        Console.ReadLine();
         }

        static double MathCalculation(int calnum,double num1, double num2)
        {
            if(calnum==1)
            {
                return (num1+num2);
            }
            else if(calnum==2)
            {
                return (num1-num2);
            } 
            else if(calnum==3)
            {
                return (num1*num2);
            } 
            else if(calnum==4)
            {
                if(num2==0){
                    Console.WriteLine("Error:Division by zero");
                    return double.NaN;
                }
                else {
                    return (num1/num2);
                }
            } 
            else 
            {
                Console.WriteLine("Can you try another number?");
                return double.NaN;
            }

        }


    }
 }
