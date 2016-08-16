using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenWeb2.Models
{
    public class Inventario
    {
        [Key]
        public int ID { get; set; }

        public string Producto { get; set; }
        public int Catidad { get; set; }
        public int CatidadMinima { get; set; }
        public int CatidadMaxima { get; set; }
        public string GrabadoExcepto { get; set; }
    }
}