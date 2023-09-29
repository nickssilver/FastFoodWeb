using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Models
{
    public class ApplicationUser : IdentityUser
    { 
        public string Name { get; set; }

        public String City { get; set; }

        public String Adresss { get; set; }

        public string PostalCode { get; set; }

    }
}
