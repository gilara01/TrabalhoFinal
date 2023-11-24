using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    internal class CadastroJogo
    {
        private int id;
        private string nome;
        private int quantidade;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        MySqlDataReader Count()
        {

            MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
            MysqlConexaoBanco.Open();
            string count = $"select count(id) from jogos where nome = '{nome}'";
            MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
            comandosql.CommandText = count;
            MySqlDataReader reader = comandosql.ExecuteReader();
            return reader;
        }

        public bool CadastrarJogo()
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
                        string insert = $"insert into jogos(nome,quantidade) values ('{nome}','{quantidade}')";
                        MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                        comandosql.CommandText = insert;
                        comandosql.ExecuteNonQuery();
                        return true;

                    }
                    else
                    {
                        MessageBox.Show("Jogo ja cadastrado");
                        return false;
                    }

                }
                return false;



            }
            catch (Exception e)
            {

                MessageBox.Show("Erro no banco de dados - CadastroJogo:" + e.Message);
                return false;
            }
        }
        public MySqlDataReader LocalizarJogo()
        {
            try
            {

                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();
                string select = $"select id,nome,quantidade from jogos where nome = '{nome}';";
                MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                comandosql.CommandText = select;
                MySqlDataReader reader = comandosql.ExecuteReader();
                return reader;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao localizar Jogo- CadastroJogo:" + ex.Message);
                return null;
            }
        }

        public bool ExcluirJogo()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string delete = $"delete from jogos where nome = '{nome}';";
                MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                comandosql.CommandText = delete;
                comandosql.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir o jogo - CadastroJogo:" + ex.Message);
                return false;
            }
        }
        public bool AtualizarJogo()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string update = $"update livros set quantidade = '{quantidade}' where nome = '{nome}';";
                MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                comandosql.CommandText = update;
                comandosql.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao atualizar jogo - CadastroJogo:" + ex.Message);
                return false;
            }

        }
    }
}
