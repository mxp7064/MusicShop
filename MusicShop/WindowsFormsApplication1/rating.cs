//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class rating
    {
        public int ratingID { get; set; }
        public Nullable<int> ratingGrade { get; set; }
        public string comment { get; set; }
        public int userID { get; set; }
        public int productID { get; set; }
    
        public virtual product product { get; set; }
        public virtual user user { get; set; }
    }
}
