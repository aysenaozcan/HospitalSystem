namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_doktor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_doktor()
        {
            tbl_randevu = new HashSet<tbl_randevu>();
        }

        [Key]
        public int doktorid { get; set; }

        [StringLength(50)]
        public string doktoradisoyadi { get; set; }

        [StringLength(50)]
        public string doktorbolum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_randevu> tbl_randevu { get; set; }
    }
}
