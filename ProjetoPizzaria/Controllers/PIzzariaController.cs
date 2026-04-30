using Microsoft.AspNetCore.Mvc;
using ProjetoPizzaria.Models;

namespace ProjetoPizarriaOne.Controllers
{
    public class PizzariaController : Controller
    {
        public IActionResult NovoPedido()
        {
            return View();
        }
        public IActionResult NotaPedido(Pedido pedido)
        {
            ViewBag.total = pedido.CalcularPedido();
            pedido.horarioPedido = DateTime.Now;
            return View(pedido);
        }
    }
}
