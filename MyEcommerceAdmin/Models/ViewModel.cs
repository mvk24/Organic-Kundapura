using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEcommerceAdmin.Models
{
    public class ViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<SubCategory> SubCategories { get; set; }
    }
}