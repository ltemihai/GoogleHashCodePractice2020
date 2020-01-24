using GoogleHashPracticeProblem2020.Solver;
using GoogleHashPracticeProblem2020.Utils;
using System;

namespace GoogleHashPracticeProblem2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExecuteSolution(@"D:\Projects\GoogleHashPracticeProblem2020\a_example.in");
            //ExecuteSolution(@"D:\Projects\GoogleHashPracticeProblem2020\b_small.in");
            ExecuteSolution(@"D:\Projects\GoogleHashPracticeProblem2020\c_medium.in");
            //ExecuteSolution(@"D:\Projects\GoogleHashPracticeProblem2020\d_quite_big.in");
            //ExecuteSolution(@"D:\Projects\GoogleHashPracticeProblem2020\e_also_big.in");
        }

        private static void ExecuteSolution(string path)
        {
            Console.WriteLine();
            Console.WriteLine(path);
            FileReader fileReader = new FileReader();
            var lines = fileReader.ReadFile(path);
            var firstLine = lines[0].Split(" ");
            var secondLine = lines[1].Split(" ");
            var maxSlicesOfPizza = int.Parse(firstLine[0]);
            var typesOfPizza = int.Parse(firstLine[1]);
            int[] slicesPerType = new int[secondLine.Length];

            for (var i = 0; i < secondLine.Length; i++)
            {
                slicesPerType[i] = int.Parse(secondLine[i]);
            }


            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            GreedySolver greedySolver = new GreedySolver();
            var greedyResult = greedySolver.GetSolution(maxSlicesOfPizza, typesOfPizza, slicesPerType);

            Console.WriteLine();
            Console.WriteLine(typesOfPizza);
            Console.WriteLine(greedyResult.NoOfSlices);
            foreach (var slice in greedyResult.TypesOfSlices)
            {
                Console.Write(slice);
                Console.Write(" ");
            }

            fileReader.WriteFile(typesOfPizza, greedyResult.TypesOfSlices, "test.out");
        }
    }
}
