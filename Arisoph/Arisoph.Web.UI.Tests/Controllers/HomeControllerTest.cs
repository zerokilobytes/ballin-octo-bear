using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arisoph.Web.UI;
using Arisoph.Web.UI.Controllers;
using Arisoph.Web.Framework.Service;
using Moq;

namespace Arisoph.Web.UI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void viewbag_message_should_return_welcome_message()
        {

            var mock = new Mock<IService>();
            mock.Setup(foo => foo.GetMessage()).Returns("Welcome");

            // Arrange
            HomeController controller = new HomeController(mock.Object);


            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Welcome", result.ViewBag.Message);
        }

        [TestMethod]
        public void about_result_should_not_be_null()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void contact_result_should_not_be_null()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
