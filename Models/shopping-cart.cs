using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory.Models
{
    internal class shopping_cart : I_Model<shopping_cart>
    {
        private Int32 _id;                  //int
        private Int32 _customerId;          //int
        private string _billingAddress;     //text
        private string _shippingAddress;    //text
        private DateTime _dateCreated;      //datetime
        private DateTime _dateUpdated;      //datetime
        private DateTime _dateOrdered;      //datetime
        private DateTime _dateShipped;      //datetime
        public shopping_cart GetById()
        {
            return null;
        }
        public shopping_cart Insert()
        {
            return null;
        }
        public shopping_cart Update()
        {
            return null;
        }
        public void Delete()
        {
            //
        }
    }
}
