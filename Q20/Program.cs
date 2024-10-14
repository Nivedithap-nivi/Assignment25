namespace Q20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Permanent");
            Console.WriteLine("2. Temporary");
            Console.WriteLine("Choose the employee type");

            int empType = int.Parse(Console.ReadLine());

            if (empType == 1)
            {
                Permanent permanentEmployee = new Permanent();
                Console.WriteLine("Enter the employee id");
                permanentEmployee.Id = Console.ReadLine();
                if (permanentEmployee.ValidateEmployeeId())
                {
                    Console.WriteLine("Enter the name");
                    permanentEmployee.Name = Console.ReadLine();
                    Console.WriteLine("Enter basic pay");
                    permanentEmployee.BasicPay = double.Parse(Console.ReadLine());
                    permanentEmployee.SalaryCalculation();
                    Console.WriteLine($"Employee id : {permanentEmployee.Id}, Name : {permanentEmployee.Name}, Salary : {permanentEmployee.Salary}");
                }
                else
                {
                    Console.WriteLine("Invalid id");
                }
            }
            else if (empType == 2)
            {
                Temporary temporaryEmployee = new Temporary();
                Console.WriteLine("Enter the employee id");
                temporaryEmployee.Id = Console.ReadLine();
                if (temporaryEmployee.ValidateEmployeeId())
                {
                    Console.WriteLine("Enter the name");
                    temporaryEmployee.Name = Console.ReadLine();
                    Console.WriteLine("Enter hours worked");
                    temporaryEmployee.HrsWorked = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter hourly wages");
                    temporaryEmployee.HrlyWages = int.Parse(Console.ReadLine());
                    temporaryEmployee.SalaryCalculation();
                    Console.WriteLine($"Employee id : {temporaryEmployee.Id}, Name : {temporaryEmployee.Name}, Salary : {temporaryEmployee.Salary}");
                }
                else
                {
                    Console.WriteLine("Invalid id");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
    
}
