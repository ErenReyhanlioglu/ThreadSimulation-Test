using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public decimal Budget { get; set; }
        public CustomerType CustomerType { get; set; } 
        public decimal TotalSpent { get; set; }
    }

    public enum CustomerType
    {
        Premium,
        Standard
    }
}
