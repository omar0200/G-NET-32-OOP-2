using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_32_OOP_2
{
    internal class Cinema
    {
        private Ticket[] _ticket = new Ticket[20];
        public Ticket this[int index] { 
            get {
                if (index < 20 && index >= 0)
                    return _ticket[index];
                else
                {
                    Console.WriteLine("Not Found");
                    return null;
                  
                }
            }
            set
            {
                if (index < 20 && index >= 0)
                     _ticket[index] = value;
                else return ;
            }


        }

        public Ticket this[string movieName]
        {
            get
            {
                foreach (var ticket in _ticket)
                {
                    if (ticket != null && ticket.MovieName == movieName)
                        return ticket;
                }
                return null;
            }
        }
        public Ticket AddTicket(Ticket t)
        {
            for (int i = 0; i < 20 ; i++)
            {
                if (_ticket[i] == null)
                {
                    _ticket[i] = t;
                    return t;
                }
            }

            return null;
        }
    }
}
