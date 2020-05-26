using HousesPeru.Controllers;
using HousesPeru.services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Tests.TestControllers
{
    [TestFixture]
    class PlanControllerTest
    {
        [Test]
        public void IndexIsOk()
        {


            var IAuthServiceMock = new Mock<IAuthService>();
            var IPlanServiceeMock = new Mock<IPlanService>();
            var IUsuarioServiceMock = new Mock<IUsuarioService>();

            var home = new PlanController(IAuthServiceMock.Object, IPlanServiceeMock.Object, IUsuarioServiceMock.Object);


            var result = home.Index() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsNull(result.ViewBag.UserLogged);



        }
        [Test]
        public void GetPlanesIsOk()
        {


            var IAuthServiceMock = new Mock<IAuthService>();
            var IPlanServiceeMock = new Mock<IPlanService>();
            var IUsuarioServiceMock = new Mock<IUsuarioService>();

            var home = new PlanController(IAuthServiceMock.Object, IPlanServiceeMock.Object, IUsuarioServiceMock.Object);


            var result = home.GetPlanes() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsNull(result.ViewBag.UserLogged);
            Assert.IsNull(result.ViewBag.PlanActual);
            Assert.IsNull(result.ViewBag.User);
      

        }
        [Test]
        public void PostPlanesIsOk()
        {


            var IAuthServiceMock = new Mock<IAuthService>();
            var IPlanServiceeMock = new Mock<IPlanService>();
            var IUsuarioServiceMock = new Mock<IUsuarioService>();

            var home = new PlanController(IAuthServiceMock.Object, IPlanServiceeMock.Object, IUsuarioServiceMock.Object);


            var result = home.PostPlanes(1) as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsNull(result.ViewBag.UserLogged);
            Assert.IsNull(result.ViewBag.PlanActual);
            Assert.IsNull(result.ViewBag.User);


        }

    }
}
