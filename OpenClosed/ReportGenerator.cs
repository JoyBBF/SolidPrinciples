using SolidPrinciples.OpenClosed;
using SolidPrinciples.SingleResponsibility;

namespace SolidPrinciples.OpenClosed
{
    public abstract class ReportGenerator
    {
        public string ReportType { get; set; }

        public abstract void GenerateReport(Person person);
    }
}