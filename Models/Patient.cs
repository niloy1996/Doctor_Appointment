//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoctorsHouseWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.Online_Payments = new HashSet<Online_Payments>();
        }
    
        public int patient_id { get; set; }
        public string patient_name { get; set; }
        public string patient_gender { get; set; }
        public string patient_mobile { get; set; }
        public string patient_email { get; set; }
        public string patient_address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Online_Payments> Online_Payments { get; set; }
    }
}
