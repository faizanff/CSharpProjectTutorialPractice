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

    }
}
