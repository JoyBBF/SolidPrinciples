namespace SolidPrinciples.InterfaceSegregation
{
    public interface IFullTimeWorkerSalary : IWorker
    {
        float MonthlySalary { get; set; }
        
        float OtherBenefits { get; set; }
        
        float CalculateNetSalary();
    }
}