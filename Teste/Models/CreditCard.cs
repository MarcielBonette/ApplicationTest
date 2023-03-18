using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Aplication.Models
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public decimal Money { get; set; }
        public CreditCardStatus Status { get; set; }
        public Owner Owner { get; set; }
        public Brand Brand { get; set; }

        public void Deposit(decimal value)
        {
            this.Money += value;
        }

        public void Buy(decimal value)
        {
            this.Money -= value;
        }
    }
}
