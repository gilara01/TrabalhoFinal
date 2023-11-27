using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Globalization;

namespace TrabalhoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtTelefone.Text.Equals("") && !txtCPF.Text.Equals(""))
                {
                    CadastroCliente cadCliente = new CadastroCliente();
                    cadCliente.Nome = txtNome.Text;
                    cadCliente.Cpf = txtCPF.Text;
                    cadCliente.Telefone = int.Parse(txtTelefone.Text);

                    if (cadCliente.CadastrarCliente())
                    {
                        MessageBox.Show($"O Cliente {cadCliente.Nome} foi registrado com sucesso");
                        txtCPF.Clear();
                        txtTelefone.Clear();
                        txtNome.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel registrar o cliente");

                    }
                }
                else
                {
                    MessageBox.Show("Por favor preencha todos os campos");
                    txtCPF.Clear();
                    txtTelefone.Clear();
                    txtNome.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao registrar as informações do cliente" + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCPF.Text.Equals(""))
                {
                    CadastroCliente cadCliente = new CadastroCliente();
                    cadCliente.Cpf = txtCPF.Text;
                    MySqlDataReader reader = cadCliente.LocalizarCliente();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lblId.Text = reader["id"].ToString();
                            txtTelefone.Text = reader["telefone"].ToString();
                            txtNome.Text = reader["nome"].ToString();


                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado");
                            txtCPF.Clear();
                            txtTelefone.Clear();
                            txtNome.Clear();
                            txtNome.Focus();
                            lblId.Text = "";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado");
                        txtCPF.Clear();
                        txtTelefone.Clear();
                        txtNome.Clear();
                        txtCPF.Focus();
                        lblId.Text = "";

                    }

                }
                else
                {
                    MessageBox.Show("Por favor Preencher o Campo corretamente");
                    txtCPF.Clear();
                    txtCPF.Focus();
                    lblId.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao localizar cliente - Form1:" + ex.Message);

            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCPF.Text.Equals("") && !txtNome.Text.Equals("") && !txtTelefone.Text.Equals(""))
                {
                    CadastroCliente cadCliente = new CadastroCliente();
                    cadCliente.Id = int.Parse(lblId.Text);
                    cadCliente.Nome = txtNome.Text;
                    cadCliente.Cpf = txtCPF.Text;
                    cadCliente.Telefone = int.Parse(txtTelefone.Text);
                    if (cadCliente.AtualizarCliente())
                    {
                        MessageBox.Show("Os dados do cliente foram atualizados com sucesso");
                        txtCPF.Clear();
                        txtTelefone.Clear();
                        txtNome.Clear();
                        lblId.Text = "";



                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações do cliente - Form1:");
                        txtCPF.Clear();
                        txtTelefone.Clear();
                        txtNome.Clear();
                        lblId.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar o cliente - Form1:");
                    txtCPF.Clear();
                    txtTelefone.Clear();
                    txtNome.Clear();
                    lblId.Text = "";

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao atualizar cliente - Form1:" + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCPF.Text.Equals("") && !txtNome.Text.Equals("") && !txtTelefone.Text.Equals(""))
                {
                    CadastroCliente cadCliente = new CadastroCliente();
                    cadCliente.Id = int.Parse(lblId.Text);
                    if (cadCliente.ExcluirClientes())
                    {
                        MessageBox.Show("O cliente foi excluido com sucesso");
                        txtCPF.Clear();
                        txtTelefone.Clear();
                        txtNome.Clear();
                        lblId.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel excluir cliente");
                        txtCPF.Clear();
                        txtTelefone.Clear();
                        txtNome.Clear();
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor pesquisar cliente que deseja excluir");
                    txtCPF.Clear();
                    txtTelefone.Clear();
                    txtNome.Clear();
                    lblId.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao exluir cliente - Form1:" + ex.Message);

            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf2.Text.Equals(""))
                {
                    CadastroCliente cadCliente = new CadastroCliente();
                    cadCliente.Cpf = txtCpf2.Text;
                    MySqlDataReader reader = cadCliente.LocalizarCliente();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lblId2.Text = reader["id"].ToString();
                            lblTelefone.Text = reader["telefone"].ToString();
                            lblNome.Text = reader["nome"].ToString();
                            lblCpf.Text = txtCpf2.Text;


                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado");
                            txtCpf2.Clear();
                            lblCpf.Text = "";
                            lblTelefone.Text = "";
                            lblNome.Text = "";
                            txtCpf2.Focus();
                            lblId2.Text = "";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado");
                        txtCpf2.Clear();
                        lblTelefone.Text = "";
                        lblNome.Text = "";
                        txtCpf2.Focus();
                        lblId2.Text = "";

                    }

                }
                else
                {
                    MessageBox.Show("Por favor Preencher o Campo corretamente");
                    txtCpf2.Clear();
                    txtCpf2.Focus();
                    lblId2.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao localizar cliente - Form1:" + ex.Message);

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCpf2.Clear();
            lblTelefone.Text = "";
            lblNome.Text = "";
            txtCpf2.Focus();
            lblCpf.Text = "";
            lblId2.Text = "";
        }

        private void btnJogosRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtJogos2.Text.Equals(""))
                {
                    CadastroJogo cadJogo = new CadastroJogo();
                    cadJogo.Nome = txtJogos2.Text;
                    cadJogo.Quantidade = int.Parse(txtQuantidade.Text);

                    if (cadJogo.CadastrarJogo())
                    {
                        MessageBox.Show($"O Jogo {cadJogo.Nome} foi registrado com sucesso");
                        txtJogos2.Clear();
                        txtJogos2.Focus();
                        txtQuantidade.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel registrar o Jogo");

                    }
                }
                else
                {
                    MessageBox.Show("Por favor preencha o nome do jogo");
                    txtJogos2.Clear();
                    txtJogos2.Focus();
                    txtQuantidade.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao registrar o jogo" + ex.Message);
            }

        }

        private void btnDisponibilidade_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtJogos2.Text.Equals(""))
                {
                    CadastroJogo cadJogo = new CadastroJogo();
                    cadJogo.Nome = txtJogos2.Text;
                    MySqlDataReader reader = cadJogo.LocalizarJogo();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            string disponivel = "disponível";
                            if (int.Parse(reader["quantidade"].ToString()) < 1)
                            {
                                disponivel = "indisponível";
                            }
                            MessageBox.Show($"O jogo {reader["nome"]} esta registrado e esta {disponivel}");



                        }
                        else
                        {
                            MessageBox.Show("Jogo não encontrado");
                            txtJogos2.Clear();
                            txtJogos2.Focus();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Jogo não encontrado");
                        txtJogos2.Clear();
                        txtJogos2.Focus();


                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao verificar a disponibilidade" + ex.Message);
            }
        }

        private void btnJogosExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtJogos2.Text.Equals(""))
                {
                    CadastroJogo cadJogo = new CadastroJogo();
                    cadJogo.Nome = txtJogos2.Text;
                    if (cadJogo.ExcluirJogo())
                    {
                        MessageBox.Show("O jogo foi excluido com sucesso");
                        txtJogos2.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel excluir jogo");
                        txtJogos2.Clear();

                    }
                }
                else
                {
                    MessageBox.Show("Favor pesquisar jogo que deseja excluir");
                    txtJogos2.Clear();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao exluir jogo - Form1:" + ex.Message);

            }

        }

        private void btnVerificarEmprestimo_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao verificar empréstimos - Form1:" + ex.Message);
            }
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtJogos.Text.Equals("") && lblCpf.Text != "")
                {
                    CadastroJogo cadJogos = new CadastroJogo();
                    CadastroEmprestimo cadEmprestimo = new CadastroEmprestimo();
                    cadJogos.Nome = txtJogos.Text;
                    MySqlDataReader reader = cadJogos.LocalizarJogo();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            if (int.Parse(reader["quantidade"].ToString()) > 0)
                            {
                                cadEmprestimo.Jogo = txtJogos.Text;
                                cadEmprestimo.Nome = lblNome.Text;
                                cadEmprestimo.Cpf = lblCpf.Text;
                                cadEmprestimo.Inicio = dtInicio.Value.ToShortDateString();
                                cadJogos.Quantidade = int.Parse(reader["quantidade"].ToString() ) - 1;

                                if (cadEmprestimo.CadastrarEmprestimos())
                                {   
                                    cadJogos.AtualizarJogo();

                                    MessageBox.Show($"O Emprestimo foi registrado com sucesso");
                                }
                                else
                                {
                                    MessageBox.Show("Não foi possivel registrar o emprestimo");
                                    MessageBox.Show(dtInicio.ToString());


                                }

                            }
                            else
                            {
                                MessageBox.Show("Jogo indisponível para emprestimo");
                            }






                        }
                        else
                        {
                            MessageBox.Show("Jogo não encontrado");
                            txtJogos2.Clear();
                            txtJogos2.Focus();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o cliente e escolha o jogo");
                }
            }



            catch (Exception ex)
            {

                MessageBox.Show("Erro ao registrar empréstimos - Form1:" + ex.Message);
            }
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            try
            {   
                CadastroJogo cadJogo = new CadastroJogo();
                
               
                CadastroEmprestimo cadEmprestimo = new CadastroEmprestimo();
                cadEmprestimo.Id = int.Parse(txtExcluir.Text);
                MySqlDataReader readeremprestimo = cadEmprestimo.LocalizarEmprestimo();
                readeremprestimo.Read();
                cadJogo.Nome = readeremprestimo["jogo"].ToString();
                cadEmprestimo.Fim = dtFim.Value.ToShortDateString();
                MySqlDataReader reader = cadJogo.LocalizarJogo();
                if (cadEmprestimo.CadastrarDevolucao())
                {
                    if (reader.HasRows)
                    {
                        cadJogo.Quantidade = (int.Parse(reader["quantidade"].ToString())) + 1;
                        cadJogo.AtualizarJogo();
                    }

                   
                    MessageBox.Show("Devolução feita");
                }
                else
                {
                    MessageBox.Show("Erro na devolução");

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao registrar devolução - Form1:" + ex.Message);
            }
        }

        private void btnExcluirEmprestimo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtExcluir.Text.Equals("") )
                {
                    CadastroEmprestimo cadEmprestimo = new CadastroEmprestimo();
                    cadEmprestimo.Id = int.Parse(txtExcluir.Text);
                    CadastroJogo cadJogos = new CadastroJogo();
                    MySqlDataReader readeremprestimo = cadEmprestimo.LocalizarEmprestimo();
                    readeremprestimo.Read();
                    cadJogos.Nome = readeremprestimo["jogo"].ToString();


                    MySqlDataReader reader = cadJogos.LocalizarJogo();
                    reader.Read();
                    
                    if (cadEmprestimo.ExcluirEmprestimo())
                    {
                        MessageBox.Show("O emprestimo foi excluido com sucesso");
                        if (reader.HasRows)
                        {
                            cadJogos.Quantidade = (int.Parse(reader["quantidade"].ToString())) + 1;
                            cadJogos.AtualizarJogo();
                        }

                        

                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel excluir emprestimo");
                        txtJogos2.Clear();

                    }
                }
                else
                {
                    MessageBox.Show("Favor pesquisar o id do empréstimo que deseja excluir o emprestimo atribuido");
                    txtJogos.Clear();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao exluir emprestimo - Form1:" + ex.Message);

            }

        }


        private void btnHistorico_Click(object sender, EventArgs e)
        {
            lblEmprestimos.Text = "";
            MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
            MysqlConexaoBanco.Open();
            

            string select = $"select * from emprestimos ";
            MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
            comandosql.CommandText = select;
            MySqlDataReader reader = comandosql.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                lblEmprestimos.Text += reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString() + " "+reader[5].ToString()+" "+ " \r";

            }
            while (reader.HasRows)
            {
                while (reader.Read()) // == this is the Read() method was called
                {
                    lblEmprestimos.Text += reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString()+ " " + reader[5].ToString() +" "+ " \r";

                }
                reader.NextResult();
            }


            reader.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
            MysqlConexaoBanco.Open();
            string createtables = "CREATE TABLE IF NOT EXISTS jogos (\r\n  id int NOT NULL AUTO_INCREMENT,\r\n " +
                " nome varchar(45) NOT NULL,\r\n  quantidade int NOT NULL,\r\n  PRIMARY KEY (id)\r\n) " +
                "ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;\r\nCREATE TABLE IF NOT EXISTS emprestimos" +
                " (\r\n  id int NOT NULL AUTO_INCREMENT,\r\n  nome varchar(45) NOT NULL,\r\n  cpf varchar(45) NOT NULL,\r\n " +
                " jogo varchar(45) NOT NULL,\r\n  inicio varchar(45) NOT NULL,\r\n  fim varchar(45) DEFAULT NULL,\r\n " +
                " PRIMARY KEY (id),\r\n  UNIQUE KEY id_UNIQUE (id)\r\n) ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;\r\n" +
                "CREATE TABLE IF NOT EXISTS cliente (\r\n  id int NOT NULL AUTO_INCREMENT,\r\n  nome varchar(45) NOT NULL,\r\n  cpf varchar(45) NOT NULL,\r\n  telefone int NOT NULL,\r\n  " +
                "PRIMARY KEY (id),\r\n  UNIQUE KEY cpf_UNIQUE (cpf)\r\n) ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;";
            MySqlCommand comandosql0 = MysqlConexaoBanco.CreateCommand();
            comandosql0.CommandText = createtables;
            comandosql0.ExecuteReader();
        }
    }
}