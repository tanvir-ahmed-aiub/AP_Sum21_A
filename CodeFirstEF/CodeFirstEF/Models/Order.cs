using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class Order
    {

        public Order() {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public int StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

       
    }
}