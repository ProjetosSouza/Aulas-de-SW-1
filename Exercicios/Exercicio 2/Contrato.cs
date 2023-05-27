public class Contrato
{
   

    protected string detalhes;
    protected string email;
    protected string telefone;
    protected string nome;

    public Contrato(string detalhes, string email, string telefone, string nome)
    {
      this.detalhes = detalhes;
      this.email = email;
      this.telefone = telefone;
      this.nome = nome;
    

    }
  

    public virtual void exibir()
    {
        Console.WriteLine("Nome : " + nome);
        Console.WriteLine("Detalhes : " + detalhes);
        Console.WriteLine("Email : " + email);
        Console.WriteLine("Telefone : " + telefone);
       
    }
}