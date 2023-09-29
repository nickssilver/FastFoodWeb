using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Models
{
    public class Cart
    {

        [Key]
        public int Id { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public String ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        [Required, MinLength]

        public int Count { get; set; }  
    }
}
