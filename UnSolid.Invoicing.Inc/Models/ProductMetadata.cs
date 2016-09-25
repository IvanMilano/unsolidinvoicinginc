using System;
using System.ComponentModel.DataAnnotations;

namespace UnSolid.Invoicing.Inc.Models
{
    [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    {
    }

    public partial class ProductMetadata
    {
        [Display(Name = "ProductUnit")]
        public ProductUnit ProductUnit { get; set; }

        [Required(ErrorMessage = "Please enter : Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Number")]
        public string Number { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Discount")]
        public decimal Discount { get; set; }

        [Display(Name = "UnitId")]
        public int UnitId { get; set; }

    }
}
