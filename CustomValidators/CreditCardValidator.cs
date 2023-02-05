#nullable enable

using System;
using static hq_blazor_code_challenge.CustomValidators.CreditCardAttribute;
using System.Text.RegularExpressions;

namespace hq_blazor_code_challenge.CustomValidators
{
    public static class CreditCardValidator
    {

        public const string MasterCard = "MasterCard";
        public const string Visa = "Visa";
        public const string Amex = "Amex";
        public const string Unknown = "Unknown";



        public const string UnknownUrl = "https://raw.githubusercontent.com/muhammederdem/credit-card-form/master/src/assets/images/chip.png";
        public const string VisaUrl = "https://raw.githubusercontent.com/muhammederdem/credit-card-form/master/src/assets/images/visa.png";
        public const string AmexUrl = "https://raw.githubusercontent.com/muhammederdem/credit-card-form/master/src/assets/images/amex.png";
        public const string MasterCardUrl = "https://raw.githubusercontent.com/muhammederdem/credit-card-form/master/src/assets/images/mastercard.png";

        public static Tuple<bool, string> IsValidCreditCard(string cardNumber)
        {
            string? cardImgUrl = string.Empty;
            cardNumber = cardNumber.Replace(" ", "").Trim();

            // Visa
            if (Regex.IsMatch(cardNumber, "^(4)"))
            {
                cardImgUrl = VisaUrl;
                return new Tuple<bool, string>(cardNumber.Replace(" ","").Length == 13 || cardNumber.Length == 16, VisaUrl);
               
            }


            // MasterCard
            if (Regex.IsMatch(cardNumber, "^(51|52|53|54|55)"))
            {
                cardImgUrl = MasterCardUrl;
                return new Tuple<bool, string>(cardNumber.Length == 16, MasterCardUrl);

            }

            // Amex
            if (Regex.IsMatch(cardNumber, "^(34|37)"))
            {
                cardImgUrl = AmexUrl;
                return new Tuple<bool, string>(cardNumber.Length == 15, AmexUrl);   

            }

            //Unknown
            cardImgUrl = UnknownUrl;
            return  new Tuple<bool, string>( false, Unknown);
            
        }
    }
}
