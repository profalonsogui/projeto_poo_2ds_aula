class Pessoa
{
    /*atributos*/
    public string? Nome;
    public int idade;

    //métodos
    public void Apresentar()
    {
        Console.WriteLine($"Meu nome é {Nome} e minha é {idade} anos");
    }
}