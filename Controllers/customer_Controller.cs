//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using laboratory.Models;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace laboratory.Controllers
{
    internal class customer_Controller //: I_Controllers
    {
        public void CreateCustomer(char[] email)
        {
            Console.WriteLine($"call: CreateCustomer({new string(email)})");
            CreateCustomer(email, new char[]{}, new char[]{}); // call other constructor with preset arguments

        }
        public void CreateCustomer(char[] email, char[] firstName, char[] lastName)
        {
            Console.WriteLine("call: CreateCustomer("
                + new string(email) + ", "
                + new string(firstName) + ", "
                + new string(lastName) + ")")
            ;
            customer customer = new customer(email, firstName, lastName);
            //customer.Insert();
        }
    }

}



/*
        public void DisplayCustomer(int customerId) {
            Customer customer = new Customer(customerId);
            customer.GetById();
            this.DisplayCustomer(customer);
        }

        public void DisplayCustomer(Customer customer) {
            // do something later in the course when we have views, or, if you want,
            // dump the data to the console.
        }

        public void UpdateCustomer(int customerId, string firstName, string lastName, string email) {
            Customer customer = Customer.GetById(customerId);
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.Email = email;
            customer.Update();
        }

        public void DeleteCustomer(int customerId) {
            Customer customer = new Customer(customerId);
            this.DeleteCustomer(customer);
        }

        public void DeleteCustomer(Customer customer) {
            customer.Delete();
        }
*/