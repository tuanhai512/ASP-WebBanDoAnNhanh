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
    
    public partial class CTHOADON
    {
        public int MACTHOADON { get; set; }
        public string MAMONAN { get; set; }
        public int MATINHTRANG { get; set; }
        public int MACTMONANDATHANG { get; set; }
        public int MAHOADON { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public string GHICHU { get; set; }
    
        public virtual CT_MONAN_DATHANG CT_MONAN_DATHANG { get; set; }
        public virtual TINHTRANGDON TINHTRANGDON { get; set; }
        public virtual HOADON HOADON { get; set; }
    }
}
