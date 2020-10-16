using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class Moto {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada) {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        public Moto() {

        }

        //getters
        public string GetMarca() {
            return Marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public int GetCilindrada() {
            return Cilindrada;
        }

        //setters
        public void SetMarca(string marca) {
            Marca = marca;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;

        }

        public void SetCilidrada(int c) {
            Cilindrada = c;
        }


    }
    class _09_GettersSetters {
        public static void Executar() {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", -639);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());
            moto1.SetCilidrada(700);
            Console.WriteLine(moto1.GetCilindrada());
        }
    }
}
