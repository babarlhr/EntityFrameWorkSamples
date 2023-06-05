using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkSample.Models
{
    public class Product
    {
        public int Id { get; set; } //Primary
        public string Name { get; set; } = null!;  //Initializing Name with null ,
                                                   //in .net 6 nullable reference type is enable by defualt.
                                                   //! is a null-forgiving operator. https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving
                                                   //Nulls property will be intialize and handled by entity framework itslef so we can assign null to any property

        public string? Name2 { get; set; } //Nullable    ?
        //If we want to store null in models . it will also make a database coulmn with which allow to store nulls in column
        
       
        [Column(TypeName ="decimal(6,2)")]  //Decimal With two Point of precision
        public decimal Price { get; set; }

    }
}
