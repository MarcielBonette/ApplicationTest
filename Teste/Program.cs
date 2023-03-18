using App.Aplication.Models;
using App.Aplication.Services;

CardServices services = new CardServices();

Owner owner = new Owner(1, "Marciel", "123456789");

CreditCard myCard = services.CreateCard(Brand.Mastercard, owner);
myCard.Deposit(5000);
myCard.Buy(2500);
myCard.Buy(950);

string result = $@"
Saldo: {myCard.Money}:
Número: {myCard.Number}";

Console.WriteLine(result);