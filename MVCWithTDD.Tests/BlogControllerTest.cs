using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Moq;
using System.Collections.Generic;
using MVCWithTDD.Service.Interfaces;
using MVCWithTDD.Controllers;
using MVCWithTDD.Model;

namespace MVCWithTDD.Tests
{
    [TestClass]
    public class BlogControllerTests
    {
        private Mock<IPostService> mockedPostService;

        [TestInitialize]
        public void SetUp()
        {
            mockedPostService = new Mock<IPostService>();
        }

        [TestMethod]
        public void RecentActionUsesConventionToChooseView()
        {
            var controller = new BlogController(mockedPostService.Object);

            var result = controller.Recent() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BlogControllerPassesCorrectViewData()
        {
            var posts = new List<Post>()
            {
                new Post(),
                new Post()
            };

            mockedPostService.Setup(r => r.ListRecentPosts(It.IsAny<int>())).Returns(posts);

            BlogController controller = new BlogController(mockedPostService.Object);
            var result = controller.Recent() as ViewResult;

            var model = result.ViewData.Model as List<Post>;
            Assert.IsNotNull(model);
        }
    }
}