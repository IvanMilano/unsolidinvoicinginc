using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnSolid.Invoicing.Inc.Models
{
    public class InvoiceLine
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Quantity { get; set; }

        public decimal? Discount { get; set; }

        public decimal Vat { get; set; }

        public decimal Price { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int InvoiceId { get; set; }

        public Invoice Invoice { get; set; }
    }
}