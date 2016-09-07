using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontosVendas
{
	class Program
	{
		static void Main(string[] args)
		{
			Produtos produto1 = new Produtos();
			produto1.nome = "Açucar";
			produto1.preco = 40;

			Produtos produto2 = new Produtos();
			produto2.nome = "Arroz";
			produto2.preco = 10;

			Produtos produto3 = new Produtos();
			produto3.nome = "Feijão";
			produto3.preco = 23;

			Produtos produto4 = new Produtos();
			produto4.nome = "Macarrão";
			produto4.preco = 26;

			Produtos produto5 = new Produtos();
			produto5.nome = "Biscoito";
			produto5.preco = 28;

			PDV pvd = new PDV();
			PDV pvd2 = new PDV();

			pvd.IniciarCompra();
            pvd.ComprarProduto(produto1);
			pvd.ComprarProduto(produto2);
			pvd.ComprarProduto(produto3);
			pvd.ComprarProduto(produto4);
			pvd.ComprarProduto(produto5);
			pvd.FinalizarCompra();

			pvd2.IniciarCompra();
			pvd2.ComprarProduto(produto5);
			pvd2.ComprarProduto(produto4);
			pvd2.ComprarProduto(produto3);
			pvd2.ComprarProduto(produto5);
			pvd2.ComprarProduto(produto5);
			pvd2.FinalizarCompra();
		}
	}
}
