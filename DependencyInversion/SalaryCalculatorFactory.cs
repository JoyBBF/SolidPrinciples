namespace SolidPrinciples.DependencyInversion
{
    public class SalaryCalculatorFactory
    {
        public static ISalaryCalculator getSalaryCalculatorObject(){
            return new SalaryCalculator();
        }
    }
}