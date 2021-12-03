namespace Верфь
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Invoices
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceId { get; set; }

        public int ContractId { get; set; }

        public bool Settled { get; set; }

        [Column(TypeName = "money")]
        public decimal Sum { get; set; }

        [Column(TypeName = "money")]
        public decimal SumInclVAT { get; set; }

        public DateTime Date { get; set; }

        public virtual Contracts Contracts { get; set; }
    }
}
