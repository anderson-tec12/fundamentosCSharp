using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class CarroOpcional {
        double desconto = 0.5;
        string nome;

        public string Nome {
            get {
                return "Opcional: " + nome;
            }

            set {
                nome = value;
            }
        }

        //propriedades autoimplementadas, podendo ser acessada diretamente igual a public
        public double Preco { get; set; }

        //somente leitura usando lambda
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco);
        }

        //Construtores

        public CarroOpcional() {

        }

        public CarroOpcional(string nome, double preco) {
            this.nome = nome;
            Preco = preco;
        }

    }

    class _10_Props {

        public static void Executar() {
            var op1 = new CarroOpcional("Ar Condicionado ", 4999.99);
            Console.WriteLine(op1.PrecoComDesconto);
        }
    }
}
