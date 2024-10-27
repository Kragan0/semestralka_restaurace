using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Restauracia.Domain.Entities
{
    public class OrderItems
    {
        public int Id { get; set; }
        // Foreign keys 
        public int OrderID { get; set; }
        public int MenuItemID   { get; set; }
        public MenuItem MenuItem { get; set; }
        public Order Order { get; set; }
    }
}
