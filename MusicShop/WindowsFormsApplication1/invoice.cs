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
    
    public partial class invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public invoice()
        {
            this.invoicedetails = new HashSet<invoicedetail>();
        }
    
        public int invoiceID { get; set; }
        public int userID { get; set; }
        public Nullable<System.DateTime> datePurchased { get; set; }
        public Nullable<float> total { get; set; }
        public Nullable<float> discount { get; set; }
        public Nullable<float> totalWithDiscount { get; set; }
    
        public virtual user user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<invoicedetail> invoicedetails { get; set; }
    }
}
