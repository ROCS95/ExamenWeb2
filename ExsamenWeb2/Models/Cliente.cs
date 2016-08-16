using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenWeb2.Models
{
    public class Cliente
    {
        [Key]
        public int ID { get; set; }

        public int Cedula { get; set; }
        public string Apellido { get; set; }
        public string FechaIngreso { get; set; }
        public string Sexo { get; set; }
        public string Tipo { get; set; }
        public string Descuento { get; set; }
    }
}