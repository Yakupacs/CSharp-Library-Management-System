//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Kitap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Kitap()
        {
            this.tbl_Emanetlerrr = new HashSet<tbl_Emanetlerrr>();
        }
    
        public int KitapID { get; set; }
        public string KitapAdı { get; set; }
        public string KitapYazarı { get; set; }
        public string KitapYayınevi { get; set; }
        public Nullable<int> KitapSayfaSayısı { get; set; }
        public string KitapKategori { get; set; }
        public string KitapEmanetMi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Emanetlerrr> tbl_Emanetlerrr { get; set; }
    }
}
