using Convey.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramin.Microservice.Catelog.Core.Domain.Products
{
    public class Product : AggregateRoot
    {
        public string Title { get; set; }

        private Product(string title)
        {
            Title = title;
        }
        public static Product Create(string title)
        {
            return new Product(title);
        }
    }
}
