
namespace Exc_playground
{
    internal class Binary
    {
        private int[] Nums = Enumerable.Range(0, 102).ToArray();

        private int getUserInfo(int num)
        {
            string[] options = new string[] {
                "My number is higher",
                "My number is lower",
                "Yes this is my number !",
                "Exit"
            };
            Console.WriteLine($"Is it your number ? : - {num} -");

            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i+1}. {options[i]}");
            }

            string userSelection = Console.ReadLine() ?? "4";
            while (!Int32.TryParse(userSelection, out num))
            {
                Console.WriteLine("Provide option number");
                userSelection = Console.ReadLine() ?? "4";
            }
            return num;
        }
        public int binarySearch()
        {
            int lowValues = 0;
            int highValues = Nums.Length - 1;
            int steps = 0;
            while(lowValues < highValues)
            {
                steps++;

                int middleValue = (int)((lowValues + highValues) / 2);

                int userInfo = getUserInfo(Nums[middleValue]);

                if (userInfo == 1)
                    lowValues = middleValue;
                else if (userInfo == 2)
                    highValues = middleValue;
                else if (userInfo == 3)
                {
                    Console.WriteLine($"Your number is {Nums[middleValue]}");
                    Console.WriteLine($"It took me {steps} steps");
                    Console.WriteLine("Goodbye !");
                    break;
                }
                else if (userInfo == 4) 
                {
                    Console.WriteLine("Goodbye !");
                    break;
                }           
            }
            return -1;
        }

    }
}
