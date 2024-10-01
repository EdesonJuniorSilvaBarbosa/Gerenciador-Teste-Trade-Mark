using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gerenciador.DTO
{
    public class contas_DTO
    {
        /*Nesta classe DTO temos os atributos dos objetos public
         para que ele seja acessível externamente. propriedade 
         GET e SET para acessar o conteúdo.*/
        public int cod_conta { get; set; }
        public int cod_usuario { get;  set; }
        public string tipo { get; set; }
        public DateTime data_cont { get; set; }
        public string dataFormatada { get; set; } // formata a data no ListBox
        public string valorFormatado { get; set; } // formata o valor no ListBox
        public decimal valor { get; set; }
        public string descricao { get; set; }
        public string status_cont { get; set; }
        public decimal total_entradas { get; set; }
        public decimal total_saidas { get; set; }
        public decimal saldo { get; set; }

    }
}
