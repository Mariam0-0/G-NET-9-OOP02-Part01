using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace G_NET_9_OOP02_Part01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            // =================================================================================================
            //Q1: Consider the following class:
            //a) Identify at least two problems with this design from an encapsulation perspective.
            //b) Describe how you would fix this class to follow proper encapsulation principles.You do not need to write the full code.
            //c) Explain why exposing fields directly(as public) is considered a bad practice in OOP.
            // =================================================================================================

            // a) 
            // 1- the fields in the class are public and could be accessed anywhere which is violating encapsulation
            // 2- Withdraw function has no validation for -ve balance which is logically wrong
            //=======================================================================


            // b)
            // Make the fields into wither private fields with getters and setters or into properties
            // Add validation for Withdraw method

            //public class BankAccount
            //{
            //    public string Owner { get; set; }
            //    public double Balance { get; set; }

            //    public void Withdraw(double amount)
            //    {
            //        if (Balance >= amount)
            //        {
            //            Balance -= amount;
            //            return;
            //        }
            //        Console.WriteLine("Balance not enough to withdraw");

            //    } 
            //}
            //=======================================================================

            // c)
            // Because then anyone can change those values without logical consideration or against business rules
            // which is violating the encapsulation principle in OOP
            #endregion

            #region Question 02
            // =================================================================================================
            //Q02 : What is the difference between a field and a property in C#? Can a property contain logic?
            //Give an example of a read-only property that returns a calculated value.
            // =================================================================================================


            // Field: is representing something in the class like Name, Age, Address, but with no validation

            // Property: is similar to a method that can get and set values in the attribute by calling it directly
            // but with cleaner syntax in C#
            // ===================================================================

            // Properties can contain any logic in setting and getting like normal set and get methods

            // ===================================================================

            // Read Only Property

            //private int quantity;
            //private decimal unitPrice;
            //public string TotalPrice
            //{
            //    get { return quantity * unitPrice; }
            //}

            // ===================================================================


        #endregion

        #region Question 03
        // =================================================================================================
        //Q3 : Look at the following code and answer the questions below:
        //a) What is `this[int index]` called? Explain its purpose.
        //b) What happens if someone writes `register[10] = "Ali";` ? How would you make the indexer safer?
        //c) Can a class have more than one indexer? If yes, give an example of when that would be useful.
        // =================================================================================================

        #endregion




        #region Question 04
        // =================================================================================================
        //Q4 : Consider the following code and answer the questions below:
        //a) What does the `static` keyword mean on `TotalOrders`? How is it different from the `Item` field?
        //b) Can a static method inside `Order` access the `Item` field directly? Why or why not?
        // =================================================================================================


        #endregion






    }
    }
}
