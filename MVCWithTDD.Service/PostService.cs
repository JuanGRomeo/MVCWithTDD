using MVCWithTDD.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCWithTDD.Model;
using MVCWithTDD.Data.Repository.Interfaces;
using MVCWithTDD.Data.Infraestructure.Interfaces;

namespace MVCWithTDD.Service
{
    public class PostService : IPostService
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly IPostRepository postRepository;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.postRepository = postRepository;
        }

        public void Create(Post post)
        {
            this.postRepository.Add(post);
            this.unitOfWork.Commit();
        }

        public List<Post> ListRecentPosts(int retrievalCount)
        {
            return this.postRepository.GetAll().OrderByDescending(post => post.PostId).Take(retrievalCount).ToList();
        }
    }
}
