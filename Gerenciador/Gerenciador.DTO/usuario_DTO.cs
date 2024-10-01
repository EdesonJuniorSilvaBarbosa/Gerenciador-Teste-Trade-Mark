using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gerenciador.DTO
{
    public class usuario_DTO
    {
        /*Nesta classe DTO temos os atributos dos objetos public
         para que ele seja acessível externamente. propriedade 
         GET e SET para acessar o conteúdo.*/
        public int cod_usuario { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string cpf { get; set; }
        public DateTime data_nasc { get; set; }
        public char sexo { get; set; }
        public string anos { get; set; }
    }
}
