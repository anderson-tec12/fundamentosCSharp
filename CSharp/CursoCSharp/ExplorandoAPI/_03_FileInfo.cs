using System;
using System.IO;

namespace CursoCSharp.ExplorandoAPI {
    class _03_FileInfo {

        public static void ExcluirSeExistir(params string[] caminhos) {
            foreach(var caminho in caminhos) {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists) {
                    arquivo.Delete();
                }
            }
        }
        public static void Executar() {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_Destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoCopia, caminhoDestino);
            //criando o arquivo de origem
            using(StreamWriter sw = File.CreateText(caminhoOrigem)) {
                sw.WriteLine("Arquivo Original");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);

            //informaçoes sobre o arquivo
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);

            //copiando o arquivo se ja existir gera um erro 
            origem.CopyTo(caminhoCopia);

            //mver
            origem.MoveTo(caminhoDestino);
        }
    }
}
