//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL_Hotel
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetailProduct
    {
        public int id { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<int> roomID { get; set; }
        public Nullable<int> orderID { get; set; }
        public Nullable<int> productID { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual Room Room { get; set; }
    }
}
