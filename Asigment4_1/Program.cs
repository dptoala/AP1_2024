using System.ComponentModel;
using System.ComponentModel.Design;
using System.Net.Security;

namespace Asigment4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter the excercise option (odd number between 1 to 7): ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int sum1 = 0;
                    int sum2 = 0;
                    int sum3 = 0;
                    Console.WriteLine("Please enter number 1: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter number 2: ");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter number 3: ");
                    int num3 = int.Parse(Console.ReadLine());
                    sum1= num1 + num2;
                    sum2= num2 + num3;
                    sum3 = num1 + num3;
                    if (sum1 == num3)
                    {
                        Console.WriteLine("num3 is the sum of num 1 + num 2");
                    }
                    else if (sum2 == num1)
                    {
                        Console.WriteLine("num1 is the sum of num 2 + num 3");
                    }
                    else if (sum3 == num2)
                    {
                        Console.WriteLine("num2 is the sum of num 1 + num 3");
                    }
                    else { Console.WriteLine("No Solution"); }

                    break;
                case 3:
                    const int MAX_GRADE_F = 60;
                    const int MAX_GRADE_D = 70;
                    const int MAX_GRADE_C = 80;
                    const int MAX_GRADE_B = 90;

                    Console.Write("Please enter the student grade:");
                    int studentGrade = int.Parse(Console.ReadLine());
                    if (studentGrade < MAX_GRADE_F)
                    {
                        Console.WriteLine("Letter F");
                    }
                    else if (studentGrade < MAX_GRADE_D)
                    {
                        Console.WriteLine("Letter D");
                    }
                    else if (studentGrade < MAX_GRADE_C)
                    {
                        Console.WriteLine("Letter C");
                    }
                    else if (studentGrade < MAX_GRADE_B)
                    {
                        Console.WriteLine("Letter B");
                    }
                    else
                    { Console.WriteLine("Letter A"); }
                    
                    break;

                case 5:
                    Console.WriteLine("Excercise 5");
                    bool isHead1 = true;
                    bool isHead2 = true;
                    const int BOTH_HEADS = 10;
                    const int ONE_HEAD = 5;
                    Console.WriteLine("Please enter the results of the game:");

                    Console.WriteLine("The player 1 got a head?");
                    isHead1 = bool.Parse(Console.ReadLine());

                    Console.WriteLine("The player 2 got a head?");
                    isHead2 = bool.Parse(Console.ReadLine());

                    if (isHead1 && isHead2)
                    {
                        Console.WriteLine("Both players win " + BOTH_HEADS);
                    }
                    else if (isHead1)
                    {

                        Console.WriteLine("Player 1 wins " + ONE_HEAD);
                    }
                    else if (isHead2)
                    {
                        Console.WriteLine("Player 2 wins " + ONE_HEAD);
                    }
                    else { Console.WriteLine("Nobody wins"); }

                    break;
                case 7:
                    Console.Write("Please enter the side 1 of the triangle: ");
                    int side1 = int.Parse(Console.ReadLine());
                    Console.Write("Please enter the side 2 of the triangle: ");
                    int side2 = int.Parse(Console.ReadLine());
                    Console.Write("Please enter the side 3 of the triangle: ");
                    int side3 = int.Parse(Console.ReadLine());
                    if (side1 == side2 && side1 == side3)
                    {
                        Console.Write("The Triangle is Equilateral");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("The Triangle is Isosceles");
                    }
                    else { Console.WriteLine("The Triangle is Scalene"); }

                    break;
                default:
                    Console.WriteLine("Nothing");
                    break;

            }
            

        }
    }
}
