using System;

namespace FirstTask
{
    internal class StringTransformer
    {
        private readonly IStringTransformable _transformer;

        public StringTransformer(IStringTransformable transformer)
        {
            _transformer = transformer ?? throw new ArgumentNullException(nameof(transformer));
        }

        public string Execute(string input)
        {
            return _transformer.Transform(input);
        }


    }
}
