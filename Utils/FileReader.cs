using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GoogleHashPracticeProblem2020.Utils
{
    public class FileReader
    {
        public string[] ReadFile(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }

        public void WriteFile(int noOfTypes, int[] typesSlices, string filename)
        {
            using (var writer = File.CreateText(Environment.CurrentDirectory + '/' + filename))
            {
                writer.WriteLine(noOfTypes);
                for(int index = 0; index < typesSlices.Length; index++)
                {
                    writer.Write(typesSlices[index] + " ");
                }
            }
        }
    }
}
