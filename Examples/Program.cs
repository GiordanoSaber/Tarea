using Examples;
using System;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {


            var cuenta = new CuentaBancaria(1400);
            cuenta.Depositar(500);
            cuenta.Retirar(200);
            cuenta.Retirar(1000);

            Console.WriteLine("El saldo Depositado es: " + cuenta.ObtenerSaldoDepositado());
            Console.WriteLine("El saldo actual es: " + cuenta.saldo);
        }
    }
             
}