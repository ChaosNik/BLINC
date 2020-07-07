namespace BLINC.Properties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stajaliste")]
    public partial class Stajaliste
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stajaliste()
        {
            StajalisteLinije = new HashSet<StajalisteLinije>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Naziv { get; set; }

        public double? X { get; set; }

        public double? Y { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StajalisteLinije> StajalisteLinije { get; set; }
    }
}
