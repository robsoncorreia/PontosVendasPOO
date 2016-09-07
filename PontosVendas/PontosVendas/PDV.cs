using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontosVendas
{
    class PDV
    {
        public short numProdutos;
        public float valorProdutos;
        public float valorMaisCaro;
        public float valorMaisBarato;

        public void ComprarProduto(Produtos produto)
        {
            Console.WriteLine("Resgistrando a compra do produto: \n{0} Valor: {1:C}", produto.nome, produto.preco);

            numProdutos++;

            if (produto.preco > valorMaisCaro)
            {
                valorMaisCaro = produto.preco;
            }
            if (produto.preco < valorMaisBarato || valorMaisBarato == 0)
            {
                valorMaisBarato = produto.preco;
            }

            valorProdutos += produto.preco;
        }
        
        public void IniciarCompra()
        {
            DateTime tempo = DateTime.Now;
            Console.WriteLine("Iniciando o registro de compra no PDV em {0}", tempo);
            ZerarValores();
        }

        public void ZerarValores()
        {
            numProdutos = 0;
            valorProdutos = 0;
            valorMaisCaro = 0;
            valorMaisBarato = 0;
        }

        public void FinalizarCompra()
        {
            DateTime tempo = DateTime.Now;
            Console.WriteLine("Compra finalizar em: {0}\nQuantidade de itens comprados: {1}\nValor pago: {2:C}\nPreço do produto mais caro: {3:C} \nPreço do produto mais barato: {4:C}\n", tempo, numProdutos, valorProdutos, valorMaisCaro, valorMaisBarato);
        }
    }
}
