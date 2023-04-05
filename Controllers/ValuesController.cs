using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RRHH.Models;

namespace RRHH.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("api/empleado")]
        [HttpGet]
        public List<DTO> ListarEMPLEADO()
        {
            var listarempleados = Models.M_Empleado.Empleados()
                .Select(p => new DTO
                {
                    Nombre = p.Nombre,
                    Apellidos = p.Apellidos,
                    Direccion = p.Direccion,
                    CorreoElectronico = p.CorreoElectronico,
                    FechaNacimiento = p.FechaNacimiento,
                    Telefono = p.Telefono,
                })
                //.Take(3)
                .ToList();
            return listarempleados;

        }
                    

        [Route("api/empleadoestado")]
        [HttpGet]
     public List<DTO> StadoEMPLEADO()
        {
            var VerEstadoEmpleado = M_Empleado.Empleados()
                .Join(M_Estado.estados()
                , e => e.IdEstado
                , et => et.IdEstado
                , (e, et) => new { e = e, et = et })
                .Select(listar => new DTO
                {
                    Nombre = listar.e.Nombre,
                    Apellidos = listar.e.Apellidos,
                    Codigo = listar.e.Codigo,
                    TipoEstado = listar.et.TipoEstado
                })
                //.Take(2)
                .ToList();
            return VerEstadoEmpleado;
                
        }




        /// <summary>
        /// ///////////////////////
        /// </summary>

        [Route("api/privada")]
        [HttpGet]

        public List<DTO> infoprivada()
        {
            var InfoPrivadaEmpleado = M_Empleado.Empleados()
                .Join(
                   // Unir la tabla "Estados"
                   M_Estado.estados(),

                    // Definir las columnas de unión para la tabla "Estados" y "Empleados"
                    e => e.IdEstado, // columna en la tabla "Empleados"
                    est => est.IdEstado, // columna en la tabla "Estados"

                    // Seleccionar los resultados de la unión de "Empleados" y "Estados" y unir con la tabla "Puestos"
                    (e, est) => new { e, est }
                )
                .Join(
                   // Unir la tabla "Puestos"
                   M_Puesto.puestos(),

                    // Definir las columnas de unión para la tabla resultante de la unión anterior y la tabla "Puestos"
                    ee => ee.e.IdPuesto, // columna en la tabla resultante de la unión anterior
                    p => p.IdPuesto, // columna en la tabla "Puestos"

                    // Seleccionar los resultados finales y crear una instancia de "EmpleadoDTO" para cada registro
                    (ee, p) => new DTO
                    {
                        Nombre = ee.e.Nombre,
                        Apellidos = ee.e.Apellidos,
                        TipoEstado = ee.est.TipoEstado,
                        Puesto = p.Puesto,
                        Salario = p.Salario
                       
                        // Agregar cualquier otra propiedad que quieras seleccionar de las tablas unidas
                    })
                //.Take(1) // Seleccionar solo el primer registro
                .ToList(); // Convertir los resultados en una lista

            return InfoPrivadaEmpleado;
        }

        [Route("api/validardespido")]
        [HttpGet]

        public List<DTO> validardespido()
        {
            var InfoPrivadaEmpleado = M_Empleado.Empleados()
                .Join(
                    M_Estado.estados(),
                    e => e.IdEstado,
                    est => est.IdEstado,
                    (e, est) => new { e, est }
                )
                .Join(
                    M_Puesto.puestos(),
                    ee => ee.e.IdPuesto,
                    p => p.IdPuesto,
                    (ee, p) => new DTO
                    {
                        Nombre = ee.e.Nombre,
                        Apellidos = ee.e.Apellidos,
                        TipoEstado = ee.est.TipoEstado,
                        Puesto = p.Puesto,
                        Salario = p.Salario,
                        Direccion = ee.e.Direccion,
                        CorreoElectronico = ee.e.CorreoElectronico,
                        FechaDespido = ee.e.IdEstado == 2 ? ee.e.FechaDespido : null, // Seleccionar la fecha de despido solo si el IdEstado es 2 (Inactivo)
                        DiasDesdeDespido = ee.e.IdEstado == 2 && ee.e.FechaDespido.HasValue ? (DateTime.Now - ee.e.FechaDespido.Value).Days : 0 // Calcular los días transcurridos desde el despido solo si el IdEstado es 2 (Inactivo) y la fecha de despido tiene valor
                    }
                )
                .Where (p=> p.TipoEstado == "Inactivo")
                .ToList();

            return InfoPrivadaEmpleado;
        }


        /// <summary>
        /// ///////////////////////////////////
        /// </summary>


        public class DTO
        {
            

            // empleado
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public string Direccion { get; set; }
            public int Telefono { get; set; }
            public string CorreoElectronico { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Sexo { get; set; }
            public string Codigo { get; set; }
            public DateTime FechaIngreso { get; set; }
            public DateTime? FechaDespido { get; set; }
            public int IdEmpleado { get; set; }
            public int IdPuesto { get; set; }
            public int IdInfoEmpleado { get; set; }
            // tipo estado
            public int IdEstado { get; set; }
            public string TipoEstado { get; set; } = "Activo";

            //info basica
            public string EstadoCivil { get; set; }
            public string DirecciónDeEmergencia { get; set; }
            public string Educacion { get; set; }
            public int NumeroEmergente { get; set; }

            //puesto
            public double Salario { get; set; }
            public string Puesto { get; set; }

            public int DiasDesdeDespido { get; set; }

            //auditoria
            public string user { get { return Environment.MachineName; } }

        }


        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
