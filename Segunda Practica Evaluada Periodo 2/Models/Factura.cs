﻿namespace Segunda_Practica_Evaluada_Periodo_2.Models
{
	public class Factura
	{
        public int NumeroFactura { get; set; }
        public string NombreCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();
        public decimal SubTotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
    }
}
