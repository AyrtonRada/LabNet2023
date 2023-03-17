using Practica5.Data;
using Practica5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
    }
}
