using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectTutorialExcercises
{
     class CSharpTestQuestions
    {
         public int CSharpTestQuestion01()
        {
            Console.WriteLine("First 10 natural numbers:");
            for (int i = 1; i<=10; i++)
            {
                Console.Write(i + "  ");
            }
            return 1;
        }
        public int CSharpTestQuestion02()
        {
            Console.WriteLine("The first 10 natural number is :");
            for (int i = 1;i<=10;i++)
            {
                Console.Write(i + "  ");
            }

            int sum = 0;
            
            for(int j = 1; j <= 10; j++) 
            {
                sum += j;

            }
            Console.WriteLine("\nThe sum is : " + sum);
            return 1;
        }

        public int CSharpTestQuestion03() 
        {
            int count = 10;
            int sum = 0;

            Console.WriteLine($"Enter {count} numbers:");

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter number {i}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }

            double average = (double)sum / count;

            Console.WriteLine($"Sum of the numbers: {sum}");
            Console.WriteLine($"Average of the numbers: {average}");

            return 1;
        }

        public int CSharpTestQuestion04()
        {
            Console.Write("Enter Numbers you want to calculate cube : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= number; i++)
            {
                int cube = i * i * i;
                Console.WriteLine("Number is : " + i + " and cube of the " + i + " is : " + cube);
            }

            return 1;
        }

        public int CSharpTestQuestion05()
        {
            Console.Write("Enter Rows You want to print : ");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
               
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            return 1;
        }

        public int CSharpTestQuestion06()
        {
            int count = 1;
            Console.Write("Enter Rows You want to print : ");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
               
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();
            }

            return 1;
        }

        public int CSharpTestQuestion07()
        {
            int count = 1;
            Console.Write("Enter Rows You want to print : ");
            int row = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= row; i++)
            {
                for(int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();
            }
            return 1;
        }

        public int CSharpTestQuestion08()
        {
            Console.Write("Enter Rows You want to print : ");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            return 1;

        }

        public int CSharpTestQuestion09()
        {
            Console.Write("Enter Rows You want to print : ");
            int row = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= row; i++)
            {
                for(int space = 1; space <= row-i; space++)
                {
                    Console.Write(" ");
                }

                for( int j = 1; j <= i; j++)
                {
                    Console.Write("*" + " ");
                }

                Console.WriteLine();
            }

            for(int i = row - 1; i >= 1; i--)
            {
                for(int space = 1; space <= row - i; space++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*" + " ");
                }

                Console.WriteLine();
            }
            return 1;

        }

        public int CSharpTestQuestion10()
        {
            char startChar = 'A';
            Console.Write("Enter Number of rows you want to print");
            int rows =  Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= rows; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(startChar + " ");
                    startChar++;
                }
                Console.WriteLine();
            }

            return 1;
        }

        public int CSharpTestQuestion11()
        {
            int num, i, counter, startingNumber, endingNumber;
            Console.Write("\n\n");
            Console.Write("Find the prime numbers within a range of numbers:\n");
            Console.Write("---------------------------------------------------\n\n");

            Console.Write("Input First Number You want to start from: "); 
            startingNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Starting Number You want to end from: ");
            endingNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("The prime numbers between " + startingNumber + " and " + endingNumber + " are : \n");

            for (num = startingNumber; num <= endingNumber; num++)
            {
                counter = 0; 

              
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        counter++; 
                        break;  
                    }
                }

             
                if (counter == 0 && num != 1)
                {
                    Console.Write(num + " ");
                }
            }
            Console.Write("\n");

            return 1;
        }

        public int CSharpTestQuestion12()
        {
            char grade;
            int score;

            Console.Write("Enter your test score: ");
            score = Convert.ToInt32(Console.ReadLine());

            if (score >= 90 && score <= 100)
            {
                grade = 'A';
            }   
            else if (score >= 80 && score < 89)
            {
                grade = 'B';
            }
            else if (score >= 70 && score < 79)
            {
                grade = 'C';
            }
            else if (score >= 60 && score < 69)
            {
                grade = 'D';
            }
            else if (score >= 0 && score < 59)
            {
                grade = 'F';
            }
            else
            {
                Console.WriteLine("Invalid score entered.");
                return 0;
            }

            Console.WriteLine("Your grade is:" + grade);

            return 1;
        }

        /* public int CSharpTestQuestion13()
        {
            char CalculateGrade(int score)
            {
                if (score >= 90 && score <= 100)
                    return 'A';
                else if (score >= 80 && score <= 89)
                    return 'B';
                else if (score >= 70 && score <= 79)
                    return 'C';
                else if (score >= 60 && score <= 69)
                    return 'D';
                else
                    return 'F';
            }

            
            string repeat;
            do
                
            {
                bool validInput = false;
                int numStudents = 0;

                while (!validInput)
                {
                    try
                    {
                        Console.Write("Enter the number of students: ");
                        numStudents = Convert.ToInt32(Console.ReadLine());
                        validInput = true;
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Invalid. Please Enter a number!");

                    }
                }

               
                int totalScore = 0;
                int highestScore = int.MinValue;
                int lowestScore = int.MaxValue;
                
                string name = "";
                int score = 0;
                
               
                for (int i = 1; i <= numStudents; i++)
                {
                    validInput = false;
                    while (!validInput)
                    {
                        try
                        {
                            Console.Write($"Enter name of student {i}: ");
                            name = Console.ReadLine();
                            if (string.IsNullOrEmpty(name))
                            {
                                throw new ArgumentException("Name cannot be empty");
                            }
                            validInput = true;
                        }
                        catch(ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    validInput = false;

                    while (!validInput)
                    {
                        try
                        {
                            Console.Write($"Enter score of student {i}: ");
                            score = Convert.ToInt32(Console.ReadLine());
                            validInput = true;
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Invalid. Please Enter score in number not in text");
                        }
                    }

                   

                    char grade = CalculateGrade(score);
                    Console.WriteLine($"Grade for {name}: {grade}");

                    totalScore += score;
                    if(score > highestScore)
                    {
                        highestScore = score;
                    }
                    if(score < lowestScore)
                    {
                        lowestScore = score;
                    }
                }

                double averageScore = (double)totalScore / numStudents;
                Console.WriteLine($"Average grade for the class: {CalculateGrade((int)averageScore)}");
                Console.WriteLine($"Highest grade in the class: {CalculateGrade(highestScore)}");
                Console.WriteLine($"Lowest grade in the class: {CalculateGrade(lowestScore)}");

                Console.Write("Do you want to input scores for another subject? (yes/no): ");
                repeat = Console.ReadLine();
            } while (repeat.ToLower() == "yes" || repeat.ToLower() == "y");
            return 1;
        } */

        public int CSharpTestQuestion13()
        {
            char CalculateGrade(int score)
            {
                if (score >= 90 && score <= 100)
                    return 'A';
                else if (score >= 80 && score <= 89)
                    return 'B';
                else if (score >= 70 && score <= 79)
                    return 'C';
                else if (score >= 60 && score <= 69)
                    return 'D';
                else
                    return 'F';
            }

            string repeat;
            do
            {
                Console.WriteLine("\n\t---------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine();    
                Console.WriteLine("\t\t\t\t\t\t\t\tC# Test Score Calculator");
                Console.WriteLine();
                Console.WriteLine("\t-----------------------------------------------------------------------------------------------------------------------\n");

                bool validInput = false;    
                int numStudents = 0;

                while (!validInput)
                {
                    try
                    {
                        Console.Write("\t\t\t\t\t\t\tEnter the number of students: ");
                        numStudents = Convert.ToInt32(Console.ReadLine());
                        validInput = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\t\t\t\t\t\t\tInvalid input. Please enter a number!");
                    }
                }

                Console.WriteLine();

                int totalScore = 0;
                int highestScore = int.MinValue;
                int lowestScore = int.MaxValue;

                for (int i = 1; i <= numStudents; i++)
                {
                    validInput = false;

                    string name = "";
                    int score = 0;

                    while (!validInput)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write($"\t\t\t\t\t\t\tEnter name of student {i}: ");
                            name = Console.ReadLine();
                            if (string.IsNullOrEmpty(name))
                            {
                                throw new ArgumentException("\t\t\t\t\t\t\tName cannot be empty");
                            }
                            validInput = true;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    validInput = false;

                    while (!validInput)
                    {
                        try
                        {
                            Console.Write($"\t\t\t\t\t\t\tEnter score of student {i}: ");
                            score = Convert.ToInt32(Console.ReadLine());
                            validInput = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\t\t\t\t\t\t\tInvalid input. Please enter the score as a number.");
                        }
                    }

                    char grade = CalculateGrade(score);
                    Console.WriteLine($"\t\t\t\t\t\t\tGrade for {name}: {grade}");

                    totalScore += score;

                    if (score > highestScore)
                        highestScore = score;

                    if (score < lowestScore)
                        lowestScore = score;
                }

                double averageScore = (double)totalScore / numStudents;

                Console.WriteLine("\n\t\t\t----------------------------------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t\t\t\tStatistics");
                Console.WriteLine();
                Console.WriteLine($"\t\t\t\t\t\t\t\tAverage grade for the class: {CalculateGrade((int)averageScore)}");
                Console.WriteLine();
                Console.WriteLine($"\t\t\t\t\t\t\t\tHighest grade in the class: {CalculateGrade(highestScore)}");
                Console.WriteLine();
                Console.WriteLine($"\t\t\t\t\t\t\t\tLowest grade in the class: {CalculateGrade(lowestScore)}");
                Console.WriteLine();
                Console.WriteLine("\t\t\t-----------------------------------------------------------------------------------------------\n");
                Console.WriteLine();

                Console.Write("\t\t\t\t\t\tDo you want to input scores for another subject? (yes/no): ");
                repeat = Console.ReadLine();
            } while (repeat.ToLower() == "yes" || repeat.ToLower() == "y");
            return 1;
        }


    }
}
