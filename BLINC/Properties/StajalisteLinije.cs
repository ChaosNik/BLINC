namespace BLINC.Properties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StajalisteLinije")]
    public partial class StajalisteLinije
    {
        public int Id { get; set; }

        public int? Linija { get; set; }

        public int? Stajaliste { get; set; }

        [Column("Redni broj")]
        public int? Redni_broj { get; set; }

        public virtual Linija Linija1 { get; set; }

        public virtual Stajaliste Stajaliste1 { get; set; }
    }
}
