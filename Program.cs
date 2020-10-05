using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace ImageSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string inPath = "../../../input.jpg";
            
            using Image image = Image.Load(inPath);
            image.Mutate(c => c.Resize(c.GetCurrentSize()/2));
            image.Save("./output.jpg");
        }
    }
}