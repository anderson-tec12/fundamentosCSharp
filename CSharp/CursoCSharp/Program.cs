using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControles;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OrientacaoObjetos;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.ExplorandoAPI;
using CursoCSharp.Topicos_Avancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", _01_PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", _02_Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", _03_VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", _04_Inferencia.Executar},
                {"Interpolaçao - Fundamentos", _05_Interpolacao.Executar},
                {"Notação Ponto  - Fundamentos", _06_NotacaoPonto.Executar},
                {"Lendo Dados Do Console - Fundamentos", _07_LendoDadosDoConsole.Executar},
                {"Formatando Numeros - Fundamentos", _08_FormatandoNumero.Executar},
                {"Converções - Fundamentos", _09_Conversoes.Executar},
                {"Operadores Aritimeticos - Fundamentos", _10_OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", _11_OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", _12_OperadoresLogicos.Executar},
                {"Operadores de atribuição - Fundamentos", _13_OperadoresDeAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", _14_OperadoresUnarios.Executar},
                {"Operadores Ternario - Fundamentos", _15_OperadorTernario.Executar},
                //CAPITULO 2
                {"Estrura IF - Estrutura de Controlles", _01_EstruturaIf.Executar},
                {"Estrura IF ELSE - Estrutura de Controlles", _02_IFELSE.Executar},
                {"Estrura IF ELSE IF - Estrutura de Controlles", _03_IfELSEIF.Executar},
                {"Estrura SWITCH - Estrutura de Controlles", _04_SWITCH.Executar},
                {"Estrura WHILE - Estrutura de Controlles", _05_WHILE.Executar},
                {"Estrura DO WHILE - Estrutura de Controlles", _06_DOWHILE.Executar},
                {"Estrura FOR - Estrutura de Controlles", _07_FOR.Executar},
                {"Estrura FOREACH - Estrutura de Controlles", _08_FOREACH.Executar},
                {"Estrura BREAK - Estrutura de Controlles", _09_BREAK.Executar},
                {"Estrura CONTINUE - Estrutura de Controlles", _10_CONTINUE.Executar},

                //Capitulo 3
                {"Membros - Classes e Metodos", _01_MEMBROS.Executar },
                {"Constructor - Classes e Metodos", _02_Construtores.Executar },
                {"Metodos com retorno  - Classes e Metodos", _03_MetodosComRetornos.Executar },
                {"Metodos Estaticos  - Classes e Metodos", _04_MetodosEstaticos.Executar },
                {"Atributos Estaticos  - Classes e Metodos", _05_AtributoEstatico.Executar },
                {"Desafio  atributos - Classes e Metodos", _06_DesafioAcessarAtributo.Executar },
                {"Parmetros Variaveis - Classes e Metodos", _07_ParametrosVariaveis.Executar },
                {"Parmetros Nomeados - Classes e Metodos", _08_ParametrosNomeados.Executar },
                {"Getter & Setters - Classes e Metodos", _09_GettersSetters.Executar },
                {"Props - Classes e Metodos", _10_Props.Executar },
                {"Readonly - Classes e Metodos", _11_Readonly.Executar },
                {"Enumeraçoes - Classes e Metodos", _12_Enumeracoes.Executar },
                {"Struct - Classes e Metodos", _13_Struct.Executar },
                {"Class VS STRUCT - Classes e Metodos", _14_ClassXStruct.Executar },
                {"Valor VS Referencia - Classes e Metodos", _15_ValorVsReferencia.Executar },
                {"Parametros por referencia - Classes e Metodos", _16_ParametrosPorReferecia.Executar },
                {"Parametros por padrao - Classes e Metodos", _17_ParametrosPadrao.Executar },

                //Capitulo 4
                {"Arrays - Coleções ", _01_Arrays.Executar },
                {"List - Coleções ", _02_List.Executar },
                {"ArrayList - Coleções ", Colecoes._03_ArrayList.Executar },
                {"Set - Coleções ", Colecoes._04_Set.Executar },
                {"queue - Coleções ", Colecoes._05_Queue.Executar },
                {"Igualdade - Coleções ", Colecoes._06_Igualdade.Executar },
                {"Stack - Coleções ", Colecoes._07_Stack.Executar },
                {"Dictionary - Coleções ", Colecoes._08_Dictionary.Executar },

                //Capitulo 5
                {"Heranção - OO" , OrientacaoObjetos._01_Heranca.Executar },
                {"THIS construtor - OO" , OrientacaoObjetos._02_ConstrutorThis.Executar },
                {"Encapsulamento - OO" , OrientacaoObjetos._03_Encapsolamento.Executar },
                {"Polimorfirmo - OO" , OrientacaoObjetos._04_Polimorfirsmo.Executar },
                {"Classe Abstrada - OO" , OrientacaoObjetos._05_ClasseAbstrata.Executar },
                {"Interface - OO" , OrientacaoObjetos._06_Interface.Executar },
                {"Classes e Metodos Seleds - OO" , OrientacaoObjetos._07_ClassMetodoSeleds.Executar },

                //Capitulo 6
                {"Exemplo lambda - Metodos e Funçoes", MetodosEFuncoes._01_ExemploLambda.Executar },
                {"lambda com Delegate - Metodos e Funçoes", MetodosEFuncoes._02_DelegateComLambda.Executar},
                {"Usando Delegate - Metodos e Funçoes", MetodosEFuncoes._03_usaandoDelegate.Executar},
                {"Delegate com funçoes anonimas - Metodos e Funçoes", MetodosEFuncoes._04_FuncoesAnonimasDelegate.Executar},
                {"Delegate como parametro - Metodos e Funçoes", MetodosEFuncoes._05_DelegateComoParametro.Executar},
                {"Metodos de extensoes - Metodos e Funçoes", MetodosEFuncoes._06_MetodosDeExtensao.Executar},

                //Capitulo 7 
                { "Tratamentos de erros - Excecoes", Excecoes._01_ExecoesETratamentosDeErros.Executar},
                { "Tratamento personalizado - Excecoes", Excecoes._02_ExcesoesPersonalizadas.Executar},

                //Capitulo 8 
                { "Escrevendo dados - Explorando API", ExplorandoAPI._01_EscrevendoDados.Executar},
                { "Lendo dados - Explorando API", ExplorandoAPI._02_LendoDados.Executar},
                { "FileInfo - Explorando API", ExplorandoAPI._03_FileInfo.Executar},
                { "Trabalhando com diretorios - Explorando API", ExplorandoAPI._04_TrabalhandoComDiretorios.Executar},
                { "DirectoryInfo - Explorando API", ExplorandoAPI._05_DirectoriInfo.Executar},
                { "Usando PATH - Explorando API", ExplorandoAPI._06_UsandoPath.Executar},
                { "DateTime - Explorando API", ExplorandoAPI._07_DateTime.Executar},
                { "Timespan - Explorando API", ExplorandoAPI._08_Timespan.Executar},

                //Capitulo 9
                { "LINQ1 - Topicos avançados", Topicos_Avancados._01_LINQ.Executar},
                { "LINQ2 - Topicos avançados", Topicos_Avancados._02_LINQ2.Executar},
                { "NULLABLES - Topicos avançados", Topicos_Avancados._03_Nullables.Executar},
                { "Dynamic - Topicos avançados", Topicos_Avancados._04_Dynamic.Executar},
                { "Generic - Topicos avançados", Topicos_Avancados._05_Generic.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}