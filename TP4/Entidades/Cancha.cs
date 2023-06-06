﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP4.Entidades
{
    public class Cancha
    {
        private bool libre = true;
        private Queue<IDisciplina> colaFH = new Queue<IDisciplina>();
        private Queue<IDisciplina> colaB = new Queue<IDisciplina>();
        private double tiempoJuego;
        private double horaFin = Double.MaxValue;

        private double rndUtilizado;

        public double HoraFin { get => horaFin; set => horaFin = value; }
        public double RndUtilizado { get => rndUtilizado; set => rndUtilizado = value; }
        public bool Libre { get => libre; set => libre = value; }
        public Queue<IDisciplina> ColaFH { get => colaFH; set => colaFH = value; }
        public Queue<IDisciplina> ColaB { get => colaB; set => colaB = value; }

        private Random rnd = new Random();

        public void recibirDisciplina(double horaInicio, IDisciplina disciplina, ref int retirados)
        {
            if (Libre)
            {
                iniciarProximoJuego(horaInicio, disciplina);
                Libre = false;
            }
            else if (hayLugarEnCola())
            {
                if (disciplina.nombre() == "Basket Ball")
                {
                    colaB.Enqueue(disciplina);
                }
                else
                {
                    colaFH.Enqueue(disciplina);
                }
            }
            else
            {
                retirados++;
            }
            Console.WriteLine("Hora fin: " + horaFin);
        }

        public void iniciarProximoJuego(double reloj, IDisciplina disciplina)
        {
            horaFin = generarProximoFinJuego(reloj, disciplina);
        }

        public IDisciplina iniciarProximoJuego(double reloj, ref double acEspF, ref double acEspH, ref double acEspB)
        {
            IDisciplina deporte = null;
            if (colaFH.Count > 0)
            {
                deporte = colaFH.Dequeue();

                if (deporte is Futbol)
                {
                    acEspF += reloj - deporte.ProximaLlegada;
                }
                else
                {
                    acEspH += reloj - deporte.ProximaLlegada;
                }

                horaFin = generarProximoFinJuego(reloj, deporte);
            }
            else if (colaB.Count > 0)
            {
                deporte = colaB.Dequeue();

                acEspB += reloj - deporte.ProximaLlegada;

                horaFin = generarProximoFinJuego(reloj, deporte);
            }
            else
            {
                Libre = true;
                horaFin = Double.MaxValue;
            }
            return deporte;
        }

        public double generarProximoFinJuego(double horaInicio, IDisciplina disciplina)
        {
            rndUtilizado = rnd.NextDouble();
            tiempoJuego = disciplina.generarTiempoJuego(rndUtilizado);
            return horaInicio + tiempoJuego;
        }

        public bool hayLugarEnCola()
        {
            return colaB.Count + colaFH.Count < 5;
        }

        public override string ToString()
        {
            return "Fin Juego";
        }

    }
}
