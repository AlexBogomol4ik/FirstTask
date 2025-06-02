using System.Text;

namespace FirstTask
{
    internal class StringCompression : IStringTransformable
    {
        public string Transform(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            var result = new StringBuilder();
            char current = input[0];
            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == current)
                {
                    count++;
                }
                else
                {
                    AppendResult(result, current, count);
                    current = input[i];
                    count = 1;
                }
            }

            AppendResult(result, current, count);
            return result.ToString();
        }

        private void AppendResult(StringBuilder builder, char character, int count)
        {
            builder.Append(character);
            if (count > 1) builder.Append(count);
        }
    }
}
