using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkSample.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }  //Forign Key Relationship with Product  in Database---Navigation Property for class to access by .
        public int OrderId { get; set; } //Forign Key Relationship with Order in database---Navigation Property for class to access by .

        public Order Order { get; set; } = null!;

        public Product Product { get; set; } = null!;
    }
}
