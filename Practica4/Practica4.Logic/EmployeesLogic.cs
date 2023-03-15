using Practica4.Data;
using Practica4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4.Logic
{
    public class EmployeesLogic : BaseLogic
    {        
        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }
    }
}
