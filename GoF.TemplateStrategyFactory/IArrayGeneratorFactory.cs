using System.Collections.Generic;

namespace GoF.TemplateStrategyFactory
{
    public interface IArrayGeneratorFactory
    {
        List<ArrayGenerator> CreateArrayGenerators();
    }

    public class AllArrayGeneratorFactory : IArrayGeneratorFactory
    {
        public List<ArrayGenerator> CreateArrayGenerators()
        {
            var generators = new List<ArrayGenerator>
            {
                new RandomArrayGenerator(),
                new FewButRandomArrayGenerator(),
                new NearlySortedArrayGenerator(),
                new ReverseOrderArrayGenerator()
            };
            return generators;
        }
    }
}