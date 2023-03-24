using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{ 
    public class CuentaBancaria
       
    {
        public decimal saldo;
        private decimal saldoDepositado;

        public CuentaBancaria(decimal saldoInicial)
        {
            saldo = saldoInicial;
            saldoDepositado = 0;
        }

        public void Depositar(decimal cantidad)
        {
            saldo += cantidad;
            saldoDepositado += cantidad;
        }
        public decimal ObtenerSaldoDepositado()
        {
            return saldoDepositado;
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
            }
            else
            {
                Console.WriteLine("No tienes suficiente saldo para realizar esta operación.");
            }
        }
    }
        
}
