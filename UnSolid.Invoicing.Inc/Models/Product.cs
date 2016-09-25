using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnSolid.Invoicing.Inc.Models
{
    public partial class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Number { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        [ForeignKey(nameof(ProductUnit))]
        public int UnitId { get; set; }

        public virtual ProductUnit ProductUnit { get; set; }
    }
}