namespace G_NET_32_OOP_2
{
    public enum TicketType { Standard, VIP, IMAX }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //    public string Owner;
            // public double Balance; both of them are public 

            //to fix it i will make it private with setter and getter and  i will do validation to withdraw function 

            //exposing fields directly  is bad because it violate oop principles because any one can set and get informations which should be private 

            #endregion

            #region Question 2 
            //field is direct data storage which  has no validation and breaks encapsulation when it public
            //meanwhile property enforce encapsulation and  could be validated 
            #endregion


            #region Question 3
            //a) this[] is an indexer which makes object accessed by array syntax
            //b) it will raise excepetion because array has 5 elements only from 0 to 4 and 10 is out of boundaries 
            // i can do a validation of index of array to be less than size of array
            //c) yes class could have more than indexer but with diffrent parameter to avoid parameter overload 
            #endregion


            #region Question 4
            //a) static makes it variable to be for the class not for instance of class that means everytime order object is instatiated total order 
            //isnot count from 0 , item field is instance variable "item" for obj 1 is diff of obj 2 
            //b) No, a static method cannot access the Item field directly.

            #endregion

            #region Question 5
            Cinema c = new Cinema();
            Console.WriteLine("Enter Data for 3 Tickets");
            for (int i = 1; i < 4; i++) {
              
                string Moviename;
                Console.WriteLine($"Enter data for Ticket {i}");
                Console.WriteLine("Movie Name: ");
               Moviename= Console.ReadLine();
                Console.WriteLine("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
                int choice = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Seat Row (A-Z): ");
               char seatrow= Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Seat Number: ");
              int seatnumber=  Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Price: ");
             double price=   Convert.ToDouble(Console.ReadLine());
                TicketType type = (TicketType)choice;
                c[i] = new Ticket(Moviename, type, new Seat(seatrow, seatnumber), price);

            }
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine(c[i]);
            }
            #endregion

            #region Searchwithmove


        }
    }
}
