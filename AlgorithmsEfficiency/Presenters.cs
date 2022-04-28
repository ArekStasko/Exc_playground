using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AlgorithmsEfficiency
{
    internal class Presenters
    {
        private List<double> InsertionSort { get; set; } = new List<double> { };
        private List<double> MergeSort { get; set; } = new List<double> { };
        private List<double> QuickSortClassical { get; set; } = new List<double> { };
        private List<double> QuickSort { get; set; } = new List<double> { };


        public void PrintStatistics()
        {
            RunAlgo();
        }


        private void RunAlgo()
        {
            var controllers = new Controllers();
            controllers.InitializeArrays(10);

            var AlgoImplementations = new AlgorithmsImplenentations();

            foreach (var arr in controllers.RandomArrays)
            {
                var sw = new Stopwatch();
                sw.Start();
                AlgoImplementations.InsertionSort(arr);
                sw.Stop();
                InsertionSort.Add(Math.Round(sw.Elapsed.TotalMilliseconds, 8));
                sw.Restart();
                AlgoImplementations.QuickSort(arr);
                sw.Stop();
                QuickSort.Add(Math.Round(sw.Elapsed.TotalMilliseconds, 8));
                sw.Restart();
                AlgoImplementations.MergeSort(arr, 0, arr.Length-1);
                sw.Stop();
                MergeSort.Add(Math.Round(sw.Elapsed.TotalMilliseconds, 8));
                sw.Restart();
                Array.Sort(arr);
                sw.Stop();
                QuickSortClassical.Add(Math.Round(sw.Elapsed.TotalMilliseconds, 8));
            }

        }

        private void PrintEffects()
        {

        }
    }
}
