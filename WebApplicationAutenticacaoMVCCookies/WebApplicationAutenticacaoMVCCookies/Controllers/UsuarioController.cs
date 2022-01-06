using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebApplicationAutenticacaoMVCCookies.Models;

namespace WebApplicationAutenticacaoMVCCookies.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginPage()
        {
            if (User.Identity.IsAuthenticated)  //Ele entra na tela de login, se tiver autenticado, vai para a index, caso contrario retorna para a tela de login
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginPage(Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //aqui faz a consulta no banco conforme os dados do usuario (usando o EF)
                    if (usuario.Login == "Douglas" && usuario.Senha == "123")
                    {
                        //*********************************** parte dificil rs

                        var claims = new List<Claim>  //claim = afirmação que é considerado verdade dentro do sistema
                        {
                            new Claim(ClaimTypes.Name, usuario.Login),  //tbm vem do Banco de Dados
                            new Claim(ClaimTypes.Role, "admin"),
                        };

                        var identidade = new ClaimsIdentity(claims, "Login");

                        ClaimsPrincipal principal = new ClaimsPrincipal(identidade);
                        var regrasAutenticacao = new AuthenticationProperties
                        {
                            AllowRefresh = true,
                            ExpiresUtc = DateTime.Now.ToLocalTime().AddHours(4),
                            IsPersistent = true
                        };

                        await HttpContext.SignInAsync(
                            CookieAuthenticationDefaults.AuthenticationScheme,
                            principal, regrasAutenticacao
                            );

                        //***********************************

                        return RedirectToAction("UserPage");
                    }
                    else
                    {
                        ViewBag.Erro = "Usuario ou senha não conferem";
                    }
                }
            }
            catch (Exception ex)
            {

                ViewBag.Erro = "Ocorreu um proble ao autenticar: " + ex.Message;
            }

            return View();
        }

        [Authorize] //não vai conseguir acessar caso não esteja autenticado. podemos usar com o privilegios [Authorize(Roles = "admin, userdefault")]
        public IActionResult UserPage()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            //HttpContext.Session.Clear();  //para quem não colocou session na program.cs    ********Descomentar aqui para mudar a forma de cookie com session

            return RedirectToAction("Index");
        }
    }
}
