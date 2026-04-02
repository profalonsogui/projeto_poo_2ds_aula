using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_2DS.ExemploProduto
{
    public class Marca
    {
        // get => responsável por retornar um valor
        // set => responsável por atribuir um valor
        public string Nome { get; }
        public double DescontoFornecido { get; } //e.: 0.10 = 10%

        public Marca(string nome, double descontoFornecido) 
        {
            Nome = nome;
            DescontoFornecido = descontoFornecido;
        }

    }
}
