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
        private Controllers _controllers = new Controllers();
        private int count = 0;
        private List<double> InsertionSort { get; set; } = new List<double> { };
        private List<double> MergeSort { get; set; } = new List<double> { };
        private List<double> QuickSortClassical { get; set; } = new List<double> { };
        private List<double> QuickSort { get; set; } = new List<double> { };



        public void PrintStatistics()
        {
            Dictionary<string, int> elements = new Dictionary<string, int>
            {
                {"mala", 10 },
                {"srednia", 1000 },
                {"duza", 10000 }
            };
            foreach(KeyValuePair<string, int> element in elements)
            {
                Console.WriteLine("Progressing...");
                Console.WriteLine("If it taking too much time, you can decrease number of elements");
                Console.WriteLine();
                try
                {
                    _controllers.DataArrays.Clear();
                    RunAlgo(element);
                }
                catch (Exception)
                {
                    Console.WriteLine("Oppps ! Something went Wrong !");
                }

            }
        }


        private void RunAlgo(KeyValuePair<string, int> el)
        {
            var AlgoImplementations = new AlgorithmsImplenentations();

            _controllers.InitializeArrays(el.Value);
            foreach (KeyValuePair<string, List<int[]>> data in _controllers.DataArrays)
            {
                count++;
                foreach (var arr in data.Value)
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
                    AlgoImplementations.MergeSort(arr, 0, arr.Length - 1);
                    sw.Stop();
                    MergeSort.Add(Math.Round(sw.Elapsed.TotalMilliseconds, 8));
                    sw.Restart();
                    Array.Sort(arr);
                    sw.Stop();
                    QuickSortClassical.Add(Math.Round(sw.Elapsed.TotalMilliseconds, 8));
                }
                PrintEffects(count, el, data.Key);
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
        }

        private void PrintEffects(int count, KeyValuePair<string, int> el, string arrType)
        {
            Console.WriteLine($"Przypadek {count}: próba {el.Key} (n = {el.Value}), {arrType}");
            Console.WriteLine($"InsertionSort: t = {InsertionSort.Average()}");
            Console.WriteLine($"MergeSort: t = {MergeSort.Average()}");
            Console.WriteLine($"QuickSort: t = {QuickSort.Average()}");
            Console.WriteLine($"QuickSortClassical: t = {QuickSortClassical.Average()}");

        }
    }
}
