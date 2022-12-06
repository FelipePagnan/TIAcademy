using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_03.models
{
    public class ContaCorrente
    {
        public int Numero { get; set; }
        private decimal  Saldo { get; set; }

        public ContaCorrente(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Sacar(decimal valor){

            if(valor <= Saldo){
                Saldo = Saldo - valor;
                System.Console.WriteLine("Saldo de " + valor + " realizado com sucesso");
            }
            else{
                System.Console.WriteLine("Saldo insuficiente");
            }
        }

        public void ExibirSaldo(){
            System.Console.WriteLine("Seu saldo é: " + Saldo);
        }
    }
}