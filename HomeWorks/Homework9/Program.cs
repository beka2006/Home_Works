using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        // N1 - კომპანია
        Employee emp1 = new Employee("John", "Doe", 30, "Developer", new int[] { 8, 8, 8, 8, 8, 0, 0 }); // 40 hours total
        Employee emp2 = new Employee("Alice", "Smith", 35, "Manager", new int[] { 9, 9, 9, 9, 9, 5, 0 }); // 50+ hours total (Bonus applicable)
        Employee emp3 = new Employee("Bob", "Johnson", 25, "Tester", new int[] { 8, 8, 8, 8, 8, 8, 8 }); // Weekend work included
        
        List<Employee> employeeList = new List<Employee> { emp1, emp2, emp3 };
        
        double totalPayroll = 0;
        Console.WriteLine("--- Employee Weekly Salaries ---");
        foreach (var emp in employeeList)
        {
            double salary = emp.CalculateWeeklySalary();
            totalPayroll += salary;
            Console.WriteLine($"{emp.FirstName} {emp.LastName} ({emp.Position}): ${salary:F2}");
        }
        
        Console.WriteLine($"Total Payroll for the Company: ${totalPayroll:F2}");
        
        Company localCompany = new Company(isLocal: true);
        double localTax = localCompany.CalculateStateTax(totalPayroll);
        Console.WriteLine($"State Tax for Local Company (18%): ${localTax:F2}");
        
        Company foreignCompany = new Company(isLocal: false);
        double foreignTax = foreignCompany.CalculateStateTax(totalPayroll);
        Console.WriteLine($"State Tax for Foreign Company (5%): ${foreignTax:F2}");
        
        
        // N2 - მასწავლებელი და სტუდენტი 
        
        // ახლა არის 2026: ჩაირიცახ 2024-ში, ასრულებს 2028-ში
        Student student1 = new Student("Beka", 20, 2024);
        
        // მასწავლებელი
        Teacher teacher1 = new Teacher("Smith", true);
        
        // რამდენი წელი დარჩა სტიდენტს?
        int yearsLeft = student1.GetYearsUntilGraduation();
        Console.WriteLine($"Student {student1.Name} has {yearsLeft} years left until graduation.");
        
        Console.WriteLine("\n--- Testing Subject Checks ---");
        
        
        for (int i = 0; i < 3; i++)
        {
            string chosenSubject = student1.GetRandomSubject();
            teacher1.CheckSubject(chosenSubject);
        }
    }
}

// ნ1-ის კლასები
class Company
{
    public bool IsLocal { get; set; }

    public Company(bool isLocal)
    {
        IsLocal = isLocal;
    }

    public double CalculateStateTax(double totalPayroll)
    {
        if (IsLocal)
        {
            return totalPayroll * 0.18; // 18% tax for local companies
        }
        else
        {
            return totalPayroll * 0.05; // 5% tax for foreign companies
        }
    }
}

class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public int Age { get; set; }
    public int[] WeeklyHours { get; set; }

    public Employee(string firstName, string lastName, int age, string position, int[] weeklyHours)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Position = position;
        WeeklyHours = weeklyHours;
    }

    public double CalculateWeeklySalary()
    {
        // განვსაზღვროთ  საათობრივი ანაზღაურება პოზიციის მიხედვით
        double baseRate = Position.ToLower() switch
        {
            "manager" => 40,
            "developer" => 30,
            "tester" => 20,
            _ => 10
        };

        double totalSalary = 0;
        int totalHoursWorked = 0;

        // გადავყვეთ 7 დღეს
        for (int day = 0; day < WeeklyHours.Length; day++)
        {
            int hoursToday = WeeklyHours[day];
            totalHoursWorked += hoursToday;

            // შევამოწმოთ შაბათი ან კვირა
            bool isWeekend = (day == 5 || day == 6);
            double currentRate = isWeekend ? baseRate * 2 : baseRate;

            if (hoursToday <= 8)
            {
                totalSalary += hoursToday * currentRate;
            }
            else
            {
                //ოვერთაიმი
                int regularHours = 8;
                int overtimeHours = hoursToday - 8;

                totalSalary += (regularHours * currentRate) + (overtimeHours * (currentRate + 5));
            }
        }

        // 20% თუ მეტია 50 საათზე
        if (totalHoursWorked > 50)
        {
            totalSalary *= 1.20;
        }

        return totalSalary;
    }
}

/////////////////////
/////////////////////
// N2 -ს კლასი დაა მეთოდები
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int EnrollmentYear { get; set; }

    private static Random random = new Random();
    private static string[] subjects = { "Math", "Chemistry", "English", "History" };

    public Student(string name, int age, int enrollmentYear)
    {
        Name = name;
        Age = age;
        EnrollmentYear = enrollmentYear;
    }

    public string GetRandomSubject()
    {
        int randomIndex = random.Next(subjects.Length);
        return subjects[randomIndex];
    }

    public int GetYearsUntilGraduation()
    {
        int currentYear = DateTime.Now.Year;
        int yearsPassed = currentYear - EnrollmentYear;
        int yearsLeft = 4 - yearsPassed;

        return yearsLeft < 0 ? 0 : yearsLeft;
    }
}

class Teacher
{
    public string Name { get; set; }
    public bool IsCertified { get; set; }

    private static Random random = new Random();

    public Teacher(string name, bool isCertified)
    {
        Name = name;
        IsCertified = isCertified;
    }

    public void CheckSubject(string subject)
    {
        Console.WriteLine($"Student chose: {subject}");

        switch (subject.ToLower())
        {
            case "math":
                int num1 = random.Next(1, 100);
                int num2 = random.Next(1, 100);
                Console.WriteLine($"Teacher {Name}: {num1} + {num2} = {num1 + num2}");
                break;

            case "chemistry":
                Console.WriteLine($"Teacher {Name}: The chemical formula for water is H2O.");
                break;

            case "english":
                Console.WriteLine($"Teacher {Name}: some text");
                break;

            default:
                Console.WriteLine($"Teacher {Name}: I am not competent in {subject}.");
                break;
        }
    }
}