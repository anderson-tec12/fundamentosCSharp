using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    interface Ponto {
        void MoverNaDiagonal(int delta);
    }

    //colocandano a struct para ser aderente a interface Ponto
    struct Coordenada : Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            Y = y;
            X = x;
        }

        public void MoverNaDiagonal(int delta) {
            Y += delta;
            X += delta;
        }
    }

    class _13_Struct {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada inicial ");
            Console.WriteLine("X = {0} ", coordenadaInicial.X);
            Console.WriteLine("Y = {0} ", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(9, 1);
            coordenadaFinal.MoverNaDiagonal(10);
            Console.WriteLine("Coordenada Final ");
            Console.WriteLine("X = {0} ", coordenadaFinal.X);
            Console.WriteLine("Y = {0} ", coordenadaFinal.Y);
        }
    }
}
