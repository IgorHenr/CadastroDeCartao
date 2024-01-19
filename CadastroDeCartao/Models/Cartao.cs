using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeCartao.Models
{
    public class CartaoDeCredito { 
        public string Numero { get; set; } 
        public DateTime Validade { get; set; }
        public string CodigoDeSeguranca { get; set; }
        public string NomeTitular { get; set; }
    }
}
