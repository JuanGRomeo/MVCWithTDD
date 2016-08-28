using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using MVCWithTDD.Controllers;
using Moq;
using MVCWithTDD.Models;
using System.Collections.Generic;
using MVCWithTDD.Model;

namespace MVCWithTDD.Tests
{
    [TestClass]
    public class BlogControllerTests
    {
        [TestMethod]
        public void RecentActionUsesConventionToChooseView()
        {
            //Arrange
            var repository = new Mock<IPostRepository>();
            var controller = new BlogController(repository.Object);

            //Act
            var result = controller.Recent() as ViewResult;

            //Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void BlogControllerPassesCorrectViewData()
        {
            //Arrange
            var posts = new List<Post>()
            {
                new Post(),
                new Post()
            };

            var repository = new Mock<IPostRepository>();
            repository.Setup(r => r.ListRecentPosts(It.IsAny<int>())).Returns(posts);

            //Act
            BlogController controller = new BlogController(repository.Object);
            var result = controller.Recent() as ViewResult;

            //Assert
            var model = result.ViewData.Model as IList<Post>;
            Assert.IsNotNull(model);
        }
    }
}
