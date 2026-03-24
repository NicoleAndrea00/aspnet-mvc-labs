using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Grocery.Models
{
    public class productItems
    {
        [Required]
        [Display(Name ="Product Code")]
        public string prodCode {  get; set; }
        [Required]
        [Display(Name = "Product Description")]
        public string prodDescription { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:€#,##0.00}")]
        [Display(Name ="Product Price")]
        public decimal prodPrice { get; set; }

    }
}
