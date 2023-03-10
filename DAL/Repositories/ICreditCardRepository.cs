using hq_blazor_code_challenge.DAL.Entities;
using System.Threading.Tasks;

namespace hq_blazor_code_challenge.DAL.Repositories
{
    public interface ICreditCardRepository
    {
        public Task<bool> AddNewCreditCard(CreditCard creditCard);
    }
}
