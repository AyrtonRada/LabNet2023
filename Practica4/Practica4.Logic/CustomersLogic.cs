using Practica4.Data;
using Practica4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4.Logic
{
    public class CustomersLogic : BaseLogic
    {        
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
    }
}
