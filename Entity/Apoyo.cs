using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Apoyo
    {
        [Key]
        public int IdApoyo { get; set; }
        public string Persona { get; set; }
        public string TipoApoyo { get; set; }
        public int Valor { get; set; }
        public DateTime Fecha { get; set; }
    }
}