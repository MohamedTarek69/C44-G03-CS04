namespace Session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number
            //Example
            //Input: 5
            //Output: 1, 2, 3, 4, 5

            //Retry:
            //Console.Write("Please enter a number: ");
            //int Number;
            //int.TryParse(Console.ReadLine(),out Number);
            //if (Number <= 0)
            //{
            //    Console.WriteLine("Please enter a positive integer");
            //    goto Retry;
            //}
            //else
            //{
            //    for (int i = 1; i <= Number; i++)
            //    {
            //        Console.Write(i);
            //        if (i < Number)
            //            Console.Write(", ");
            //    }
            //}

            #endregion

            #region Q2- Write a program that allows the user to insert an integer then print a multiplication table up to 12
            // Example
            // Input: 5
            // Output: 5 10 15 20 25 30 35 40 45 50 55 60

            //Retry:
            //    Console.Write("Please enter a number: ");
            //    int Number;
            //    int.TryParse(Console.ReadLine(), out Number);
            //    if (Number <= 0)
            //    {
            //        Console.WriteLine("Please enter a positive integer");
            //        goto Retry;
            //    }
            //    else
            //    {
            //        for (int i = 1; i <= 12; i++)
            //        {
            //            Console.Write(i*Number);
            //            if (i < 12)
            //                Console.Write(" ");
            //        }
            //    }
            #endregion

            #region Q3- Write a program that allows the user to insert a number then print all even numbers between 1 to this number
            // Example
            // Input: 15
            // Output: 2 4 6 8 10 12 14

            //Retry:
            //    Console.Write("Please enter a number: ");
            //    int Number;
            //    int.TryParse(Console.ReadLine(), out Number);
            //    if (Number <= 0)
            //    {
            //        Console.WriteLine("Please enter a positive integer");
            //        goto Retry;
            //    }
            //    else
            //    {
            //        for (int i = 0; i <= Number; i+=2)
            //        {
            //            if (i==0)
            //            {
            //                continue;
            //            }
            //            Console.Write(i);
            //            if (i < Number)
            //                Console.Write(" ");

            //        }
            //    }

            #endregion

            #region @4- Write a program that takes two integers then prints the power
            // Example
            // Input: 4 3
            // Output: 64 (since 4^3 = 4 * 4 * 4)

            //Retry:
            //    Console.Write("Please enter the first number: ");
            //    int Number1;
            //    int.TryParse(Console.ReadLine(), out Number1);
            //    Console.Write("Please enter the second number: ");
            //    int Number2;
            //    int.TryParse(Console.ReadLine(), out Number2);
            //    if (Number1 <= 0||Number2 <= 0)
            //    {
            //        Console.WriteLine("Please enter a positive integer");
            //        goto Retry;
            //    }
            //    else
            //    {
            //        double Result = Math.Pow(Number1,Number2);
            //        Console.WriteLine(Result);
            //    }

            #endregion

            #region @5- Write a program to enter marks of five subjects and calculate total, average and percentage
            // Example
            // Input: 95 76 58 90 89
            // Output: Total marks = 408
            //         Average Marks = 81
            //         Percentage = 81

            //int TotalMarks =0;
            //Console.WriteLine("Enter marks for five subjects:");
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"Subject {i}: ");
            //    int mark;
            //    int.TryParse(Console.ReadLine(),out mark);
            //    TotalMarks += mark;
            //}
            //double Avg = TotalMarks / 5.0;
            //double Perc = Avg;
            //Console.WriteLine($"Total marks = {TotalMarks}");
            //Console.WriteLine($"Average Marks = {Avg}");
            //Console.WriteLine($"Percentage = {Perc}");

            #endregion

            #region Q6- Write a program to allow the user to enter a string and print the REVERSE of it

            //Console.Write("Enter a string: ");
            //string str = Console.ReadLine();

            //string ReversedStr = "";
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    ReversedStr += str[i];
            //}
            //Console.WriteLine($"The reversec string is: {ReversedStr}");

            #endregion

            #region Q7- Write a program to allow the user to enter an int and print the REVERSED of it
            //int Number;
            //Console.Write("Enter an integer: ");
            //int.TryParse(Console.ReadLine(), out Number);
            //int ReversedNumber = 0;
            //while (Number != 0)
            //{
            //    int digit = Number % 10;
            //    ReversedNumber = ReversedNumber * 10 + digit;
            //    Number /= 10;
            //}
            //Console.WriteLine($"Reversed number: {ReversedNumber}");

            #endregion

            #region Q8- Write a program in C# Sharp to find prime numbers within a range of numbers
            //Test Data :
            //Input starting number of ranges: 1
            //Input ending number of range: 50

            //Expected Output :
            //The prime number between 1 and 50 are:
            //2 3 5 7 11 13 17 19 23 29 31 37 41 43 47


            //Console.Write("Enter the starting number of range: ");
            //int Start;
            //int.TryParse(Console.ReadLine(), out Start);
            //Console.Write("Enter the ending number of range: ");
            //int End;
            //int.TryParse(Console.ReadLine(), out End);
            //Console.WriteLine($"The prime numbers between {Start} and {End} are:");
            //for (int i = Start; i <= End; i++)
            //{
            //    if (i < 2) 
            //        continue;
            //    bool isPrime = true;
            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //Console.WriteLine();

            #endregion

            #region @9- Write a program in C# Sharp to convert a decimal number into binary without using an array
            //Test Data :
            //Enter a number to convert: 25
            //Expected Output :
            //The Binary of 25 is 11001.

            //Console.Write("Enter a decimal number to convert: ");
            //int DecimalNumber;
            //int.TryParse(Console.ReadLine(), out DecimalNumber);
            //int BinaryNumber = 0, Place = 1;
            //int temp = DecimalNumber;
            //while (temp > 0)
            //{
            //    int Reminder = temp % 2;
            //    BinaryNumber = BinaryNumber + Reminder * Place;
            //    Place *= 10;
            //    temp /= 2;
            //}
            //Console.WriteLine($"The Binary of {DecimalNumber} is {BinaryNumber}.");

            #endregion

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
