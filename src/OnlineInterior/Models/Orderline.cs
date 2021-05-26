using System.ComponentModel.DataAnnotations;

namespace OnlineInterior.Models
{
    public class Orderline
    {
        [Required]
        public int OrderLineId { get; set; }

        [Display(Name = "Produkt")]
        public string ProductName { get; set; }

        [Display(Name = "Leverantör")]
        public string Supplier { get; set; }

        [Display(Name = "Länk")]
        public string Info { get; set; }

        [Display(Name = "Antal")]
        public int Amount { get; set; }

        [Display(Name = "Styckpris")]
        public int UnitPrice { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int GetLineTotal()
        {
            var lineTotal = Amount * UnitPrice;
            return lineTotal;
        }
    }
}