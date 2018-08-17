using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CroweTest;
using CroweTest.Controllers;

namespace CroweTest.Tests.Controllers
{
    [TestClass]
    public class MessageToWorldApiControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            MessageToWorldApiController controller = new MessageToWorldApiController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hello World!", result.Message);
            Assert.AreEqual(1, result.Id);
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            MessageToWorldApiController controller = new MessageToWorldApiController();

            // Act
            var result = controller.Get(5);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hello World!", result.Message);
            Assert.AreEqual(5, result.Id);
        }
    }
}
