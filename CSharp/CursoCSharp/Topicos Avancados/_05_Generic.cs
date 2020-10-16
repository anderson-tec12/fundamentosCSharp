using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Topicos_Avancados {

    public class Caixa<T> {
        T valoPrivado;
        public T Coisa { get; set; }

        public Caixa(T coisa) {
            Coisa = coisa;
            valoPrivado = coisa ;
        }

        public T metodoGenerico(T valor) {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor() {
            return valoPrivado;
        }
    }

    class CaixaInt : Caixa<int> {
        public CaixaInt() : base(0) { }
    }
    class _05_Generic {
        public static void Executar() {
            var caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("teste");
            Console.WriteLine(caixa2.metodoGenerico("GENERICO"));
            Console.WriteLine(caixa2.Coisa.GetType());
        }
    }
}
