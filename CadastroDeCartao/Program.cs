using System;
using CadastroDeCartao.Models;
using CadastroDeCartao.Services;

class Program { 
    public static void Main(string[] args) {
        CadastroService.CadastrarPessoas("Yuri Martins", 21, "205.457.663-65", new DateTime(2003, 07, 26), "YuriMartins@test.com");

        List<Pessoa> todasPessoas = CadastroService.ObterTodasPessoas();

        foreach (var pessoa in todasPessoas) {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Id: {pessoa.Id}");
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine($"Data de nascimento: {pessoa.DataDeNascimento}");
            Console.WriteLine($"Cpf: {pessoa.Cpf}");
            Console.WriteLine($"Email: {pessoa.Email}");
            Console.WriteLine("-------------------------------------");
            CartaoDeCredito cartao = CartaoDeCreditoService.GerarCartaoCredito(pessoa);
            Console.WriteLine("\n Dados do cartão de crédito");
            Console.WriteLine($"Titular: {cartao.NomeTitular}");
            Console.WriteLine($"Número do cartão: {cartao.Numero}");
            Console.WriteLine($"Código de segurança: {cartao.CodigoDeSeguranca}");
            Console.WriteLine($"Validade: {cartao.Validade}");
            Console.WriteLine("-------------------------------------");
        }
    }
}