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
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Istoria_pokupok = new HashSet<Istoria_pokupok>();
            this.Poseshenie_client = new HashSet<Poseshenie_client>();
        }
    
        public int Id_client { get; set; }
        public string Surname { get; set; }
        public string Name_client { get; set; }
        public string Middle_name { get; set; }
        public System.DateTime Date_client { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Id_pol { get; set; }
        public int Id_teg { get; set; }
    
        public virtual Pol Pol { get; set; }
        public virtual Teg Teg { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Istoria_pokupok> Istoria_pokupok { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Poseshenie_client> Poseshenie_client { get; set; }
    }
}
