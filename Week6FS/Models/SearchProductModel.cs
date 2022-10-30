using System;
using System.Collections.Generic;

namespace Week6FS.Models
{
    public partial class SearchProductModel
    { 
        public string ProductName { get; set; } = null!;
   
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        
     
    }
}
