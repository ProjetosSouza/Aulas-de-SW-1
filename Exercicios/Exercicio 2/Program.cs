﻿﻿namespace exercicio_2;
class Program
{
    static void Main(string[] args)
    {

        Contrato_pessoa_juridica Contrato_pessoa_juridica = new Contrato_pessoa_juridica("contrato de pessoa jurídica","(11) 99999-9999","12.345.678/0001-00","juri007@gmail.com","André Silvestrini Silva", "123456789", "Nibri Móveis");
        Contrato_pessoa_juridica.exibir();

  Console.WriteLine("-------------------------------------------");

        Contrato_pessoa_fisica Contrato_pessoa_fisica = new Contrato_pessoa_fisica("contrato de pessoa física","123.456.789-00","(11) 00000-0000","fisc3902@gmail.com","Quenia Orellana",  19);
        Contrato_pessoa_fisica.exibir();
        Console.WriteLine();


    }
        
    
}