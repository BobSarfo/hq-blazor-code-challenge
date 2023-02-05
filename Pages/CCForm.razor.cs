using hq_blazor_code_challenge.DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace hq_blazor_code_challenge.Pages
{
    public partial class CCForm
    {
        public CreditCard CreditCard { get; set; } = new CreditCard();
        private List<string> _months { get; set; } = new List<string> { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
        private List<int> _years { get; set; } = Enumerable.Range(DateTime.Now.Year, 10).ToList();

    }
}
