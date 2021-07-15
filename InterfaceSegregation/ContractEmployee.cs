using System;

namespace SolidPrinciples.InterfaceSegregation
{
    public class ContractEmployee : IContractWorkerSalary
    {
        public string Id { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public float HourlyRate { get; set; }
        
        public float HoursInMonth { get; set; }
        
        public float CalculateWorkedSalary() => HourlyRate * HoursInMonth;
    }
}