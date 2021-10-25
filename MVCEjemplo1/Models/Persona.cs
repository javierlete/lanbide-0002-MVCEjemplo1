using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEjemplo1.Models
{
    public class Persona
    {
        public long? Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}