namespace projeto_2DS.ExemploProduto
{
    public class Produto
    {
        public string Nome { get; }
        public double Preco { get; }
        public Marca Fabricante { get; }

        public Produto(string nome, double preco, Marca fabricante)
        {
            Nome = nome;
            Preco = preco;
            Fabricante = fabricante;
        }

        public double CalcularPrecoFinal()
        {
            return Preco - (Preco * Fabricante.DescontoFornecido);
        }

        public void ExibirCupom()
        {
            Console.WriteLine("===== Cupom Fiscal =====");
            Console.WriteLine($"Item: {Nome} | Marca: {Fabricante.Nome}");
            Console.WriteLine($"Preço Original: R${Preco:f2}");
            Console.WriteLine($"Desconto: {Fabricante.DescontoFornecido:P}");
            Console.WriteLine($"TOTAL A PAGAR: R${CalcularPrecoFinal():f2}");
        }
    }
}