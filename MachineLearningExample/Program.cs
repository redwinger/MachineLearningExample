using System;
using System.IO;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace MachineLearningExample
{
    class Program
    {
        static readonly string _trainDataPath = Path.Combine(Environment.CurrentDirectory, "Data", "Models", "taxi-fare-train.csv");
        static readonly string _testDataPath = Path.Combine(Environment.CurrentDirectory, "Data", "Models", "taxi-fare-test.csv");
        static readonly string _modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "Models", "Model.zip");
        static void Main(string[] args)
        {
            MLContext context = new MLContext(seed: 0);

            var model = Train(context, _trainDataPath);

        }

        public static ITransformer Train(MLContext mlContext, string dataPath)
        {

        }
    }
}
