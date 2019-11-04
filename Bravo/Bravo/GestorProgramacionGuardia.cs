using Bravo.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo
{
    public class GestorProgramacionGuardia
    {
        private List<Bombero> bomberos;
        private List<ProgramacionGuardia> programaciones;
        DiaSemana[] dias;
        PantallaProgramacionGuardia pantalla;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private DateTime fechaActual;

        public GestorProgramacionGuardia()
        {
            // instanciar todo lo que necesitamos (programaciones con sus estados, bomberos con disponibilidad, detalle y dias
            //Creamos los dias de DiaSemana
            bomberos = new List<Bombero>();
            programaciones = new List<ProgramacionGuardia>();

            String[] d = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            dias = new DiaSemana[7];
            for (int i = 0; i < dias.Length; i++)
            {
                dias[i] = new DiaSemana(d[i]);
            }

            //se crean un par de horas para los detalles
            DateTime horaDesde1 = new DateTime(2019, 1, 1, 4, 0, 0);
            DateTime horaHasta1 = new DateTime(2019, 1, 1, 12, 00, 0);
            DateTime horaDesde2 = new DateTime(2019, 1, 1, 15, 0, 0);
            DateTime horaHasta2 = new DateTime(2019, 1, 1, 22, 0, 0);

            //creo unos cuantos DetalleDisponibilidad
            DetalleDisponibilidad det1 = new DetalleDisponibilidad(horaDesde1, horaHasta1, dias[0]);
            DetalleDisponibilidad det2 = new DetalleDisponibilidad(horaDesde2, horaHasta2, dias[1]);
            DetalleDisponibilidad det3 = new DetalleDisponibilidad(horaDesde2, horaHasta2, dias[2]);
            DetalleDisponibilidad det4 = new DetalleDisponibilidad(horaDesde2, horaHasta2, dias[3]);

            List<DetalleDisponibilidad> detalles1 = new List<DetalleDisponibilidad>();
            detalles1.Add(det1);
            detalles1.Add(det2);

            List<DetalleDisponibilidad> detalles2 = new List<DetalleDisponibilidad>();
            detalles2.Add(det3);
            detalles2.Add(det4);

            DateTime fechaDesde = new DateTime(2019, 10, 31);
            DateTime fechaHasta = new DateTime(2019, 11, 30);

            //creo algunas disponibilidades con sus detalles

            Disponibilidad dis1 = new Disponibilidad(fechaDesde, fechaHasta, detalles1);
            Disponibilidad dis2 = new Disponibilidad(fechaDesde, fechaHasta, detalles2);

            List<Disponibilidad> disponibilidad1 = new List<Disponibilidad>();
            disponibilidad1.Add(dis1);

            List<Disponibilidad> disponibilidad2 = new List<Disponibilidad>();
            disponibilidad2.Add(dis2);

            DateTime nacimiento1 = new DateTime(1995, 6, 15);

            //creo los bomberos

            Bombero bombero1 = new Bombero("Tito", "Fuentes", 30420069, "Calle Falsa 123", "maildetito@yahoo.com.ar", 
                "3525502402", nacimiento1, disponibilidad1);
            Bombero bombero2 = new Bombero("Geraldo", "Riviera", 40576394, "Yrigoyen 500", "geraldoriviera@gmail.com", 
                "351256789", nacimiento1, disponibilidad2);

            bomberos.Add(bombero1);
            bomberos.Add(bombero2);




            //aca empieza el caso de uso solicitando el periodo
            fechaActual = DateTime.Now;
            pantalla = new PantallaProgramacionGuardia(this);

        }

        public void tomarPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.validarProgramaciones();
        }

        public void validarProgramaciones()
        {
            bool bandera = true;
            foreach(ProgramacionGuardia programacion in programaciones)
            {
                if(!programacion.coincidePeriodo(fechaDesde, fechaHasta))
                {
                    bandera = false;
                    //mensaje de error y se rompio todo, de nuevo
                }
            }

            if(bandera)
            {
                this.buscarBomberos();
            }
        }

        public void buscarBomberos()
        {
            List<Bombero> bomberoActivos = new List<Bombero>();
            foreach(Bombero bombero in bomberos)
            {
                if(bombero.esActivo())
                {
                    bombero.mostrarDatos(fechaActual);
                }
            }
        }
    }
}
