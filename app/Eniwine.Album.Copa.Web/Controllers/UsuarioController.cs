using Eniwine.Album.Copa.Dominio.Entidades;
using Eniwine.Album.Copa.Dominio.Interfaces.Aplicacao;
using Eniwine.Album.Copa.Web.Gerenciador;
using Eniwine.Album.Copa.Web.ViewModels;
using Ninject;
using System.Web.Mvc;

namespace Eniwine.Album.Copa.Web.Controllers
{
    public class UsuarioController : Controller
    {

        [Inject]
        public IUsuarioAplicacao UsuarioAplicacao { get; set; }

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult AcessoNegado()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(UsuarioViewModel usuarioViewModel)
        {
            Usuario usuario = UsuarioAplicacao.Busca(usuarioViewModel.Login, usuarioViewModel.Senha);
            if (usuario != null)
            {
                GerenciadorUsuario.Autentica(usuario, Response);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [AllowAnonymous]
        public ActionResult Registrar()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Registrar(RegistrarViewModel registrarViewModel)
        {
            return View();
        }

    }
}