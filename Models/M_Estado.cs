using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RRHH.Models
{
    public static class M_Estado
    {
        public class Estado
        {
            public int IdEstado { get; set; }
            public string TipoEstado { get; set; } = "Activo";

            public Estado(string TipoEstado, int IdEstado)
            {
                this.TipoEstado = TipoEstado;
                this.IdEstado = IdEstado;
            }
        }
        public static List<Estado> estados()
        {
            return new List<Estado>
            {
                new Estado("Activo",1),
                new Estado("Inactivo",2)
            };
        }
    }
}