using Convey.Domain.Entities;
using Convey.Domain.Repository;
using Convey.persistence.PostgreSQL.Repositories;
using Ramin.Services.Products.Core.Domain.Products;
using Ramin.Services.Products.Infrastructure.PostgreSQL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramin.Services.Products.Infrastructure.PostgreSQL.Repositories
{
    public class ProductRepository : Repository<Ramin.Services.Products.Core.Domain.Products.Product, ProductContext>, IProductRepository
    {
        public ProductRepository(ProductContext context) : base(context)
        {

        }
    }
}
