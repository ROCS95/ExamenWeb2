using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenWeb2.Models
{
    public class Factura
    {
        [Key]
        public int ID { get; set; }

        public string ClienteNombre { get; set; }
        public string Fecha { get; set; }
        public string Detalle { get; set; }
        public double SubTotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
    }
}