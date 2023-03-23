﻿using System;
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

        [Required(ErrorMessage = "The Last Name is Required")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [StringLength(10)]
        public string FirstName { get; set; }
    }
}