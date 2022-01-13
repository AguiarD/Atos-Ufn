#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoFinanceira;
using GestaoFinanceira.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace GestaoFinanceira.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Contexto _context;

        public UsuarioController(Contexto context)
        {
            _context = context;
        }

        // GET: Usuario
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuario.ToListAsync());
        }

        public IActionResult LoginPage()
        {
            if (User.Identity.IsAuthenticated)  //Ele entra na tela de login, se tiver autenticado, vai para a index, caso contrario retorna para a tela de login
            {
                string urlAnterior = Request.Headers["Referer"].ToString();

                if (urlAnterior.Contains("Tipo"))
                {
                    return RedirectToAction("Index", "Tipo");
                }
                else if (urlAnterior.Contains("Grupo"))
                {
                    return RedirectToAction("Index", "Grupo");
                }
                else if (urlAnterior.Contains("Conta"))
                {
                    return RedirectToAction("Index", "Conta");
                }
                else if (urlAnterior.Contains("Lancamento"))
                {
                    return RedirectToAction("Index", "Lancamento");
                }
                else
                    return RedirectToAction("Index", "Home");
                
                
                //return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginPage(string Login, string Senha)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //var dbLogin = _context.Usuario.Where(l => l.Login == Login).Select(l => l.Id);
                    //var dbSenha = _context.Usuario.Where(l => l.Senha == Senha).Select(l => l.Id);
                    //aqui faz a consulta no banco conforme os dados do usuario (usando o EF)
                    if (Login == "Douglas" && Senha == "1234")
                    {
                        //*********************************** parte dificil rs

                        var claims = new List<Claim>  //claim = afirmação que é considerado verdade dentro do sistema
                        {
                            new Claim(ClaimTypes.Name, Login),  //tbm vem do Banco de Dados
                            //new Claim(ClaimTypes.Role, "admin"),
                        };

                        var identidade = new ClaimsIdentity(claims, "Login");

                        ClaimsPrincipal principal = new ClaimsPrincipal(identidade);
                        var regrasAutenticacao = new AuthenticationProperties
                        {
                            AllowRefresh = true,
                            ExpiresUtc = DateTime.Now.ToLocalTime().AddMinutes(1),
                            IsPersistent = true
                        };

                        await HttpContext.SignInAsync(
                            CookieAuthenticationDefaults.AuthenticationScheme,
                            principal, regrasAutenticacao
                            );

                        //***********************************

                        return RedirectToAction("Index", "Lancamento");
                    }
                    else
                    {
                        ViewBag.Erro = "Usuario ou senha não conferem";
                    }
                }
            }
            catch (Exception ex)
            {

                ViewBag.Erro = "Ocorreu um problema ao autenticar: " + ex.Message;
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            //HttpContext.Session.Clear();  //para quem não colocou session na program.cs    ********Descomentar aqui para mudar a forma de cookie com session

            return RedirectToAction("Index", "Home");
        }
    }
}
