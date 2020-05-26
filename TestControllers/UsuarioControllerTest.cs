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
using System.Web;
using System.Web.Mvc;

namespace Tests.TestControllers
{
    [TestFixture]
    class UsuarioControllerTest
    {
 
        [Test]
        public void GetRegistroAgenteIsOk() {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IAuthServiceMock = new Mock<IAuthService>(); 
            var IInmuebleServiceMock = new Mock<IInmuebleService>(); 
            var IImageServiceMock = new Mock<IImageService>();
            var ICloudinaryServiceMock = new Mock<ICloudinaryService>();
             
            var home = new UsuarioController(IUsuarioServiceMock.Object, IValidacionUsuarioMock.Object, IAuthServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, ICloudinaryServiceMock.Object);
            var result=home.RegistroAgente();

            Assert.IsInstanceOf<RedirectToRouteResult>(result);
 
        }
        [Test]
        public void PostRegistroAgenteIsOk()
        {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var ICloudinaryServiceMock = new Mock<ICloudinaryService>();

            IAuthServiceMock.Setup(x => x.GetLogedUser()).Returns(new Usuario());
            var home = new UsuarioController(IUsuarioServiceMock.Object, IValidacionUsuarioMock.Object, IAuthServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, ICloudinaryServiceMock.Object);
            var result = home.RegistroAgente(new UsuarioViewModel());

            Assert.IsInstanceOf<RedirectToRouteResult>(result);

        }
        [Test]
        public void ListaUsuariosIsOk() {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var ICloudinaryServiceMock = new Mock<ICloudinaryService>();

            IAuthServiceMock.Setup(x => x.GetLogedUser()).Returns(new Usuario());
            var home = new UsuarioController(IUsuarioServiceMock.Object, IValidacionUsuarioMock.Object, IAuthServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, ICloudinaryServiceMock.Object);
            var result = home.ListaUsuarios();

            Assert.IsInstanceOf<RedirectToRouteResult>(result);
        }
        [Test]
        public void ListaAgentesIsOk()
        {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var ICloudinaryServiceMock = new Mock<ICloudinaryService>();

            IAuthServiceMock.Setup(x => x.GetLogedUser()).Returns(new Usuario());
            var home = new UsuarioController(IUsuarioServiceMock.Object, IValidacionUsuarioMock.Object, IAuthServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, ICloudinaryServiceMock.Object);
            var result = home.ListaAgentes();

            Assert.IsInstanceOf<RedirectToRouteResult>(result);
        }
        [Test]
        public void GetUserIsOk()
        {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var ICloudinaryServiceMock = new Mock<ICloudinaryService>();
        
            var usuario = new Usuario() { UsuarioId = 1, Nombre = "", ApellidoP = "", ApellidoM = "", FechaNacimiento = DateTime.Now, Email = "xd@xd.com", Password = "", Sexo = "" };
            IAuthServiceMock.Setup(x => x.GetLogedUser()).Returns(usuario);
            IUsuarioServiceMock.Setup(x => x.GetUsuarioByID(usuario.UsuarioId)).Returns(usuario);
            
            var home = new UsuarioController(IUsuarioServiceMock.Object, IValidacionUsuarioMock.Object, IAuthServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, ICloudinaryServiceMock.Object);
            var result = home.GetUser();

            Assert.IsInstanceOf<ViewResult>(result);
        }
        [Test]
        public void GetUserIsOkpost()
        {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IValidacionUsuarioMock = new Mock<IValidacionUsuario>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var IInmuebleServiceMock = new Mock<IInmuebleService>();
            var IImageServiceMock = new Mock<IImageService>();
            var ICloudinaryServiceMock = new Mock<ICloudinaryService>();
            var imgperfil = new Mock<HttpPostedFileBase>();

            var usuario = new Usuario() { UsuarioId = 1, Nombre = "", ApellidoP = "", ApellidoM = "", FechaNacimiento = DateTime.Now, Email = "xd@xd.com", Password = "", Sexo = "" };
            IAuthServiceMock.Setup(x => x.GetLogedUser()).Returns(usuario);
            IUsuarioServiceMock.Setup(x => x.GetUsuarioByID(usuario.UsuarioId)).Returns(usuario);
            var home = new UsuarioController(IUsuarioServiceMock.Object, IValidacionUsuarioMock.Object, IAuthServiceMock.Object, IInmuebleServiceMock.Object, IImageServiceMock.Object, ICloudinaryServiceMock.Object);
            
            
            var result = home.GetUser(usuario, imgperfil.Object);

            
            Assert.IsInstanceOf<RedirectToRouteResult>(result);
        }

    }
}
