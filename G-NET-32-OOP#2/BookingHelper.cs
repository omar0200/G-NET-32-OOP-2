using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_32_OOP_2
{
    internal static class BookingHelper

    {
        private static int counter = 0;
        static public double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            if (numberOfTickets > 5) {
                double totalprice;
                totalprice = (pricePerTicket * numberOfTickets) * .90;
                return totalprice;
            }
            else return numberOfTickets * pricePerTicket;
        }
        static public string GenerateBookingReference()
        {
            counter++;
            return $"BK- {counter}";
        }
    }
}
