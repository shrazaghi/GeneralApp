using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class Product : Entity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        protected Product() { }

        public Product(long id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
    }
}
