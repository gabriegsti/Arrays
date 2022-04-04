using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Model
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[5];
            _proximaPosicao = 0;
        }

        public void MeuMetodo(string texto = "texto padrão", int numero = 5)
        {
           
        }

        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proximaPosicao+1);
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao} ");
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;
            for (int i =0; i < _proximaPosicao; i++)
            {
                if (_itens[i].Equals(item))
                {

                }
            }
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length>+tamanhoNecessario)
            {
                return;
            }
            int novoTamanho = _itens.Length*2 ;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }
            Console.WriteLine($"Aumentando a capacidade da lista !!");

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            for (int indice = 0; indice< _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
            }

            _itens = novoArray;
        }

    }
}
