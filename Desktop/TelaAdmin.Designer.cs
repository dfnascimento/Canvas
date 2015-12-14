
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
            this.NomeAval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusAval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaAval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormacaoAval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.gridOrientadoresProj = new System.Windows.Forms.DataGridView();
            this.NomeOrient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailOrient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusOrien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisciplinaOrient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartamentoOrient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridAlunosParicipantesProj = new System.Windows.Forms.DataGridView();
            this.NomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CursoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampusAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.cbProjDisp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNota6 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNota7 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNota8 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtNota5 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtNota9 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSelec = new System.Windows.Forms.Button();
            this.combProjDisp = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.NomeAv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaAv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MediaPond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAvaliadoresProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrientadoresProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunosParicipantesProj)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 545);
            this.tabControl1.TabIndex = 1;
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
            this.combAvaliadoresDisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbProjDisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjDisp.FormattingEnabled = true;
            this.cbProjDisp.Location = new System.Drawing.Point(135, 16);
            this.cbProjDisp.Name = "cbProjDisp";
            this.cbProjDisp.Size = new System.Drawing.Size(392, 21);
            this.cbProjDisp.TabIndex = 1;
            this.cbProjDisp.Click += new System.EventHandler(this.combProjEmAva);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Selecione o projeto : ";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnConfirmar);
            this.tabPage5.Controls.Add(this.tableLayoutPanel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(879, 519);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Gerenciamento de Pesos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(732, 490);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(129, 23);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 427);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(803, 278);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.txtNota1);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(643, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 272);
            this.panel3.TabIndex = 4;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(104, 248);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(47, 20);
            this.txtNota1.TabIndex = 0;
            this.txtNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberKeyPress);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(57, 251);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 13);
            this.label32.TabIndex = 4;
            this.label32.Text = "Peso: ";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(21, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 81);
            this.label19.TabIndex = 3;
            this.label19.Text = "Para quem criamos valor?                                                      Qua" +
    "is são nossos clientes mais importantes?";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 49);
            this.label10.TabIndex = 2;
            this.label10.Text = "I) Segmento de Clientes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.txtNota2);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(323, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 272);
            this.panel2.TabIndex = 3;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(102, 249);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(47, 20);
            this.txtNota2.TabIndex = 0;
            this.txtNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberKeyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(60, 252);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(37, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "Peso: ";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(23, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 94);
            this.label18.TabIndex = 2;
            this.label18.Text = "Que valor proporcionou a nossos clientes?                                  Que pr" +
    "oblemas de nossos clientes estão solucionados? ";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 49);
            this.label9.TabIndex = 1;
            this.label9.Text = "II) Proposta de Valor";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(163, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(154, 272);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.txtNota6);
            this.panel5.Controls.Add(this.label28);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(3, 139);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(148, 130);
            this.panel5.TabIndex = 1;
            // 
            // txtNota6
            // 
            this.txtNota6.Location = new System.Drawing.Point(98, 106);
            this.txtNota6.Name = "txtNota6";
            this.txtNota6.Size = new System.Drawing.Size(47, 20);
            this.txtNota6.TabIndex = 0;
            this.txtNota6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberKeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(51, 109);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(37, 13);
            this.label28.TabIndex = 6;
            this.label28.Text = "Peso: ";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(4, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(131, 57);
            this.label21.TabIndex = 5;
            this.label21.Text = "Que recursos físicos, humanos, intelectuais ou econômicos são essenciais?";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 52);
            this.label14.TabIndex = 4;
            this.label14.Text = "VI) Recursos Chave";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.txtNota7);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 130);
            this.panel4.TabIndex = 0;
            // 
            // txtNota7
            // 
            this.txtNota7.Location = new System.Drawing.Point(98, 107);
            this.txtNota7.Name = "txtNota7";
            this.txtNota7.Size = new System.Drawing.Size(47, 20);
            this.txtNota7.TabIndex = 0;
            this.txtNota7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberKeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(51, 110);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 13);
            this.label27.TabIndex = 5;
            this.label27.Text = "Peso: ";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(21, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 34);
            this.label20.TabIndex = 4;
            this.label20.Text = "O que devemos Saber e fazer?";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 49);
            this.label13.TabIndex = 1;
            this.label13.Text = "VII) Atividades Chave";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(483, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(154, 272);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Controls.Add(this.txtNota3);
            this.panel7.Controls.Add(this.label31);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Location = new System.Drawing.Point(3, 139);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(148, 130);
            this.panel7.TabIndex = 2;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(98, 106);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(47, 20);
            this.txtNota3.TabIndex = 0;
            this.txtNota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberKeyPress);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(51, 109);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 13);
            this.label31.TabIndex = 8;
            this.label31.Text = "Peso: ";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(4, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(141, 76);
            this.label23.TabIndex = 7;
            this.label23.Text = "Que meios preferem utilizar nosso segmento de mercado?                        Com" +
    "o estabelecer contato com os clientes?";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 32);
            this.label16.TabIndex = 6;
            this.label16.Text = "III) Canais";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Controls.Add(this.txtNota4);
            this.panel6.Controls.Add(this.label30);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(148, 130);
            this.panel6.TabIndex = 1;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(98, 107);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(47, 20);
            this.txtNota4.TabIndex = 0;
            this.txtNota4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberKeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(51, 110);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 13);
            this.label30.TabIndex = 7;
            this.label30.Text = "Peso: ";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(4, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(146, 70);
            this.label22.TabIndex = 6;
            this.label22.Text = "Que tipo de relacionamento que cada segmento de cliente espera ter para estabelec" +
    "er e manter sua preferencia?";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 49);
            this.label15.TabIndex = 5;
            this.label15.Text = "IV) Relacionamento com clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.txtNota8);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 272);
            this.panel1.TabIndex = 0;
            // 
            // txtNota8
            // 
            this.txtNota8.Location = new System.Drawing.Point(104, 249);
            this.txtNota8.Name = "txtNota8";
            this.txtNota8.Size = new System.Drawing.Size(47, 20);
            this.txtNota8.TabIndex = 1;
            this.txtNota8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberKeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(57, 252);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Peso: ";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(16, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 61);
            this.label17.TabIndex = 1;
            this.label17.Text = "Quem são nossos parceiros e provedores fundamentais?";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 49);
            this.label8.TabIndex = 0;
            this.label8.Text = "VIII) Parcerias Chave";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel9, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 287);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(803, 137);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkGray;
            this.panel9.Controls.Add(this.txtNota5);
            this.panel9.Controls.Add(this.label34);
            this.panel9.Controls.Add(this.label25);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(404, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(395, 131);
            this.panel9.TabIndex = 1;
            // 
            // txtNota5
            // 
            this.txtNota5.Location = new System.Drawing.Point(343, 108);
            this.txtNota5.Name = "txtNota5";
            this.txtNota5.Size = new System.Drawing.Size(47, 20);
            this.txtNota5.TabIndex = 0;
            this.txtNota5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberKeyPress);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(296, 111);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(37, 13);
            this.label34.TabIndex = 4;
            this.label34.Text = "Peso: ";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(23, 38);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(339, 50);
            this.label25.TabIndex = 3;
            this.label25.Text = "Por que valor os nossos clientes realmente estão dispostos a pagar?              " +
    "                                                                                " +
    "             Como gostariam de pagar?";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "V) Receitas";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Controls.Add(this.txtNota9);
            this.panel8.Controls.Add(this.label33);
            this.panel8.Controls.Add(this.label24);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(395, 131);
            this.panel8.TabIndex = 0;
            // 
            // txtNota9
            // 
            this.txtNota9.Location = new System.Drawing.Point(345, 108);
            this.txtNota9.Name = "txtNota9";
            this.txtNota9.Size = new System.Drawing.Size(47, 20);
            this.txtNota9.TabIndex = 0;
            this.txtNota9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberKeyPress);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(298, 111);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(37, 13);
            this.label33.TabIndex = 6;
            this.label33.Text = "Peso: ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(44, 55);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(297, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Quais são os custos mais importantes do modelo de negocio?";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "IX) Custos";
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
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(18, 100);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(118, 13);
            this.label36.TabIndex = 3;
            this.label36.Text = "Notas dos avaliadores: ";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeAv,
            this.mediaAv,
            this.MediaPond});
            this.dataGridView3.Location = new System.Drawing.Point(71, 136);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(724, 150);
            this.dataGridView3.TabIndex = 4;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(119, 354);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(41, 13);
            this.label37.TabIndex = 5;
            this.label37.Text = "label37";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(120, 400);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(41, 13);
            this.label38.TabIndex = 6;
            this.label38.Text = "label38";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Confirmar Status";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(615, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Encerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnSelec);
            this.tabPage4.Controls.Add(this.combProjDisp);
            this.tabPage4.Controls.Add(this.label39);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.label38);
            this.tabPage4.Controls.Add(this.label37);
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Controls.Add(this.label36);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(879, 519);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Acompanhar Projeto";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnSelec
            // 
            this.btnSelec.Location = new System.Drawing.Point(778, 23);
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(75, 23);
            this.btnSelec.TabIndex = 21;
            this.btnSelec.Text = "Selecionar";
            this.btnSelec.UseVisualStyleBackColor = true;
            // 
            // combProjDisp
            // 
            this.combProjDisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combProjDisp.FormattingEnabled = true;
            this.combProjDisp.Location = new System.Drawing.Point(286, 20);
            this.combProjDisp.Name = "combProjDisp";
            this.combProjDisp.Size = new System.Drawing.Size(405, 21);
            this.combProjDisp.TabIndex = 20;
            this.combProjDisp.Click += new System.EventHandler(this.clickComb);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(18, 23);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(177, 13);
            this.label39.TabIndex = 19;
            this.label39.Text = "Projetos com avaliação encerrada:  ";
            // 
            // NomeAv
            // 
            this.NomeAv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeAv.HeaderText = "Nome";
            this.NomeAv.Name = "NomeAv";
            this.NomeAv.ReadOnly = true;
            // 
            // mediaAv
            // 
            this.mediaAv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mediaAv.HeaderText = "Média Aritimética";
            this.mediaAv.Name = "mediaAv";
            this.mediaAv.ReadOnly = true;
            // 
            // MediaPond
            // 
            this.MediaPond.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MediaPond.HeaderText = "Média Ponderada";
            this.MediaPond.Name = "MediaPond";
            this.MediaPond.ReadOnly = true;
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
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtNota8;
        private System.Windows.Forms.TextBox txtNota7;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtNota6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtNota9;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtNota5;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSelec;
        private System.Windows.Forms.ComboBox combProjDisp;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaAv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MediaPond;
    }
}