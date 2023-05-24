public class Contrato_pessoa_fisica:Contrato
{
    public string cpf;
    public int idade;

    public Contrato_pessoa_fisica(string detalhes,string email, string telefone, string nome, string cpf, int idade)
        : base(detalhes, email, telefone, nome)
    {
        this.cpf = cpf;
        this.idade = idade;
    }

    public override void exibir()
    {
        base.exibir();
        Console.WriteLine("CPF : " + cpf);
        Console.WriteLine("Idade : " + idade);
    }
}