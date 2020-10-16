using System;
using System.Collections.Generic;
using System.Text;
//nome do namespace usado no outro projeto que foi referenciado
using Encapsulamento;

namespace CursoCSharp.OrientacaoObjetos {

    public class FilhoNaoReconhecido : SubCelebridade {
        public  new void MeusAcessos() {
            Console.WriteLine("Filho nao reconhecido.... ");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(JeitoDeFalar);
        }
    }

    public class AmigoDistante {
        public readonly SubCelebridade amigo = new SubCelebridade();
        public void MeusAcessos() {
            Console.WriteLine("Amigo distante .....");

            Console.WriteLine(amigo.InfoPublica);
            
        }
    }

    class _03_Encapsolamento {
        public static void Executar(){
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();

            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();

            new AmigoDistante().MeusAcessos();
        }
    }
}
