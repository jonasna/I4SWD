using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ReportGenerator
{
    public class NameFirstCompiler : ICompiler
    {
        public string Compile(List<Employee> employees)
        {
            var builder = new StringBuilder();
            builder.AppendLine("Name-first report");
            foreach (var e in employees)
            {
                builder.AppendLine("------------------");
                builder.AppendLine($"Name: {e.Name}");
                builder.AppendLine($"Salary: {e.Salary}");
                builder.AppendLine($"Age: {e.Age}");
                builder.AppendLine("------------------");
            }
            return builder.ToString();
        }
    }
}
