using CadastroDeCartao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeCartao.Services
{

    public class CartaoDeCreditoService {
        public static CartaoDeCredito GerarCartaoCredito(Pessoa pessoa)
        {
            // Lógica para gerar os dados do cartão de crédito
            CartaoDeCredito cartao = new CartaoDeCredito
            {
                Numero = GerarNumeroCartao(),
                Validade = DateTime.Now.AddYears(5), 
                CodigoDeSeguranca = GerarCodigoSeguranca(),
                NomeTitular = pessoa.Nome
            };
                return cartao;
        }

        private static string GerarNumeroCartao() {
           Random random = new Random();
            string numeroCartao = "";
                for (int i = 0; i < 16; i++) {
                    numeroCartao += random.Next(0, 10).ToString();
            }
            return numeroCartao;
        }
        private static string GerarCodigoSeguranca(){
            Random random = new Random();
                return random.Next(100,1000).ToString();
        }
    }
}
