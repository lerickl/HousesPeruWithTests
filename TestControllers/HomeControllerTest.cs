using HousesPeru.Controllers;
using HousesPeru.Models;
using HousesPeru.services;
using HousesPeru.validaciones;
using HousesPeru.ViewModels;
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
    class HomeControllerTest
    {


        [Test]
        public void GetIndexIsOk() {
            
           
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();

            var home = new HomeController(IUsuarioServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IValidacionUsuarioMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object);

            //var inmuebles = IInmuebleServiceMock.Setup(x=>x.GetInmubles()).Returns(new List<Inmueble>());
            var inmuebles = new List<Inmueble>();
            var Imagenes = new List<Imagen>();
            var tipoinmueble = new List<InmuebleTipo>();
            var ciudad = new List<Ciudades>();
            var result = home.Index() as ViewResult; 
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsNull(result.ViewBag.UserLogged);
            Assert.AreEqual(result.ViewBag.Inmuebles, inmuebles);
            Assert.AreEqual(result.ViewBag.Imagenes, Imagenes);
            Assert.AreEqual(result.ViewBag.TipoInmueble, tipoinmueble);
            Assert.AreEqual(result.ViewBag.ciudad, ciudad);

  
        }
        [Test]
        public void GetRegistroIsOk()
        {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();

            var home = new HomeController(IUsuarioServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IValidacionUsuarioMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object);


            var result = home.Registro();
            Assert.IsInstanceOf<ViewResult>(result);


        }
        [Test]
        public void GetRegistroIsOk1()
        {
            

            var home = new HomeController(null, null, null, null, null, null, null, null);


            var result = home.Registro();
            Assert.IsInstanceOf<ViewResult>(result);


        }
        [Test]
         public void PostRegistroIsOk()
        {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();

            var home = new HomeController(IUsuarioServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IValidacionUsuarioMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object);

            var user = new UsuarioViewModel();
            var result = home.Registro(user);
            Assert.IsInstanceOf<RedirectToRouteResult>(result);
        }
        [Test]
        public void PostRegistroErrorIsOk()
        {
            var user = new UsuarioViewModel() { Nombre=""};
            var modelstate = new ModelStateDictionary();
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();
            IValidacionUsuarioMock.Setup(x => x.validarUsuario(user, modelstate));
            var home = new HomeController(IUsuarioServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IValidacionUsuarioMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object);

           

            var result = home.Registro(user);
            Assert.IsInstanceOf<RedirectToRouteResult>(result);
        }
        [Test]
        public void GetLoginIsOk()
        {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();

            var home = new HomeController(IUsuarioServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IValidacionUsuarioMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object);

            var user = new UsuarioViewModel();
            var result = home.Login();
            Assert.IsInstanceOf<ViewResult>(result);
        }
        [Test]
        public void PostLoginIsOk()
        {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();

            var home = new HomeController(IUsuarioServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IValidacionUsuarioMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object);

            var user = new UsuarioViewModel();
            var result = home.Login(new Usuario());
            Assert.IsInstanceOf<RedirectToRouteResult>(result);
        }
        [Test]
        public void LogOutIsOk()
        {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();

            var home = new HomeController(IUsuarioServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IValidacionUsuarioMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object);

            var user = new UsuarioViewModel();
            var result = home.LogOut();
            Assert.IsInstanceOf<RedirectToRouteResult>(result);
        }
  
        [Test]
        public void AboutIsOk()
        {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();

            var home = new HomeController(IUsuarioServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IValidacionUsuarioMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object);

            var user = new UsuarioViewModel();
            var result = home.About();
            Assert.IsInstanceOf<ViewResult>(result);
        }
        [Test]
        public void ContactIsOk()
        {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var IInmuebleTipoServiceMock = new Mock<IInmuebleTipoService>();
            var ICiudadServiceMock = new Mock<ICiudadService>();

            var home = new HomeController(IUsuarioServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IValidacionUsuarioMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, IInmuebleTipoServiceMock.Object, ICiudadServiceMock.Object);

            var user = new UsuarioViewModel();
            var result = home.Contact();
            Assert.IsInstanceOf<ViewResult>(result);
        }
    }

}
