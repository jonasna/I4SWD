using System;
using System.Diagnostics;

namespace GoF.TemplateStrategyFactory
{
    public class SuperSorter
    {
        private SortTask _sortTask;
        private readonly Stopwatch _stopWatch = new Stopwatch();

        public SuperSorter(SortTask task)
        {
            _sortTask = task;
        }

        public double Sort(int[] array, SortTask task = null)
        {
            if (task != null)
                _sortTask = task;

            _stopWatch.Reset();
            _stopWatch.Start();
            _sortTask.Sort(array);
            _stopWatch.Stop();
            return _stopWatch.Elapsed.TotalMilliseconds;
        }
    }
}