using HousesPeru.Controllers;
using HousesPeru.Models;
using HousesPeru.services;
using HousesPeru.validaciones;
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
    class PublicacionControllerTest
    {
        [Test]
        public void GetIndexIsOk()
        {
    
            var IAuthServiceMock = new Mock<IAuthService>();
            var IPlanServiceMock = new Mock<IPlanService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();
            var ICloudinaryServiceMock = new Mock<ICloudinaryService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();

            var IPublicacionServiceMock = new Mock<IPublicacionService>();
            var IValidacionInmuebleMock = new Mock<IValidacionInmueble>();
          
          
            var home = new PublicacionController(IAuthServiceMock.Object, IPlanServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object, ICloudinaryServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IPublicacionServiceMock.Object, IValidacionInmuebleMock.Object);

          
            var result = home.Index() as ViewResult;

            Assert.IsInstanceOf<ViewResult>(result);
      

        }
        [Test]
        public void AddPublicacionIsOk()
        {

            var IAuthServiceMock = new Mock<IAuthService>();
            var IPlanServiceMock = new Mock<IPlanService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();
            var ICloudinaryServiceMock = new Mock<ICloudinaryService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();

            var IPublicacionServiceMock = new Mock<IPublicacionService>();
            var IValidacionInmuebleMock = new Mock<IValidacionInmueble>();


            var home = new PublicacionController(IAuthServiceMock.Object, IPlanServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object, ICloudinaryServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IPublicacionServiceMock.Object, IValidacionInmuebleMock.Object);


            var result = home.AddPublicacion() as ViewResult;

            Assert.IsInstanceOf<ViewResult>(result);

            Assert.IsNull(result.ViewBag.UserLogged);

        }
        [Test]
        public void GetInmuebleByIDIsOk()
        {

            var IAuthServiceMock = new Mock<IAuthService>();
            var IPlanServiceMock = new Mock<IPlanService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();
            var ICloudinaryServiceMock = new Mock<ICloudinaryService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();

            var IPublicacionServiceMock = new Mock<IPublicacionService>();
            var IValidacionInmuebleMock = new Mock<IValidacionInmueble>();

            IInmuebleServiceMock.Setup(x => x.GetInmuebleById(1)).Returns(new Inmueble());
            var home = new PublicacionController(IAuthServiceMock.Object, IPlanServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object, ICloudinaryServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IPublicacionServiceMock.Object, IValidacionInmuebleMock.Object);


            var result = home.GetInmuebleByID(1) as ViewResult;

            Assert.IsInstanceOf<ViewResult>(result);

            Assert.IsNull(result.ViewBag.UserLogged);

        }
        [Test]
        public void DireccionesIsOk()
        {

            var IAuthServiceMock = new Mock<IAuthService>();
            var IPlanServiceMock = new Mock<IPlanService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();
            var ICloudinaryServiceMock = new Mock<ICloudinaryService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();

            var IPublicacionServiceMock = new Mock<IPublicacionService>();
            var IValidacionInmuebleMock = new Mock<IValidacionInmueble>();


            var home = new PublicacionController(IAuthServiceMock.Object, IPlanServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object, ICloudinaryServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IPublicacionServiceMock.Object, IValidacionInmuebleMock.Object);


            var result = home.Direcciones() as ViewResult;

            Assert.IsInstanceOf<ViewResult>(result);


        }
    }
}
