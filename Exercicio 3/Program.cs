﻿namespace exercicio3;
class Program
{
    static void Main(string[] args)
    {
        Juridico novo = new Juridico();
        novo.CalcularPrestacao(200,10);
        Console.WriteLine("cada prestacao vale:" + novo.Prestacao + "reais.");

        Fisico aaa = new Fisico();
        aaa.Idade = 2;  
        aaa.CalcularPrestacao(200,10);
        Console.WriteLine("cada prestacao vale:" + aaa.Prestacao + "reais");

    }
}