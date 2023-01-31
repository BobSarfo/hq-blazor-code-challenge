using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hq_blazor_code_challenge.DAL.Entities
{
    public class CreditCard
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.CreditCard)]
        public string Number { get; set; }

        [MaxLength(12), MinLength(1)]
        public int ExpireMonth { get; set; }

        public int ExpireYear { get; set; }

        [MaxLength(9999), MinLength(100)]
        public int CVV { get; set; }

    }
}
