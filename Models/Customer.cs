using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomersApi.Models
{
    public class Customer 
    {
        public int id { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
 
        public string Email { set; get; }

 

    }
}