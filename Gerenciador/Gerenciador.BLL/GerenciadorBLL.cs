using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerenciador.DTO;
using Gerenciador.DAL;
using System.Diagnostics;
using System.Data;

namespace Gerenciador.BLL
{
    public class GerenciadorBLL
    {
        public IList<contas_DTO> ConsultarContasPorNome(string nomeConta, DateTime dataPesquisada)
        {
            try
            {
                int codUsuarioAutenticado = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;

                GerenciadorDAL dal = new GerenciadorDAL();

                IList<contas_DTO> contasConsultadas = dal.ConsultarContasPorNome(codUsuarioAutenticado, nomeConta, dataPesquisada);

                foreach (contas_DTO conta in contasConsultadas)
                {
                }
                return contasConsultadas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList<contas_DTO> ContasPendentes(DateTime dataInicial, DateTime dataFinal, string nomeConta, out decimal pendenteEntradas, out decimal pendenteSaidas, out decimal recebidos, out decimal pagos, out decimal previstoEntradas, out decimal previstoSaidas)
        {
            try
            {
                int codUsuarioAutenticado = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;

                GerenciadorDAL dal = new GerenciadorDAL();

                IList<contas_DTO> contasConsultadas = dal.ContasPendentes(codUsuarioAutenticado, dataInicial, dataFinal, nomeConta, out pendenteEntradas, out pendenteSaidas, out recebidos, out pagos, out previstoEntradas, out previstoSaidas);

                return contasConsultadas;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao processar a solicitação.", ex);
            }
        }
        public IList<string> ObterContasEPreencherComboBox(int codUsuario, DateTime dataInicial, DateTime dataFinal)
        {
            GerenciadorDAL gerenciadorDAL = new GerenciadorDAL();
            return gerenciadorDAL.ObterContasEPreencherComboBox(codUsuario, dataInicial, dataFinal);
        }
        public IList<contas_DTO> ConsultarContasProximasDoVencimento()
        {
            try
            {
                int codUsuarioAutenticado = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;

                GerenciadorDAL dal = new GerenciadorDAL();

                IList<contas_DTO> contasConsultadas = dal.ConsultarContasProximasDoVencimento(codUsuarioAutenticado);

                foreach (contas_DTO conta in contasConsultadas)
                {
                }
                return contasConsultadas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList<usuario_DTO> ConsultarUsuarios()
        {
            try
            {
                int codUsuarioAutenticado = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;

                GerenciadorDAL dal = new GerenciadorDAL();

                IList<usuario_DTO> usuarioConsultado = dal.ConsultarUsuarios(codUsuarioAutenticado);

                foreach (usuario_DTO conta in usuarioConsultado)
                {
                }
                return usuarioConsultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insereConta(contas_DTO CONT)
        {
            try
            {
                return GerenciadorDAL.insereConta(CONT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int alteraConta(contas_DTO CONT, int codUsuarioAutenticado)
        {
            try
            {
                return new GerenciadorDAL().alteraConta(CONT, codUsuarioAutenticado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int excluiConta(contas_DTO CONT, int codUsuarioAutenticado)
        {
            try
            {
                return new GerenciadorDAL().excluiConta(CONT, codUsuarioAutenticado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insereUsuario(usuario_DTO USU)
        {
            try
            {
                return new GerenciadorDAL().insereUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int alteraUsuario(usuario_DTO USU)
        {
            try
            {
                return new GerenciadorDAL().alteraUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insereLogin(login_DTO LOG)
        {
            try
            {
                return new GerenciadorDAL().insereLogin(LOG);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool alteraLogin(login_DTO LOG, string email, string novaSenha)
        {
            try
            {
                // Valida se o email e a senha são válidos(opcional)
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(novaSenha))
                {
                    throw new ArgumentException("E-mail e senha não podem ser vazios.");
                }

                // valida se a senha atende aos critérios de segurança (opcional)
                if (novaSenha.Length < 8)
                {
                    throw new ArgumentException("A senha deve ter pelo menos 8 carateres.");
                }

                // Chamar o método na camada BLL para realizar a atualização
                bool emailExists = new GerenciadorDAL().alteraLogin(LOG, email, novaSenha);

                if (!emailExists)
                {
                    throw new InvalidOperationException("O e-mail não está cadastrado na base de dados");
                }

                // Chamar o método na camada DAL para realizar a atualização
                bool rowsAffected = new GerenciadorDAL().alteraLogin(LOG, email, novaSenha);

                return rowsAffected;

            }catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList<contas_DTO> ObterDadosParaGraficoAnual(int mesSelecionado, int anoSelecionado)
        {
            try
            {
                int codUsuarioAutenticado = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;

                GerenciadorDAL dal = new GerenciadorDAL();

                IList<contas_DTO> contasConsultadas = dal.ObterDadosParaGraficoAnual(codUsuarioAutenticado, mesSelecionado, anoSelecionado);

                foreach (contas_DTO conta in contasConsultadas)
                {
                }
                return contasConsultadas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GerarBackupContas(int codUsuarioAutenticado, string filePath)
        {
            try
            {
                GerenciadorDAL.GerarBackupContas(codUsuarioAutenticado, filePath);
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insereBanco(bancos_DTO BAN)
        {
            try
            {
                return GerenciadorDAL.insereBanco(BAN);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList<bancos_DTO> cargaBanco()
        {
            try
            {
                int codUsuarioAutenticado = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;

                return GerenciadorDAL.cargaBanco(codUsuarioAutenticado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int alteraBanco(bancos_DTO BAN)
        {
            try
            {
                return new GerenciadorDAL().alteraBanco(BAN);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int excluiBanco(bancos_DTO BAN)
        {
            try
            {
                return new GerenciadorDAL().excluiBanco(BAN);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
