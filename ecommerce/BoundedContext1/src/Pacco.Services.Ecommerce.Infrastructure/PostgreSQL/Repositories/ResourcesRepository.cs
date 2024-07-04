using Convey.Domain.Entities;
using Convey.Domain.Repository;
using Convey.persistence.PostgreSQL.Repositories;
using Pacco.Services.Ecommerce.Core.Entities;
using Pacco.Services.Ecommerce.Core.Repositories;
using Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.Repositories
{
    public class ResourcesRepository : Repository<Resource, AvailabilityContext>, IResourcesRepository 
    {
        public ResourcesRepository(AvailabilityContext context) : base(context)
        {
            
        }
    }
}
