using System;
//using System.Collections.Generic; nao pode usa
using System.Text;
using System.Collections;

namespace CursoCSharp.Colecoes {
    class _03_ArrayList {
        public static void Executar() {
            var arrayList = new ArrayList {
                "palavra",
                3,
                true
            };

            arrayList.Add(3.14);

            foreach(var i in arrayList){
                Console.WriteLine("{0} => {1}",i ,i.GetType());
            }
        }
    }
}
