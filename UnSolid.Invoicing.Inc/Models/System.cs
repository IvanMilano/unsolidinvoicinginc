using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnSolid.Invoicing.Inc.Models
{
    public class System
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public int OrgNumber { get; set; }

        [ForeignKey(nameof(OrgType))]
        public int OrgTypeId { get; set; }

        public virtual OrgType OrgType { get; set; }

        public string Email { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public int ZipCode { get; set; }

        public string City { get; set; }

        public string Swift { get; set; }

        public string Iban { get; set; }

        public int Phone { get; set; }

        public string Url { get; set; }

        public int Maturity { get; set; }

        public bool UseVat { get; set; }

    }
}