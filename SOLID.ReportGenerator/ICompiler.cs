using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ReportGenerator
{
    public interface ICompiler
    {
        string Compile(List<Employee> employees);
    }
}
