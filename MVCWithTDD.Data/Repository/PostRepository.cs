using EnjoyMyTown.Data.Infraestructure;
using EnjoyMyTown.Data.Infraestructure.Interfaces;
using MVCWithTDD.Data.Repository.Interfaces;
using MVCWithTDD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithTDD.Data.Repository
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
        }
    }
}