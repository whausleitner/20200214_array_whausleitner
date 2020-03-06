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
        /// Erstellt ein array vom Messwerten mittels Zufallsgenerator
        /// </summary>
        /// <param name="n">Anzahl der Messwerte</param>
        /// <param name="minValue">Minimalwert</param>
        /// <param name="maxValue">Maximalwert</param>
        /// <returns>
        /// array Measurements mit Messwerten
        /// </returns>
        static double[] GetMeasurements(int n, double minValue, double maxValue)
        {
            Random generator = new Random();
            double[] Measurements = new double[n];
            for (int i = 0; i < n; i++)
            {
                Measurements[i] = generator.NextDouble() * (maxValue - minValue) + minValue;
                // generator.NextDouble() ... erzeugt double-Zufallszahl zwischen 0 und 1
            }
            return Measurements;
        }

        /// <summary>
        /// Bestimmt den kleinsten Wert des Arrays
        /// </summary>
        /// <param name="array">Array mit Messwerten</param>
        /// <returns>
        /// Minimum des Arrays
        /// </returns>
        static double GetMinimum(double[] array)
        {
            double min = double.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
            }
            if (array.Length == 0) min = double.NaN; // ist das array leer (n=0), dann ist min = NaN
            return min;
        }

        /// <summary>
        /// Bestimmt den größten Wert des Arrays
        /// </summary>
        /// <param name="array">Array mit Messwerten</param>
        /// <returns>
        /// Maximum des Arrays
        /// </returns>
        static double GetMaximum(double[] array)
        {
            double max = double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }
            if (array.Length == 0) max = double.NaN; // ist das array leer (n=0), dann ist max = NaN
            return max;
        }

        /// <summary>
        /// Bestimmt den Mittelwert eines Arrays
        /// </summary>
        /// <param name="array">Array mit Messwerten</param>
        /// <returns>
        /// Arithmetisches Mittel der Werte in array
        /// </returns>
        static double GetMean(double[] array)
        {
            double meanValue = 0;            
            for (int i = 0; i < array.Length; i++)
            {
                meanValue += array[i];
            }
            return meanValue / array.Length;
        }

        /// <summary>
        /// Berechnet die Standardabweichung der Werte in array
        /// </summary>
        /// <param name="array">Array mit Messwerten</param>
        /// <returns>
        /// Standardabweichung der Werte in array
        /// </returns>
        static double GetStandardDeviation(double[] array)
        {
            double mean = GetMean(array);
            double variance = 0, standardDeviation = 0;
            // int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
               variance += Math.Pow(array[i] - mean, 2);
                // Summe der quadratischen Abweichungen vom Mittwelwert
            }
            variance /= array.Length;
            // Varianz ist die mittlere quadratischen Abweichung vom Mittwelwert
            standardDeviation = Math.Sqrt(variance); // std.deviation ist Wurzel aus Varianz
            return standardDeviation;
        }

        /// <summary>
        /// Hauptprogramm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n;
            double min, max;

            Console.Write("Anzahl der Temperaturwerte: ");
            int.TryParse(Console.ReadLine(), out n);
            Console.Write("Minimalwert: ");
            double.TryParse(Console.ReadLine(), out min);
            Console.Write("Maximalwert: ");
            double.TryParse(Console.ReadLine(), out max);

            Console.WriteLine("Kleinster Messwert: " + GetMinimum(GetMeasurements(n, min, max)));
            Console.WriteLine("Größter Messwert: " + GetMaximum(GetMeasurements(n, min, max)));
            Console.WriteLine("Arithmetisches Mittel der Messwerte: " + GetMean(GetMeasurements(n, min, max)));
            Console.WriteLine("Standardabweichung der Messwerte: " + GetStandardDeviation(GetMeasurements(n, min, max)));
        }
    }
}

