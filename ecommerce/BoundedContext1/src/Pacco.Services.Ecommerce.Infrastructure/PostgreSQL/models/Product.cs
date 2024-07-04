using System;
using System.Collections.Generic;

namespace Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<Tag> Tags { get; set; }
    }

}