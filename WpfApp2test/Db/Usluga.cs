//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2test.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usluga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usluga()
        {
            this.Istoria_pokupok = new HashSet<Istoria_pokupok>();
            this.Poseshenie_client = new HashSet<Poseshenie_client>();
        }
    
        public int Id_usluga { get; set; }
        public string Name_usluga { get; set; }
        public string Opisanie { get; set; }
        public decimal Stoimost { get; set; }
        public Nullable<double> Skidka { get; set; }
        public int Prodolzhitelnost { get; set; }
        public byte[] Osn_photo { get; set; }
        public byte[] Dop_photo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Istoria_pokupok> Istoria_pokupok { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Poseshenie_client> Poseshenie_client { get; set; }
    }
}