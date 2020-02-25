using System;
using System.Linq;
using MachineLearningTesterML.Model;

namespace MachineLearningTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var input = new ModelInput();
            input.ImageSource = @"C:\MLTestFiles\index.png";
            var result = ConsumeModel.Predict(input);
            Console.WriteLine($"This is a {result.Prediction} with a confidence of {Math.Round(Convert.ToDecimal(result.Score.Max())*100m, 3)}%");
        }
    }
}
