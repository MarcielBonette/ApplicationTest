using App.Aplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Aplication.Services
{
    public class CardServices
    {
        private ICardRepository _cardRepository;
        public CardServices(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }
        public CardServices()
        {

        }
        public CreditCard CreateCard(Brand brand, Owner owner)
        {
            ValidOwnerCard(owner);
            string cardNumber = GenerateCardNumber();

            CreditCard cardCreated = new CreditCard()
            {
                Number = cardNumber,
                Brand = brand,
                Owner = owner,
                Status = CreditCardStatus.Active,
            };
            return cardCreated;
        }

        public string GenerateCardNumber()
        {
            Random random = new Random();
            int number = random.Next(9999999);
            int digit = random.Next(9);
            return $"{number}-{digit}";
        }

        public void ValidOwnerCard(Owner owner)
        {
            if(owner == null)
            {
                throw new ArgumentException("Responsável Obrigatório!");
            }
            if(string.IsNullOrEmpty(owner.Name))
            {
                throw new ArgumentException("Campo obrigatório: Nome do Responsável");
            }
            if (string.IsNullOrEmpty(owner.Document))
            {
                throw new ArgumentException("Campo obrigatório: Documento do responsável");
            }
        }

        public interface ICardRepository
        {
            CreditCard GetByNumber(string number);
            int Save(CreditCard mycard);
        }

        public class CardRepository : ICardRepository
        {
            public CreditCard GetByNumber(string number)
            {
                //exemplo:: buscar do banco::
                return null;
            }

            public int Save(CreditCard mycard)
            {
                //saved
                return 1;
            }
        }



    }
}
