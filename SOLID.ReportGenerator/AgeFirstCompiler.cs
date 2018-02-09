using System.Collections.Generic;
using System.Text;

namespace SOLID.ReportGenerator
{
    public class AgeFirstCompiler : ICompiler
    {
        public string Compile(List<Employee> employees)
        {
            var builder = new StringBuilder();
            builder.AppendLine("Age-first report");
            foreach (var e in employees)
            {
                builder.AppendLine("------------------");
                builder.AppendLine($"Age: {e.Age}");
                builder.AppendLine($"Name: {e.Name}");
                builder.AppendLine($"Salary: {e.Salary}");
                builder.AppendLine("------------------");
            }
            return builder.ToString();
        }
    }
}