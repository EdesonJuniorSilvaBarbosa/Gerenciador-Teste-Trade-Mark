using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gerenciador.DTO
{
    public class bancos_DTO
    {
        public int cod_banco { get; set; }
        public int cod_usuario { get; set; }
        public string nome_banco { get; set; }
        public decimal saldo { get; set; }
        public decimal total_saldo { get; set; }
        public decimal saldo_previsto { get; set; }
    }
}
