// 3.6 Creating properties

class Employee
{
    // create attributes
    public int employeeNumber;
    public string employeeName; 

    static void Main()
    {
        Employee developer = new Employee();
        developer.employeeNumber = 1;
        developer.employeeName = "Haven Eldebaque";
        Console.WriteLine("****** Employee Staff ******");
        Console.WriteLine(developer.employeeNumber);
        Console.WriteLine(developer.employeeName);
    }
}
