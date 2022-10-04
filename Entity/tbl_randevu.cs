namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_randevu
    {
        [Key]
        public int randevuid { get; set; }

        [StringLength(50)]
        public string randevuadsoyad { get; set; }

        [StringLength(11)]
        public string randevutcno { get; set; }

        [StringLength(11)]
        public string randevutel { get; set; }

        public int? randevudoktorid { get; set; }

        public int? randevubolumid { get; set; }

        public DateTime? randevutarihsaat { get; set; }

        public int? randevuhastaid { get; set; }

        public virtual tbl_bolum tbl_bolum { get; set; }

        public virtual tbl_doktor tbl_doktor { get; set; }

        public virtual tbl_hasta tbl_hasta { get; set; }
    }
}
