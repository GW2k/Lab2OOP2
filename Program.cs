using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;

namespace Lab2OOP2;

class Program
{
    static void Main()
    {
        string filePath = "../../../employees.txt";
        List<Employee> employees = new List<Employee>();
        List<double> wages = new List<double>();
        List<double> salyr = new List<double>();
        string[] employeeDataLines = File.ReadAllLines(filePath);
        foreach (var employee in employeeDataLines)
        {
            if (employee.StartsWith("0", StringComparison.Ordinal) ||
                employee.StartsWith("1", StringComparison.Ordinal) ||
                employee.StartsWith("2", StringComparison.Ordinal) ||
                employee.StartsWith("3", StringComparison.Ordinal) ||
                employee.StartsWith("4", StringComparison.Ordinal))
            {
                // salaried
                string[] employeeDater = employee.Split(":");
                long sinnum;
                double salaryNum;
                sinnum = long.Parse(employeeDater[4]);
                salaryNum = double.Parse(employeeDater[7]);
                Salaried localEmployee = new Salaried(employeeDater[0], employeeDater[1], employeeDater[2],
                    employeeDater[3], sinnum, employeeDater[5], employeeDater[6], salaryNum);
                employees.Add(localEmployee);
                salyr.Add(localEmployee.GetPay());
                
            }
            else if (employee.StartsWith("5", StringComparison.Ordinal) ||
                     employee.StartsWith("6", StringComparison.Ordinal) ||
                     employee.StartsWith("7", StringComparison.Ordinal))
            {
                // waged
                string[] employeeDater = employee.Split(":");
                long sinnum;
                double rate;
                double hours;
                rate = double.Parse(employeeDater[7]);
                hours = double.Parse(employeeDater[8]);
                sinnum = long.Parse(employeeDater[4]);
                Wages localEmployee = new Wages(employeeDater[0], employeeDater[1], employeeDater[2],
                    employeeDater[3], sinnum, employeeDater[5], employeeDater[6], rate, hours);
                employees.Add(localEmployee);
                
                wages.Add(localEmployee.GetPay());
            }
            else if (employee.StartsWith("8", StringComparison.Ordinal) ||
                     employee.StartsWith("9", StringComparison.Ordinal))
            {
                // part time
                string[] employeeDater = employee.Split(":");
                long sinnum;
                double hours;
                double rate;
                hours = double.Parse(employeeDater[7]);
                rate = double.Parse(employeeDater[8]);
                sinnum = long.Parse(employeeDater[4]);
                PartTime localEmployee = new PartTime(employeeDater[0], employeeDater[1], employeeDater[2],
                    employeeDater[3], sinnum, employeeDater[5], employeeDater[6], rate, hours);
                employees.Add(localEmployee);
            }
        }
        // Weekly Wealthiest Wage
        wages.Sort();
        double richest = wages.Last();
        Console.WriteLine($"Elle Driver makes: ${richest} a week");
        //
        salyr.Sort();
        double leastRichest = salyr.First();
        Console.WriteLine($"Samuel Ludlow III makes ${leastRichest} the least salaried employee");

    }
}

