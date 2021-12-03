namespace Верфь
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contracts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contracts()
        {
            Invoices = new HashSet<Invoices>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContractId { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "money")]
        public decimal DepositPayed { get; set; }

        public int OrderId { get; set; }

        [Column(TypeName = "money")]
        public decimal ContractTotalPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal ContractTotalPriceInclVAT { get; set; }

        public int ProductionProcessId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoices> Invoices { get; set; }
    }
}
