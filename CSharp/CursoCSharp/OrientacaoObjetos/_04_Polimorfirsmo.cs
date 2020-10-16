using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoObjetos {
    //Clase base para o polimorfismo

    public class Comida {
        public double Peso;

        public Comida(double peso) {
            Peso = peso;
        }

        public Comida() {
        }
    }

    public class Feijao : Comida {
       
    }

    public class Arroz : Comida  {
       
    }

    public class Carne : Comida {
        
    }

    public class Pessoa {
        public double Peso;

        //public void Comer(Feijao feijao) {
        //    Peso += feijao.Peso;
        //}

        //public void Comer(Arroz arroz) {
        //    Peso += arroz.Peso;
        //}

        //public void Comer(Carne carne) {
        //    Peso += carne.Peso;
        //}

        //Comida polimorfirmos;
        public void Comer(Comida comida) {
            Peso += comida.Peso;
        }


    }

    

    class _04_Polimorfirsmo {
        public static void Executar() {

            //sem poliformismo
            Feijao ingrediente1 = new Feijao();
            ingrediente1.Peso = 0.3;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;


            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine(cliente.Peso);

        }
    }
}
