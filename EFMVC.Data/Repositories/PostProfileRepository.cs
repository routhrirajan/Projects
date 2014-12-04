using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFMVC.Data.Infrastructure;
using EFMVC.Model;

namespace EFMVC.Data.Repositories
{
    public class PostProfileRepository : RepositoryBase<PostProfile>, IPostProfileRepository
    {
        public PostProfileRepository(IDatabaseFactory databaseFactory) 
            : base(databaseFactory)
        { 
        }
    }

    public interface IPostProfileRepository : IRepository<PostProfile>
    { 
    }
}
