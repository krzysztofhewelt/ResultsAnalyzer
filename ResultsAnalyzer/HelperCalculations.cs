using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsAnalyzer
{
    class HelperCalculations
    {
        private readonly Double[] inputData;

        public HelperCalculations(Double[] input)
        {
            this.inputData = input;
        }

        /// <summary>
        /// Calculates sum from input data.
        /// </summary>
        /// <returns>Sum of input data.</returns>
        public Double CalcSum()
        {
            Double sum = 0;

            for(int i = 0; i < inputData.Length; i++)
            {
                sum += inputData[i];
            }

            return sum;
        }

        /// <summary>
        /// Calculates mean value from input data.
        /// </summary>
        /// <returns>Mean value of input data</returns>
        public Double CalcMeanValue()
        {
            Double meanValue;

            meanValue = (inputData.Length != 0) ? CalcSum() / inputData.Length : 0;

            return meanValue;
        }

        /// <summary>
        /// Calculates variance from input data.
        /// </summary>
        /// <returns>Variance of input data</returns>
        public Double CalcVariance()
        {
            Double meanValue = CalcMeanValue();
            Double tempSum = 0, variance = 0;

            if(inputData.Length > 0)
            {
                for (int i = 0; i < inputData.Length; i++)
                {
                    tempSum += Math.Pow(inputData[i] - meanValue, 2);
                }

                variance = tempSum / inputData.Length;
            }

            return variance;
        }

        /// <summary>
        /// Calculates standard deviation from input data.
        /// </summary>
        /// <returns>Standard deviation of input data</returns>
        public Double CalcStandardDeviation()
        {
            Double variance = CalcVariance();
            Double standardDeviation;

            standardDeviation = (inputData.Length > 0) ? Math.Sqrt(variance) : 0;

            return standardDeviation;
        }

        /// <summary>
        /// Calculates median from input data.
        /// </summary>
        /// <returns>Median of input data</returns>
        public Double CalcMedian()
        {
            Double median;
            int mid;

            Double[] temp = inputData;
            Array.Sort(temp);

            if(inputData.Length > 0)
            {
                mid = inputData.Length / 2;
                median = (inputData.Length % 2 != 0) ? inputData[mid] : (inputData[mid] + inputData[mid - 1]) / 2;
            }
            else
            {
                median = 0;
            }

            return median;
        }
    }
}
