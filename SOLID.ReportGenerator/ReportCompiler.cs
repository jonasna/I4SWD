using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ReportGenerator
{
    public enum ReportOutputFormatType
    {
        NameFirst,
        SalaryFirst
    }
    public class ReportCompiler
    {
        public ReportOutputFormatType Format { get; set; } = ReportOutputFormatType.NameFirst;

        public string Compile(List<Employee> employees)
        {
            var builder = new StringBuilder();

            // All employees collected - let's output them
            switch (Format)
            {
                case ReportOutputFormatType.NameFirst:
                    builder.AppendLine("Name-first report");
                    foreach (var e in employees)
                    {
                        builder.AppendLine("------------------");
                        builder.AppendLine($"Name: {e.Name}");
                        builder.AppendLine($"Salary: {e.Salary}");
                        builder.AppendLine("------------------");
                    }
                    break;

                case ReportOutputFormatType.SalaryFirst:
                    builder.AppendLine("Salary-first report");
                    foreach (var e in employees)
                    {
                        builder.AppendLine("------------------");
                        builder.AppendLine($"Salary: {e.Salary}");
                        builder.AppendLine($"Name: {e.Name}");
                        builder.AppendLine("------------------");
                    }
                    break;
            }

            return builder.ToString();
        }
    }
}
