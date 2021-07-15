namespace SolidPrinciples.DependencyInversion
{
    public class EmployeeDetails
    {
        public int HoursWorked { get; set; }
        
        public int HourlyRate { get; set; }

        public ISalaryCalculator salaryCalculator;

        public EmployeeDetails(){
            salaryCalculator = SalaryCalculatorFactory.getSalaryCalculatorObject();
        }
        
        public float GetSalary()
        {  
            return salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }  
    }
}