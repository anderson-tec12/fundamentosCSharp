using System;
using System.IO; //precisa dele pra escrever arquivos

namespace CursoCSharp.ExplorandoAPI {

    public static class ExtesaoString{
        public static string ParseHome(this string  path) {
            //pegando a variavel de ambiente para descobri o caminho da pasta do usuario 
            string home = (
                    Environment.OSVersion.Platform == PlatformID.Unix ||
                    Environment.OSVersion.Platform == PlatformID.MacOSX
                ) ? Environment.GetEnvironmentVariable("home")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }

    class _01_EscrevendoDados {
        public static void Executar() {
            //@ nao interpreta os caracteres especiais como /n e /t
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            //criando o arquivo
            if (!File.Exists(path)){
                //Criando o arquivo caso nao exista
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("oprimeiro arquivo");
                }
            }

            // adicionando texto num arquivo ja existente
            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("Obaaaa");
                sw.WriteLine("add");
            }
        }
    }
}
