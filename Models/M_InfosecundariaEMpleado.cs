using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RRHH.Models
{
    public static class M_InfosecundariaEMpleado
    {
        public class InfoEmpleado
        {
            public string EstadoCivil { get; set; }
            public string DirecciónDeEmergencia { get; set; }
            public string Educacion { get; set; }
            public int NumeroEmergente { get; set; }
            public int IdInfoEmpleado { get; set; }

            //constructor de la clase infoempleado, el constructor asigna los valores recibidos a los atributos correspondientes del objeto creado.
            public InfoEmpleado(int IdInfoEmpleado, string EstadoCivil, string DirecciónDeEmergencia, int NumeroEmergente, string Educacion)
            {
                this.IdInfoEmpleado = IdInfoEmpleado;
                this.EstadoCivil = EstadoCivil;
                this.DirecciónDeEmergencia = DirecciónDeEmergencia;
                this.NumeroEmergente = NumeroEmergente;
                this.Educacion = Educacion;


            }
        }


        public static List<InfoEmpleado> infoEmpleados()
        {
            return new List<InfoEmpleado>
            {
                 new InfoEmpleado  (1,"soltero","Bello Amanecer",123,"Profescional"),
                 new InfoEmpleado  (2,"casada","Colonia Centroamérica",456,"universitario"),
                 new InfoEmpleado  (3,"casado","Barrio San Judas",789,"Profescional"),
                 new InfoEmpleado  (4,"soltera","Residencial Los Robles",101112,"Profescional"),
                 new InfoEmpleado  (5,"casado","Barrio Jorge Dimitrov",131415,"Profescional"),
                 new InfoEmpleado  (6,"soltera","Colonia Centroamérica",161718,"Profescional"),
                 new InfoEmpleado  (7,"casado","Barrio San Judas",192021,"Profescional"),
                 new InfoEmpleado  (8,"casada","Residencial Los Robles",222324,"Profescional"),
                 new InfoEmpleado  (9,"soltero","Bello Amanecer",252627,"Profescional"),
                 new InfoEmpleado  (10,"casada","Barrio Jorge Dimitrov",282930,"Profescional"),
                 new InfoEmpleado  (11,"soltero","Colonia Centroamérica",313233,"Profescional")

            };

        }
    }
}