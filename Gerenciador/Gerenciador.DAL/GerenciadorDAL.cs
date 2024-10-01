using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerenciador.DTO;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.Globalization;
using System.IO;
using OfficeOpenXml;

namespace Gerenciador.DAL
{
    public class GerenciadorDAL
    {
        public usuario_DTO ObterUsuarioNome(int codUsuario)
        {
            try
            {
                using (SqlConnection CON = new SqlConnection(Properties.Settings.Default.CST))
                {
                    CON.Open();
                    using (SqlCommand CM = new SqlCommand("SELECT nome, sobrenome FROM tb_usuarios WHERE cod_usuario = @cod_usuario", CON))
                    {
                        CM.Parameters.AddWithValue("@cod_usuario", codUsuario);
                        using (SqlDataReader ER = CM.ExecuteReader())
                        {
                            if (ER.Read())
                            {
                                usuario_DTO usuario = new usuario_DTO();
                                usuario.nome = ER["nome"].ToString();
                                usuario.sobrenome = ER["sobrenome"].ToString();
                                return usuario;
                            }
                        }
                    }
                }
                // Se não encontrar o usuário, retornar null ou lançar uma exceção, conforme sua necessidade
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList<contas_DTO> ConsultarContasPorNome(int codUsuarioAutenticado, string nomeConta, DateTime dataPesquisada)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.CST))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT cod_conta, cod_usuario, tipo, data_cont, valor, descricao, " +
                                                            "CASE " +
                                                                "WHEN data_cont < GETDATE() AND tipo = 'Entrada' THEN 'Recebido' " +
                                                                "WHEN data_cont >= GETDATE() AND tipo = 'Entrada' THEN 'Receberá ' + " +
                                                                    "CASE " +
                                                                        "WHEN DATEDIFF(DAY, GETDATE(), data_cont) = 1 THEN 'amanhã' " +
                                                                        "ELSE 'em ' + CAST(DATEDIFF(DAY, GETDATE(), data_cont) AS VARCHAR(10)) + ' dias' " +
                                                                    "END " +
                                                                "WHEN data_cont < GETDATE() AND tipo = 'Saida' THEN 'Pago' " +
                                                                "WHEN data_cont >= GETDATE() AND tipo = 'Saida' THEN 'Vencerá ' + " +
                                                                    "CASE " +
                                                                        "WHEN DATEDIFF(DAY, GETDATE(), data_cont) = 1 THEN 'amanhã' " +
                                                                        "ELSE 'em ' + CAST(DATEDIFF(DAY, GETDATE(), data_cont) AS VARCHAR(10)) + ' dias' " +
                                                                    "END " +
                                                                "ELSE 'Outro Status' " +
                                                            "END AS status_cont " +
                                                        "FROM tb_contas " +
                                                        "WHERE cod_usuario = @cod_usuario AND (descricao LIKE @descricao AND data_cont = @data_cont)", connection);


                    AdicionarParametros(command, codUsuarioAutenticado, nomeConta, dataPesquisada);

                    SqlDataReader reader = command.ExecuteReader();

                    IList<contas_DTO> resultadoConsulta = new List<contas_DTO>();

                    while (reader.Read())
                    {
                        //Debug.WriteLine($"cod_conta: {reader["cod_conta"]}, cod_usuario: {reader["cod_usuario"]}, tipo: {reader["tipo"]}, data_cont: {reader["data_cont"]}, valor: {reader["valor"]}, descricao: {reader["descricao"]}, status_cont: {reader["status_cont"]}");

                        contas_DTO conta = new contas_DTO
                        {
                            cod_conta = Convert.ToInt32(reader["cod_conta"]),
                            cod_usuario = Convert.ToInt32(reader["cod_usuario"]),
                            tipo = Convert.ToString(reader["tipo"]),
                            data_cont = Convert.ToDateTime(reader["data_cont"]),
                            valor = Convert.ToDecimal(reader["valor"]),
                            descricao = Convert.ToString(reader["descricao"]),
                            status_cont = Convert.ToString(reader["status_cont"]),
                        };

                        resultadoConsulta.Add(conta);
                    }

                    reader.Close();

                    return resultadoConsulta;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        void AdicionarParametros(SqlCommand command, int codUsuarioAutenticado, string nomeConta, DateTime dataPesquisada)
        {
            command.Parameters.AddWithValue("@cod_usuario", codUsuarioAutenticado);
            command.Parameters.AddWithValue("@descricao", "%" + nomeConta + "%");
            command.Parameters.AddWithValue("@data_cont", dataPesquisada.ToString("dd/MM/yyyy"));
        }
        public IList<contas_DTO> ConsultarContasProximasDoVencimento(int codUsuarioAutenticado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.CST))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT data_cont, valor, descricao, " +
                                        "CASE " +
                                            "WHEN data_cont >= GETDATE() AND tipo = 'Entrada' THEN 'Receberá ' + " +
                                            "CASE " +
                                                "WHEN DATEDIFF(DAY, GETDATE(), data_cont) = 1 THEN 'amanhã' " +
                                                "ELSE 'em ' + CAST(DATEDIFF(DAY, GETDATE(), data_cont) AS VARCHAR(10)) + ' dias' " +
                                            "END " +
                                            "WHEN data_cont >= GETDATE() AND tipo = 'Saida' THEN 'Vencerá ' + " +
                                            "CASE " +
                                                "WHEN DATEDIFF(DAY, GETDATE(), data_cont) = 1 THEN 'amanhã' " +
                                                "ELSE 'em ' + CAST(DATEDIFF(DAY, GETDATE(), data_cont) AS VARCHAR(10)) + ' dias' " +
                                            "END " +
                                          "ELSE 'Outro Status' " +
                                        "END AS status_cont " +
                                    "FROM tb_contas " +
                                        "WHERE cod_usuario = @cod_usuario " +
                                        "AND data_cont BETWEEN DATEADD(DAY, 0, GETDATE()) AND DATEADD(DAY, 5, GETDATE())", connection);

                    //AdicionarParametros(command, codUsuarioAutenticado);
                    command.Parameters.Add("cod_usuario", System.Data.SqlDbType.Int).Value = codUsuarioAutenticado;

                    SqlDataReader reader = command.ExecuteReader();

                    IList<contas_DTO> resultadoConsulta = new List<contas_DTO>();

                    while (reader.Read())
                    {
                        //DateTime data_cont = Convert.ToDateTime(reader["data_cont"]);
                        //string dataFormatada = data_cont.ToString("dd/MM/yyyy");

                        contas_DTO conta = new contas_DTO
                        {
                            dataFormatada = Convert.ToDateTime(reader["data_cont"]).ToString("dd/MM/yyyy"),
                            valorFormatado = Convert.ToDecimal(reader["valor"]).ToString("C", CultureInfo.GetCultureInfo("pt-BR")),
                            descricao = Convert.ToString(reader["descricao"]),
                            status_cont = Convert.ToString(reader["status_cont"]),
                        };

                        resultadoConsulta.Add(conta);
                    }

                    reader.Close();

                    return resultadoConsulta;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList<contas_DTO> ContasPendentes(int codUsuarioAutenticado, DateTime dataInicial, DateTime dataFinal, string nomeConta, out decimal pendenteEntradas, out decimal pendenteSaidas, out decimal recebidos, out decimal pagos, out decimal previstoEntradas, out decimal previstoSaidas)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.CST))
                {
                    connection.Open();

                    SqlCommand sumCommand = new SqlCommand("sp_ContasPendentes", connection);
                    sumCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    sumCommand.Parameters.Add("@cod_usuario", System.Data.SqlDbType.Int).Value = codUsuarioAutenticado;
                    sumCommand.Parameters.Add("@dataInicial", System.Data.SqlDbType.DateTime).Value = dataInicial;
                    sumCommand.Parameters.Add("@dataFinal", System.Data.SqlDbType.DateTime).Value = dataFinal;
                    sumCommand.Parameters.Add("@nome_conta", System.Data.SqlDbType.NVarChar).Value = (object)nomeConta ?? DBNull.Value;

                    SqlDataReader pendentesReader = sumCommand.ExecuteReader();

                    // Leitura do primeiro resultado (distinct descricao)
                    IList<contas_DTO> resultadoConsulta = new List<contas_DTO>();
                    pendentesReader.NextResult(); // Ignorar o primeiro resultado (nomes distintos)

                    // Leitura do segundo resultado (calcular valores pendentes)
                    if (pendentesReader.Read())
                    {
                        pendenteEntradas = pendentesReader.IsDBNull(pendentesReader.GetOrdinal("pendente_entradas")) ? 0 : pendentesReader.GetDecimal(pendentesReader.GetOrdinal("pendente_entradas"));
                        pendenteSaidas = pendentesReader.IsDBNull(pendentesReader.GetOrdinal("pendente_saidas")) ? 0 : pendentesReader.GetDecimal(pendentesReader.GetOrdinal("pendente_saidas"));
                        recebidos = pendentesReader.IsDBNull(pendentesReader.GetOrdinal("recebidos")) ? 0 : pendentesReader.GetDecimal(pendentesReader.GetOrdinal("recebidos"));
                        pagos = pendentesReader.IsDBNull(pendentesReader.GetOrdinal("pagos")) ? 0 : pendentesReader.GetDecimal(pendentesReader.GetOrdinal("pagos"));
                        previstoEntradas = pendentesReader.IsDBNull(pendentesReader.GetOrdinal("previsto_entradas")) ? 0 : pendentesReader.GetDecimal(pendentesReader.GetOrdinal("previsto_entradas"));
                        previstoSaidas = pendentesReader.IsDBNull(pendentesReader.GetOrdinal("previsto_saidas")) ? 0 : pendentesReader.GetDecimal(pendentesReader.GetOrdinal("previsto_saidas"));
                    }
                    else
                    {
                        pendenteEntradas = 0;
                        pendenteSaidas = 0;
                        recebidos = 0;
                        pagos = 0;
                        previstoEntradas = 0;
                        previstoSaidas = 0;
                    }

                    // Próximo resultado (carregar o DataGridView)
                    pendentesReader.NextResult();
                    while (pendentesReader.Read())
                    {
                        contas_DTO conta = new contas_DTO
                        {
                            cod_conta = Convert.ToInt32(pendentesReader["cod_conta"]),
                            cod_usuario = Convert.ToInt32(pendentesReader["cod_usuario"]),
                            tipo = Convert.ToString(pendentesReader["tipo"]),
                            data_cont = Convert.ToDateTime(pendentesReader["data_cont"]),
                            valor = Convert.ToDecimal(pendentesReader["valor"]),
                            descricao = Convert.ToString(pendentesReader["descricao"]),
                            status_cont = Convert.ToString(pendentesReader["status_cont"]),
                        };
                        resultadoConsulta.Add(conta);
                    }

                    pendentesReader.Close();
                    return resultadoConsulta;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList<string> ObterContasEPreencherComboBox(int codUsuario, DateTime dataInicial, DateTime dataFinal)
        {
            IList<string> descricoes = new List<string>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.CST))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("sp_ContasPendentes", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod_usuario", codUsuario);
                    cmd.Parameters.AddWithValue("@dataInicial", dataInicial);
                    cmd.Parameters.AddWithValue("@dataFinal", dataFinal);
                    cmd.Parameters.AddWithValue("@nome_conta", DBNull.Value);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Ler o primeiro resultado (descrições das contas)
                        while (reader.Read())
                        {
                            descricoes.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return descricoes;
        }
        public IList<usuario_DTO> ConsultarUsuarios(int codUsuarioAutenticado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.CST))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT *, " +
                                                                    "CASE " +
                                                                        "WHEN GETDATE() < data_nasc THEN CAST(DATEDIFF(YEAR, GETDATE(), data_nasc) AS VARCHAR(10)) + ' Anos' " +
                                                                        "ELSE CAST(DATEDIFF(YEAR, data_nasc, GETDATE()) AS VARCHAR(10)) + ' Anos' " +
                                                                    "END as anos " +
                                                                    "FROM tb_usuarios WHERE cod_usuario = @cod_usuario ", connection);

                    command.Parameters.Add("@cod_usuario", System.Data.SqlDbType.Int).Value = codUsuarioAutenticado;

                    SqlDataReader reader = command.ExecuteReader();

                    IList<usuario_DTO> resultadoConsulta = new List<usuario_DTO>();

                    while (reader.Read())
                    {
                        usuario_DTO usuario = new usuario_DTO
                        {
                            cod_usuario = Convert.ToInt32(reader["cod_usuario"]),
                            nome = Convert.ToString(reader["nome"]),
                            sobrenome = Convert.ToString(reader["sobrenome"]),
                            cpf = Convert.ToString(reader["cpf"]),
                            data_nasc = Convert.ToDateTime(reader["data_nasc"]),
                            sexo = Convert.ToChar(reader["sexo"]),
                            anos = Convert.ToString(reader["anos"]),
                        };
                        resultadoConsulta.Add(usuario);
                    }

                    reader.Close();

                    return resultadoConsulta;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int insereConta(contas_DTO CONT)
        {
            try
            {
                int codUsuarioAutenticado = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;

                /*Conexão com o BD Inserindo dados na tb_contas*/
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO tb_contas (cod_usuario, tipo, data_cont, valor, descricao)" +
                    "VALUES(@cod_usuario, @tipo, @data_cont, @valor, @descricao)";

                CM.Parameters.Add("cod_usuario", System.Data.SqlDbType.Int).Value = CONT.cod_usuario;
                CM.Parameters.Add("tipo", System.Data.SqlDbType.VarChar).Value = CONT.tipo;

                // Validar e ajustar a data
                DateTime dataContValidada = AjustarData(CONT.data_cont);
                CM.Parameters.Add("data_cont", System.Data.SqlDbType.DateTime).Value = CONT.data_cont;

                CM.Parameters.Add("valor", System.Data.SqlDbType.Decimal).Value = CONT.valor;
                CM.Parameters.Add("descricao", System.Data.SqlDbType.VarChar).Value = CONT.descricao;

                CM.Connection = CON;

                CON.Open();
                int qtd = CM.ExecuteNonQuery();

                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static DateTime AjustarData(DateTime data)
        {
            // Certificar-se de que a data está dentro dos limites suportados pelo SQL Server
            if (data < DateTime.MinValue)
            {
                return DateTime.MinValue;
            }
            else if (data > DateTime.MaxValue)
            {
                return DateTime.MaxValue;
            }
            return data;
        }
        public int alteraConta(contas_DTO CONT, int codUsuarioAutenticado)
        {
            try
            {
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "UPDATE tb_contas SET tipo=@tipo, " +
                                                       "valor=@valor, " +
                                                       "data_cont=@data_cont, " +
                                                       "descricao=@descricao " +
                                                       "WHERE cod_conta=@cod_conta";

                /*Parameters irá substituir os valores dentro dos campos*/
                CM.Parameters.Add("tipo", System.Data.SqlDbType.VarChar).Value = CONT.tipo;
                CM.Parameters.Add("data_cont", System.Data.SqlDbType.DateTime).Value = CONT.data_cont;
                CM.Parameters.Add("valor", System.Data.SqlDbType.Decimal).Value = CONT.valor;
                CM.Parameters.Add("descricao", System.Data.SqlDbType.VarChar).Value = CONT.descricao;
                CM.Parameters.Add("cod_conta", System.Data.SqlDbType.Int).Value = CONT.cod_conta;

                // Passa o código do usuário autenticado como parâmetro
                CM.Parameters.Add("cod_usuario", System.Data.SqlDbType.Int).Value = codUsuarioAutenticado;

                CM.Connection = CON;

                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
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
                /*Excluindo dados na tb_contas*/
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "DELETE tb_contas WHERE cod_conta=@cod_conta";

                /*Tem um único parametro que será o codigo da conta, só existe um*/
                CM.Parameters.Add("cod_conta", System.Data.SqlDbType.Int).Value = CONT.cod_conta;

                // Parâmetro para o codigo do usuario autenticado na Trigger [trg_log_alteracoes_contas]
                CM.Parameters.Add("cod_usuario", System.Data.SqlDbType.Int).Value = codUsuarioAutenticado;

                CM.Connection = CON;
                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
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
                /*Conexão com o BD 
                 Inserindo dados na tb_contas*/
                SqlConnection CON = new SqlConnection();
                login_DTO LOG = new login_DTO();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO tb_usuarios (nome, sobrenome, cpf, data_nasc, sexo)" +
                    "VALUES(@nome, @sobrenome, @cpf, @data_nasc, @sexo)";

                CM.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = USU.nome;
                CM.Parameters.Add("sobrenome", System.Data.SqlDbType.VarChar).Value = USU.sobrenome;
                CM.Parameters.Add("cpf", System.Data.SqlDbType.VarChar).Value = USU.cpf;
                CM.Parameters.Add("data_nasc", System.Data.SqlDbType.DateTime).Value = USU.data_nasc;
                CM.Parameters.Add("sexo", System.Data.SqlDbType.VarChar).Value = USU.sexo;
                CM.Connection = CON;

                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
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
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "UPDATE tb_usuarios SET nome=@nome, " +
                                                       "sobrenome=@sobrenome, " +
                                                       "cpf=@cpf, " +
                                                       "data_nasc=@data_nasc, " +
                                                       "sexo=@sexo " +
                                                       "WHERE cod_usuario=@cod_usuario";

                /*Parameters irá substituir os valores dentro dos campos*/
                CM.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = USU.nome;
                CM.Parameters.Add("sobrenome", System.Data.SqlDbType.VarChar).Value = USU.sobrenome;
                CM.Parameters.Add("cpf", System.Data.SqlDbType.VarChar).Value = USU.cpf;
                CM.Parameters.Add("data_nasc", System.Data.SqlDbType.DateTime).Value = USU.data_nasc;
                CM.Parameters.Add("sexo", System.Data.SqlDbType.Char).Value = USU.sexo;
                CM.Parameters.Add("cod_usuario", System.Data.SqlDbType.Int).Value = USU.cod_usuario;
                CM.Connection = CON;

                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
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
                /*Conexão com o BD Inserindo dados na tb_contas*/
                SqlConnection CON = new SqlConnection();
                usuario_DTO USU = new usuario_DTO();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO tb_login (cod_usuario, nome_login, senha_login) " +
                    "VALUES((SELECT MAX(cod_usuario) FROM tb_usuarios), @nome_login, @senha_login) ";

                /*Para cada campo citado acima são colocados os valores */
                /*Parameters irá substituir os valores dentro dos campos*/
                CM.Parameters.Add("cod_usuario", System.Data.SqlDbType.Int).Value = USU.cod_usuario;
                CM.Parameters.Add("nome_login", System.Data.SqlDbType.VarChar).Value = LOG.nome_login;
                CM.Parameters.Add("senha_login", System.Data.SqlDbType.VarChar).Value = LOG.senha_login;
                CM.Connection = CON;

                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool EmailExiste(string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.CST))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM tb_login WHERE nome_login = @nome_login", connection);
                    command.Parameters.Add("@nome_login", SqlDbType.VarChar).Value = email;

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CpfExiste(string cpf)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.CST))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM tb_usuarios WHERE cpf = @cpf", connection);
                    command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
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
                using (SqlConnection CON = new SqlConnection(Properties.Settings.Default.CST))
                {
                    CON.Open();
                    SqlCommand CM = new SqlCommand();
                    CM.CommandType = System.Data.CommandType.Text;

                    CM.CommandText = "IF EXISTS (SELECT 1 FROM tb_login WHERE nome_login = @nome_login) " +
                                     "BEGIN " +
                                     "UPDATE tb_login SET senha_login=@senha_login " +
                                     " WHERE nome_login = @nome_login; " +
                                     "END";

                    /*Parameters irá substituir os valores dentro dos campos*/
                    CM.Parameters.Add("nome_login", System.Data.SqlDbType.VarChar).Value = email;
                    CM.Parameters.Add("senha_login", System.Data.SqlDbType.VarChar).Value = novaSenha;
                    CM.Connection = CON;

                    int qtd = CM.ExecuteNonQuery();
                    return qtd > 0;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList<contas_DTO> ObterDadosParaGraficoAnual(int codUsuarioAutenticado, int numeroMes, int numeroAno)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.CST))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("sp_GerarDemonstrativoGrafico", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@cod_usuario", codUsuarioAutenticado);
                    command.Parameters.AddWithValue("@ano", numeroAno); 
                    command.Parameters.AddWithValue("@mes", numeroMes); // Usa numeroMes em vez de mesSelecionado

                    SqlDataReader reader = command.ExecuteReader();

                    IList<contas_DTO> resultadoConsulta = new List<contas_DTO>();

                    while (reader.Read())
                    {
                        contas_DTO conta = new contas_DTO
                        {
                            cod_usuario = Convert.ToInt32(reader["cod_usuario"]),
                            descricao = Convert.ToString(reader["descricao"]),
                            tipo = Convert.ToString(reader["tipo"]),
                            valor = Convert.ToDecimal(reader["valor"]),
                        };
                        resultadoConsulta.Add(conta);
                    }

                    reader.Close();

                    return resultadoConsulta;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void GerarBackupContas(int codUsuarioAutenticado, string filePath)
        {
            try
            {
                // Define a codificação UTF-8
                Encoding encoding = Encoding.UTF8;

                using (StreamWriter writer = new StreamWriter(filePath, false, encoding))
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.CST))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand("SELECT * FROM tb_contas WHERE cod_usuario = @codUsuario AND data_cont <= SYSDATETIME() ORDER BY data_cont ASC", connection);
                        command.Parameters.AddWithValue("@codUsuario", codUsuarioAutenticado);

                        SqlDataReader reader = command.ExecuteReader();

                        // Escreve o cabeçalho do arquivo
                        writer.WriteLine("CodigoConta;CodigoUsuario;Tipo;DataConta;Valor;Descricao");

                        while (reader.Read())
                        {
                            // Escreve os dados no arquivo CSV
                            string dataFormatada = ((DateTime)reader["data_cont"]).ToString("dd/MM/yyyy");
                            decimal valor = (decimal)reader["valor"];
                            string valorFormatado = valor.ToString("#0.00", CultureInfo.GetCultureInfo("pt-BR"));
                            string linha = $"{reader["cod_conta"]}; {reader["cod_usuario"]}; {reader["tipo"]}; {dataFormatada}; {valorFormatado}; {reader["descricao"]}";
                            writer.WriteLine(linha);
                        }
                        reader.Close();
                    }
                }
                Console.WriteLine($"Backup das contas gerado com sucesso em: {filePath}");

                // Abre o diretorio onde o arquivo foi salvo
                Process.Start("explorer.exe", "/select, \"" + filePath + "\"");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gerar backup das contas: {ex.Message}");
            }
        }
        public static int insereBanco(bancos_DTO BAN)
        {
            try
            {
                int codUsuarioAutenticado = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;

                /*Conexão com o BD Inserindo dados na tb_contas*/
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO tb_bancos (cod_usuario, nome_banco, saldo)" +
                    "VALUES(@cod_usuario, @nome_banco, @saldo)";

                CM.Parameters.Add("cod_usuario", System.Data.SqlDbType.Int).Value = BAN.cod_usuario;
                CM.Parameters.Add("nome_banco", System.Data.SqlDbType.VarChar).Value = BAN.nome_banco;
                CM.Parameters.Add("saldo", System.Data.SqlDbType.Decimal).Value = BAN.saldo;

                CM.Connection = CON;

                CON.Open();
                int qtd = CM.ExecuteNonQuery();

                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static IList<bancos_DTO> cargaBanco(int codUsuario)
        {
            try
            {
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand("sp_CalculoSaldoBancos", CON);
                CM.CommandType = CommandType.StoredProcedure;
                CM.Parameters.AddWithValue("@cod_usuario", codUsuario);
                CM.Connection = CON;

                SqlDataReader ER;
                IList<bancos_DTO> listaBancosDTO = new List<bancos_DTO>();

                CON.Open();
                ER = CM.ExecuteReader();
                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        bancos_DTO ban = new bancos_DTO();
                        ban.cod_banco = Convert.ToInt32(ER["cod_banco"]);
                        ban.cod_usuario = Convert.ToInt32(ER["cod_usuario"]);
                        ban.nome_banco = Convert.ToString(ER["nome_banco"]);
                        ban.saldo = Convert.ToDecimal(ER["saldo"]);
                        ban.total_saldo = Convert.ToDecimal(ER["total_saldo"]);
                        ban.saldo_previsto = Convert.ToDecimal(ER["saldo_previsto"]);
                        
                        listaBancosDTO.Add(ban);
                    }
                }
                return listaBancosDTO;
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
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "UPDATE tb_bancos SET saldo=@saldo " +
                                                       "WHERE cod_usuario=@cod_usuario AND nome_banco=@nome_banco";

                /*Parameters irá substituir os valores dentro dos campos*/
                CM.Parameters.Add("nome_banco", System.Data.SqlDbType.VarChar).Value = BAN.nome_banco;
                CM.Parameters.Add("saldo", System.Data.SqlDbType.Decimal).Value = BAN.saldo;
                CM.Parameters.Add("cod_banco", System.Data.SqlDbType.Int).Value = BAN.cod_banco;
                CM.Parameters.Add("cod_usuario", System.Data.SqlDbType.Int).Value = BAN.cod_usuario;
                
                CM.Connection = CON;

                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
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
                /*Excluindo dados na tb_contas*/
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "DELETE tb_bancos WHERE cod_usuario=@cod_usuario AND nome_banco=@nome_banco";

                /*Tem um único parametro que será o codigo da conta, só existe um*/
                CM.Parameters.Add("cod_usuario", System.Data.SqlDbType.Int).Value = BAN.cod_usuario;
                CM.Parameters.Add("nome_banco", System.Data.SqlDbType.VarChar).Value = BAN.nome_banco;

                CM.Connection = CON;
                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
