using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Aplication.Models
{
    public class Owner
    {
        public Owner(int id, string name, string document)
        {
            this.Id = id;
            this.Name = name;
            this.Document = document;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
    }
}
