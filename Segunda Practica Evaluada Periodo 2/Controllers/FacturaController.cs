using Microsoft.AspNetCore.Mvc;
using Segunda_Practica_Evaluada_Periodo_2.Models;

namespace Segunda_Practica_Evaluada_Periodo_2.Controllers
{
	public class FacturaController : Controller
	{
		
        public IActionResult Factura()
        {
            var model = new Factura();
            return View(model);
        }

        
        [HttpPost]
        public IActionResult Factura(Factura model)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1000, 1000000);
            model.NumeroFactura = numeroAleatorio;
            
            model.SubTotal = model.Productos.Sum(p => p.Precio * p.Cantidad);
            model.IVA = model.SubTotal * 0.14m; 
            model.Total = model.SubTotal + model.IVA;

            
            return View(model);
        }
    }
}
