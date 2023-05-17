namespace exercicio3;
class Contrato
{

    public int Prestacao;
    public virtual double CalcularPrestacao(int valor, int prazo){
        Prestacao = valor/prazo;
        return Prestacao;

    }
}