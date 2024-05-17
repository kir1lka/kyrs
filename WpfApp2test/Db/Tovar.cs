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
    
    public partial class Tovar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tovar()
        {
            this.Istoria_pokupok = new HashSet<Istoria_pokupok>();
        }
    
        public int Id_tovar { get; set; }
        public string Name_tovar { get; set; }
        public int Id_podkategoria { get; set; }
        public decimal Zakupka { get; set; }
        public double Procent { get; set; }
        public decimal Itog_sum { get; set; }
        public string Harakteristika { get; set; }
        public string Primechanie { get; set; }
        public double Ves { get; set; }
        public int Id_proizvoditel { get; set; }
        public System.DateTime Srok_godnosti { get; set; }
        public byte[] Image { get; set; }
        public byte[] Dop_image { get; set; }
        public int Id_flag { get; set; }
    
        public virtual Flag Flag { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Istoria_pokupok> Istoria_pokupok { get; set; }
        public virtual Podkategoria Podkategoria { get; set; }
        public virtual Proizvoditel Proizvoditel { get; set; }
    }
}