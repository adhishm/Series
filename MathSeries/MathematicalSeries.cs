using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSeries
{
    public class MathematicalSeries
    {
        #region staticFunctions
        /// <summary>
        /// Generates the Fibonacci series.
        /// </summary>
        /// <param name="nTerms"></param>
        /// <param name="terms"></param>
        public static void FibonacciSeries (int nTerms, ref int[] terms)
        {
            if (nTerms <= 0)
                return;            

            terms[0] = 1;

            if (nTerms == 1)
                return;

            terms[1] = 1;

            if (nTerms == 2)
                return;

            int i = 2;

            while (i<nTerms)
            {
                terms[i] = terms[i - 1] + terms[i - 2];
                i++;
            }
        }

        /// <summary>
        /// Generates a series of odd numbers.
        /// </summary>
        /// <param name="nTerms"></param>
        /// <param name="terms"></param>
        public static void OddNumbers (int nTerms, int[] terms)
        {
            if (nTerms < 0)
                return;

            terms[0] = 1;

            int i = 1;

            while (i < nTerms)
            {
                terms[i] = terms[i - 1] + 2;
                i++;
            }
        }

        /// <summary>
        /// Generates a series of even numbers.
        /// </summary>
        /// <param name="nTerms"></param>
        /// <param name="terms"></param>
        public static void EvenNumbers(int nTerms, int[] terms)
        {
            if (nTerms < 0)
                return;

            terms[0] = 0;

            int i = 1;

            while (i < nTerms)
            {
                terms[i] = terms[i - 1] + 2;
                i++;
            }
        }

        /// <summary>
        /// Generates an arithmetic series.
        /// </summary>
        /// <param name="nTerms"></param>
        /// <param name="root"></param>
        /// <param name="increment"></param>
        /// <param name="terms"></param>
        public static void ArithmeticSeries(int nTerms, double root, double increment, double[] terms)
        {
            if (nTerms <= 0)
                return;            

            terms[0] = root;

            int i = 1;

            while (i < nTerms)
            {
                terms[i] = terms[i - 1] + increment;
                i++;
            }
        }

        /// <summary>
        /// Generates a geometric series.
        /// </summary>
        /// <param name="nTerms"></param>
        /// <param name="root"></param>
        /// <param name="factor"></param>
        /// <param name="terms"></param>
        public static void GeometricSeries(int nTerms, double root, double factor, double[] terms)
        {
            if (nTerms <= 0)
                return;

            terms[0] = root;

            int i = 1;

            while (i < nTerms)
            {
                terms[i] = terms[i - 1] * factor;
                i++;
            }
        }
        #endregion
    }
}
