using System;
using System.Collections.Generic;
using CourseCSharp;
using CourseCSharp.Fundamentos;
using CourseCSharp.EstruturasDeControle;
using CourseCSharp.ClassesEMetodos;
using CourseCSharp.Colecoes;
using CourseCSharp.OrientacaoObjetos;
using CourseCSharp.MetodosFuncoes;
using CourseCSharp.Excecoes;
using CourseCSharp.Api;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                // Fundamentos
                {
                    "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar
                },
                {
                    "Comentários - Fundamentos", Comentarios.Executar
                },
                {
                    "Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar
                },
                {
                    "Inferência - Fundamentos", Inferencia.Executar
                },
                {
                    "Interpolação - Fundamentos", Interpolacao.Executar
                },
                {
                    "Notação Ponto - Fundamentos", NotacaoPonto.Executar
                },
                {
                    "Lendo Dados - Fundamentos", LendoDados.Executar
                },
                {
                    "Formatando Número - Fundamentos", FormatandoNumero.Executar
                },
                {
                    "Conversões - Fundamentos", Conversoes.Executar
                },
                {
                    "Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar
                },
                {
                    "Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar
                },
                {
                    "Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar
                },
                {
                    "Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar
                },
                {
                    "Operadores Unários - Fundamentos", OperadoresUnarios.Executar
                },
                {
                    "Operador Ternário - Fundamentos", OperadorTernario.Executar
                },

                // Estruturas de Controle
                {
                    "Estrutura If - Estruturas de Controle", EstruturaIf.Executar
                },
                {
                    "Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar
                },
                {
                    "Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar
                },
                {
                    "Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar
                },
                {
                    "Estrutura While - Estruturas de Controle", EstruturaWhile.Executar
                },
                {
                    "Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar
                },
                {
                    "Estrutura For - Estruturas de Controle", EstruturaFor.Executar
                },
                {
                    "Estrutura Foreach - Estruturas de Controle", EstruturaForEach.Executar
                },
                {
                    "Usando Break - Estruturas de Controle", UsandoBreak.Executar
                },
                {
                    "Usando Continue - Estruturas de Controle", UsandoContinue.Executar
                },

                // Classes & Métodos
                {
                    "Membros - Classes e Métodos", Membros.Executar
                },
                {
                    "Construtores - Classes e Métodos", Construtores.Executar
                },
                {
                    "Metodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar
                },
                {
                    "Metodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar
                },
                {
                    "Atributos Estáticos - Classes e Métodos", AtritubosEstaticos.Executar
                },
                {
                    "Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar
                },
                {
                    "Params - Classes e Métodos", Params.Executar
                },
                {
                    "Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar
                },
                {
                    "Getters & Setters - Classes e Métodos", GetSet.Executar
                },
                {
                    "Props - Classes e Métodos", Props.Executar
                },
                {
                    "Readonly - Classes e Métodos", Readonly.Executar
                },
                {
                    "Enum - Classes e Métodos", ExemploEnum.Executar
                },
                {
                    "Struct - Classes e Métodos", ExemploStruct.Executar
                },
                {
                    "Struct vs Classe - Classes e Métodos", StructVsClasse.Executar
                },
                {
                    "Valor vs Referência - Classes e Métodos", ValorVsReferencia.Executar
                },
                {
                    "Parâmetro por Referência - Classes e Métodos", ParametrosPorReferencia.Executar
                },
                {
                    "Parâmetro com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar
                },

                // Coleções
                {
                    "Array - Coleções", UsandoArray.Executar
                },
                {
                    "List - Coleções", UsandoList.Executar
                },
                {
                    "Array List - Coleções", UsandoArrayList.Executar
                },
                {
                    "Set - Coleções", UsandoSet.Executar
                },
                {
                    "Queue - Coleções", UsandoQueue.Executar
                },
                {
                    "Igualdade - Coleções", Igualdade.Executar
                },
                {
                    "Stack - Coleções", UsandoStack.Executar
                },
                {
                    "Dictionary - Coleções", UsandoDictionary.Executar
                },

                // Orientação a Objetos
                {
                    "Herança - Orientação a Objetos", Heranca.Executar
                },
                {
                    "Construtor Usando o This - Orientação a Objetos", ConstrutorThis.Executar
                },
                {
                    "Encapsulamento - Orientação a Objetos", UsandoEncapsulamento.Executar
                },
                {
                    "Polimorfismo - Orientação a Objetos", UsandoPolimorfismo.Executar
                },
                {
                    "Classe Abstrata - Orientação a Objetos", ClasseAbstrata.Executar
                },
                {
                    "Interface - Orientação a Objetos", UsandoInterface.Executar
                },
                {
                    "Classe e Método Sealed - Orientação a Objetos", ClasseSealed.Executar
                },

                // Métodos & Funções
                {
                    "Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar
                },
                {
                    "Delegate com Lambda - Métodos e Funções", DelegateLambda.Executar
                },
                {
                    "Usando Delegates - Métodos e Funções", UsandoDelegates.Executar
                },
                {
                    "Delegate com Funções Anônimas - Métodos e Funções", DelegateFuncaoAnonima.Executar
                },
                {
                    "Passando Delegate como Parâmetro - Métodos e Funções", DelegateParametro.Executar
                },
                {
                    "Métodos de Extensão - Métodos e Funções", MetodosExtensao.Executar
                },

                // Exceções
                {
                    "Exceções e Tratamento de Erro - Exceções", ExcecoesTratamentoErro.Executar
                },
                {
                    "Criando Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar
                },

                 // Usando API
                {
                    "Primeiro Arquivo - Usando Api", PrimeiroArquivo.Executar
                },
                {
                    "Lendo Arquivos - Usando Api", LendoArquivos.Executar
                },
                {
                    "Usando FileInfo - Usando Api", UsandoFileInfo.Executar
                },
                {
                    "Trabalhando com Diretórios - Usando Api", TrabalhandoDiretorios.Executar
                },
                {
                    "Usando DirectoryInfo - Usando Api", UsandoDirectoryInfo.Executar
                },
                {
                    "Usando Path - Usando Api", UsandoPath.Executar
                },
                {
                    "Usando DateTime - Usando Api", UsandoDateTime.Executar
                },
                {
                    "Usando TimeSpan - Usando Api", UsandoTimeSpan.Executar
                },
            });

            central.SelecionarEExecutar();
        }
    }
}
