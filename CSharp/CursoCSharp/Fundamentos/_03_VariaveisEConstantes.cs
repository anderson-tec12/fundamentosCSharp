using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class _03_VariaveisEConstantes {
        public static void Executar() {
            //Area d circuferencia
            double raio = 4.5;
            const double PI = 3.4;

            raio = 5.5;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é "+ area ); // + é para concatenar 
            Console.WriteLine("Área é "+ area + 1000); // vai concatenar os 3 valores por que tem uma string
            Console.WriteLine("Área é "+ (area + 1000)); // caso seja nescessario fazer uma soma e uma concatenização

            //tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo " + estaChovendo);

            // é um intero o que muda é a capacidade de armazenamento 
            byte idade = 26;          

            sbyte saldoDeGolds = sbyte.MinValue;
            
            //inteiros
            Console.WriteLine("Idade " + idade);
            Console.WriteLine("Idade maxima " + byte.MaxValue);
            Console.WriteLine("Idade minima " + byte.MinValue);
            Console.WriteLine("sbyte maximo " + sbyte.MaxValue);
            Console.WriteLine("sbyte minimo " + sbyte.MinValue);
            Console.WriteLine("short minimo " + short.MinValue);
            Console.WriteLine("short maximo " + short.MaxValue);
            Console.WriteLine("int minimo " + int.MinValue);
            Console.WriteLine("int maximo " + int.MaxValue);
            Console.WriteLine("uint minimo " + uint.MinValue);
            Console.WriteLine("uint maximo " + uint.MaxValue);
            Console.WriteLine("long minimo " + long.MinValue);
            Console.WriteLine("long maximo " + long.MaxValue);
            Console.WriteLine("ulong minimo " + ulong.MinValue);
            Console.WriteLine("ulong maximo " + ulong.MaxValue);

            //fim dos iteiros

            //flutuantes "Reais"
            float precoComputador = 1299.99f;
            Console.WriteLine("preço do ocmputador " + precoComputador);


            double valorDeMercadoDaApple = 1000000000.00; // mais usados dos REAIS
            Console.WriteLine("Valor da APPLE", valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia das estrelas" + distanciaEntreEstrelas);

            char letra = 'a';
            Console.WriteLine("Letras " + letra);

            string texto = "Seja bem vindo ao C#";
            Console.WriteLine("Tipo de string" + texto );
            //Fim dos  reais
        }
    }
}
