using System;
using System.Collections.Generic;
using DevopsLearn.Controllers;
using DevopsLearn.Models;
using DevopsLearn.Repository;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DevopsLearn.Test
{
    public class PostTestController
    {
        private PostRepository repository;
        public PostTestController()
        {
            repository = new PostRepository();
        }

        [Fact]
        public void Test_Index_View_result()
        {
            //Arrange
            var controller = new HomeController(this.repository);

            //Act
            var res = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(res);
        }

        [Fact]
        public void Test_Index_Return_result()
        {
            //Arrange
            var controller = new HomeController(this.repository);

            //Act
            var res = controller.Index();

            //Assert
            Assert.NotNull(res);
        }

        [Fact]
        public void Test_Index_GetPost_MatchData()
        {
            //Arrange
            var controller = new HomeController(this.repository);

            //Act
            var res = controller.Index();

            //Assert
            var viewRes = Assert.IsType<ViewResult>(res);
            var model = Assert.IsAssignableFrom<List<PostViewModel>>(viewRes.ViewData.Model);

            Assert.Equal(2, model.Count);
            Assert.Equal(101, model[0].PostId);
           // Assert.Equal(102, model[1].PostId);
        }
    }
}
