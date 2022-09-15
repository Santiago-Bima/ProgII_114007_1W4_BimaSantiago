﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco.Dominio
{
    internal class Transaccion
    {
        private int idCuenta;
        private int nroT;
        private double monto;
        private DateTime fecha;
        private int activo;
        public List<Movimiento> Movimiento { get; set; }

        public int IdCuenta
        {
            get { return idCuenta; }
            set { idCuenta = value; }
        }

        public int NroT
        {
            get { return nroT; }
            set { nroT = value; }
        }

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public Transaccion()
        {
            Movimiento = new List<Movimiento>();
        }
        public int pActivo
        {
            get { return activo; }
            set { activo = value; }
        }

        public void AgregarMovimiento(Movimiento movimiento)
        {
            Movimiento.Add(movimiento);
        }

        public void QuitarMovimiento (int indice)
        {
            Movimiento.RemoveAt(indice);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (Movimiento item in Movimiento)
            {
                total += item.Monto;
            }
            return total;
        }
    }
}
