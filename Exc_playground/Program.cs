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

int[] nums = new int[] { 10, 23, 43, -12, 43, -43, 45, 13, 549 };
var insertSort = new InsertionSort();
insertSort.insertionSort(nums);
foreach (int num in nums) Console.Write($"{num} ");

int[] nums = new int[] { 10, 23, 43, -12, 43, -43, 45, 13, 549, -30 };
int[] nums2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 0 };
var bubbleSort = new BubbleSort();
bubbleSort.sort(nums2);
foreach (int num in nums2) Console.Write($"{num} ");


int[] nums = new int[] { 10, 23, 43, -12, 43, -43, 45, 13, 549, -30 };
var quicksort = new QuickSort();
quicksort.sort(nums);
foreach (int num in nums) Console.WriteLine(num);
*/
/*
// SHOULD RETURN "abigailtheta" FOR 2
string[] arr = new String[] {"zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"};

//SHOULD RETURN "ixoyx3452zzzzzzzzzzzz" FOR 3
string[] arr1 = new string[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" };

var ConString = new ConsecutiveStrings();
Console.WriteLine(ConString.findString(arr1, 3));
*/

// SHOULD RETURN 30
/*
int result = ModifiedSum.GetModifiedSum(new int[] { 1, 2, 3}, 3);
Console.WriteLine(result);


int[] nums = new int[] { 1, 22, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] result = SumOfMinimum.revert(nums);
foreach (int num in result) Console.WriteLine(num);

var data = new Dictionary<Guid, string>();
var productLocation = new ProductLocation(data);
var a = productLocation.AddProduct("Magazyn A");
var b = productLocation.AddProduct("Magazyn B");
var c = productLocation.AddProduct("Magazyn C");
var d = productLocation.AddProduct("Magazyn D");

productLocation.DeleteProduct(c);
productLocation.DeleteProduct(d);
productLocation.PrintProducts();
Console.WriteLine(productLocation.GetProductLocation(a));
Console.WriteLine(productLocation.GetProductLocation(new Guid()));

var data = new Dictionary<Guid, User>() { };
var userDetails = new UserDetails(data);

var a = userDetails.AddUser(new User("Tom", "Fox", "tom.fox@mkc.com"));
var b = userDetails.AddUser(new User("John", "Smith", "tom.fox@mkc.com"));
var c = userDetails.AddUser(new User("Jake", "Clark", "tom.fox@mkc.com"));
var d = userDetails.AddUser(new User("Zack", "Lorren", "tom.fox@mkc.com"));

userDetails.DeleteUser(d);
userDetails.DeleteUser(c);
userDetails.PrintUsers();
Console.WriteLine(userDetails.GetUser(a));
Console.WriteLine(userDetails.GetUser(new Guid()));

var sortedDictionary = new SortedDictionary();
sortedDictionary.AddItem("Sidzina", "Jakas wiocha");
sortedDictionary.AddItem("Skotniki", "Wiocha obok sidziny");
sortedDictionary.AddItem("Belchatow", "Chyba jest cos takiego");
sortedDictionary.AddItem("Ruczaj", "Pato wiocha");
sortedDictionary.AddItem("Austynów", "Wymyslilem to");
sortedDictionary.AddItem("Kraków", "Metropolia <3");
sortedDictionary.PrintItems();

var apiDemo = new API_demo();
apiDemo.Call();

*/

var tree = new BasicTree<int>();
tree.Root = new TreeNode<int>();
tree.Root.Data = 100;
var node1 = new TreeNode<int>();
var node2 = new TreeNode<int>();
var node3 = new TreeNode<int>();
tree.Root.Children = new List<TreeNode<int>> { node1, node2, node3 };
node1.Parent = tree.Root;
node2.Parent = tree.Root;
node3.Parent = tree.Root;
node1.Data = 50;
node2.Data = 1;
node3.Data = 150;
var node3Children = new TreeNode<int>();
node3.Children = new List<TreeNode<int>>() { node3Children };
node3Children.Parent = node3;



