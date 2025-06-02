using System;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string original = "aaabbcccdde";

            var compressor = new StringTransformer(new StringCompression());
            string compressed = compressor.Execute(original);
            Console.WriteLine($"Сжатие: {compressed}"); 

            var decompressor = new StringTransformer(new StringDecompression());
            string decompressed = decompressor.Execute(compressed);
            Console.WriteLine($"Декомпрессия: {decompressed}");

            Console.ReadLine();

        }
    }
}
