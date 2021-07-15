using System;

namespace SolidPrinciples.InterfaceSegregation
{
    public class FullTimeWorker : IFullTimeWorkerSalary
    {
        public string Id { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public float MonthlySalary { get; set; }
        
        public float OtherBenefits { get; set; }
        
        public float CalculateNetSalary() => MonthlySalary + OtherBenefits;
    }
}