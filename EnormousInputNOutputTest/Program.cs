using EnormousInputNOutputTest;

var controllers = new Controllers();
int[] result = controllers.RunTest(5);
foreach (int i in result) Console.WriteLine(i);