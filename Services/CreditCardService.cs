using hq_blazor_code_challenge.DAL;
using hq_blazor_code_challenge.DAL.Entities;
using System;
using System.Threading.Tasks;

namespace hq_blazor_code_challenge.Services
{
    public class CreditCardService : ICreditCardService
    {
        public async Task<bool> AddNewCreditCard(CreditCard creditCard)
{
            using (var context = new HqDbContext())
            { 
                context.CreditCards.Add(creditCard);
                await context.SaveChangesAsync();
            }

            return true;    
        }
    }
}
