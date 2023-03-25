using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica4.MVC.Models
{
    public class EmployeesView
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "*El Apellido es Obligatorio")]        
        [StringLength(20, ErrorMessage = "*El límite es 20 carácteres")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*El Nombre es Obligatorio")]        
        [StringLength(10, ErrorMessage = "*El límite es 10 carácteres")]
        public string FirstName { get; set; }
    }
}