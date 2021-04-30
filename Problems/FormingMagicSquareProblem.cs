using System.Collections.Generic;
using System.Linq;

namespace HackerHank.Console.Problems
{
    public static class FormingMagicSquareProblem
    {
        public static int FormingMagicSquare(List<List<int>> s)
        {
            var integers = new List<int>();
            s.ForEach(i => integers.AddRange(i));

            integers = integers.OrderBy(i => i).ToList();

            //Pego os numeros que nao tem
            //Calculo as possibilidades de troca
            //Aplico as possibilidades no matriz            
            //Teste

            return 0;
        }
    }
}
