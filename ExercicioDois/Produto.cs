using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioDois
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtd;

        public Produto(string nome, double preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        public double ValorTotalEstoque()
        {
            return Preco * Qtd; 
        }

        public void AddProduto(int qtd)
        {
            Qtd += qtd;
        }

        public void RemoverProduto(int qtd)
        {
            Qtd -= qtd;
        }

        public override string ToString()
        {
            return Nome + 
                ", R$" + 
                Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " +
                Qtd +
                " unidade(s), Total: R$" +
                ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
