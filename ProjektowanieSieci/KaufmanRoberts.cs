using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrawdopodobieństwoBlokady
{
    static class KaufmanRoberts
    {

        static public List<double> BlockingPropabilities(int V, List<int> t, double a, List<int> A_ratio)
        {
            if (A_ratio.Count != t.Count)
            {
                throw new Exception("Length of list t and list A_ratio must be the same!");
            }

            double aV = a * V;
            double x = aV / A_ratio.Sum();

            List<double> A = calculateAi(A_ratio, a, V, t);

            return BlockingPropabilities(V, t, A);
        }

        static public List<double> BlockingPropabilities(int V, List<int> t, List<double> A)
        {
            if (t.Count != A.Count)
            {
                throw new Exception("Length of list t and list A must be the same!");
            }
            // find propability coefficients
            List<double> blockingCoefficients = new List<double>();
            blockingCoefficients.Add(1d);
            for (int i = 1; i <= V; i++)
            {
                double coefficient = calculateCoefficient(blockingCoefficients, i, t, A);
                blockingCoefficients.Add(coefficient);
            }
            // normalize propability
            double normalizationConstant = 1 / blockingCoefficients.Sum();
            List<double> blockingPropabilities = new List<double>(blockingCoefficients.Count);
            double xd = blockingCoefficients.Sum();
            foreach(double coeff in blockingCoefficients)
            {
                blockingPropabilities.Add(coeff * normalizationConstant);
            }
            // find blocking propability for each class
            List<double> classBlockingPropabilities = new List<double>(t.Count);
            foreach(int i in t)
            {
                classBlockingPropabilities.Add(blockingPropabilities.Skip(V - i + 1).Sum());
            }
            double check = blockingPropabilities.Sum();
            return classBlockingPropabilities;
        }

        static double calculateCoefficient(List<double> coeffs, int n, List<int> t, List<double> A)
        {
            double coeff = 0;
            for (int i = 0; i < t.Count; i++)
            {
                if (t.ElementAt(i) > n)
                    continue;
                coeff += A.ElementAt(i) * t.ElementAt(i) * coeffs.ElementAt(n - t.ElementAt(i));
            }
            // if it wasnt changed, give it initial value
            if (coeff == 0)
                coeff = 1;
            return (coeff/n);
        }

        static private List<double> calculateAi(List<int> A_ratio, double a, int V, List<int> t)
        {
            List<double> A = new List<double>();

            double aV = a * V;
            double AiTi = 0;
            for(int i=0; i< A_ratio.Count; i++)
            {
                AiTi += A_ratio[i] * t[i];
            }
            double x = aV / AiTi;
            for (int i = 0; i < A_ratio.Count; i++)
            {
                A.Add(x*A_ratio[i]);
            }
            return A;
        }
    }
}
