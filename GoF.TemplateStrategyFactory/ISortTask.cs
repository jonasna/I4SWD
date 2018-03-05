namespace GoF.TemplateStrategyFactory
{
    public abstract class SortTask
    {
        public abstract void Sort(int[] array);
        public abstract string Name { get; }
        protected static void Swap(int[] array, int indexA, int indexB)
        {
            var temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;
        }
    }
}