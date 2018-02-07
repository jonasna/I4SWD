using System;
using System.Collections.Generic;

namespace SOLID.ReportGenerator
{


    internal class ReportGenerator
    {
        private readonly EmployeeDB _employeeDb;
        private readonly ReportCompiler _reportCompiler = new ReportCompiler();
        
        public ReportGenerator(EmployeeDB employeeDb)
        {
            if (employeeDb == null) throw new ArgumentNullException("employeeDb");
            _employeeDb = employeeDb;
        }


        public void CompileReport()
        {
            var employees = new List<Employee>();
            Employee employee;

            _employeeDb.Reset();

            // Get all employees
            while ((employee = _employeeDb.GetNextEmployee()) != null)
            {
                employees.Add(employee);
            }

            // Compile them
            var output = _reportCompiler.Compile(employees);

            // Print output
            Console.WriteLine(output);
        }


        public void SetOutputFormat(ReportOutputFormatType format)
        {
            _reportCompiler.Format = format;
        }
    }
}