using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplicationConsumirAPI.Models;

namespace WebApplicationConsumirAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Pessoas()  //retornar a lista de todas as pessoas da api
        {
            string BaseUrl = "https://localhost:7100/";

            List<Pessoa>? pessoas = new List<Pessoa>();

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Clear(); //Aqui começa a montar o cabeçalho
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("api/pessoas"); //response vai receber o retorno da lista de pessoas

            if (response.IsSuccessStatusCode)
            {
                var dados = response.Content.ReadAsStringAsync().Result;
                pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(dados); //transformar a lista de dados no formato de pessoas
            }
            return View(pessoas);
        }

        public async Task<ActionResult> PessoaId(int id)
        {
            string BaseUrl = "https://localhost:7100/";
                
            Pessoa? p = new Pessoa();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new 
                System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("api/pessoas/" + id);

            if (response.IsSuccessStatusCode)
            {
                var dados = response.Content.ReadAsStringAsync().Result;
                p = JsonConvert.DeserializeObject<Pessoa>(dados);
            }

            return View(p);
        }

        public IActionResult Cadastrar() //Para abrir a view.
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Cadastrar(Pessoa p)
        {
            string BaseUrl = "https://localhost:7100/";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await 
                client.PostAsJsonAsync(BaseUrl + "api/pessoas", p);

            return RedirectToAction("pessoas");
        }

        public IActionResult Alterar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Alterar(Pessoa p, int id)
        {
            string BaseUrl = "https://localhost:7100/";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.PutAsJsonAsync(BaseUrl + "api/pessoas/" + id, p);

            return RedirectToAction("pessoas");
        }

        public IActionResult Excluir()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Excluir(int id)
        {
            string BaseUrl = "https://localhost:7100/";
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.DeleteAsync(BaseUrl + "api/pessoas/" + id);

            return RedirectToAction("pessoas");
        }
    }
}
