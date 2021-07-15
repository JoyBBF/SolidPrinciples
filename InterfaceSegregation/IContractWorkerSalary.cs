namespace SolidPrinciples.InterfaceSegregation
{
    public interface IContractWorkerSalary : IWorker
    {
        float HourlyRate { get; set; }
        
        float HoursInMonth { get; set; }
        
        float CalculateWorkedSalary();
    }
}