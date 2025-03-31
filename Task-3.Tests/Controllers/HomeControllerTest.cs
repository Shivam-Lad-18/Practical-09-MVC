using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Task_3;
using Task_3.Controllers;

namespace Task_3.Tests.Controllers
{
    // Using TestClass as an attribute to HomeControllerTest class
    [TestClass]
    public class HomeControllerTest
    {
        // Using TestMethod as an attribute to Index method
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);//Checking wether my view is not null
            Assert.AreEqual("Hello, World!", result.ViewBag.Message); //Comparing two strings to check if they are equal
        }
    }
}
