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
    
    public partial class MONAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONAN()
        {
            this.CT_MONAN_DATHANG = new HashSet<CT_MONAN_DATHANG>();
        }
    
        public string MAMONAN { get; set; }
        public string TENMONAN { get; set; }
        public string HINHANH { get; set; }
        public Nullable<int> MADONVITINH { get; set; }
        public double GIABAN { get; set; }
        public Nullable<double> THUE { get; set; }
        public string MOTA { get; set; }
        public string MALOAI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_MONAN_DATHANG> CT_MONAN_DATHANG { get; set; }
        public virtual DONVITINH DONVITINH { get; set; }
        public virtual LOAI LOAI { get; set; }
    }
}
