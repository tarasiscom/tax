using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
  /// <summary>
  /// Represent users salary information
  /// </summary>
  public class Salary
  {
    private double basicSalary;
    private double currentSalary;

    private const double Basic_Tax = 0.15;
    private const double Additional_First_Type_Tax = 0.17;
    private const double Additional_Second_Type_Tax = 0.2;
    public double Tax { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="basicSalary"></param>
    /// <param name="currentSalary"></param>
    public Salary(double basicSalary, double currentSalary)
    {
      this.BasicSalary = basicSalary;
      this.CurrentSalary = currentSalary;
      this.Tax = 0;
    }

    /// <summary>
    /// Get or set basic salary
    /// </summary>
    public double BasicSalary
    {
      get { return basicSalary; }
      set
      {
        if (value <= 0)
        {
          Console.WriteLine("Your basic salary should more than 0");
        }
        else basicSalary = value;
      }
    }

    public double CurrentSalary
    {
      get { return currentSalary; }
      set
      {
        if (value <= 0)
        {
          Console.WriteLine("Your basic salary should more than 0");
        }
        else currentSalary = value;
      }
    }

    /// <summary>
    /// Shown users salary info
    /// </summary>
    public void OutputSalaryInformation()
    {
      if (CurrentSalary>0 && BasicSalary>0)
      {
        CalculateTax();
        Console.WriteLine("\n Basic Salary = {0}\n Current Salary (Brutto) = {1}\n Taxes to pay = {2}\n Current Salary (Netto)  = {3}", BasicSalary,
        CurrentSalary, Tax, (CurrentSalary - Tax));
      }
    }

    /// <summary>
    /// Calculate tax amount
    /// </summary>
    private void CalculateTax()
    {
      //used only when current salary > 5*BS
      var basicTax = (BasicSalary * 5)* Basic_Tax;

      if (CurrentSalary > BasicSalary && CurrentSalary <= 5 * BasicSalary) Tax = CurrentSalary * Basic_Tax;
      if (CurrentSalary > 5 * BasicSalary && CurrentSalary <= 10 * BasicSalary) Tax = basicTax + (currentSalary-basicSalary*5)*Additional_First_Type_Tax;
      if (CurrentSalary > 10 * BasicSalary) Tax = basicTax + (currentSalary - BasicSalary*5) * Additional_Second_Type_Tax;
    }
  }
}