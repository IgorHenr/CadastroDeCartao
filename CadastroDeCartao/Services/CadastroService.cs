using CadastroDeCartao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeCartao.Services
{
    public class CadastroService { 

        private static List<Pessoa> ListaDePessoas = new List<Pessoa>();
        private static int ProximoId = 1;

        public static void CadastrarPessoas(string nome, int idade,string cpf, DateTime dataDeNascimento, string email) {
            Pessoa pessoa = new Pessoa
            {
                Id = ProximoId++,
                Nome = nome,
                Idade = idade,
                Cpf = cpf,
                DataDeNascimento = dataDeNascimento,
                Email = email
            };
                ListaDePessoas.Add(pessoa);
        }
        public static List<Pessoa> ObterTodasPessoas() { 
            return ListaDePessoas;
        }
    }
}
