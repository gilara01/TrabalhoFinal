using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    internal class CadastroEmprestimo
    {

        private int id;
        private string cpf;
        private string jogo;
        private string inicio;
        private string fim;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Jogo
        {
            get { return jogo; }
            set { jogo = value; }
        }
        public string Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }


        public string Fim
        {
            get { return fim; }
            set { fim = value; }
        }



        MySqlDataReader Count()
        {

            MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
            MysqlConexaoBanco.Open();
            string count = $"select count(quantidade) from jogos where nome = '{jogo}'";
            MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
            comandosql.CommandText = count;
            MySqlDataReader reader = comandosql.ExecuteReader();
            return reader;
        }

        public bool CadastrarEmprestimos()
        {
            try
            {

                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();
                MySqlDataReader reader = Count();

                if (reader != null)
                {
                    reader.Read();
                    if (reader.GetUInt32(0) > 0)
                    {
                        string insert = $"insert into emprestimos(cpf,jogo,inicio) values ('{cpf}','{jogo}','{inicio}')";
                        MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                        comandosql.CommandText = insert;
                        comandosql.ExecuteNonQuery();
                        return true;

                    }
                    else
                    {
                        MessageBox.Show("Emprestimo ja cadastrado");
                        return false;
                    }

                }
                return false;



            }
            catch (Exception e)
            {

                MessageBox.Show("Erro no banco de dados - CadastroEmprestimos:" + e.Message);
                return false;
            }
        }
        public bool CadastrarDevolucao()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();
                MySqlDataReader reader = Count();

                if (reader != null)
                {
                    reader.Read();
                    if (reader.GetUInt32(0) < 1)
                    {
                        string insert = $"update emprestimos set fim = '{fim}' where jogo = '{jogo}'";
                        MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                        comandosql.CommandText = insert;
                        comandosql.ExecuteNonQuery();
                        return true;

                    }
                    else
                    {
                        MessageBox.Show("Emprestimo ja cadastrado");
                        return false;
                    }

                }
                return false;


            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao registrar devolução");
                return false;

            }
        }
        public MySqlDataReader LocalizarLivro()
        {
            try
            {

                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();
                string select = $"select id,nome,quantidade from jogos where nome = '{cpf}';";
                MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                comandosql.CommandText = select;
                MySqlDataReader reader = comandosql.ExecuteReader();
                return reader;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao localizar Jogo- CadastroEmprestimo:" + ex.Message);
                return null;
            }
        }

        public bool ExcluirEmprestimo()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string delete = $"delete from emprestimos where cpf = '{cpf}' AND jogo = '{jogo}';";
                MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                comandosql.CommandText = delete;
                comandosql.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir o Emprestimo - CadastroEmprestimos:" + ex.Message);
                return false;
            }
        }
    }
}
