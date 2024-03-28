using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectTutorialExcercises
{
    static class Program
    {
        static void Main(string[] args)
        {

            CSharpTestQuestions myObj = new CSharpTestQuestions();
            /*naming conventions
                1. camel case sLimated
                2. pascal case Liscal
            */

            #region [This Region Belongs to Print CSharp Output]
            //Program.CSharpOutputPrint();
            #endregion
            #region [This region Belongs to See CSharp Single and MultiLine Comment]
            //Program.CSharpSingleMultiLineComment();
            #endregion
            #region [This region Belongs to practice int Variable through small example]
            //Program.CSharpIntVariablePractice();
            #endregion
            #region[This region Belongs to practice double Variable through small example]
            //Program.CSharpDoubleVariablePractice();
            #endregion
            #region[This region Belongs to practice Char Variable through small example]
            //Program.CSharpCharVariablePractive();
            #endregion
            #region[This region Belongs to practice Bool Variable through small example]
            //Program.CSharpBoolVariablePractice();
            #endregion
            #region[This region Belongs to practice String Variable through small example]
            //Program.CSharpStringVariablePractice();
            #endregion
            #region[This region Belongs to practice Implicit Casting through small example]
            //Program.CSharpImplicitCastingPractice();
            #endregion
            #region[This region Belongs to practice Explicit Casting through small example]
            //Program.CSharpExplicitCastingPractice();
            #endregion
            #region[This region Belongs to practice User Input through small example]
            //Program.CSharpUserInputPractice();
            #endregion
            #region[This region Belongs to practice Arthmetic operator through small example]
            //Program.CSharpArthmeticOperatorsPractice();
            #endregion
            #region[This region Belongs to practice Comparison operator through small example]
            //Program.CSharpComparisonOperatorsPractice();
            #endregion
            #region[This region Belongs to practice Logical operator through small example]
            //Program.CSharpLogicalOperatorsPractice();
            #endregion
            #region[This region Belongs to practice Assignment operator through example]
            //Program.CSharpAssignmentOperatorsPractice();
            #endregion
            #region[This reigon Belongs to practice Increment and Decrement  operator through example]
            //Program.CSharpIncrementandDecrementPractice();
            #endregion
            #region[This region Belongs to practice Strings through small example]
            //Program.CSharpStringsPractice();
            #endregion
            #region[This region Belongs to practice Booleans through small example]
            //Program.CSharpBooleansPractice();
            #endregion
            #region[This region Belongs to practice If Else Statement through small example]
            //Program.CSharpIfElseStatementPractice();
            #endregion
            #region[This region Belongs to practice Switch Statement through small example]
            //Program.CSharpSwitchStatementPractice();
            #endregion
            #region[This region Belongs to practice While Loop through small example]
            //Program.CSharpWhileLoopPractice();
            #endregion
            #region[This region Belongs to practice Do While Loop through small example]
            //Program.CSharpDoWhileLoop();
            #endregion
            #region[This region Belongs to practice For Loop through small example]
            //Program.CSharpForLoopPractice();
            #endregion
            #region[This region Belongs to practice Arrays through small example]
            //Program.CSharpArrayPractice();
            #endregion
            #region[This region Belongs to practice Two Dimensional Arrays through small example]
            //Program.CSharpTwoDimensionalArrayPractice();
            #endregion


            #region[This region Belongs to pratice test of Question No 01]
            //myObj.CSharpTestQuestion01();
            #endregion
            #region[This region Belongs to practice test of Question No 02]
            //myObj.CSharpTestQuestion02();
            #endregion
            #region[This region Belongs to practice test of Question 03]
            //myObj.CSharpTestQuestion03();
            #endregion
            #region[This region Belongs to practice test of Question No 04]
            //myObj.CSharpTestQuestion04();
            #endregion
            #region[This region Belongs to practice test of Question No 05]
            //myObj.CSharpTestQuestion05();
            #endregion
            #region[This region Belongs to practice test of Question No 06]
            //myObj.CSharpTestQuestion06();
            #endregion
            #region[This region Belongs to practice test of Question No 07]
            //myObj.CSharpTestQuestion07();
            #endregion
            #region[This region Belongs to practice test of Question No 08]
            //myObj.CSharpTestQuestion08();
            #endregion
            #region[This region Belongs to practice test of Question No 09]
            //myObj.CSharpTestQuestion09();
            #endregion
            #region[This region Belongs to practice test of Question No 10]
            //myObj.CSharpTestQuestion10();
            #endregion
            #region[This region Belongs to practice test of Question No 11]
            //myObj.CSharpTestQuestion11();
            #endregion
            #region[This region Belongs to practice test of Question No 12]
            //myObj.CSharpTestQuestion12();
            #endregion
            #region[This region Belongs to practice test of Question No 13]
            myObj.CSharpTestQuestion13();
            #endregion



        }

        private static int CSharpOutputPrint()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");
            Console.WriteLine(3+3);
            return 1;
       }

        private static int CSharpSingleMultiLineComment()
        {

            //single Line comment using these slashes

           /* Multi lines comment The code below will print the words Hello World
           to the screen, and it is amazing */

           Console.WriteLine("Hello World");
            return 1;
        }
        private static int CSharpIntVariablePractice() 
        {
            int num1 = 10;
            int num2 = 5;

            int sum = num1 + num2;
            int minus = num1 - num2;
            int multiply = num1 * num2;
            int divide  = num1 / num2;
            int reminder= num1 % num2;

            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Minus : " + minus);
            Console.WriteLine("Multiply : " + multiply);
            Console.WriteLine("Divide : " + divide);
            Console.WriteLine("Reminder : " + reminder);

            return 1;
        }
        private static int CSharpDoubleVariablePractice()
        {
            double num1 = 10.5;
            double num2 = 3.5;

            double sum = num1 + num2;
            double minus = num1 - num2;
            double multiply = num1 * num2;
            double divide = num1 / num2;
            double reminder = num1 % num2;

            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Minus : " + minus);
            Console.WriteLine("Multiply : " + multiply);
            Console.WriteLine("Divide : " + divide);
            Console.WriteLine("Reminder : " + reminder);

            return 1;

        }

        private static int CSharpCharVariablePractive ()
        {
            char firstLetter = 'A';
            char secondLetter = 'B';

            
            Console.WriteLine("First Letter: " + firstLetter);
            Console.WriteLine("Second Letter: " + secondLetter);

           
            bool isEqual = firstLetter == secondLetter;
            bool isUpperCase = char.IsUpper(firstLetter);
            bool isLowerCase = char.IsLower(secondLetter);

            
            Console.WriteLine("Are the letters equal? " + isEqual);
            Console.WriteLine("Is the first letter upper case? " + isUpperCase);
            Console.WriteLine("Is the second letter lower case? " + isLowerCase);

            return 1;
        }

        private static int CSharpBoolVariablePractice()
        {
            bool isSunny = true;
            bool isRaining = false;

            Console.WriteLine("Is it sunny? " + isSunny);
            Console.WriteLine("Is it raining? " + isRaining);

            bool isGoodWeather = isSunny && !isRaining;
            bool isBadWeather = isRaining || !isSunny;

            Console.WriteLine("Is it good weather? " + isGoodWeather);
            Console.WriteLine("Is it bad weather? " + isBadWeather);

            return 1;
        }

        private static int CSharpStringVariablePractice()
        {
            string firstName = "Faizan";
            string lastName = "Ahmed";

            string fullName = firstName + " " + lastName;

            
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Full Name: " + fullName);

           
            int fullNameLength = fullName.Length;
            Console.WriteLine("Length of Full Name: " + fullNameLength);

            char firstCharacter = fullName[0];
            Console.WriteLine("First Character of Full Name: " + firstCharacter);

            return 1;
        }

        private static int CSharpImplicitCastingPractice()
        {
            int intValue = 10;
            double doubleValue = intValue;

            Console.WriteLine("Implicit Conversion:");
            Console.WriteLine("Integer Value: " + intValue);
            Console.WriteLine("Double Value: " + doubleValue);
            return 1;

        }

        private static int CSharpExplicitCastingPractice()
        {
            double doubleValue = 15.75;
            int intValue = (int)doubleValue;

            Console.WriteLine("Explicit Conversion:");
            Console.WriteLine("Double Value: " + doubleValue);
            Console.WriteLine("Integer Value: " + intValue);

            return 1;
        }

        private static int CSharpUserInputPractice()
        {
            Console.WriteLine("Please enter your name:");

            string userName = Console.ReadLine();

            Console.WriteLine("Hello, " + userName + "!");

            Console.WriteLine("Please enter your age:");

            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a child.");
            }

            return 1;
        }

        private static int CSharpArthmeticOperatorsPractice()
        {
            int num1 = 10;
            int num2 = 5;
            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine("num1 + num2 = " + (num1 + num2));
            Console.WriteLine("num1 - num2 = " + (num1 - num2));
            Console.WriteLine("num1 * num2 = " + (num1 * num2));
            Console.WriteLine("num1 / num2 = " + (num1 / num2));
            Console.WriteLine("num1 % num2 = " + (num1 % num2));

            return 1;
        }

        private static int CSharpComparisonOperatorsPractice()
        {


            int num1 = 10;
            int num2 = 5;
            Console.WriteLine("\nRelational Operators:");
            Console.WriteLine("num1 > num2 is " + (num1 > num2));
            Console.WriteLine("num1 < num2 is " + (num1 < num2));
            Console.WriteLine("num1 >= num2 is " + (num1 >= num2));
            Console.WriteLine("num1 <= num2 is " + (num1 <= num2));
            Console.WriteLine("num1 == num2 is " + (num1 == num2));
            Console.WriteLine("num1 != num2 is " + (num1 != num2));

            return 1;
        }

        private static int CSharpLogicalOperatorsPractice()
        {
            int num1 = 10;
            Console.WriteLine("Num1 && Num2 result is " + (num1 < 5 && num1 > 5));
            Console.WriteLine("Num1 || Num2 result is " + (num1 < 5 || num1 > 5 ));
            Console.WriteLine("!Num and Num2 result is " + (!(num1 < 5 || num1 > 5)));

            return 1;
        }

        private static int CSharpAssignmentOperatorsPractice()
        {
            int result = 0;
            Console.WriteLine("\nAssignment Operators:");
            Console.WriteLine("Initial Value of result: " + result);
            result += 5; 
            Console.WriteLine("After result += 5, result = " + result);
            result -= 3;
            Console.WriteLine("After result -= 3, result = " + result);
            result *= 2;
            Console.WriteLine("After result *= 2, result = " + result);
            result /= 4;
            Console.WriteLine("After result /= 4, result = " + result);
            result %= 3;
            Console.WriteLine("After result %= 3, result = " + result);

            return 1;
        }

        private static int CSharpIncrementandDecrementPractice()
        {
            int value = 5;
            Console.WriteLine("\nIncrement and Decrement Operators:");
            Console.WriteLine("Initial Value: " + value);
            value++;
            Console.WriteLine("After value++, value = " + value);
            value--;
            Console.WriteLine("After value--, value = " + value);

            return 1;
        }

        private static int CSharpStringsPractice()
        {
            string firstName = "Faizan";
            string lastName = "Ahmed";

            //interpolation fullname
            string fullName = $"{firstName} {lastName}!";

            // Concatenation
            string messageConcatenation = "Hello, " + fullName + "!";

            // String interpolation
            string messageInterpolation = $"Hello, {fullName}!";

            // Accessing strings
            char firstChar = fullName[0];
            char lastChar = fullName[fullName.Length - 1];

            // Using special characters
            string specialCharacters = "Special Characters: \n\tBackslash: \\ \n\tDouble Quotes: \" \n\tSingle Quotes: \' \n\tTab: \t";

            Console.WriteLine("Concatenation using + operator:");
            Console.WriteLine(messageConcatenation);
            Console.WriteLine("\nString interpolation:");
            Console.WriteLine(messageInterpolation);
            Console.WriteLine("\nAccessing strings:");
            Console.WriteLine($"First Character: {firstChar}");
            Console.WriteLine($"Last Character: {lastChar}");
            Console.WriteLine("\nUsing special characters:");
            Console.WriteLine(specialCharacters);

            return 1;
        }

        private static int CSharpBooleansPractice()
        {
            bool isSunny = true;
            bool isRaining = false;

            Console.WriteLine($"Is it sunny? {isSunny}");
            Console.WriteLine($"Is it raining? {isRaining}");

            Console.WriteLine($"Is it sunny and not raining? {isSunny && !isRaining}");

            Console.WriteLine($"Is it sunny or raining? {(isSunny || isRaining ? "Yes" : "No")}");

            return 1;
        }
        private static int CSharpIfElseStatementPractice()
        {
            double result = 0;
            Console.WriteLine("Enter First Number You want to Calculate");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second number You want to Calculate");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");

            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                result = num1 + num2;
            }
            else if(choice == 2)
            {
                result = num1 - num2;
            }
            else if(choice == 3)
            {
                result = num1 * num2;
            }
            else if( choice == 4)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid operation.");
            }

            Console.WriteLine("Result: " + result);

            return 1;
        }

        private static int CSharpSwitchStatementPractice()
        {
            do
            {
                
                double result = 0;
                Console.WriteLine("Enter First number you want to calculate");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Second number you want to calculate");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");

                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {

                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 - num2;
                        break;
                    case 3:
                        result = num1 + num2;
                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");

                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid operation.");
                        break;

                }

                Console.WriteLine("Result is : " + result);

                Console.Write("Do you want to calculate another operation? (yes/no): ");
                string choice = Console.ReadLine().ToLower();

                if (choice != "yes" && choice != "y")
                {
                    break;
                }

            } while (true);

            Console.WriteLine("Thank you for using the Calculator Program!");


            return 1;
        }

        private static int CSharpWhileLoopPractice()
        {
            int count = 1;

            Console.WriteLine("Printing numbers from 1 to 5 using a while loop:");
            while (count <= 5)
            {
                Console.WriteLine(count);
                count++;
            }

            int sum = 0;
            count = 1;
            while (count <= 10)
            {
                sum += count;
                count++;
            }
            Console.WriteLine("\nSum of numbers from 1 to 10: " + sum);
         
            return 1;
        }

        private static int CSharpDoWhileLoop()
        {
            int count = 0;
            Console.WriteLine("Printing numbers from 1 to 5 using a while loop:");
            do
            {
                Console.WriteLine(count);
                count++;

            } while (count <= 5);

            int sum = 0;
            count = 1;

            do
            {

                sum += count;
                count++;

            } while (count <= 10);

            Console.WriteLine("\nSum of numbers from 1 to 10: " + sum);
            return 1;
        }

        private static int CSharpForLoopPractice()
        {
            Console.WriteLine("Printing numbers from 1 to 5 using a while loop:");
            for(int i = 1; i<=5; i++)
            {
                Console.WriteLine(i);
            }

            int sum = 0;
            Console.WriteLine("\nFinding sum of 1 to 10 numbers using for loop");

            for(int j = 1; j <= 10; j++)
            {
                sum+= j;
            }
            Console.WriteLine("Sum of numbers from 1 to 10: " + sum);
            return 1;

        }
        private static int CSharpArrayPractice()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Accessing elements of the array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element at index " + i + ": " + numbers[i]);
            }

            numbers[2] = 10;

            Console.WriteLine("\nModified element at index 2: " + numbers[2]);

            string[] fruits = new string[3];
            fruits[0] = "Apple";
            fruits[1] = "Banana";
            fruits[2] = "Orange";

            Console.WriteLine("\nAccessing elements of the string array:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            return 1;
        }

        private static int CSharpTwoDimensionalArrayPractice()
        {
            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Elements of the 2D array:");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
            }
            return 1;
        }
    }
}
