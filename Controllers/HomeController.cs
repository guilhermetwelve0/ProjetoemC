using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Cadastro(){
            return View();
        }
         public IActionResult Servicos(){
            return View();
        }
        public IActionResult Agenda(){
            return View();
        }
        


        [HttpPost]

        public IActionResult Cadastro(ItemServico novoItem){
            
            Dados.ServicoAtual.AdicionaServico(novoItem);
            return View("Concluido");
        }
        public IActionResult Listagem(){
            List<ItemServico> servico = Dados.ServicoAtual.ListaServicos();
            
            return View(servico);
        }
        public IActionResult Agenda(Agenda novoPedido){
            
            Inform.PedidoAtual.AdicionaPedido(novoPedido);
            return View("Concluido");
        }
        public IActionResult Lista(){
            List<Agenda> pedido = Inform.PedidoAtual.ListaPedido();
            
            return View(pedido);
        }
        public IActionResult Sobre()
        {
            Pessoa contato = new Pessoa();
            contato.nome = "Ronald de Farias Ramos";

            return View(contato);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
