﻿﻿﻿namespace Terceiro;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica n1 = new ContratoPessoaFisica();
        ContratoPessoaJuridica n2 = new ContratoPessoaJuridica();

        n1.Email = "Brianzinho@gmail.com";
        n1.Nome = "Brian";
        n1.Telefone = "(11) 96682-1500";
        n1.cpf = "444.888.999-79";
        n1.Idade = 17;
        n1.Prazo = 10;


        n2.Email = "Cesarzinho@gmail.com";
        n2.Nome = "Cesar";
        n2.Telefone = "(11) 32099-9275";
        n2.cnpj = "13.589.678/0001-00";
        n2.ie = "142.270.790.110";
        n2.NomeEmpresa = "Nibri móveis";
        n2.Prazo = 10;
        

        Console.WriteLine("Os dados Pessoa Física são: " + n1.MostraDados());
        Console.WriteLine("Os dados Pessoa Jurídica são: " + n2.MostraDados());
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("O valor da prestação da Pessoa Física é de: " + n1.calcularPrestacao());
        Console.WriteLine("O valor da prestação da Pessoa Jurídica é de: " + n2.calcularPrestacao());
    }
}