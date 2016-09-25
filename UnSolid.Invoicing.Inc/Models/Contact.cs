using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnSolid.Invoicing.Inc.Models
{
    public class Contact
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public int? VatNumber { get; set; }

        public bool Active { get; set; }

        public string Email { get; set; }

        public string StreetAddress { get; set; }

        public int StreetZipCode { get; set; }

        public int StreetCity { get; set; }

        public string PostalAddress { get; set; }

        public int PostalZipCode { get; set; }

        public int PostalCity { get; set; }

        public decimal Disccount { get; set; }

    }
}