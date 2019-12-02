using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuctioinSite.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctioinSite.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void Index_ReturnsViewResult()
        {
            HomeController home = new HomeController();

            var result = home.Index();

            Assert.IsNotNull(result);
        }
    }
}
