using System;

namespace GoF.TemplateStrategyFactory
{
    public abstract class ArrayGenerator
    {
        public int[] GenerateArray(int size, int seed)
        {
            var generator = new Random(seed);

            var array = new int[size];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = generator.Next(size);
            }

            return Format(array);
        }

        protected abstract int[] Format(int[] array);
    }
}