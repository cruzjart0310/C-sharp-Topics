using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.PatternDesign.Factory
{
    public class CreditCardFactory
    {
        public CreditCardFactory()
        {

        }

        public static ICreditCard GetCreditCard(CardType cardType)
        {
            ICreditCard cardDetails = null;
            if (cardType == CardType.TITANIUM)
            {
                cardDetails = new Titanium();
            }
            else if (cardType == CardType.PLATINUM)
            {
                cardDetails = new Platinum();
            }
            else if (cardType == CardType.GOLD)
            {
                cardDetails = new Gold();
            }
            return cardDetails;
        }
    }
}
