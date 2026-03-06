namespace G_NET_32_OOP_2
{
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

        }
    }
}
