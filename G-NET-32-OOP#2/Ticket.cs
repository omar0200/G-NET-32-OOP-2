using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum TicketType { Standard, VIP, IMAX }
struct Seat
{
    public int a;
    public int b;
    public char row;
    public int number;

    public Seat(char row, int number)
    {
        this.row = row;
        this.number = number;
    }

    public override string ToString() => $"{row}{number}";
}

namespace G_NET_32_OOP_2
{
    internal class Ticket
    {

        public TicketType Type { get; set; }
        public Seat _seat { get; set; }
        private double price;
        static private int ticketCounter = 0;
        private String? moviename;

       
        public String? MovieName	
        {
			get { return moviename; }
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					moviename = value;
				}
				else return;
			}
		}
        public double Price
        {
            get { return price; }
            set { if(value > 0 )
                    price = value;
            }
        }
        public double PriceAfterTax { get { return price + price * 0.14; }  }
        public int TicketId  { get;  }

        public Ticket(string movieName, TicketType type, Seat seat, double price)
        {
            ticketCounter++;
            TicketId = ticketCounter;
            MovieName = movieName;
            Type = type;
            _seat = seat;
            Price = price;

        }

        static  public int GetTotalTicketsSold()
        {
            return ticketCounter;
        }

        public override string ToString()
        {
            return $"Ticket ID: {TicketId}, Movie: {MovieName}, Type: {Type}, Seat: {_seat}, Price: {Price}, Price After Tax: {PriceAfterTax}";
        }
    }
}
