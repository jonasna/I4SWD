using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ReportGenerator
{
    public class SalaryFirstCompiler : ICompiler
    {
        public string Compile(List<Employee> employees)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Salary-first report");
            foreach (var e in employees)
            {
                sb.AppendLine("------------------");
                sb.AppendLine($"Salary: {e.Salary}");
                sb.AppendLine($"Name: {e.Name}");
                sb.AppendLine($"Age: {e.Age}");
                sb.AppendLine("------------------");
            }
            return sb.ToString();
        }
    }
}
