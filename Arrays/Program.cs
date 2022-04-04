using Arrays.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TestaArrayObject();
            Console.ReadLine(); 

            TestaOpcional(arg1: "arg1");
            TestaOpcional(arg2: "arg2");
            TestaOpcional();

            Console.ReadLine();

            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.MeuMetodo(numero: 10);

            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679754));
            lista.Adicionar(new ContaCorrente(874, 5679445));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679754));
            lista.Adicionar(new ContaCorrente(874, 5679445));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679754));
            lista.Adicionar(new ContaCorrente(874, 5679445));

            Console.ReadLine();

        }

        static void TestaArrayObject()
        {
            Cliente cli1 = new Cliente();
            cli1.Nome = "Tainá";

            Cliente cli2 = new Cliente();
            cli2.Nome = "Carlos";

            object[] referencias = new object[5];

            referencias[0] = cli1;
            referencias[1] = cli2;

            Console.WriteLine(referencias[1].Nome);
            
        }
        static void TestaOpcional()
        {
            Console.WriteLine("Executando método sem argumentos");
        }

        static void TestaOpcional(string arg1 = "opcional 1", string arg2 = "opcional 2")
        {
            Console.WriteLine($"{arg1} {arg2}");
        }
        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 4456668),
                new ContaCorrente(874, 7781438)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }


        static void TestaArrayInt()
        {
            //Array de inteiros, com 5 posições

            int[] idades = new int[3];
            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;


            Console.WriteLine(idades.Length);


            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");
                acumulador += idade;
                Console.WriteLine($"Acumulador: {acumulador}");
            }

            double media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");

        }
    }
}
