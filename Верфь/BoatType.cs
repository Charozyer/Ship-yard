namespace Верфь
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BoatType")]
    public partial class BoatType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BoatType()
        {
            Boats = new HashSet<Boats>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BoatTypeId { get; set; }

        [Column("BoatType")]
        [Required]
        [StringLength(50)]
        public string BoatType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boats> Boats { get; set; }
    }
}
