using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.TemplateStrategyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortFactory = new AllSortTaskFactory();
            var arrayFactory = new AllArrayGeneratorFactory();

            var sortTasks = sortFactory.CreateSortTasks();
            var arrayGenerators = arrayFactory.CreateArrayGenerators();

            var superSorter = new SuperSorter(sortTasks[0]);

            foreach (var generator in arrayGenerators)
            {
                Console.WriteLine($"<{generator}>:");
                Console.WriteLine("---");
                foreach (var sort in sortTasks)
                {
                    var array = generator.GenerateArray(20000, 0);
                    Console.WriteLine($"{sort.Name}:\t{superSorter.Sort(array, sort):F5} ms");
                }
                Console.WriteLine("---");
            }
        }
    }
}
