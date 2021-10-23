using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Escuela
{
    public class EstudiantesBL
    {
        Contexto _contexto;
        public BindingList<Estudiante> ListaEstudiantes { get; set; }

        public EstudiantesBL()
        {
            _contexto = new Contexto();
            ListaEstudiantes = new BindingList<Estudiante>();
        }

        public BindingList<Estudiante> ObtenerEstudiantes()
        {
            _contexto.Estudiantes.Load();
            ListaEstudiantes = _contexto.Estudiantes.Local.ToBindingList();

            return ListaEstudiantes;
        }

        public Resultado GuardarEstudiante(Estudiante estudiante)
        {
            var resultado = Validar(estudiante);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges(); // el contexto representa nuestra bd

            resultado.Exitoso = true;
            return resultado;
        } //  GuardarEstudiante

        public void AgregarEstudiante()
        {
            var nuevoEstudiante = new Estudiante();
            ListaEstudiantes.Add(nuevoEstudiante);
        }

        public bool EliminarEstudiante(int id)
        {
            foreach (var estudiante in ListaEstudiantes)
            {
                if (estudiante.Id == id)
                {
                    ListaEstudiantes.Remove(estudiante);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Estudiante estudiante)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(estudiante.Cedula) == true)
            {
                resultado.Mensaje = "Ingrese un numero de cedula";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(estudiante.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(estudiante.Apellido) == true)
            {
                resultado.Mensaje = "Ingrese un Apellido";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(estudiante.Celular) == true)
            {
                resultado.Mensaje = "Ingrese un numero celular";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(estudiante.Correo) == true)
            {
                resultado.Mensaje = "Ingrese un correo electrónico";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(estudiante.Grado) == true || estudiante.Grado != "Primero" && estudiante.Grado != "Segundo"
                && estudiante.Grado != "Tercero" && estudiante.Grado != "Cuarto" && estudiante.Grado != "Quinto" && estudiante.Grado != "Sexto")
            { 
                resultado.Mensaje = "El campo está vacío o ingresó un grado incorrecto";
                resultado.Exitoso = false;
            }
            
            if (estudiante.Edad <6 || estudiante.Edad > 13)
            {
                resultado.Mensaje = "La edad no debe ser menor que 6 ni mayor que 13";
                resultado.Exitoso = false;
            }
            if (estudiante.Clases < 1 || estudiante.Clases > 12)
            {
                resultado.Mensaje = "Las clases deben ser mayor a 1 y menor que 12";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Estudiante
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Grado { get; set; }
        public int Clases { get; set; }
        public bool Activo { get; set; }

    }
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
