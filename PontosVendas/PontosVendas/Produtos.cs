using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontosVendas
{
    class Produtos
    {
        public string nome;
        public float preco;

        public void Exibir()
        {
            Console.WriteLine("Nome produto {0} \nValor {1}", this.nome, this.preco);
        }
    }
}
