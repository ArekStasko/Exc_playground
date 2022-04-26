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
        private int InsertionSort { get; set; }
        private int MergeSort { get; set; }
        private int QuickSortClassical { get; set; }
        private int QuickSort { get; set; }


        public void PrintStatistics()
        {
            RunAlgo();
        }


        private void RunAlgo()
        {
            var controllers = new Controllers();
            controllers.InitializeArrays(10);

            var AlgoImplementations = new AlgorithmsImplenentations();

            var sw = new Stopwatch();

            sw.Start();
            foreach (var arr in controllers.RandomArrays)
            {                
                AlgoImplementations.InsertionSort(arr);
            }
            sw.Stop();

            Console.WriteLine($"InsertionSort time : {sw.Elapsed.Milliseconds}");
        }

        private void PrintEffects()
        {

        }
    }
}
