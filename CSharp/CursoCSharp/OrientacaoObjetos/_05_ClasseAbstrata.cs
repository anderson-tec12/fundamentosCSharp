using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoObjetos {

    public abstract class Cecular{
        public abstract string Assistente();

        public string Tocar() {
            return "Trim trim trim ";
        }
            
    }

    public class Samsung : Cecular {
        public override string Assistente() {
            return "Ola eu sou a BIXBY";
        }
    }

    public class Iphone : Cecular {
        public override string Assistente() {
            return "Ola eu sou a SIRI";
        }
    }

    class _05_ClasseAbstrata {
        public static void Executar() {
            var celulares = new List<Cecular> {
                  new Samsung(),
                  new Iphone()
              };

            foreach(var celular in  celulares){
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
