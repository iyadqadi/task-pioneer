using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using POS;

namespace POS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Items DAO
            GenericDAO<Item,int> genericDAO = new GenericDAO<Item,int>();


            //Using by insert method to add items to DAO
            genericDAO.Insert(new Item() {Id =  1,  BarCode = "9621001", Description = "Pepsi", Price = 0.25, Quantity = 25 });
            genericDAO.Insert(new Item() { Id = 2, BarCode = "9621002", Description = "Cola", Price = 0.25, Quantity = 20 });
            genericDAO.Insert(new Item() { Id = 3, BarCode = "9621003", Description = "Meranda", Price = 0.20, Quantity = 5 });
            genericDAO.Insert(new Item() { Id = 4, BarCode = "9621004", Description = "juice", Price = 1, Quantity = 4 });
            genericDAO.Insert(new Item() { Id = 5, BarCode = "9621005", Description = "Pepsi", Price = 0.5, Quantity = 200 });


            //Retrieving All Items using For each loop
            Console.WriteLine("\nRetrieving All Items using For Each Loop");
            foreach (Item i in genericDAO.GetAll())
            {
                Console.WriteLine(i);
            }

            // OR you can write as below
            Console.WriteLine("\nRetrieving All Items using ForEach method");
            genericDAO.GetAll().ForEach(item => Console.WriteLine(item));

            // Use Exists method when you want to check if an item exists or not
            // in the list based on a condition
            Console.WriteLine("\nExists Method Name StartsWith P");
            if (genericDAO.GetAll().Exists(x => x.Description.StartsWith("P")))
            {
                Console.WriteLine("List contains Item whose Name Starts With P");
            }
            else
            {
                Console.WriteLine("List does not contains any item with description starts With P");
            }




            // Use Find() method, if you want to return the First Matching Element by a conditions 
            Console.WriteLine("\nFind Method to Return First Matching Item whose Desc = Pepsi");
            var item = genericDAO.GetAll().Find(Item => Item.Description  == "Pepsi");
            if(item != null )
                Console.WriteLine(item);





            // Use FindAll() method when you want to return all the items that matches the conditions
            Console.WriteLine("\nFindAll Method to return All Matching Items Where Desc = Pepsi");
            genericDAO.GetAll(Item => Item.Description == "Pepsi").ForEach(x => Console.WriteLine(x));
           


        }
    }
}
