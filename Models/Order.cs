using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkSample.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulFilled { get; set; }       
        public int CustomerID { get; set; }  //Represent Foriegn key Relationship with Customer Table .
                                             //If we omit this property in class it will be automatically created by EntityFramewrok
                                             //because it is also called a shadow property.

        public Customer Customer { get; set; } = null!; //Navigation property --- Forign key Relationship .. One customer ID for order.

        public ICollection<OrderDetail> OrderDetails { get; set; } = null!; //Navigation property

    }
}
