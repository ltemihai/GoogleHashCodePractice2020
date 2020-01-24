using GoogleHashPracticeProblem2020.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoogleHashPracticeProblem2020.Solver
{
    public class GreedySolution
    {
        public int NoOfSlices { get; set; }
        public int[] TypesOfSlices { get; set; }
    }
    public class GreedySolver
    {
        public GreedySolution GetSolution(int maxNumberOfSlices, int typesOfPizza, int[] typeSlices)
        {
            int noOfSlices = 0;
            List<Pizza> pizzas = new List<Pizza>();
            int[] resultTypeSlices = new int[typesOfPizza];
            for(var id = 0; id < typesOfPizza; id++)
            {
                pizzas.Add(new Pizza
                {
                    Id = id,
                    NoSlices = typeSlices[id]
                });
            }

            var descendingListByNoOfSlices = pizzas.OrderByDescending(x => x.NoSlices);
            var minValue = descendingListByNoOfSlices.Last().NoSlices;

            while(noOfSlices <= maxNumberOfSlices)
            {
                if (noOfSlices == maxNumberOfSlices || noOfSlices + minValue > maxNumberOfSlices)
                {
                    return new GreedySolution()
                    {
                        NoOfSlices = noOfSlices,
                        TypesOfSlices = resultTypeSlices
                    };
                }

                foreach (var pizza in descendingListByNoOfSlices)
                {
                    if (noOfSlices + pizza.NoSlices > maxNumberOfSlices)
                    {
                        continue;
                    }
                    noOfSlices = noOfSlices + pizza.NoSlices;
                    resultTypeSlices[pizza.Id]++;
                }
            }

            return new GreedySolution()
            {
                NoOfSlices = noOfSlices,
                TypesOfSlices = resultTypeSlices
            };

        }
    }
}
