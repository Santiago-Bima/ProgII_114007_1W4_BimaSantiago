﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using banco.Dominio;

namespace banco
{
    internal class Cuenta
    {
        private int cbu;
        private int id;
        private int tipoCuenta;
        private int cliente;
        private double total;
        private int activo;


        public int pCbu
        {
            get { return cbu; }
            set { cbu = value; }
        }

        public int pId
        {
            get { return id; }
            set { id = value; }
        }

        public int pTipoCuenta
        {
            get { return tipoCuenta; }
            set { tipoCuenta = value; }
        }

        public int pCliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public double pTotal
        {
            get { return total; }
            set { total = value; }
        }

        public int pActivo
        {
            get { return activo; }
            set { activo = value; }
        }
        public Cuenta()
        {
            cbu= 0;
            tipoCuenta= 0;
            cliente= 0;
            activo = 1;
            total = 0;
        }

        public Cuenta(int cbu, int tipoCuenta, int cliente,double total, int activo)
        {
            this.cbu = cbu;
            this.tipoCuenta = tipoCuenta;
            this.cliente = cliente;
            this.activo = 1;
            this.total = total;
        }
        public override string ToString()
        {
            return cbu + " - "  + tipoCuenta + " - " + cliente ;
        }
    }
}
