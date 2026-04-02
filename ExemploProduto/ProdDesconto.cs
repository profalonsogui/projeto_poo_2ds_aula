namespace projeto_2DS.ExemploProduto
{
    public class ProdDesconto : Produto
    {
        public double Porcentagem { get; }
        public ProdDesconto(string nome, double preco, Marca fabricante, double porcentagem)
            : base(nome, preco, fabricante)
        {
            Porcentagem = porcentagem;
        }

        public void ExibirComDesconto()
        {
            double  valorFinal = Preco - (Preco * Porcentagem / 100);

            Console.WriteLine("[PROMOÇÃO EXTRA] {nome}");
            Console.WriteLine($"De R$ {Preco:f2} por apenas R$ R${valorFinal:f2}");
            Console.WriteLine($"Desconto aplicado: {Porcentagem}");
            Console.WriteLine("----------------------------------\n");
        }
    }
}