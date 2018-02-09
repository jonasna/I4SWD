using System;
using System.Collections.Generic;

namespace SOLID.ReportGenerator
{


    internal class ReportGenerator
    {
        private readonly EmployeeDB _employeeDb;
        private ICompiler _reportCompiler = new NameFirstCompiler();
        
        public ReportGenerator(EmployeeDB employeeDb)
        {
            _employeeDb = employeeDb ?? throw new ArgumentNullException("employeeDb");
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

        public void SetOutputFormat(ICompiler compiler)
        {
            _reportCompiler = compiler ?? throw new ArgumentNullException("compiler");
        }
    }
}