namespace exercicio3;
class Fisico:Contrato
{
    public int Idade;
    public override double CalcularPrestacao(int valor, int prazo)
    {
        return base.CalcularPrestacao(valor, prazo)+1;
    }
}