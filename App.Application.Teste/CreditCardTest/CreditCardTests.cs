using App.Aplication.Models;
using App.Aplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Teste.CreditCardTest
{
    public class CreditCardTests
    {
        //[Fact(Skip="Motivo para pular o teste)] >> Quando coloco dessa forma, ele automaticamente pula os testes na qual está sendo referenciado.
        [Fact(DisplayName = "Testando cartão com número")]
        [Trait("Cartão", "com número")]
        public void DeveCriarCartaoComNumero()
        {
            CardServices services = new CardServices();
            Owner owner = new Owner(1, "Marciel", "123124");

           var CreditCard = services.CreateCard(Aplication.Models.Brand.Visa, owner);

            //Assert xUnit
            Assert.NotNull(CreditCard.Number);
            Assert.NotEqual("", CreditCard.Number);
        }
    }
}
