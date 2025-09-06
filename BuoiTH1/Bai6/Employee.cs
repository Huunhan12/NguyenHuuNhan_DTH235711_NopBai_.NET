using System;

class Employee
{
    // ===== Thành phần dữ liệu =====
    private int id;
    private string name;
    private int yearOfBirth;
    private double salaryLevel;
    private static double basicSalary; // dùng chung cho mọi nhân viên

    // ===== Constructor =====
    public Employee() { }

    public Employee(int id, string name, int yearOfBirth, double salaryLevel)
    {
        this.id = id;
        this.name = name;
        this.yearOfBirth = yearOfBirth;
        this.salaryLevel = salaryLevel;
    }

    public int GetId()
    {
        return id;
    }

    public string GetName()
    {
        return name;
    }

    public int GetYearOfBirth()
    {
        return yearOfBirth;
    }

    public double GetIncome()
    {
        return salaryLevel * basicSalary;
    }

    public void SetSalaryLevel(double level)
    {
        salaryLevel = level;
    }

    public static void SetBasicSalary(double basic)
    {
        basicSalary = basic;
    }

    // ===== Nhập thông tin nhân viên =====
    public void Input()
    {
        Console.Write("Nhap ID: ");
        id = int.Parse(Console.ReadLine());

        Console.Write("Nhap ho ten: ");
        name = Console.ReadLine();

        Console.Write("Nhap nam sinh: ");
        yearOfBirth = int.Parse(Console.ReadLine());

        Console.Write("Nhap bac luong: ");
        salaryLevel = double.Parse(Console.ReadLine());
    }

    // ===== Hiển thị thông tin nhân viên =====
    public void Display()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Ten: " + name);
        Console.WriteLine("Nam sinh: " + yearOfBirth);
        Console.WriteLine("Luong co ban: " + basicSalary);
        Console.WriteLine("Thu nhap: " + GetIncome());
        Console.WriteLine("----------------------");
    }
}