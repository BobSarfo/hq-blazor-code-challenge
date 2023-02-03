using hq_blazor_code_challenge.CustomValidators;
using hq_blazor_code_challenge.DAL.Entities;
using hq_blazor_code_challenge.Services;
using System;
using System.Threading.Tasks;

namespace hq_blazor_code_challenge.Pages
{
    public partial class Form
    {
        private readonly ICreditCardRepository _creditCardRepository;

        public Form(ICreditCardRepository creditCardRepository)
        {            
            _creditCardRepository = creditCardRepository;
        }
        public CreditCard CreditCard { get; set; } = new CreditCard();


        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        public async void HandleValidSubmit()
        {
            await _creditCardRepository.AddNewCreditCard(CreditCard);
        }

        public void ValidateCreditCard()
        {

            //CreditCardValidator.IsValidCreditCard();

        }

    }
}