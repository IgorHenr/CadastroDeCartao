using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeCartao.Models
{
    public class Pessoa { 
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string NumeroDeCelular { get; set; }

    }
}
