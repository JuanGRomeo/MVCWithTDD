using MVCWithTDD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithTDD.Models
{
    public class InMemoryPostRepository : IPostRepository
    {
        //simulates database storage
        private static IList<Post> posts = new List<Post>();

        public void Create(Post post)
        {
            posts.Add(post);
        }

        public IList<Post> ListRecentPosts(int retrievalCount)
        {
            if (retrievalCount < 0)
                throw new ArgumentOutOfRangeException("retrievalCount"
                    , "Let’s be positive, ok?");

            IList<Post> recent = new List<Post>();
            int recentIndex = posts.Count - 1;
            for (int i = 0; i < retrievalCount; i++)
            {
                if (recentIndex < 0)
                    break;
                recent.Add(posts[recentIndex--]);
            }
            return recent;
        }

        public static void Clear()
        {
            posts.Clear();
        }
    }
}