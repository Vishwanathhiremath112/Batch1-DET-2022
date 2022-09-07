using Batch1_DET_2022.Data;
using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class CodeFirstApproach
    {
        static void Main(string[] args)
        {
            //AddNewBook();
            //DeleteNewBook();
            //UpdateBookk();
            // GetBooks();
            //AddnewCustomerAndOrder();
            //GetAllCustomersWithOrder_EagerLoading();
            //GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();

            Console.ReadLine();
        }

        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 3;
        //    book.BookName = "abc";
        //    book.author = "Ali";
        //    book.price = 250;


        //    try
        //    {
        //        ctx.Book.Add(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New book added successfully");
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void DeleteNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 2;
        //    book.BookName = "c#";
        //    book.author = "John";
        //    book.price = 200;


        //    try
        //    {
        //        ctx.Book.Remove(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New book removed successfully");
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}


        //public static void UpdateBookk()
        //{
        //    var ctx = new BookContext();
        //    var book = ctx.Book.Where(a => a.BookID == 2).SingleOrDefault();

        //    book.BookName = "c";
        //    book.author = "Johnn";
        //    book.price = 400;

        //        ctx.Update(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" book updated successfully");

        //}

        //private static void GetBooks()
        //{
        //    try
        //    {
        //        var ctx = new BookContext();
        //        var books = ctx.Book;

        //        foreach (var book in books)
        //        {
        //            Console.WriteLine(book.BookID + "  " + book.BookName + "  " + book.author + "  " + book.price);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //    private static void AddnewCustomerAndOrder()
        //{
        //    var ctx = new BookContext();
        //    Customer customer = new Customer();
        //    customer.ID = 1;
        //    customer.Name = "Vishwanath";
        //    customer.Age = 25;

        //    Order ord = new Order();
        //    ord.Order_ID = 100;
        //    ord.Amount = 2000;
        //    ord.OrderDate = DateTime.Now;

        //    Order orde = new Order();
        //    ord.Order_ID = 200;
        //    ord.Amount = 3000;
        //    ord.OrderDate = DateTime.Now;

        //    orde.cust = customer;
        //    try
        //    {
        //        ctx.Orders.Add(orde);
        //        ctx.SaveChanges();
        //        Console.WriteLine("customer and order is created");
        //    }
        //    catch (Exception ex)
        //    { Console.WriteLine(ex.Message); }



            //private static void GetAllCustomersWithOrder_EagerLoading()
            //{
            //    //Eager loading means that the related data is loaded 
            //    //from the database as part of the initial query.
            //    var ctx = new BookContext();
            //    try
            //    {
            //        var customers = ctx.Customers.Include("Orders");

            //        //var customers = ctx.Customers.Include(o => o.Orders);                   

            //        foreach (var customer in customers)
            //        {
            //            Console.WriteLine(customer.Name);
            //            Console.WriteLine("----->");


            //            foreach (var order in customer.Orders)
            //            {
            //                Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
            //            }
            //            Console.WriteLine("-----");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }



            //private static void GetAllCustomersWithOrder_ExplicitLoading()
            //{
            //    //Explicit loading means that the related data is
            //    //explicitly loaded from the database at a later time.
            //    //Needs MARS to be set to TRUE in connection string
            //    var ctx = new BookContext();
            //    try
            //    {
            //        var customers = ctx.Customers;

            //        foreach (var customer in customers)
            //        {
            //            Console.WriteLine(customer.Name);
            //            Console.WriteLine("----->");

            //            ctx.Entry(customer).Collection(o => o.Orders).Load();

            //            foreach (var order in customer.Orders)
            //            {
            //                Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());

            //            }
            //            Console.WriteLine("-----");

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            private static void Disconnectedarchitecture()
            {
                var ctx = new BookContext();

                var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

                ctx.Dispose();

                UpdateCustomerName(customer);

            }


        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            //  ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");

        }
  
     
       


    }
}
