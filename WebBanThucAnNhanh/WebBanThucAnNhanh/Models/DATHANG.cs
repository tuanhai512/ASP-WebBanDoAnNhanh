//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanThucAnNhanh.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DATHANG()
        {
            this.CT_MONAN_DATHANG = new HashSet<CT_MONAN_DATHANG>();
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public int MADATHANG { get; set; }
        public System.DateTime NGAY { get; set; }
        public int MADIACHI { get; set; }
        public Nullable<double> TONGTIEN { get; set; }
        public string GHICHU { get; set; }
        public int MATINHTRANG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_MONAN_DATHANG> CT_MONAN_DATHANG { get; set; }
        public virtual TINHTRANGDON TINHTRANGDON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
