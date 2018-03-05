using System;
using System.Collections;
using System.Linq;

namespace GoF.TemplateStrategyFactory
{
    public class RandomArrayGenerator : ArrayGenerator
    {
        protected override int[] Format(int[] array)
        {
            return array;
        }

        public override string ToString()
        {
            return "Random array";
        }
    }

    public class NearlySortedArrayGenerator : ArrayGenerator
    {
        protected override int[] Format(int[] array)
        {
            Array.Sort(array);

            var random = new Random();

            for (int i = array.Length - 2; i >= 0; i -= (array.Length / 6))
            {
                array[i] = array[random.Next(i)];
            }

            return array;
        }

        public override string ToString()
        {
            return "Nearly sorted array";
        }
    }

    public class ReverseOrderArrayGenerator : ArrayGenerator
    {
        protected override int[] Format(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }

        public override string ToString()
        {
            return "Reverse order array";
        }
    }

    public class FewButRandomArrayGenerator : ArrayGenerator
    {
        protected override int[] Format(int[] array)
        {
            var maxVal = array.Max();

            for (int i = 0; i < array.Length; i++)
            {
                var rand = new Random( i % 3 );

                array[i] = rand.Next(maxVal + 1);
            }

            var rnd = new Random(maxVal);
            return array.OrderBy(x => rnd.Next()).ToArray();
        }

        public override string ToString()
        {
            return "Few but random array";
        }
    }

}