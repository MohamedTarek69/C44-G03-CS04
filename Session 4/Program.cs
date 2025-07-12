using System.Diagnostics;
using System.Xml.Linq;

namespace Session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------Video 01 - conditional Statements------------------------------------
            #region Control Statements
            #region 1. Conditional Statements

            #region Example 01 [Year Quarter] - [If,Switch With Numeric type using Constant Pattern]
            //Console.Write("Please Enter A Month Number Existed in 1st Quarter : ");
            //int MonthNumber;
            //bool Flage = int.TryParse(Console.ReadLine(), out MonthNumber);

            #region if else
            //if (MonthNumber == 1)
            //    Console.WriteLine("Month is Jan");
            //else if (MonthNumber == 2)
            //    Console.WriteLine("Month is Feb");
            //else if (MonthNumber == 3)
            //    Console.WriteLine("Month is Mar");
            //else
            //    Console.WriteLine("Invalid Month Number");
            #endregion

            #region switch
            //jump table
            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Month is Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Month is Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Month is Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Month Number");
            //        break;
            //}
            #endregion

            #endregion

            #region Example 02[Student Age] - [If, Switch With Numeric type using Relational Pattern]
            /// Age is greater than 22 => Student Age Is greater than 22
            /// Age is Less than 22 => Student Age Is Less than 22
            /// Age is 22 => Student Age is 22

            //Console.Write("Please Enter Student Age : ");
            //int.TryParse(Console.ReadLine(), out int age);

            #region if else
            //if (age > 22)
            //    Console.WriteLine("Student Age Is greater than 22 ");
            //else if (age < 22)
            //    Console.WriteLine("Student Age Is Less than 22");
            //else
            //    Console.WriteLine("Student Age is 22");
            #endregion

            #region switch
            //switch (age)
            //{
            //    case >22:
            //        Console.WriteLine("Student Age Is greater than 22 ");
            //        break;
            //    case <22:
            //        Console.WriteLine("Student Age Is Less than 22");
            //        break;
            //    default:
            //        Console.WriteLine("Student Age is 22");
            //        break;
            //}
            #endregion

            #endregion

            #region Example 03[Student Name] - [If, Switch With String type]
            /// name = Omar => Hello Omar
            /// name = May => Hello May
            /// name = Aliaa => Hello Aliaa

            //Console.Write("Enter Student Name : ");
            //string name = Console.ReadLine() ?? "No Name Entered";

            #region if else
            //if (name == "Omar")
            //    Console.WriteLine("Hello Omar ");
            //else if (name == "May")
            //    Console.WriteLine("Hello May ");
            //else if (name == "Aliaa")
            //    Console.WriteLine("Hello Aliaa ");
            #endregion

            #region switch
            //switch (name)
            //{
            //    case "Omar":
            //        Console.WriteLine("Hello Omar ");
            //        break;
            //    case "May":
            //        Console.WriteLine("Hello May ");
            //        break;
            //    case "Aliaa":
            //        Console.WriteLine("Hello Aliaa ");
            //        break;
            //}
            #endregion

            #endregion

            #endregion

            #endregion

        }
    }
}
