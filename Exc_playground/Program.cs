using Exc_playground;
using Exc_playground.YearlyTransport;
using Exc_playground.SortingAlgorithms;

/*
Console.WriteLine("I will guess your number !");
Console.WriteLine("select a number from 1 to 100");
var binary = new Binary();
binary.binarySearch(); 

var findDivider = new FindDivider();
Console.WriteLine(findDivider.divider(48, 8));


Stock stock = new Stock("THPW");
stock.Price = 27.10M;
// Register with the PriceChanged event
stock.PriceChanged += stock_PriceChanged;
stock.Price = 31.59M;

static void stock_PriceChanged(object sender, PriceChangedEventArgs e)
{
    if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
        Console.WriteLine("Alert, 10% stock price increase!");
}


var multiplicationTable = new MultiplicationTable();
int[,] table = multiplicationTable.table;
for (int i = 0; i < table.GetLength(0); i++)
{
    Console.WriteLine($"{table[i,0]} {table[i, 1]} {table[i, 2]} {table[i, 3]} {table[i, 4]} {table[i, 5]} {table[i, 6]} {table[i, 7]} {table[i, 8]} {table[i, 9]}");
}

var yearlyTransport = new YearlyTransport();
yearlyTransport.DisplayTransportPlan();

var sumOfMinimum = new SumOfMinimum();

Console.WriteLine(sumOfMinimum.GetSumOfMinimum());

var EventsNDelegatesExample = new EventsAndDelegates();
EventsNDelegatesExample.RunRegistration();

var spoonerizeString = new SpoonerizeString();
// should return -> "bedding wells"
Console.WriteLine(spoonerizeString.Spoonerize("wedding bells"));

//Should return 6
var remainderWithoutMod = new RemainderWithoutModulus();
Console.WriteLine(remainderWithoutMod.RemainderWithoutMod(27, 5));
int[] nums = new int[] { 10, 23, 43, -12, 43, -43, 45, 13, 549 };
string[] strings = new string[] { "b", "c", "a" };
var selSort = new SelectionSort();
selSort.selectionSort(nums);
selSort.selectionSort(strings);

foreach (int num in nums) Console.Write($"{num} ");
Console.WriteLine();
foreach (string str in strings) Console.Write($"{str} ");
*/

int[] nums = new int[] { 10, 23, 43, -12, 43, -43, 45, 13, 549 };
var insertSort = new InsertionSort();
insertSort.insertionSort(nums);
foreach (int num in nums) Console.Write($"{num} ");