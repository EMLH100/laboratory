using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory.Models
{
    internal class product : I_Model<product>
    {
        private Int32 _id;              //int
        private Int64 _gtinCode;        //bigint
        private Int32 _quantityInStock; //int
        private string _name;           //text
        private string _description;    //text
        public product GetById()
        {
            return null;
        }
        public product Insert()
        {
            return null;
        }
        public product Update()
        {
            return null;
        }
        public void Delete()
        {
            //
        }
    }
}
