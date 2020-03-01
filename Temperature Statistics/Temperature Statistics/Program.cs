using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Statistics
{
    class Program
    {
        /// <summary>
        /// Gibt Werte für ein Array aus.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static double[] GetMeasurements(int n, double min, double max)
        {
            Random rdm = new Random();
            double[] Measurements = new double[n];
            for (int i = 0; i < n; i++)
            {
                double rp = rdm.NextDouble() * (max - min) + min;
                Measurements[i] = rp;
            }
            return Measurements;
        }
        /// <summary>
        /// Bestimmt den kleinsten Wert des Arrays
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static double GetMinimum(double[] array)
        {
            double min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
        /// <summary>
        /// Bestimmt den größten Wert des Arrays
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static double GetMaximum(double[] array)
        {
            double max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        /// <summary>
        /// Errechnet den Mittelwert eines Arrays
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static double GetMean(double[] array)
        {
            double mean = array[0];
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                n++;
                mean = array[0 + i];
            }
            return mean / n;
        }
        /// <summary>
        /// Errechnet die Standardabweichung der Messwerte
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static double GetStandardDeviation(double[] array)
        {
            double mean = GetMean(array), varianz = 0;
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                n++;
                varianz = varianz + Math.Pow(array[0 + i] - mean, 2);
            }
            varianz = varianz / n;
            return Math.Sqrt(varianz);
        }

        static void Main(string[] args)
        {
            int n;
            double min, max;
            Console.Write("Anzahl der Messwerte: ");
            int.TryParse(Console.ReadLine(), out n);
            Console.Write("Untere Grenze der Messungen: ");
            double.TryParse(Console.ReadLine(), out min);
            Console.Write("Obere Grenze der Messungen: ");
            double.TryParse(Console.ReadLine(), out max);

            Console.WriteLine("Der kleinste Messwert ist: " + GetMinimum(GetMeasurements(n, min, max)));
            Console.WriteLine("Der größte Messwert ist: " + GetMaximum(GetMeasurements(n, min, max)));
            Console.WriteLine("Der Mittelwert der Messwerte ist: " + GetMean(GetMeasurements(n, min, max)));
            Console.WriteLine("Die Standardabweichung der Messwerte ist: " + GetStandardDeviation(GetMeasurements(n, min, max)));
        }
    }
}

