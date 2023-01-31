using System;

namespace hq_blazor_code_challenge.DAL.Entities
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear { get; set; }
        public int CVV { get; set; }

    }
}
