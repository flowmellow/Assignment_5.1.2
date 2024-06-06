/*
Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
Test Data :
Enter a number: 1234
Expected Output :
The sum of the digits of the number 1234 is : 10
*/

namespace Assignment_5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1234;
            int sum = SumOfDigits(number);
                   
            Console.WriteLine($"The sum of number {number} is: {sum}");
                        
        }

        static int SumOfDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        //static int SumOfDigits(int number)
        //{
        //    if (number == 0)
        //    {
        //        return 0;
        //    }
            
        //    return (number % 10) + SumOfDigits(number / 10);
        //}
    }
}
