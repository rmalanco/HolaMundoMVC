using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundoMVC.Models
{
    public class Escuela
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public int AñoDeCreacion { get; set; }

    }
}