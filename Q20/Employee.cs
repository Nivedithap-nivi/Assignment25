using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q20
{
    public abstract class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public bool ValidateEmployeeId()
        {
            if (Id.Length == 5 && Id.StartsWith("EM") && int.TryParse(Id.Substring(2), out int _))
            {
                return true;
            }
            return false;
        }

        public abstract Employee SalaryCalculation();
    }

    public class Permanent : Employee
    {
        public double BasicPay { get; set; }

        public override Employee SalaryCalculation()
        {
            double DA = 0.50 * BasicPay;
            double HRA = 0.30 * BasicPay;
            Salary = BasicPay + DA + HRA;
            return this;
        }
    }

    public class Temporary : Employee
    {
        public int HrsWorked { get; set; }
        public int HrlyWages { get; set; }

        public override Employee SalaryCalculation()
        {
            Salary = HrsWorked * HrlyWages;
            return this;
        }

    }
}
