namespace TrabalhoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>

        /// <summary>
        private System.ComponentModel.IContainer components = null;
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtCPF = new TextBox();
            btnCliente = new Button();
            btnExcluir = new Button();
            label3 = new Label();
            lblId = new Label();
            btnAtualizar = new Button();
            btnPesquisar = new Button();
            label4 = new Label();
            txtCpf2 = new TextBox();
            btnPesquisarCliente = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            lblCpf = new Label();
            lblId2 = new Label();
            label9 = new Label();
            txtJogos = new TextBox();
            btnEmprestimo = new Button();
            label10 = new Label();
            label11 = new Label();
            dtInicio = new DateTimePicker();
            dtFim = new DateTimePicker();
            label12 = new Label();
            btnDevolucao = new Button();
            btnExcluirEmprestimo = new Button();
            txtJogos2 = new TextBox();
            btnJogosExcluir = new Button();
            btnJogosRegistrar = new Button();
            btnDisponibilidade = new Button();
            btnHistorico = new Button();
            btnLimpar = new Button();
            btnVerificarEmprestimo = new Button();
            lblEmprestimos = new Label();
            txtQuantidade = new TextBox();
            label13 = new Label();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.None;
            lbl.AutoSize = true;
            lbl.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(14, 85);
            lbl.Name = "lbl";
            lbl.Size = new Size(83, 29);
            lbl.TabIndex = 0;
            lbl.Text = "Nome";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 143);
            label1.Name = "label1";
            label1.Size = new Size(111, 29);
            label1.TabIndex = 1;
            label1.Text = "Telefone";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 200);
            label2.Name = "label2";
            label2.Size = new Size(58, 29);
            label2.TabIndex = 2;
            label2.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.None;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(18, 116);
            txtNome.Margin = new Padding(0);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(610, 25);
            txtNome.TabIndex = 3;
            txtNome.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.None;
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Cursor = Cursors.IBeam;
            txtTelefone.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(18, 173);
            txtTelefone.Margin = new Padding(0);
            txtTelefone.MaxLength = 100;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(395, 25);
            txtTelefone.TabIndex = 4;
            txtTelefone.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCPF
            // 
            txtCPF.Anchor = AnchorStyles.None;
            txtCPF.BorderStyle = BorderStyle.None;
            txtCPF.Cursor = Cursors.IBeam;
            txtCPF.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.Location = new Point(18, 231);
            txtCPF.Margin = new Padding(0);
            txtCPF.MaxLength = 11;
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(183, 25);
            txtCPF.TabIndex = 5;
            txtCPF.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(0, 71, 143);
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(421, 273);
            btnCliente.Margin = new Padding(3, 4, 3, 4);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new Padding(5);
            btnCliente.Size = new Size(208, 64);
            btnCliente.TabIndex = 6;
            btnCliente.Text = "Registrar Aluno";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnAluno_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(0, 71, 143);
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(18, 273);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(183, 64);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir Aluno";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 64);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 10;
            label3.Text = "ID:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.ForeColor = Color.White;
            lblId.Location = new Point(57, 64);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 20);
            lblId.TabIndex = 11;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(0, 71, 143);
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(208, 273);
            btnAtualizar.Margin = new Padding(3, 4, 3, 4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Padding = new Padding(5);
            btnAtualizar.Size = new Size(206, 64);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar Aluno";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(0, 71, 143);
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(208, 227);
            btnPesquisar.Margin = new Padding(0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(138, 36);
            btnPesquisar.TabIndex = 13;
            btnPesquisar.Text = "Pesquisar CPF";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(686, 85);
            label4.Name = "label4";
            label4.Size = new Size(185, 29);
            label4.TabIndex = 14;
            label4.Text = "CPF do Cliente";
            // 
            // txtCpf2
            // 
            txtCpf2.Anchor = AnchorStyles.None;
            txtCpf2.BorderStyle = BorderStyle.None;
            txtCpf2.Cursor = Cursors.IBeam;
            txtCpf2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf2.Location = new Point(686, 116);
            txtCpf2.Margin = new Padding(0);
            txtCpf2.MaxLength = 11;
            txtCpf2.Name = "txtCpf2";
            txtCpf2.Size = new Size(271, 25);
            txtCpf2.TabIndex = 15;
            // 
            // btnPesquisarCliente
            // 
            btnPesquisarCliente.BackColor = Color.FromArgb(0, 71, 143);
            btnPesquisarCliente.FlatAppearance.BorderSize = 0;
            btnPesquisarCliente.FlatStyle = FlatStyle.Flat;
            btnPesquisarCliente.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisarCliente.ForeColor = Color.White;
            btnPesquisarCliente.Location = new Point(971, 112);
            btnPesquisarCliente.Margin = new Padding(0);
            btnPesquisarCliente.Name = "btnPesquisarCliente";
            btnPesquisarCliente.Size = new Size(138, 36);
            btnPesquisarCliente.TabIndex = 16;
            btnPesquisarCliente.Text = "Pesquisar Cpf";
            btnPesquisarCliente.UseVisualStyleBackColor = false;
            btnPesquisarCliente.Click += btnPesquisarAluno_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(690, 152);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 20;
            label5.Text = "ID:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(686, 288);
            label6.Name = "label6";
            label6.Size = new Size(68, 29);
            label6.TabIndex = 19;
            label6.Text = "CPF:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(686, 231);
            label7.Name = "label7";
            label7.Size = new Size(122, 29);
            label7.TabIndex = 18;
            label7.Text = "Telefone:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(686, 173);
            label8.Name = "label8";
            label8.Size = new Size(94, 29);
            label8.TabIndex = 17;
            label8.Text = "Nome:";
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.None;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(769, 173);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 29);
            lblNome.TabIndex = 21;
            // 
            // lblTelefone
            // 
            lblTelefone.Anchor = AnchorStyles.None;
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefone.ForeColor = Color.White;
            lblTelefone.Location = new Point(808, 232);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(0, 29);
            lblTelefone.TabIndex = 22;
            // 
            // lblCpf
            // 
            lblCpf.Anchor = AnchorStyles.None;
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCpf.ForeColor = Color.White;
            lblCpf.Location = new Point(749, 288);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(0, 29);
            lblCpf.TabIndex = 23;
            // 
            // lblId2
            // 
            lblId2.AutoSize = true;
            lblId2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblId2.ForeColor = Color.White;
            lblId2.Location = new Point(729, 152);
            lblId2.Name = "lblId2";
            lblId2.Size = new Size(0, 20);
            lblId2.TabIndex = 24;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(686, 356);
            label9.Name = "label9";
            label9.Size = new Size(182, 29);
            label9.TabIndex = 25;
            label9.Text = "Nome do jogo";
            // 
            // txtJogos
            // 
            txtJogos.Anchor = AnchorStyles.None;
            txtJogos.BorderStyle = BorderStyle.None;
            txtJogos.Cursor = Cursors.IBeam;
            txtJogos.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtJogos.Location = new Point(686, 387);
            txtJogos.Margin = new Padding(0);
            txtJogos.MaxLength = 100;
            txtJogos.Name = "txtJogos";
            txtJogos.Size = new Size(424, 25);
            txtJogos.TabIndex = 26;
            // 
            // btnEmprestimo
            // 
            btnEmprestimo.BackColor = Color.FromArgb(0, 71, 143);
            btnEmprestimo.FlatAppearance.BorderSize = 0;
            btnEmprestimo.FlatStyle = FlatStyle.Flat;
            btnEmprestimo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmprestimo.ForeColor = Color.White;
            btnEmprestimo.Location = new Point(686, 525);
            btnEmprestimo.Margin = new Padding(3, 4, 3, 4);
            btnEmprestimo.Name = "btnEmprestimo";
            btnEmprestimo.Padding = new Padding(5);
            btnEmprestimo.Size = new Size(418, 64);
            btnEmprestimo.TabIndex = 27;
            btnEmprestimo.Text = "Registrar empréstimo";
            btnEmprestimo.UseVisualStyleBackColor = false;
            btnEmprestimo.Click += btnEmprestimo_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(686, 452);
            label10.Name = "label10";
            label10.Size = new Size(175, 29);
            label10.TabIndex = 28;
            label10.Text = "Data de início";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(895, 452);
            label11.Name = "label11";
            label11.Size = new Size(205, 29);
            label11.TabIndex = 30;
            label11.Text = "Data de entrega";
            // 
            // dtInicio
            // 
            dtInicio.Checked = false;
            dtInicio.CustomFormat = "yyyy/MM/dd";
            dtInicio.Format = DateTimePickerFormat.Custom;
            dtInicio.Location = new Point(686, 487);
            dtInicio.Margin = new Padding(3, 4, 3, 4);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(187, 27);
            dtInicio.TabIndex = 32;
            // 
            // dtFim
            // 
            dtFim.CustomFormat = "yyyy/MM/dd";
            dtFim.Format = DateTimePickerFormat.Custom;
            dtFim.Location = new Point(896, 487);
            dtFim.Margin = new Padding(3, 4, 3, 4);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(213, 27);
            dtFim.TabIndex = 33;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1178, 85);
            label12.Name = "label12";
            label12.Size = new Size(182, 29);
            label12.TabIndex = 34;
            label12.Text = "Nome do jogo";
            // 
            // btnDevolucao
            // 
            btnDevolucao.BackColor = Color.FromArgb(0, 71, 143);
            btnDevolucao.FlatAppearance.BorderSize = 0;
            btnDevolucao.FlatStyle = FlatStyle.Flat;
            btnDevolucao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDevolucao.ForeColor = Color.White;
            btnDevolucao.Location = new Point(896, 597);
            btnDevolucao.Margin = new Padding(3, 4, 3, 4);
            btnDevolucao.Name = "btnDevolucao";
            btnDevolucao.Padding = new Padding(5);
            btnDevolucao.Size = new Size(208, 64);
            btnDevolucao.TabIndex = 35;
            btnDevolucao.Text = "Registrar devolução";
            btnDevolucao.UseVisualStyleBackColor = false;
            btnDevolucao.Click += btnDevolucao_Click;
            // 
            // btnExcluirEmprestimo
            // 
            btnExcluirEmprestimo.BackColor = Color.FromArgb(0, 71, 143);
            btnExcluirEmprestimo.FlatAppearance.BorderSize = 0;
            btnExcluirEmprestimo.FlatStyle = FlatStyle.Flat;
            btnExcluirEmprestimo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluirEmprestimo.ForeColor = Color.White;
            btnExcluirEmprestimo.Location = new Point(686, 597);
            btnExcluirEmprestimo.Margin = new Padding(3, 4, 3, 4);
            btnExcluirEmprestimo.Name = "btnExcluirEmprestimo";
            btnExcluirEmprestimo.Padding = new Padding(5);
            btnExcluirEmprestimo.Size = new Size(187, 64);
            btnExcluirEmprestimo.TabIndex = 36;
            btnExcluirEmprestimo.Text = "Excluir empréstimo";
            btnExcluirEmprestimo.UseVisualStyleBackColor = false;
            btnExcluirEmprestimo.Click += btnExcluirEmprestimo_Click;
            // 
            // txtJogos2
            // 
            txtJogos2.Anchor = AnchorStyles.None;
            txtJogos2.BorderStyle = BorderStyle.None;
            txtJogos2.Cursor = Cursors.IBeam;
            txtJogos2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtJogos2.Location = new Point(1178, 121);
            txtJogos2.Margin = new Padding(0);
            txtJogos2.MaxLength = 100;
            txtJogos2.Name = "txtJogos2";
            txtJogos2.Size = new Size(418, 25);
            txtJogos2.TabIndex = 37;
            // 
            // btnJogosExcluir
            // 
            btnJogosExcluir.BackColor = Color.FromArgb(0, 71, 143);
            btnJogosExcluir.FlatAppearance.BorderSize = 0;
            btnJogosExcluir.FlatStyle = FlatStyle.Flat;
            btnJogosExcluir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnJogosExcluir.ForeColor = Color.White;
            btnJogosExcluir.Location = new Point(1178, 196);
            btnJogosExcluir.Margin = new Padding(3, 4, 3, 4);
            btnJogosExcluir.Name = "btnJogosExcluir";
            btnJogosExcluir.Padding = new Padding(5);
            btnJogosExcluir.Size = new Size(195, 64);
            btnJogosExcluir.TabIndex = 40;
            btnJogosExcluir.Text = "Excluir Jogo";
            btnJogosExcluir.UseVisualStyleBackColor = false;
            btnJogosExcluir.Click += btnLivroExcluir_Click;
            // 
            // btnJogosRegistrar
            // 
            btnJogosRegistrar.BackColor = Color.FromArgb(0, 71, 143);
            btnJogosRegistrar.FlatAppearance.BorderSize = 0;
            btnJogosRegistrar.FlatStyle = FlatStyle.Flat;
            btnJogosRegistrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnJogosRegistrar.ForeColor = Color.White;
            btnJogosRegistrar.Location = new Point(1379, 197);
            btnJogosRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnJogosRegistrar.Name = "btnJogosRegistrar";
            btnJogosRegistrar.Padding = new Padding(5);
            btnJogosRegistrar.Size = new Size(217, 64);
            btnJogosRegistrar.TabIndex = 38;
            btnJogosRegistrar.Text = "Registrar Jogo";
            btnJogosRegistrar.UseVisualStyleBackColor = false;
            btnJogosRegistrar.Click += btnLivroRegistrar_Click;
            // 
            // btnDisponibilidade
            // 
            btnDisponibilidade.BackColor = Color.FromArgb(0, 71, 143);
            btnDisponibilidade.FlatAppearance.BorderSize = 0;
            btnDisponibilidade.FlatStyle = FlatStyle.Flat;
            btnDisponibilidade.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisponibilidade.ForeColor = Color.White;
            btnDisponibilidade.Location = new Point(1406, 80);
            btnDisponibilidade.Margin = new Padding(0);
            btnDisponibilidade.Name = "btnDisponibilidade";
            btnDisponibilidade.Size = new Size(187, 36);
            btnDisponibilidade.TabIndex = 41;
            btnDisponibilidade.Text = "Verificar disponibilidade";
            btnDisponibilidade.UseVisualStyleBackColor = false;
            btnDisponibilidade.Click += btnDisponibilidade_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.FromArgb(0, 71, 143);
            btnHistorico.FlatAppearance.BorderSize = 0;
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistorico.ForeColor = Color.White;
            btnHistorico.Location = new Point(729, 700);
            btnHistorico.Margin = new Padding(3, 4, 3, 4);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Padding = new Padding(5);
            btnHistorico.Size = new Size(322, 64);
            btnHistorico.TabIndex = 42;
            btnHistorico.Text = "Histórico de empréstimos";
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(0, 71, 143);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(686, 320);
            btnLimpar.Margin = new Padding(0);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(138, 36);
            btnLimpar.TabIndex = 45;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnVerificarEmprestimo
            // 
            btnVerificarEmprestimo.BackColor = Color.FromArgb(0, 71, 143);
            btnVerificarEmprestimo.FlatAppearance.BorderSize = 0;
            btnVerificarEmprestimo.FlatStyle = FlatStyle.Flat;
            btnVerificarEmprestimo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerificarEmprestimo.ForeColor = Color.White;
            btnVerificarEmprestimo.Location = new Point(896, 416);
            btnVerificarEmprestimo.Margin = new Padding(0);
            btnVerificarEmprestimo.Name = "btnVerificarEmprestimo";
            btnVerificarEmprestimo.Size = new Size(214, 36);
            btnVerificarEmprestimo.TabIndex = 46;
            btnVerificarEmprestimo.Text = "Verificar empréstimo";
            btnVerificarEmprestimo.UseVisualStyleBackColor = false;
            btnVerificarEmprestimo.Click += btnVerificarEmprestimo_Click;
            // 
            // lblEmprestimos
            // 
            lblEmprestimos.Anchor = AnchorStyles.None;
            lblEmprestimos.AutoSize = true;
            lblEmprestimos.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmprestimos.ForeColor = Color.White;
            lblEmprestimos.Location = new Point(661, 823);
            lblEmprestimos.Name = "lblEmprestimos";
            lblEmprestimos.Size = new Size(0, 29);
            lblEmprestimos.TabIndex = 47;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Anchor = AnchorStyles.None;
            txtQuantidade.BorderStyle = BorderStyle.None;
            txtQuantidade.Cursor = Cursors.IBeam;
            txtQuantidade.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantidade.Location = new Point(1178, 168);
            txtQuantidade.Margin = new Padding(0);
            txtQuantidade.MaxLength = 100;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(90, 25);
            txtQuantidade.TabIndex = 48;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(1178, 146);
            label13.Name = "label13";
            label13.Size = new Size(149, 29);
            label13.TabIndex = 49;
            label13.Text = "Quantidade";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 131, 204);
            ClientSize = new Size(1924, 1055);
            Controls.Add(label13);
            Controls.Add(txtQuantidade);
            Controls.Add(lblEmprestimos);
            Controls.Add(btnVerificarEmprestimo);
            Controls.Add(btnLimpar);
            Controls.Add(btnHistorico);
            Controls.Add(btnDisponibilidade);
            Controls.Add(btnJogosExcluir);
            Controls.Add(btnJogosRegistrar);
            Controls.Add(txtJogos2);
            Controls.Add(btnExcluirEmprestimo);
            Controls.Add(btnDevolucao);
            Controls.Add(label12);
            Controls.Add(dtFim);
            Controls.Add(dtInicio);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnEmprestimo);
            Controls.Add(txtJogos);
            Controls.Add(label9);
            Controls.Add(lblId2);
            Controls.Add(lblCpf);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btnPesquisarCliente);
            Controls.Add(txtCpf2);
            Controls.Add(label4);
            Controls.Add(btnPesquisar);
            Controls.Add(btnAtualizar);
            Controls.Add(lblId);
            Controls.Add(label3);
            Controls.Add(btnExcluir);
            Controls.Add(btnCliente);
            Controls.Add(txtCPF);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emprestimo de Livros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtCPF;
        private Button btnCliente;
        private Button btnExcluir;
        private Label label3;
        private Label lblId;
        private Button btnAtualizar;
        private Button btnPesquisar;
        private Label label4;
        private TextBox txtCpf2;
        private Button btnPesquisarCliente;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblNome;
        private Label lblTelefone;
        private Label lblCpf;
        private Label lblId2;
        private Label label9;
        private TextBox txtJogos;
        private Button btnEmprestimo;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label12;
        private Button btnDevolucao;
        private Button btnExcluirEmprestimo;
        private TextBox txtJogos2;
        private Button btnJogosExcluir;
        private Button btnJogosRegistrar;
        private Button btnDisponibilidade;
        private Button btnHistorico;
        private Button btnLimpar;
        private Button btnVerificarEmprestimo;
        private DateTimePicker dtInicio;
        private DateTimePicker dtFim;
        private Label lblEmprestimos;
        private TextBox txtQuantidade;
        private Label label13;
    }
}