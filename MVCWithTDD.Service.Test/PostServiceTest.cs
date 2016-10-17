using EnjoyMyTown.Data.Infraestructure.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MVCWithTDD.Data.Repository.Interfaces;
using MVCWithTDD.Model;
using MVCWithTDD.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWithTDD.Service.Test
{
    [TestClass]
    public class PostServiceTest
    {
        private Mock<IPostRepository> mockedPostRepository;
        private Mock<IUnitOfWork> mockedUnitOfWork;

        [TestInitialize]
        public void SetUp()
        {
            mockedPostRepository = new Mock<IPostRepository>();
            mockedUnitOfWork = new Mock<IUnitOfWork>();
        }

        [TestMethod]
        public void GetLocalPeoplePaging_CallToGetPage_OnRepository()
        {
            IEnumerable<Post> results = new List<Post>()
            {
                new Post { Content = "Content", Title = "Title" },
                new Post { Content = "Content2", Title = "Title2"  }
            };

            mockedPostRepository.Setup(repo => repo.GetAll()).Returns(results);

            IPostService postService = new PostService(mockedPostRepository.Object, mockedUnitOfWork.Object);
            List<Post> result = postService.ListRecentPosts(5);


            Assert.IsNotNull(result);
            mockedPostRepository.VerifyAll();
        }
    }
}
