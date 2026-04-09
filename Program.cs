using projeto_2DS.ExemploProduto;
public class Program
{
    public static void Main(string[] args)
    {
        // criando uma list de catalogo de Marcas
        List<Marca> catalogoMarcas = new List<Marca>
        {
            new Marca("Geral", 0.0),
            new Marca("Sansung", 0.05),
            new Marca("Apple", 0.02),
            new Marca("Xiaomi", 0.15),
            new Marca("Motorola", 0.10)
        };

        System.Console.WriteLine("Digite o nome do produto");
        string nomeProd = Console.ReadLine()!;

        System.Console.WriteLine("Digite o preço base:");
        double precoProd = double.Parse(Console.ReadLine()!);

        System.Console.WriteLine("\n Escolha a marca pelo número");
        for (int i = 0; i < catalogoMarcas.Count(); i++)
        {
            System.Console.WriteLine($"{i} - {catalogoMarcas[i].Nome}");
        }

        int opcao = int.Parse(Console.ReadLine()!);

        Marca marcaEscolhida = catalogoMarcas[opcao];
        Produto novoProduto = new Produto(nomeProd, precoProd, marcaEscolhida);

        Console.Clear();
        novoProduto.ExibirCupom();
    }
}