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
        private List<Bombero> bomberosSeleccionados;
        private List<Estado> estadosProgramacion;
        private Estado estadoProgramada;

        public GestorProgramacionGuardia()
        {
            // instanciar todo lo que necesitamos (programaciones con sus estados, bomberos con disponibilidad, detalle y dias
            //Creamos los dias de DiaSemana
            bomberos = new List<Bombero>();
            programaciones = new List<ProgramacionGuardia>();
            estadosProgramacion = new List<Estado>();

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
            DateTime horaDesde3 = new DateTime(2019, 1, 1, 5, 0, 0);
            DateTime horaHasta4 = new DateTime(2019, 1, 1, 13, 00, 0);
            DateTime horaDesde5 = new DateTime(2019, 1, 1, 16, 0, 0);
            DateTime horaHasta5 = new DateTime(2019, 1, 1, 23, 0, 0);
            DateTime horaDesde6 = new DateTime(2019, 1, 1, 3, 0, 0);
            DateTime horaHasta6 = new DateTime(2019, 1, 1, 11, 00, 0);
            DateTime horaDesde7 = new DateTime(2019, 1, 1, 14, 0, 0);
            DateTime horaHasta7 = new DateTime(2019, 1, 1, 21, 0, 0);
            DateTime horaDesde8 = new DateTime(2019, 1, 1, 6, 0, 0);
            DateTime horaHasta8 = new DateTime(2019, 1, 1, 10, 00, 0);


            //creo unos cuantos DetalleDisponibilidad
            DetalleDisponibilidad det1 = new DetalleDisponibilidad(horaDesde1, horaHasta1, dias[0]);
            DetalleDisponibilidad det2 = new DetalleDisponibilidad(horaDesde2, horaHasta2, dias[1]);
            DetalleDisponibilidad det3 = new DetalleDisponibilidad(horaDesde2, horaHasta2, dias[2]);
            DetalleDisponibilidad det4 = new DetalleDisponibilidad(horaDesde3, horaHasta4, dias[3]);
            DetalleDisponibilidad det5 = new DetalleDisponibilidad(horaDesde5, horaHasta5, dias[4]);
            DetalleDisponibilidad det6 = new DetalleDisponibilidad(horaDesde6, horaHasta6, dias[5]);
            DetalleDisponibilidad det7 = new DetalleDisponibilidad(horaDesde7, horaHasta7, dias[6]);
            DetalleDisponibilidad det8 = new DetalleDisponibilidad(horaDesde8, horaHasta8, dias[0]);


            List<DetalleDisponibilidad> detalles1 = new List<DetalleDisponibilidad>();
            detalles1.Add(det1);
            detalles1.Add(det2);

            List<DetalleDisponibilidad> detalles2 = new List<DetalleDisponibilidad>();
            detalles2.Add(det3);
            detalles2.Add(det4);

            List<DetalleDisponibilidad> detalles3 = new List<DetalleDisponibilidad>();
            detalles3.Add(det5);
            detalles3.Add(det6);
            List<DetalleDisponibilidad> detalles4 = new List<DetalleDisponibilidad>();
            detalles4.Add(det7);
            detalles4.Add(det8);

            DateTime fechaDesde = new DateTime(2019, 10, 31);
            DateTime fechaHasta = new DateTime(2019, 11, 30);
            DateTime fechaDesde1 = new DateTime(2019, 9, 18);
            DateTime fechaHasta1= new DateTime(2019, 11, 28);
            DateTime fechaDesde2 = new DateTime(2019, 11, 1);
            DateTime fechaHasta2 = new DateTime(2019, 12, 25);

            //creo algunas disponibilidades con sus detalles

            Disponibilidad dis1 = new Disponibilidad(fechaDesde, fechaHasta, detalles1);
            Disponibilidad dis2 = new Disponibilidad(fechaDesde1, fechaHasta1, detalles2);
            Disponibilidad dis3 = new Disponibilidad(fechaDesde1, fechaHasta1, detalles2);
            Disponibilidad dis4 = new Disponibilidad(fechaDesde2, fechaHasta2, detalles3);
            Disponibilidad dis5 = new Disponibilidad(fechaDesde2, fechaHasta2, detalles4);

            List<Disponibilidad> disponibilidad1 = new List<Disponibilidad>();
            disponibilidad1.Add(dis1);

            List<Disponibilidad> disponibilidad2 = new List<Disponibilidad>();
            disponibilidad2.Add(dis2);

            List<Disponibilidad> disponibilidad3= new List<Disponibilidad>();
            disponibilidad3.Add(dis3);

            List<Disponibilidad> disponibilidad4 = new List<Disponibilidad>();
            disponibilidad4.Add(dis4);

            List<Disponibilidad> disponibilidad5 = new List<Disponibilidad>();
            disponibilidad5.Add(dis5);

            DateTime nacimiento1 = new DateTime(1995, 6, 15);
            DateTime nacimiento2 = new DateTime(1980, 12, 21);
            DateTime nacimiento3 = new DateTime(1975, 5, 28);
            DateTime nacimiento4 = new DateTime(1989, 8, 2);
            DateTime nacimiento5 = new DateTime(1987, 9, 7);
            DateTime nacimiento6 = new DateTime(1988, 7, 19);
            //creo los bomberos

            Bombero bombero1 = new Bombero("Tito", "Fuentes", 30420069, "Calle Falsa 123", "maildetito@yahoo.com.ar", 
                "3525502402", nacimiento1, disponibilidad1);
            Bombero bombero2 = new Bombero("Geraldo", "Riviera", 40576394, "Yrigoyen 500", "geraldoriviera@gmail.com", 
                "351256789", nacimiento1, disponibilidad2);
            Bombero bombero3 = new Bombero("Juan","Garcia",30405060,"Obispo Oro 1221","juangarcia@gmail.com", 
                "352845466",nacimiento2,disponibilidad3);
            Bombero bombero4 = new Bombero("Esteban", "Quito", 39564898, "Larrañaga 800", "estebanquito@gmail.com",
                "351344389", nacimiento3, disponibilidad4);
            Bombero bombero5 = new Bombero("Marcos", "Paz", 40155465, "Ituzaingo 550", "marcospaz@gmail.com",
                "351256789", nacimiento4, disponibilidad5);
            Bombero bombero6 = new Bombero("Juana", "DeArco", 36859445, "Chacabuco 8800", "juanita@gmail.com",
                "351256789", nacimiento5, disponibilidad4);
            Bombero bombero7 = new Bombero("Daniel", "Caminos", 39656545, "Yrigoyen 500", "danicaminos@gmail.com",
                "351256789", nacimiento6, disponibilidad3);

            bomberos.Add(bombero1);
            bomberos.Add(bombero2);
            bomberos.Add(bombero3);
            bomberos.Add(bombero4);
            bomberos.Add(bombero5);
            bomberos.Add(bombero6);
            bomberos.Add(bombero7);

            //2 guardias de prueba
            DateTime desde = new DateTime(2019, 1, 1, 4, 0, 0);
            DateTime hasta = new DateTime(2019, 1, 1, 12, 00, 0);
            DateTime desde1 = new DateTime(2019, 1, 1, 15, 0, 0);
            DateTime desde2 = new DateTime(2019, 1, 1, 22, 0, 0);


            EnCurso e1 = new EnCurso();
            GuardiaBombero guardia1 = new GuardiaBombero(desde, hasta);
            guardia1.setEstado(e1);
            GuardiaBombero guardia2 = new GuardiaBombero(desde1, hasta);
            guardia2.setEstado(e1);


            //programacion de prueba
            List<GuardiaBombero> guardias = new List<GuardiaBombero>();
            guardias.Add(guardia1);
            guardias.Add(guardia2);

            DateTime fechaIn = new DateTime(2019, 9, 1);
            DateTime fechaFin = new DateTime(2019, 10, 3);
            ProgramacionGuardia programacion = new ProgramacionGuardia(fechaIn, fechaFin, guardias);

            //estado de la programacion

            Estado estado = new Estado("encurso", "esta en curso");
            estadosProgramacion.Add(estado);
            estado = new Estado("programada", "esta programada");
            estadosProgramacion.Add(estado);

            programacion.setEstado(estado);

            programaciones.Add(programacion);

            //aca empieza el caso de uso solicitando el periodo
            fechaActual = DateTime.Now;
            pantalla = new PantallaProgramacionGuardia(this);
            pantalla.habilitarVentana();

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
                    MessageBox.Show("El periodo ya esta en una programacion valida", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    bomberoActivos.Add(bombero.mostrarDatos(fechaActual));
                }
            }
            pantalla.mostrarBomberosYDisponibilidad(bomberoActivos);
        }

        public void tomarBomberos(List<Bombero> bomberoSeleccionado)
        {
            bomberosSeleccionados = bomberoSeleccionado;
            if(validarDisponibilidadBombero(bomberosSeleccionados))
            {
                pantalla.solicitarConfirmacion();
            }
        }

        public bool validarDisponibilidadBombero(List<Bombero> bomberos)
        {
            bool valido = true;
            foreach(Bombero bombero in bomberos)
            {
                //revisar que no hayan cambiado las disponibilidades, no esta programado todavia, no van a cambiar
            }
            return valido;
        }

        public void tomarConfirmacion()
        {
            this.generarProgramacion();
        }

        public void generarProgramacion()
        {
            this.buscarEstados();
        }

        public void buscarEstados()
        {
            foreach(Estado estado in estadosProgramacion)
            {
                if(estado.esProgramada())
                {
                    estadoProgramada = estado;
                }
            }
            List<DateTime[]> horasDesde = new List<DateTime[]>(); //lista con vectores de horasDesde, cada posicion de la lista es un bombero, y cada vector son sus horasDesde
            List<DateTime[]> horasHasta = new List<DateTime[]>();
            List<DiaSemana[]> diasSemana = new List<DiaSemana[]>();

            for(int i = 0; i < bomberosSeleccionados.Count; i++)
            {
                List<Object[]> detalles = bomberosSeleccionados[i].datosDisponibilidadVigente();
                DateTime[] hdesde = new DateTime[detalles.Count];//vector con todas las horas desde de el bombero i
                DateTime[] hhasta = new DateTime[detalles.Count];//vector con todas las horas hasta de el bombero i
                DiaSemana[] dias = new DiaSemana[detalles.Count];//vector con todos los dias de el bombero i

                for (int j = 0; j < detalles.Count; j++)
                {
                
                    hdesde[j] =(DateTime)detalles[j][0]; // busco el elemento j en la lista detalles (que es un vector de objetos) y en la posicion 0 siempre esta la hora desde
                    hhasta[j] = (DateTime)detalles[j][1]; //en la posicion 1 siempre tengo horas hasta
                    dias[j] = (DiaSemana)detalles[j][2]; //en la posicion 2 del vector siempre tengo dias
                }
                horasDesde.Insert(i, hdesde); 
                horasHasta.Insert(i, hhasta);
                diasSemana.Insert(i, dias);
            }

            ProgramacionGuardia nueva = new ProgramacionGuardia(fechaDesde, fechaHasta, estadoProgramada, bomberosSeleccionados,horasDesde,horasHasta,diasSemana);

            programaciones.Add(nueva);
            MessageBox.Show("Programacion creada con éxito", "Programación finalizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
