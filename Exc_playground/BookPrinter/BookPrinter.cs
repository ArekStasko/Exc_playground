using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground
{
    public class BookPrinter
    {
        LinkedList<Page> pages = new LinkedList<Page>();

        Page page1 = new Page() { Content = "Lorem ipsum dolor sit amet" };
        Page page2 = new Page() { Content = "Lorem ipsum dolor sit amet" };
        Page page3 = new Page() { Content = "Lorem ipsum dolor sit amet" };
        Page page4 = new Page() { Content = "Lorem ipsum dolor sit amet" };
        Page page5 = new Page() { Content = "Lorem ipsum dolor sit amet" };
        Page page6 = new Page() { Content = "Lorem ipsum dolor sit amet" };

        public BookPrinter()
        {
            pages.AddLast(page2);
            LinkedListNode<Page> nodePageFourth = pages.AddLast(page4);
            pages.AddLast(page6);
            pages.AddFirst(page1);
            pages.AddBefore(nodePageFourth, page3);
            pages.AddAfter(nodePageFourth, page5);
        }

        private string GetSpaces(int number)
        {
            string result = string.Empty;
            for (int i = 0; i < number; i++)
            {
                result += " ";
            }
            return result;
        }

        public void Read()
        {
            LinkedListNode<Page> current = pages.First;
            int number = 1;

            while (current != null)
            {
                Console.Clear();
                string numberString = $"- {number} -";
                int leadingSpaces = (90 - numberString.Length) / 2;
                Console.WriteLine(numberString.PadLeft(leadingSpaces + numberString.Length));
                Console.WriteLine();

                string content = current.Value.Content;
                for (int i = 0; i < content.Length; i += 90)
                {
                    string line = content.Substring(i);
                    line = line.Length > 90 ? line.Substring(0, 90) : line;
                    Console.WriteLine(line);
                }

                Console.WriteLine();

                Console.WriteLine(current.Previous != null ? "< PREVIOUS [P]" : GetSpaces(14));
                Console.WriteLine(current.Next != null ? "[N] NEXT >".PadLeft(76) : string.Empty);
                Console.WriteLine();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.N:
                        if (current.Next != null)
                        {
                            current = current.Next;
                            number++;
                        }
                        break;
                    case ConsoleKey.P:
                        if (current.Previous != null)
                        {
                            current = current.Previous;
                            number--;
                        }
                        break;
                    default: return;
                }
            }
        }

    }
}


