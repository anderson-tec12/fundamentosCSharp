using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoObjetos {

    //os metodos de uma interfae ja são abstratas logo nao podem ter corpo
    //por padrao é public tambem 
    interface OperacaoBinaria {
        int Operacao(int a, int b);
    }

    class Soma : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a + b;
        }
    }

    class Subtracao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a * b;
        }
    }

    class Calculadora {
        List<OperacaoBinaria> operacaos = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarTodasAsOperacoes(int a, int b) {
            string resultados = "";
            foreach(var op in operacaos) {
                resultados += $"Usand  {op.GetType().Name} = {op.Operacao(a,b)}\n";
            }

            return resultados;
        }

    }

    class _06_Interface {
        public static void Executar() {
            var calc = new Calculadora();
            var resultado = calc.ExecutarTodasAsOperacoes(5, 2);
            Console.WriteLine(resultado);
        }
    }
}
