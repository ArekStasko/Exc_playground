using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground.YearlyTransport
{
    public class YearlyTransport
    {
        private TransportPlan[][] GetTransportPlan()
        {
            Random random = new Random();
            int transportTypesCount = Enum.GetNames(typeof(TransportPlan)).Length;

            TransportPlan[][] transport = new TransportPlan[12][];

            for (int month = 1; month <= 12; month++)
            {
                //Good example of getting count of days in concrete month
                int daysCount = DateTime.DaysInMonth(
                    DateTime.Now.Year, month);

                transport[month-1] = new TransportPlan[daysCount];

                for (int day = 1; day <= daysCount; day++)
                {
                    int randomType = random.Next(transportTypesCount);
                    transport[month - 1][day - 1] = (TransportPlan)randomType;
                }
            }

            return transport;
        }

        private string[] GetMonthNames()
        {
            string[] names = new string[12];

            for(int month = 1; month <= 12; month++)
            {
                DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
                string name = firstDay.ToString("MMMM");
                names[month-1] = name;
            }
            return names;
        }

        public void DisplayTransportPlan()
        {
            var transport = GetTransportPlan();
            string[] monthNames = GetMonthNames();
            int monthNamesPart = monthNames.Max(n => n.Length) * 2;

            for (int month = 1; month <= transport.Length; month++)
            {
                Console.Write($"{monthNames[month - 1]}):".PadRight(monthNamesPart));
                
                for (int day = 0; day <= transport[month-1].Length; day++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = transport[month-1][day-1].GetColor();
                    Console.Write(transport[month-1][day-1].GetChar());
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
