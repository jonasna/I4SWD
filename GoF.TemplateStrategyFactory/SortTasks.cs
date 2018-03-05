using System;

namespace GoF.TemplateStrategyFactory
{
    public class QuickSort : SortTask
    {
        public override void Sort(int[] array)
        {
            IntArrayQuickSort(array, 0, array.Length-1);
        }

        public override string Name { get; } = "Quick Sort";

        private static void IntArrayQuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    Swap(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }
    }

    public class InsertionSort : SortTask
    {
        public override void Sort(int[] array)
        {
            int i, j;
            int N = array.Length;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && array[i] < array[i - 1]; i--)
                {
                    Swap(array, i, i - 1);
                }
            }
        }

        public override string Name { get; } = "Insertion Sort";
    }

    public class ShellSort : SortTask
    {
        public override void Sort(int[] array)
        {
            var intervals = GenerateIntervals(array.Length);
            IntArrayShellSort(array, intervals);
        }

        public override string Name { get; } = "Shell Sort";

        private static void IntArrayShellSort(int[] data, int[] intervals)
        {
            int i, j, k, m;
            int N = data.Length;

            // The intervals for the shell sort must be sorted, ascending

            for (k = intervals.Length - 1; k >= 0; k--)
            {
                int interval = intervals[k];
                for (m = 0; m < interval; m++)
                {
                    for (j = m + interval; j < N; j += interval)
                    {
                        for (i = j; i >= interval && data[i] < data[i - interval]; i -= interval)
                        {
                            Swap(data, i, i - interval);
                        }
                    }
                }
            }
        }
        private static int[] GenerateIntervals(int n)
        {
            if (n < 2)
            {  // no sorting will be needed
                return new int[0];
            }
            int t = Math.Max(1, (int)Math.Log(n, 3) - 1);
            int[] intervals = new int[t];
            intervals[0] = 1;
            for (int i = 1; i < t; i++)
                intervals[i] = 3 * intervals[i - 1] + 1;
            return intervals;
        }
    }

}