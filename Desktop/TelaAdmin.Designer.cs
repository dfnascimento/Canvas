using Modelo.PN;

namespace Desktop
{
    partial class TelaAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAtivar2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.combAvaliadoresDisp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gridAvaliadoresProj = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.gridOrientadoresProj = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridAlunosParicipantesProj = new System.Windows.Forms.DataGridView();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.cbProjDisp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.NomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CursoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampusAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeOrient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailOrient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusOrien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisciplinaOrient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartamentoOrient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusAval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaAval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormacaoAval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAvaliadoresProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrientadoresProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunosParicipantesProj)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAtivar);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(879, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aprovar Professor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(744, 15);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(127, 23);
            this.btnAtivar.TabIndex = 3;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.UseVisualStyleBackColor = true;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Email,
            this.Disciplina,
            this.Departamento});
            this.dataGridView1.Location = new System.Drawing.Point(21, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(852, 332);
            this.dataGridView1.TabIndex = 2;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.FillWeight = 150F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.FillWeight = 150F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Disciplina
            // 
            this.Disciplina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Disciplina.FillWeight = 150F;
            this.Disciplina.HeaderText = "Disciplina";
            this.Disciplina.Name = "Disciplina";
            this.Disciplina.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Departamento.FillWeight = 150F;
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Professores inativos: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAtivar2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(879, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aprovar Avaliador Externo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAtivar2
            // 
            this.btnAtivar2.Location = new System.Drawing.Point(744, 19);
            this.btnAtivar2.Name = "btnAtivar2";
            this.btnAtivar2.Size = new System.Drawing.Size(127, 23);
            this.btnAtivar2.TabIndex = 6;
            this.btnAtivar2.Text = "Ativar";
            this.btnAtivar2.UseVisualStyleBackColor = true;
            this.btnAtivar2.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(25, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(846, 332);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 150F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Email";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Área";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 150F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Formação";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Avaliadores Externos inativos";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAdicionar);
            this.tabPage3.Controls.Add(this.combAvaliadoresDisp);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.lblStatus);
            this.tabPage3.Controls.Add(this.gridAvaliadoresProj);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.gridOrientadoresProj);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.gridAlunosParicipantesProj);
            this.tabPage3.Controls.Add(this.btnCarregar);
            this.tabPage3.Controls.Add(this.cbProjDisp);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(879, 519);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Atribuir Avaliadores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(516, 467);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // combAvaliadoresDisp
            // 
            this.combAvaliadoresDisp.FormattingEnabled = true;
            this.combAvaliadoresDisp.Location = new System.Drawing.Point(14, 469);
            this.combAvaliadoresDisp.Name = "combAvaliadoresDisp";
            this.combAvaliadoresDisp.Size = new System.Drawing.Size(392, 21);
            this.combAvaliadoresDisp.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Adicionar avaliador: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(697, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status: ";
            this.lblStatus.Click += new System.EventHandler(this.label7_Click);
            // 
            // gridAvaliadoresProj
            // 
            this.gridAvaliadoresProj.AllowUserToAddRows = false;
            this.gridAvaliadoresProj.AllowUserToDeleteRows = false;
            this.gridAvaliadoresProj.AllowUserToOrderColumns = true;
            this.gridAvaliadoresProj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAvaliadoresProj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeAval,
            this.EmailAval,
            this.StatusAval,
            this.AreaAval,
            this.FormacaoAval});
            this.gridAvaliadoresProj.Location = new System.Drawing.Point(12, 322);
            this.gridAvaliadoresProj.Name = "gridAvaliadoresProj";
            this.gridAvaliadoresProj.ReadOnly = true;
            this.gridAvaliadoresProj.Size = new System.Drawing.Size(836, 94);
            this.gridAvaliadoresProj.TabIndex = 8;
            this.gridAvaliadoresProj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Avaliadores";
            // 
            // gridOrientadoresProj
            // 
            this.gridOrientadoresProj.AllowUserToAddRows = false;
            this.gridOrientadoresProj.AllowUserToDeleteRows = false;
            this.gridOrientadoresProj.AllowUserToOrderColumns = true;
            this.gridOrientadoresProj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrientadoresProj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeOrient,
            this.EmailOrient,
            this.StatusOrien,
            this.DisciplinaOrient,
            this.DepartamentoOrient});
            this.gridOrientadoresProj.Location = new System.Drawing.Point(12, 217);
            this.gridOrientadoresProj.Name = "gridOrientadoresProj";
            this.gridOrientadoresProj.ReadOnly = true;
            this.gridOrientadoresProj.Size = new System.Drawing.Size(836, 54);
            this.gridOrientadoresProj.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Orientadores: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alunos Participantes: ";
            // 
            // gridAlunosParicipantesProj
            // 
            this.gridAlunosParicipantesProj.AllowUserToAddRows = false;
            this.gridAlunosParicipantesProj.AllowUserToDeleteRows = false;
            this.gridAlunosParicipantesProj.AllowUserToOrderColumns = true;
            this.gridAlunosParicipantesProj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlunosParicipantesProj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeAluno,
            this.EmailAluno,
            this.StatusAluno,
            this.CursoAluno,
            this.PeriodoAluno,
            this.CampusAluno});
            this.gridAlunosParicipantesProj.Location = new System.Drawing.Point(12, 77);
            this.gridAlunosParicipantesProj.Name = "gridAlunosParicipantesProj";
            this.gridAlunosParicipantesProj.ReadOnly = true;
            this.gridAlunosParicipantesProj.Size = new System.Drawing.Size(836, 94);
            this.gridAlunosParicipantesProj.TabIndex = 3;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(560, 14);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // cbProjDisp
            // 
            this.cbProjDisp.FormattingEnabled = true;
            this.cbProjDisp.Location = new System.Drawing.Point(135, 16);
            this.cbProjDisp.Name = "cbProjDisp";
            this.cbProjDisp.Size = new System.Drawing.Size(392, 21);
            this.cbProjDisp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Selecione o projeto : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(755, 551);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(127, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // NomeAluno
            // 
            this.NomeAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeAluno.HeaderText = "Nome";
            this.NomeAluno.Name = "NomeAluno";
            this.NomeAluno.ReadOnly = true;
            // 
            // EmailAluno
            // 
            this.EmailAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailAluno.HeaderText = "Email";
            this.EmailAluno.Name = "EmailAluno";
            this.EmailAluno.ReadOnly = true;
            // 
            // StatusAluno
            // 
            this.StatusAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusAluno.HeaderText = "Status";
            this.StatusAluno.Name = "StatusAluno";
            this.StatusAluno.ReadOnly = true;
            // 
            // CursoAluno
            // 
            this.CursoAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CursoAluno.HeaderText = "Curso";
            this.CursoAluno.Name = "CursoAluno";
            this.CursoAluno.ReadOnly = true;
            // 
            // PeriodoAluno
            // 
            this.PeriodoAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PeriodoAluno.HeaderText = "Periodo";
            this.PeriodoAluno.Name = "PeriodoAluno";
            this.PeriodoAluno.ReadOnly = true;
            // 
            // CampusAluno
            // 
            this.CampusAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CampusAluno.HeaderText = "Campus";
            this.CampusAluno.Name = "CampusAluno";
            this.CampusAluno.ReadOnly = true;
            // 
            // NomeOrient
            // 
            this.NomeOrient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeOrient.HeaderText = "Nome";
            this.NomeOrient.Name = "NomeOrient";
            this.NomeOrient.ReadOnly = true;
            // 
            // EmailOrient
            // 
            this.EmailOrient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailOrient.HeaderText = "Email";
            this.EmailOrient.Name = "EmailOrient";
            this.EmailOrient.ReadOnly = true;
            // 
            // StatusOrien
            // 
            this.StatusOrien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusOrien.HeaderText = "Status";
            this.StatusOrien.Name = "StatusOrien";
            this.StatusOrien.ReadOnly = true;
            // 
            // DisciplinaOrient
            // 
            this.DisciplinaOrient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DisciplinaOrient.HeaderText = "Disciplina Principal";
            this.DisciplinaOrient.Name = "DisciplinaOrient";
            this.DisciplinaOrient.ReadOnly = true;
            // 
            // DepartamentoOrient
            // 
            this.DepartamentoOrient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepartamentoOrient.HeaderText = "Departamento";
            this.DepartamentoOrient.Name = "DepartamentoOrient";
            this.DepartamentoOrient.ReadOnly = true;
            // 
            // NomeAval
            // 
            this.NomeAval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeAval.HeaderText = "Nome";
            this.NomeAval.Name = "NomeAval";
            this.NomeAval.ReadOnly = true;
            // 
            // EmailAval
            // 
            this.EmailAval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailAval.HeaderText = "Email";
            this.EmailAval.Name = "EmailAval";
            this.EmailAval.ReadOnly = true;
            // 
            // StatusAval
            // 
            this.StatusAval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusAval.HeaderText = "Status";
            this.StatusAval.Name = "StatusAval";
            this.StatusAval.ReadOnly = true;
            // 
            // AreaAval
            // 
            this.AreaAval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AreaAval.HeaderText = "Area Atuação";
            this.AreaAval.Name = "AreaAval";
            this.AreaAval.ReadOnly = true;
            // 
            // FormacaoAval
            // 
            this.FormacaoAval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FormacaoAval.HeaderText = "Formação";
            this.FormacaoAval.Name = "FormacaoAval";
            this.FormacaoAval.ReadOnly = true;
            // 
            // TelaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 586);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAvaliadoresProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrientadoresProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunosParicipantesProj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.Button btnAtivar2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridAvaliadoresProj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridOrientadoresProj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridAlunosParicipantesProj;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ComboBox cbProjDisp;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox combAvaliadoresDisp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CursoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CampusAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAval;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAval;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusAval;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaAval;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormacaoAval;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeOrient;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailOrient;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusOrien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisciplinaOrient;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartamentoOrient;
    }
}