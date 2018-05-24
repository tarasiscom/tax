using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter Basic Salary : ");
      var basicSalary =  Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter Current Salary : ");
      var currentSalary= Convert.ToDouble(Console.ReadLine());

      var userSalaryInformation = new Salary(basicSalary, currentSalary);
      userSalaryInformation.OutputSalaryInformation();

      Console.ReadKey();
    }
  }
}
