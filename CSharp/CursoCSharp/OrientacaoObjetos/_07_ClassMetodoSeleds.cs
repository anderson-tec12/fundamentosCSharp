using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoObjetos {

    //seled nao permite herança
    sealed class semFilho {
        public double ValorDaFortuna() {
            return 1407033.65;
        }
    }

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai:Avo {
        public override sealed bool HonrarNomeFamilia() {
            return true;
        }
    }

    class FilhoRebelde :Pai {
        //não permite sobre escrita mas pdemos ocutar
        public new bool HonrarNomeFamilia() {
            return false;
        }
    }
    class _07_ClassMetodoSeleds {
        public static void Executar() {
            semFilho semFilho = new semFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
