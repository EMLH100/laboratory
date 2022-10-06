using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory.Models
{
    public interface I_Model<T_Model> where T_Model:I_Model<T_Model>
    {
        T_Model GetById();
        T_Model Insert();
        T_Model Update();
        void Delete();
    }


}
