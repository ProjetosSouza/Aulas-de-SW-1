namespace exercicio3;
class Juridico:Contrato
{

    public override double CalcularPrestacao(int valor , int prazo)
    {
        return base.CalcularPrestacao(valor, prazo)+3;
    }
}