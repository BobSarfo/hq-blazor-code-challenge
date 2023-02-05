using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hq_blazor_code_challenge.DAL.Entities
{
    public class CreditCard
    {
        //[Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.CreditCard)]
        public string Number { get; set; }

        [Required]
        public string ExpireMonth { get; set; }

        [Required]
        public int ExpireYear { get; set; }

        [Required]
        [Range(100,9999, ErrorMessage ="CVV is out of range")]
        public int CVV { get; set; }

    }
}
