using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    internal class CadastroCliente
    {
        private int id;
        private string nome;
        private int telefone;
        private string cpf;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public string Cpf { get => cpf; set => cpf = value; }

        MySqlDataReader Count()
        {

            MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
            MysqlConexaoBanco.Open();
            string countcpf = $"select count(id) from cliente where cpf = '{cpf}'";
            MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
            comandosql.CommandText = countcpf;
            MySqlDataReader reader = comandosql.ExecuteReader();
            return reader;
        }

        public bool CadastrarCliente()
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
                        string insert = $"insert into cliente(nome,cpf,telefone) values ('{nome}','{cpf}','{telefone}')";
                        MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                        comandosql.CommandText = insert;
                        comandosql.ExecuteNonQuery();
                        return true;

                    }
                    else
                    {
                        MessageBox.Show("Cpf ja cadastrado");
                        return false;
                    }

                }
                return false;



            }
            catch (Exception e)
            {

                MessageBox.Show("Erro no banco de dados - CadastroCliente:" + e.Message);
                return false;
            }
        }

        public MySqlDataReader LocalizarCliente()
        {
            try
            {

                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();
                string select = $"select id,nome,cpf,telefone from cliente where cpf = '{cpf}';";
                MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                comandosql.CommandText = select;
                MySqlDataReader reader = comandosql.ExecuteReader();
                return reader;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao localizar Cliente - CadastroCliente:" + ex.Message);
                return null;
            }
        }
        public bool AtualizarCliente()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string update = $"update cliente set nome = '{nome}', cpf = '{cpf}',telefone = '{telefone}' where id = '{Id}';";
                MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                comandosql.CommandText = update;
                comandosql.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao atualizar cliente - CadastroCliente:" + ex.Message);
                return false;
            }
        }

        public bool ExcluirAlunos()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string delete = $"delete from cliente where id = '{Id}';";
                MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                comandosql.CommandText = delete;
                comandosql.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir cliente - CadastroCliente:" + ex.Message);
                return false;
            }
        }
    }
}
