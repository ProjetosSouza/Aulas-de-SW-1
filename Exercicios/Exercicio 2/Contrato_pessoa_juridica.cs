﻿public class Contrato_pessoa_juridica:Contrato
{

    private string inscricao_estadual;
    private string cnpj;
    private string empresa;

    public Contrato_pessoa_juridica(string detalhes,string email, string telefone,string nome, string cnpj, string inscricao_estadual, string empresa)
        : base(detalhes, email, telefone, nome)
        
    {
        this.inscricao_estadual = inscricao_estadual;
        this.cnpj = cnpj;
        this.empresa = empresa;
        
      



    }

    public override void exibir()
    {
        base.exibir();
        Console.WriteLine("Inscrição Estadual : " + inscricao_estadual);
        Console.WriteLine("CNPJ : " + cnpj);
        Console.WriteLine("Nome da empresa : " + empresa);
        



    }
}