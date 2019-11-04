﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Entidades
{

    class Bombero
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

        public void mostrarDatos(DateTime fechaActual)
        {
            foreach(Disponibilidad disponibilidad in disponibilidad)
            {

            }
        }
    }
}
