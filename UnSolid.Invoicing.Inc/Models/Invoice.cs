using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnSolid.Invoicing.Inc.Models
{
    public class Invoice
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public long Number { get; set; }

        public decimal Sum { get; set; }

        public string Description { get; set; }

        public string Reference { get; set; }

        public string DeliveryPlace { get; set; }

        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }

        [ForeignKey(nameof(Contact))]
        public int ContactId { get; set; }

        public virtual Contact Contact { get; set; }
    }
}