using System.Text;
using System;

namespace FirstTask
{
    internal class StringDecompression : IStringTransformable
    {
        public string Transform(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            var result = new StringBuilder();
            int index = 0;

            while (index < input.Length)
            {
                char current = input[index++];

                if (char.IsLetter(current))
                {
                    int count = ExtractNumber(input, ref index);
                    result.Append(current, count > 0 ? count : 1);
                }
                else
                {
                    throw new FormatException($"Не правильный символ '{current}' в позиции {index}");
                }
            }

            return result.ToString();
        }

        private int ExtractNumber(string input, ref int index)
        {
            int start = index;
            while (index < input.Length && char.IsDigit(input[index]))
            {
                index++;
            }

            if (start == index)
                return 0;

            return int.Parse(input.Substring(start, index - start));
        }
    }
}
