namespace Верфь
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Boats
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BoatId { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        public int BoatTypeId { get; set; }

        public int? NumberOfRowers { get; set; }

        public bool Mast { get; set; }

        [StringLength(50)]
        public string Colour { get; set; }

        public int? WoodTypeId { get; set; }

        [Column(TypeName = "money")]
        public decimal BasePrice { get; set; }

        public decimal WAT { get; set; }

        public virtual BoatType BoatType { get; set; }

        public virtual WoodType WoodType { get; set; }
    }
}
