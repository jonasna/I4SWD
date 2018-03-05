using System.Collections.Generic;

namespace GoF.TemplateStrategyFactory
{
    public interface ISortTaskFactory
    {
        List<SortTask> CreateSortTasks();
    }

    public class AllSortTaskFactory : ISortTaskFactory
    {
        public List<SortTask> CreateSortTasks()
        {
            var tasks = new List<SortTask>
            {
                new InsertionSort(),
                new QuickSort(),
                new ShellSort()
            };

            return tasks;
        }
    }
}