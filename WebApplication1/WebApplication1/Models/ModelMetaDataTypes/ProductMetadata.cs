using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.ModelMetaDataTypes
{
    public class ProductMetadata
    {
        [Required(ErrorMessage ="Bos buraxilmaz")]
        [StringLength(100,ErrorMessage ="Herf sayi 100den cox olanmaz")]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        [EmailAddress(ErrorMessage ="Email duzgun formatda deyil")]
        public string Email { get; set; }
    }
}
