using Microsoft.AspNetCore.Mvc;
using Segunda_Practica_Evaluada_Periodo_2.Models;

namespace Segunda_Practica_Evaluada_Periodo_2.Controllers
{
	public class FacturaController : Controller
	{
		public IActionResult Factura()
		{
            var factura = new Factura
            {
                NumeroFactura = "001",
                NombreCliente = "Juan Pérez",
                TelefonoCliente = "1234-5678",
                DireccionCliente = "Calle Ejemplo 123",
                Productos = new List<Producto>
            {
                new Producto { Descripcion = "Producto 1", Cantidad = 2, Precio = 10.50m },
                new Producto { Descripcion = "Producto 2", Cantidad = 1, Precio = 20.00m }
            },
                SubTotal = 41.00m,
                IVA = 8.20m,
                Total = 49.20m
            };

            return View(factura);

        }
	}
}
