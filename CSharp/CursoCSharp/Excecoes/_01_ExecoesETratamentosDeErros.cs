using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes {
    public class Conta {
        double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if(valor > Saldo) {
                throw new ArgumentException("Saldo insuficiente");
            }

            Saldo -= valor; 
        }
    }
    class _01_ExecoesETratamentosDeErros {
        public static void Executar() {
            var conta = new Conta(1223.45);
            //caso gere erro 
            try {
                conta.Sacar(1600);
                Console.WriteLine("Retirada cm sucesso");
            }catch(Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("Final, sempre executado mesmo com ou sem erros");
            }
        }
    }
}
