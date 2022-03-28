using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Exc_playground
{
    public class SortedDictionary
    {
        private SortedDictionary<string, string> _wiki = new SortedDictionary<string, string>();

        public SortedDictionary<string, string> Wiki { get => _wiki; }

        public void AddItem(string key, string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(key))
            {
                Console.WriteLine("You cant provide empty data");
                return;
            }
            Wiki.Add(key, value);
        }

        public void DeleteItem(string key)
        {
            if(Wiki.ContainsKey(key)) Wiki.Remove(key);
            else
            {
                Console.WriteLine($"You dont have item with {key} item");
                return;
            }
        }

        public void PrintItems()
        {
            foreach (var item in Wiki)
                Console.WriteLine($"{item.Key} - {item.Value}");
        }


    }
}
