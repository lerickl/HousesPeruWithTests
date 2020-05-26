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
using System.Web;
using System.Web.Mvc;

namespace Tests.TestControllers
{
    [TestFixture]
    class InmuebleControllerTest
    {
        [Test]
        public void GetInmueblesIsOk()
        {


     

            var IAuthServiceMock = new Mock<IAuthService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();
            var IUsuarioServiceMock = new Mock<IUsuarioService>();

            var IPublicacionServiceMock = new Mock<IPublicacionService>();

            var IPlanServiceMock = new Mock<IPlanService>();

            var IValidacionInmuebleMock = new Mock<IValidacionInmueble>();
         

            var inmueble = new InmuebleController(IAuthServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object, IUsuarioServiceMock.Object, IPublicacionServiceMock.Object, IPlanServiceMock.Object, IValidacionInmuebleMock.Object);

            //var inmuebles = IInmuebleServiceMock.Setup(x=>x.GetInmubles()).Returns(new List<Inmueble>());
            var result = inmueble.GetInmuebles() as ViewResult;

            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsNull(result.ViewBag.UserLogged);

     


        }
        [Test]
        public void BuscarIsOk()
        { 
            var IAuthServiceMock = new Mock<IAuthService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();
            var IUsuarioServiceMock = new Mock<IUsuarioService>();

            var IPublicacionServiceMock = new Mock<IPublicacionService>();

            var IPlanServiceMock = new Mock<IPlanService>();

            var IValidacionInmuebleMock = new Mock<IValidacionInmueble>();


            var inmueble = new InmuebleController(IAuthServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object, IUsuarioServiceMock.Object, IPublicacionServiceMock.Object, IPlanServiceMock.Object, IValidacionInmuebleMock.Object);

            //var inmuebles = IInmuebleServiceMock.Setup(x=>x.GetInmubles()).Returns(new List<Inmueble>());
            var result = inmueble.Buscar("Alquiler") as ViewResult;

            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsNull(result.ViewBag.UserLogged);

 
        }
        [Test]
        public void PostBuscarIsOk()
        {
            var IAuthServiceMock = new Mock<IAuthService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();
            var IUsuarioServiceMock = new Mock<IUsuarioService>();

            var IPublicacionServiceMock = new Mock<IPublicacionService>();

            var IPlanServiceMock = new Mock<IPlanService>();

            var IValidacionInmuebleMock = new Mock<IValidacionInmueble>();


            var inmueble = new InmuebleController(IAuthServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object, IUsuarioServiceMock.Object, IPublicacionServiceMock.Object, IPlanServiceMock.Object, IValidacionInmuebleMock.Object);

            //var inmuebles = IInmuebleServiceMock.Setup(x=>x.GetInmubles()).Returns(new List<Inmueble>());
            var result = inmueble.Buscar(1,1,"Alquiler") as ViewResult;

            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsNull(result.ViewBag.UserLogged);


        }
        [Test]
        public void InmuebleIsOk()
        {
            var IAuthServiceMock = new Mock<IAuthService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();
            var IUsuarioServiceMock = new Mock<IUsuarioService>();

            var IPublicacionServiceMock = new Mock<IPublicacionService>();

            var IPlanServiceMock = new Mock<IPlanService>();

            var IValidacionInmuebleMock = new Mock<IValidacionInmueble>();
            IInmuebleServiceMock.Setup(x => x.GetInmuebleById(1)).Returns(new Inmueble());

            var inmueble = new InmuebleController(IAuthServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object, IUsuarioServiceMock.Object, IPublicacionServiceMock.Object, IPlanServiceMock.Object, IValidacionInmuebleMock.Object);

            //var inmuebles = IInmuebleServiceMock.Setup(x=>x.GetInmubles()).Returns(new List<Inmueble>());
            var result = inmueble.Inmueble(1) as ViewResult;

            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsNull(result.ViewBag.UserLogged);


        }
        [Test]
        public void DelImgIsOk()
        {
            var IAuthServiceMock = new Mock<IAuthService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();
            var IUsuarioServiceMock = new Mock<IUsuarioService>();

            var IPublicacionServiceMock = new Mock<IPublicacionService>();

            var IPlanServiceMock = new Mock<IPlanService>();

            var IValidacionInmuebleMock = new Mock<IValidacionInmueble>();
       

            var inmueble = new InmuebleController(IAuthServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object, IUsuarioServiceMock.Object, IPublicacionServiceMock.Object, IPlanServiceMock.Object, IValidacionInmuebleMock.Object);

            //var inmuebles = IInmuebleServiceMock.Setup(x=>x.GetInmubles()).Returns(new List<Inmueble>());
            var result = inmueble.DelImg(1) ;

            Assert.IsInstanceOf<JsonResult>(result);
  


        }
        [Test]
        public void InmLayoutIsOk()
        {
            var IAuthServiceMock = new Mock<IAuthService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();
            var IUsuarioServiceMock = new Mock<IUsuarioService>();

            var IPublicacionServiceMock = new Mock<IPublicacionService>();

            var IPlanServiceMock = new Mock<IPlanService>();

            var IValidacionInmuebleMock = new Mock<IValidacionInmueble>();


            var inmueble = new InmuebleController(IAuthServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object, IUsuarioServiceMock.Object, IPublicacionServiceMock.Object, IPlanServiceMock.Object, IValidacionInmuebleMock.Object);

            var result = inmueble.InmLayout();

            Assert.IsInstanceOf<JsonResult>(result);



        }
    }
}
