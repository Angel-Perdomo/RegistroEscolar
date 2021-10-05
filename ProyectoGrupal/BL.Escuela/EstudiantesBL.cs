using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Escuela
{
    public class EstudiantesBL
    {
        public BindingList<Estudiantes> ListaEstudiantes { get; set; } //**

        public EstudiantesBL()
        {
            ListaEstudiantes = new BindingList<Estudiantes>();

            var estuden1 = new Estudiantes();
            estuden1.numeroCuenta = 2021001;
            estuden1.primerNombre = "María";
            estuden1.segundoNombre = "Josefa";
            estuden1.primerApellido = "Montes";
            estuden1.segundoApellido = "Reyes";
            estuden1.estMatriculado = true;
            ListaEstudiantes.Add(estuden1);

            var estuden2 = new Estudiantes();
            estuden2.numeroCuenta = 2021002;
            estuden2.primerNombre = "Carlos";
            estuden2.segundoNombre = "Ernesto";
            estuden2.primerApellido = "Martinez";
            estuden2.segundoApellido = "Flores";
            estuden2.estMatriculado = true;
            ListaEstudiantes.Add(estuden2);

            var estuden3 = new Estudiantes();
            estuden3.numeroCuenta = 2021003;
            estuden3.primerNombre = "Kathia";
            estuden3.segundoNombre = "Joselin";
            estuden3.primerApellido = "Alcantara";
            estuden3.segundoApellido = "Vasquez";
            estuden3.estMatriculado = true;
            ListaEstudiantes.Add(estuden3);

        }

        public BindingList<Estudiantes> ObtenerEstudiantes()
        {
            return ListaEstudiantes;
        }

    } // Fin class EstudiantesBL.

    public class Estudiantes //CLASE
    {
        public int numeroCuenta { get; set; } //Propiedad
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public bool estMatriculado { get; set; }
    }
}
