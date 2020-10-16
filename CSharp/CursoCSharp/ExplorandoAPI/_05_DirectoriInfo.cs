using System;
using System.IO;

namespace CursoCSharp.ExplorandoAPI {
    class _05_DirectoriInfo {
        public static void Executar() {
            var pasta = @"~/DadosPessoais".ParseHome();
            var dirInfo = new DirectoryInfo(pasta);

            Console.WriteLine("Arquivos");
            var arquivos = dirInfo.GetFiles();
            foreach(var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("Diretorios");
            var diretorios = dirInfo.GetDirectories();
            foreach (var dir in diretorios) {
                Console.WriteLine(dir);
            }


            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);


        }

    }
}
