namespace BLINC.Properties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Polazak")]
    public partial class Polazak
    {
        public int Id { get; set; }

        public int? Linija { get; set; }

        public TimeSpan? Vrijeme { get; set; }

        public bool Povratak { get; set; }

        public virtual Linija Linija1 { get; set; }
    }
}
