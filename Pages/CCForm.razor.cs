using hq_blazor_code_challenge.DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Components;
using hq_blazor_code_challenge.DAL.Repositories;
using hq_blazor_code_challenge.CustomValidators;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;

namespace hq_blazor_code_challenge.Pages
{
    public partial class CCForm
    {

        [Inject]
        public ICreditCardRepository?   CreditCardRepository { get; set; }

        public CreditCard CreditCard { get; set; } = new CreditCard();
        private List<string> _months { get; set; } = new List<string> { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
        private List<int> _years { get; set; } = Enumerable.Range(DateTime.Now.Year, 10).ToList();
        public string CardProviderImg { get; set; } = String.Empty;



        protected async Task HandleValidSubmit(){

            await CreditCardRepository.AddNewCreditCard(CreditCard);
            
        }

        public void UpdateName(ChangeEventArgs args) 
        {
            CreditCard.Name = (string)args.Value;
        }
        
        public void MatchCreditCard(ChangeEventArgs args)
        {
            CreditCard.Number = (string)args.Value;
            if (CreditCard.Number is not null)
            {
                var result = CreditCardValidator.IsValidCreditCard(CreditCard.Number);
                CardProviderImg = result.Item2;
            }
        }

    }
}
