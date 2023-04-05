using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RRHH.Models
{
    public static class M_Empleado
    {
        public class Empleado
        {
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
            public int IdEstado { get; set; }
            public int IdPuesto { get; set; }
            public int IdInfoEmpleado { get; set; }

            public Empleado(int IdEmpleado, string Nombre, string Apellidos, string Direccion, int Telefono, string CorreoElectronico, DateTime FechaNacimiento,
             string Sexo, DateTime FechaIngreso, DateTime? FechaDespido, string Codigo, int IdEstado, int IdPuesto, int infoEmpleados)
            {
                this.IdEmpleado = IdEmpleado;
                this.Nombre = Nombre;
                this.Apellidos = Apellidos;
                this.Direccion = Direccion;
                this.Telefono = Telefono;
                this.CorreoElectronico = CorreoElectronico;
                this.FechaNacimiento = FechaNacimiento;
                this.Sexo = Sexo;
                this.FechaIngreso = FechaIngreso;
                this.FechaDespido = FechaDespido;
                this.Codigo = Codigo;
                this.IdEstado = IdEstado;
                this.IdPuesto = IdPuesto;
                this.IdInfoEmpleado = infoEmpleados;


            }


        }

        public static List<Empleado> Empleados()
        {
            return new List<Empleado>
            {
                new Empleado(1, "David", "Lovo", "Ciudad sandino", 87034314, "dlovo@gmail.com", DateTime.Parse("1997-01-10"), "Masculino", DateTime.Parse("2020-05-01"),DateTime.Parse("2023-03-22"), "EMP-001", 2, 1,1),
                new Empleado(2, "Maria", "Gonzalez", "Managua", 87654321, "mgonzalez@gmail.com", DateTime.Parse("1995-05-15"), "Femenino",  DateTime.Parse("2019-02-15"), null, "EMP-002", 1, 2,2),
                new Empleado(3, "Juan", "Perez", "León", 89765432, "jperez@gmail.com", DateTime.Parse("1990-12-23"), "Masculino", DateTime.Parse("2015-06-01"), null, "EMP-003", 1, 3,2),
                new Empleado(4, "Ana", "Martinez", "Granada", 86543210, "amartinez@gmail.com", DateTime.Parse("1988-07-04"), "Femenino", DateTime.Parse("2021-01-01"), null, "EMP-004", 1, 4,4),
                new Empleado(5, "Pedro", "Ramirez", "Masaya", 87654321, "pramirez@gmail.com", DateTime.Parse("1992-10-20"), "Masculino",  DateTime.Parse("2018-11-01"),DateTime.Parse("2023-03-1"), "EMP-005", 2, 1,5),
                new Empleado(6, "Lucia", "Lopez", "Estelí", 89654321, "llopez@gmail.com", DateTime.Parse("1996-03-17"), "Femenino", DateTime.Parse("2020-02-15"), null, "EMP-006", 1, 2,6),
                new Empleado(7, "David", "Lovo", "Ciudad sandino", 87034314, "dlovo@gmail.com", DateTime.Parse("1997-01-10"), "masculino", DateTime.Parse("2020-01-01"), null, "EMP-007", 1, 1,7),
                new Empleado(8, "Maria", "Gonzalez", "Managua", 87654321, "mgonzalez@gmail.com", DateTime.Parse("1995-05-15"), "Femenino",  DateTime.Parse("2018-05-01"), null, "EMP-008", 1, 2,8),
                new Empleado(9, "Juan", "Perez", "León", 89765432, "jperez@gmail.com", DateTime.Parse("1990-12-23"), "Masculino",  DateTime.Parse("2019-03-15"), DateTime.Parse("2023-03-11"), "EMP-009", 2, 3,9),
                new Empleado(10, "Laura", "Gutierrez", "Chinandega", 87651234, "lgutierrez@gmail.com", DateTime.Parse("1993-09-22"), "Femenino",DateTime.Parse("2021-08-01"), null, "EMP-010", 1, 1,10),
                new Empleado(11, "Carlos", "Gomez", "Rivas", 89876543, "cgomez@gmail.com", DateTime.Parse("1991-06-15"), "Masculino", DateTime.Parse("2020-12-15"), DateTime.Parse("2023-03-2"), "EMP-011", 2, 2,11)
            };

        }

    }
}