using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using MVCApplication;
using MVCApplication.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.Index() as ViewResult;
            //Assert
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void ViewRecipes()
        //{
        //    //Arrange
        //    HomeController controller = new HomeController();
        //    //Act
        //    ViewResult result = controller.ViewRecipes() as ViewResult;
        //    //Assert
        //    Assert.AreEqual("Your recipe list", result.ViewBag);

        //}
        [TestMethod]
        public void Recipe()
        {
            //Arrange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.Recipe() as ViewResult;
            //Assert
            Assert.IsNotNull(result);

        }
    }
}
