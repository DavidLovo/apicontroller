using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RRHH.Models
{
    public static class M_Puesto
    {
        public class PuestoE
        {
            public int IdPuesto { get; set; }
            public double Salario { get; set; }
            public string Puesto { get; set; }
            public PuestoE(int IdPuesto, string Puesto, double Salario)
            {
                this.IdPuesto = IdPuesto;
                this.Puesto = Puesto;
                this.Salario = Salario;
            }
        }
        public static List<PuestoE> puestos()
        {
            return new List<PuestoE>
            {
                new PuestoE (1,"Gerente",50000),
                new PuestoE (2,"Supervisor",19000),
                new PuestoE (3,"Programado",25000),
                new PuestoE (4,"Auxiliar",19000)

            };
        }
    }
}