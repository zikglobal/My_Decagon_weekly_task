using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    public class PrintTable
    {
        // declaration of variable

        int weightPoint;
        string remark;
        char grade;
        int gradeUnit;
        string courseCode;
        int courseUnit;
        int courseScore;
        int totalCourseUnitRegistered;
        int totalCourseUnitpassed;
        double totalWeightPoint;
        double gpa;
        string allInputTotal = "";

        public void mySolutions()
        {
            // ask the user to enter the number of course he/she wants to check
            Console.WriteLine("Enter Number of Course offered");

            string number = Console.ReadLine();
            int input;

            //asking the user to enter a number instesd of letters
            while (!int.TryParse(number, out input))
            {
                Console.WriteLine("Enter a Number");
                number = Console.ReadLine();
            }
            // asking the user to enter course & code, course unit and course score

            for (int i = 0; i < input; i++)

            {
                do
                {
                    Console.WriteLine("Enter Course & Code E.g CHM101,PHY102");
                    courseCode = Console.ReadLine();

                } while (!Regex.IsMatch(courseCode, @"^[A-z]{3}\d{3}$"));
                Console.WriteLine("Enter Course Unit From 1-5");
                courseUnit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Course Score");
                courseScore = Convert.ToInt32(Console.ReadLine());



                if (courseScore <= 39)
                {
                    grade = 'F';
                    gradeUnit = 0;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Fail";
                }
                else if (courseScore <= 44)
                {
                    grade = 'E';
                    gradeUnit = 1;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "pass";
                }
                else if (courseScore <= 49)
                {
                    grade = 'D';
                    gradeUnit = 2;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "pass";
                }
                else if (courseScore <= 59)
                {
                    grade = 'C';
                    gradeUnit = 3;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Good";
                }
                else if (courseScore <= 69)
                {
                    grade = 'B';
                    gradeUnit = 4;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Very Good";
                }
                else if (courseScore <= 100)
                {
                    grade = 'A';
                    gradeUnit = 5;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Excellent";
                }
                else Console.WriteLine("invalid score enter");

                allInputTotal += $"| {courseCode,-10} | {courseUnit,-10} | {grade,-9} | {gradeUnit,-9} | {weightPoint,-8} | {remark,-10} |\n";

                //calculating for total course unit registered,
                //total course unit passed, total weight point and GPA

                totalCourseUnitRegistered += courseUnit;
                if (gradeUnit != 'F')
                {
                    totalCourseUnitpassed += courseUnit;
                }

                totalWeightPoint += weightPoint;
                gpa = totalWeightPoint / totalCourseUnitRegistered;
            }

            // To display the result of our inputs in a tabler form.
            Console.WriteLine("|------------|------------|-----------|-----------|----------|------------|");
            Console.WriteLine("|COURSE CODE | COURSE UNIT| GRADE     |GRADE UNIT |WEIGHT PT |    REMARK  |");
            Console.WriteLine("|------------|------------|-----------|-----------|----------|------------|");
            Console.Write(allInputTotal);
            Console.WriteLine("|------------|------------|-----------|-----------|----------|------------|");
            Console.WriteLine($"Total Course Unit Registered is : {totalCourseUnitRegistered}");
            Console.WriteLine($"Total Course Unit Passed is : {totalCourseUnitpassed}");
            Console.WriteLine($"Total Weight Point is : {totalWeightPoint}");
            Console.WriteLine($"Your GPA is {gpa:F2}");
            Console.ReadKey();
        }
    }
}


//  public void GPAstats()
//  {





//  }







//  Program ogun = new Program();
//  ogun.mySolutions();

//Program gpas = new Program();
//gpas.GPAstats();




