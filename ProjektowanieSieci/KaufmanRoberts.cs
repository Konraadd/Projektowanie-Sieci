using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrawdopodobieństwoBlokady
{
    static class KaufmanRoberts
    {
        static int truncation = 1;

        static public List<double> BlockingPropabilities(int V, List<int> t, List<double> A, double a)
        {

            if (t.Count != A.Count)
            {
                throw new Exception("Length of list t and list A should be the same!");
            }

            // find propability coefficients
            List<double> blockingCoefficients = new List<double>();         //        P 
            blockingCoefficients.Add(1d / truncation);
            for (int i = 1; i <= V; i++)
            {
                double coefficient = calculateCoefficient(blockingCoefficients, i, t, A);       //P (0,1,...n)
                blockingCoefficients.Add(coefficient);
            }
            // normalize propability
            double normalizationConstant = 1 / blockingCoefficients.Sum();          //Gv 
            List<double> blockingPropabilities = new List<double>(blockingCoefficients.Count);      // [P]
            double xd = blockingCoefficients.Sum();             //
            foreach (double coeff in blockingCoefficients)
            {
                blockingPropabilities.Add(coeff * normalizationConstant);       // [P](0,1,2,...,n)
            }
            // find blocking propability for each class             
            List<double> classBlockingPropabilities = new List<double>(t.Count);            //E
            foreach (int i in t)
            {
                classBlockingPropabilities.Add(blockingPropabilities.Skip(V - i + 1).Sum());        //E(1,2,3...)
            }
            double check = blockingPropabilities.Sum();
            return classBlockingPropabilities;
        }

        static double calculateCoefficient(List<double> coeffs, int n, List<int> t, List<double> A)     //liczenie P
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
                coeff = 1 / truncation;
            return (coeff / n) / truncation;
        }

        static public List<double> calculateAi(List<double> B, double a, int V, List<int> t)        //
        {
            List<double> A = new List<double>();
            double suma_proporcji = 0;
            foreach (double index in B)
            {
                suma_proporcji += index;
            }
            double aV = a * V;
            double Ai;
            for (int i = 0; i < B.Count; i++)
            {
                Ai = aV / (B[i] * suma_proporcji) / t[i];
                A.Add(Ai);
            }
            return A;
        }

        static public bool checkEi(List<double> BlockingProbabilities, List<double> P_blokady)
        {
            for (int i = 0; i < P_blokady.Count; i++)
            {
                if (BlockingProbabilities[i] > P_blokady[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}