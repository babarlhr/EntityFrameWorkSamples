using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkSample.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;  
        public string LastName { get; set; } = null!;
        public string? Address { get; set; } //Allow creating database columns with null values
        public string? Phone { get; set; }

        public string? Email { get; set; }

        public ICollection<Order> Orders { get; set; } = null!;  //Navigation Property  ---Collection of order objects
        //Its means that customer had 0(Zero) Or More Orders   --- One2Many Relationship In Database
    }
}
