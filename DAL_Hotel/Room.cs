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
    
    public partial class Room
    {
        public int id { get; set; }
        public Nullable<int> num { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<int> orderID { get; set; }
        public Nullable<int> floorId { get; set; }
        public Nullable<int> typeRoomId { get; set; }
    
        public virtual Floor Floor { get; set; }
        public virtual Order Order { get; set; }
        public virtual TypeRoom TypeRoom { get; set; }
    }
}
