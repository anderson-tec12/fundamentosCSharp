using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoObjetos {

    public class Carro {
        //escondendo o metodo assim quem chamar por henraçna nao consegue mexer
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMAxima) {
            VelocidadeMaxima = velocidadeMAxima;
        }

        //escondendo o metodo assim quem chamar por henraçna nao consegue mexer
        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = delta + VelocidadeAtual;
            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        //esta publico 
        //virtual quando adicionado permite que o metodo seja reescrito nos herdeiros
        public virtual int Acelerar() {
            return AlterarVelocidade(5);
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }

    //criando uma class que herda de carro

        public class Uno : Carro {
        //chamando o construtor da class herdade
            public Uno() : base(200) {

            }
        }

    public class Ferrari : Carro{
        public Ferrari() : base(300) { }

        //sobre escrever o metodo de acelerar
        public override int Acelerar() {
            return AlterarVelocidade(15);
        }

        //ocutar o metodo frear da class pai, porem no poliformismo vai pegar o metodo que foi ocutado gerando assim um problema
        //sempre opte por sobre escrita
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }

    class _01_Heranca {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());

            Console.WriteLine("Ferrari com o tipo CARRO...");
            Carro carro3 = new Ferrari(); //polimofirsmo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("uno com o tipo CARRO...");
            carro3 = new Uno(); //polimofirsmo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}

