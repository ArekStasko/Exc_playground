using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground.YearlyTransport
{
    public static class TransportEnumExtension
    {
        public static char GetChar(this TransportPlan transport)
        {
            switch (transport)
            {
                case TransportPlan.BIKE: return 'B';
                case TransportPlan.BUS: return 'U';
                case TransportPlan.CAR: return 'C';
                case TransportPlan.SUBWAY: return 'S';
                case TransportPlan.WALK: return 'W';
                default: throw new Exception("Uknown transport");
            }
        }

        public static ConsoleColor GetColor(this TransportPlan transport)
        {
            switch (transport)
            {
                case TransportPlan.BIKE: return ConsoleColor.Blue;
                case TransportPlan.BUS: return ConsoleColor.DarkGreen;
                case TransportPlan.CAR: return ConsoleColor.Red;
                case TransportPlan.SUBWAY: return ConsoleColor.DarkMagenta;
                case TransportPlan.WALK: return ConsoleColor.DarkYellow;
                default: throw new Exception("Uknown transport");
            }
        }
    }
}
