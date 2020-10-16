using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }

        public int Somar(int a, int b, int c) {
            return a + b + c;
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }

        public int Dividir(int a, int b) {
            return a / b;
        }
    }

    class CalculadoraCadeia {
        int memoria;
        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }

    class _03_MetodosComRetornos {

        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();

            Console.WriteLine(calculadoraComum.Somar(5,5));
            Console.WriteLine(calculadoraComum.Somar(5,5, 5));
            Console.WriteLine(calculadoraComum.Subtrair(5,4));
            Console.WriteLine(calculadoraComum.Dividir(5,5));
            Console.WriteLine(calculadoraComum.Multiplicar(5,5));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Somar(8).Imprimir();
        }
    }
}
