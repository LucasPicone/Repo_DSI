using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Entidades
{

    public class Bombero
    {
        private bool activo;
        private String apellido;
        private String nombre;
        private int DNI;
        private String direccion;
        private String email;
        private String telefono;
        private DateTime fechaNacimiento;
        private List<Disponibilidad> disponibilidad;
        private Disponibilidad dispoVigente;

        public Bombero(String nombre, String apellido, int dni, String dir, String email, String tel, DateTime fecha, List<Disponibilidad> dis)
        {
            this.activo = true;
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = dni;
            this.direccion = dir;
            this.email = email;
            this.telefono = tel;
            this.fechaNacimiento = fecha;
            this.disponibilidad = dis;
        }

        public bool esActivo()
        {
            return activo;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public String getApellido()
        {
            return this.apellido;
        }

        public List<String[]> disponibilidadVigente()
        {
            return dispoVigente.mostrarDisponibilidadCompleta();
        }

        public DateTime getFinVigenciaDisponibilidadActual()
        {
            return dispoVigente.getFinVigencia();
        }
        public Bombero mostrarDatos(DateTime fechaActual)
        {
            /*
            Object[] bombero = new Object[3];
            List<String[]> disponibilidadCompleta = null;
            */
            foreach(Disponibilidad disponibilidad in disponibilidad)
            {
                if(disponibilidad.sosVigente(fechaActual))
                {
                    this.dispoVigente = disponibilidad;
                    //disponibilidadCompleta = disponibilidad.mostrarDisponibilidadCompleta();
                    return this;
                }
            }
            /*
            bombero[0] = this.nombre;
            bombero[1] = this.apellido;
            bombero[2] = disponibilidadCompleta;
            */
            return null;
        }
    }
}
