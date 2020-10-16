using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Carro{
        public string Modelo;
        public string Fabricante;
        public int Ano;

        //construindo um construtor
        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Ano = ano;
            Fabricante = fabricante;
        }

        public Carro() {

        }
    }

    class _02_Construtores {
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Modelo = "235I";
            carro1.Fabricante = "BMW";
            carro1.Ano = 2019;

            Console.WriteLine("{0} {1} {2}",carro1.Ano, carro1.Modelo, carro1.Fabricante);

            var carro2 = new Carro("Ka", "Ford", 2003);
            Console.WriteLine("{0} {1} {2}", carro2.Ano, carro2.Modelo, carro2.Fabricante);

            var carro3 = new Carro() {
                Modelo = "HB20",
                Ano = 2019,
                Fabricante = "HYUNDAY"
            };
            Console.WriteLine("{0} {1} {2}", carro3.Ano, carro3.Modelo, carro3.Fabricante);
        }
    }
}
