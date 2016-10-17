using MVCWithTDD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWithTDD.Service.Interfaces
{
    public interface IPostService
    {
        void Create(Post post);
        List<Post> ListRecentPosts(int retrievalCount);
    }
}
