using laboratory.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("TEST");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button 1 Click");
            customer_Controller my_cust_ctrl = new customer_Controller();

            string my_email = "my@mail.com";
            char[] my_email_char_array = new char[128]; // size does not limit inputs...
            //char[] my_email_char_array = { 'a', '@', 'a', '.', 'a' };
            my_email_char_array = my_email.ToCharArray();

            my_cust_ctrl.CreateCustomer(my_email_char_array);
            my_cust_ctrl.CreateCustomer(my_email.ToCharArray());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button 2 Click");

        }
    }
}
