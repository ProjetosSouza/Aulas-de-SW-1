namespace exercicio1;
class Program
{
    static void Main(string[] args)
    {
    Homem Cleber = new Homem();
    Cao Thor = new Cao();
    Gato Floquinho = new Gato();

    Console.WriteLine(Cleber.Fala());
    Console.WriteLine(Thor.Fala());
    Console.WriteLine(Floquinho.Fala());
    }   
        
}