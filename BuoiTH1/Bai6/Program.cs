class Program
{
    static void Main(string[] args)
    {
        // Thiết lập lương cơ bản (dùng chung cho tất cả nhân viên)
        Employee.SetBasicSalary(1800000);
        // Nhập số nhân viên
        Console.Write("Nhap so luong nhan vien: ");
        int n = int.Parse(Console.ReadLine());
        //Tạo mảng nhân viên
        Employee[]employees = new Employee[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap thong tin nhan vien {i + 1}");
            employees[i] = new Employee();
            employees[i].Input();
        }
        Console.WriteLine("\n Danh sach nhan vien");
            for(int i = 0; i < n;i++)
        {
            employees[i].Display();
        }
        Console.ReadLine();
       
    }
}
