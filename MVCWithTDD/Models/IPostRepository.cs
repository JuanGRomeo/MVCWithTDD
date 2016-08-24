using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWithTDD.Models
{
    public interface IPostRepository
    {
        void Create(Post post);
        IList<Post> ListRecentPosts(int retrievalCount);
    }
}
