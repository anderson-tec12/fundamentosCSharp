using System;
using System.IO;

namespace CursoCSharp.ExplorandoAPI {
    class _04_TrabalhandoComDiretorios {
        public static void Executar() {
            var novoDir = @"~/PastaNovaCsharp".ParseHome();
            var novoDirDestino = @"~/PastaNovaCsharpDestino".ParseHome();
            var dirDados = @"~/node_modules".ParseHome();
            var dirDados2 = @"~/DadosPessoais/Fotos/2017".ParseHome();

            //verifica se existe a pasta
            if (Directory.Exists(novoDir)) {
                //excluir diretorio, se marcado true vai ser deletardo recursivamente
                Directory.Delete(novoDir, true); 
            }

            if (Directory.Exists(novoDirDestino)) {
                //excluir diretorio, se marcado true vai ser deletardo recursivamente
                Directory.Delete(novoDirDestino, true);
            }

            //criando a pasta

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir)); //ver a data de criacao


            //exibindo pastas
            Console.WriteLine("pasta =======");
            var pastas = Directory.GetDirectories(dirDados);
            foreach(var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            //exibindo arquivos
            Console.WriteLine("arquivos =======");
            var arquivos = Directory.GetFiles(dirDados2);
            foreach(var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            //obtendo  a raiz
            Console.WriteLine("Diretorio RAIZ");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            //movendo uma pasta
            Directory.Move(novoDir, novoDirDestino);

        }
    }
}
