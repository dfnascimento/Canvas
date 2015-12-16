using Modelo.PN;
using System.Windows.Forms;

namespace Desktop
{
    partial class TelaAvaliador
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
            this.tabAvaliar = new System.Windows.Forms.TabPage();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.cmbQuadros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAvaliar = new System.Windows.Forms.Button();
            this.cmbProjDisp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.Label();
            this.txtMediaPond = new System.Windows.Forms.Label();
            this.txtMediaArit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNota9 = new System.Windows.Forms.Label();
            this.lblNota8 = new System.Windows.Forms.Label();
            this.lblNota7 = new System.Windows.Forms.Label();
            this.lblNota5 = new System.Windows.Forms.Label();
            this.lblNota6 = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.btnSelec = new System.Windows.Forms.Button();
            this.combProjDisp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbDesativar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAvaliar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAvaliar);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 463);
            this.tabControl1.TabIndex = 1;
            // 
            // tabAvaliar
            // 
            this.tabAvaliar.Controls.Add(this.btnConfirmar);
            this.tabAvaliar.Controls.Add(this.txtNota);
            this.tabAvaliar.Controls.Add(this.label6);
            this.tabAvaliar.Controls.Add(this.textBox2);
            this.tabAvaliar.Controls.Add(this.label5);
            this.tabAvaliar.Controls.Add(this.textBox1);
            this.tabAvaliar.Controls.Add(this.label4);
            this.tabAvaliar.Controls.Add(this.btnSelecionar);
            this.tabAvaliar.Controls.Add(this.cmbQuadros);
            this.tabAvaliar.Controls.Add(this.label3);
            this.tabAvaliar.Controls.Add(this.btnAvaliar);
            this.tabAvaliar.Controls.Add(this.cmbProjDisp);
            this.tabAvaliar.Controls.Add(this.label2);
            this.tabAvaliar.Location = new System.Drawing.Point(4, 22);
            this.tabAvaliar.Name = "tabAvaliar";
            this.tabAvaliar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAvaliar.Size = new System.Drawing.Size(885, 437);
            this.tabAvaliar.TabIndex = 0;
            this.tabAvaliar.Text = "Avaliar Projeto";
            this.tabAvaliar.UseVisualStyleBackColor = true;
            this.tabAvaliar.Click += new System.EventHandler(this.tabAvaliar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(532, 392);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(395, 394);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 11;
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nota: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 229);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(733, 134);
            this.textBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resposta: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(733, 83);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enunciado: ";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(779, 59);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 5;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // cmbQuadros
            // 
            this.cmbQuadros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuadros.FormattingEnabled = true;
            this.cmbQuadros.Location = new System.Drawing.Point(287, 59);
            this.cmbQuadros.Name = "cmbQuadros";
            this.cmbQuadros.Size = new System.Drawing.Size(405, 21);
            this.cmbQuadros.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quadro: ";
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.Location = new System.Drawing.Point(779, 16);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(75, 23);
            this.btnAvaliar.TabIndex = 2;
            this.btnAvaliar.Text = "Avaliar";
            this.btnAvaliar.UseVisualStyleBackColor = true;
            this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
            // 
            // cmbProjDisp
            // 
            this.cmbProjDisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjDisp.FormattingEnabled = true;
            this.cmbProjDisp.Location = new System.Drawing.Point(287, 13);
            this.cmbProjDisp.Name = "cmbProjDisp";
            this.cmbProjDisp.Size = new System.Drawing.Size(405, 21);
            this.cmbProjDisp.TabIndex = 1;
            this.cmbProjDisp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbProjDisp.Click += new System.EventHandler(this.cmbProjDisp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Projetos disponíveis para avaliação: ";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnSelec);
            this.tabPage1.Controls.Add(this.combProjDisp);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnFinalizar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 437);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Finalizar Avaliação";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Notas finais: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Revisão de notas: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel2.Controls.Add(this.txtStatus);
            this.panel2.Controls.Add(this.txtMediaPond);
            this.panel2.Controls.Add(this.txtMediaArit);
            this.panel2.Location = new System.Drawing.Point(74, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 105);
            this.panel2.TabIndex = 20;
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(439, 51);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 20);
            this.txtStatus.TabIndex = 15;
            // 
            // txtMediaPond
            // 
            this.txtMediaPond.AutoSize = true;
            this.txtMediaPond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaPond.Location = new System.Drawing.Point(248, 51);
            this.txtMediaPond.Name = "txtMediaPond";
            this.txtMediaPond.Size = new System.Drawing.Size(0, 20);
            this.txtMediaPond.TabIndex = 14;
            // 
            // txtMediaArit
            // 
            this.txtMediaArit.AutoSize = true;
            this.txtMediaArit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaArit.Location = new System.Drawing.Point(41, 51);
            this.txtMediaArit.Name = "txtMediaArit";
            this.txtMediaArit.Size = new System.Drawing.Size(0, 20);
            this.txtMediaArit.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lblNota9);
            this.panel1.Controls.Add(this.lblNota8);
            this.panel1.Controls.Add(this.lblNota7);
            this.panel1.Controls.Add(this.lblNota5);
            this.panel1.Controls.Add(this.lblNota6);
            this.panel1.Controls.Add(this.lblNota4);
            this.panel1.Controls.Add(this.lblNota3);
            this.panel1.Controls.Add(this.lblNota2);
            this.panel1.Controls.Add(this.lblNota1);
            this.panel1.Location = new System.Drawing.Point(52, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 120);
            this.panel1.TabIndex = 19;
            // 
            // lblNota9
            // 
            this.lblNota9.AutoSize = true;
            this.lblNota9.Location = new System.Drawing.Point(426, 98);
            this.lblNota9.Name = "lblNota9";
            this.lblNota9.Size = new System.Drawing.Size(0, 13);
            this.lblNota9.TabIndex = 11;
            // 
            // lblNota8
            // 
            this.lblNota8.AutoSize = true;
            this.lblNota8.Location = new System.Drawing.Point(426, 55);
            this.lblNota8.Name = "lblNota8";
            this.lblNota8.Size = new System.Drawing.Size(0, 13);
            this.lblNota8.TabIndex = 10;
            // 
            // lblNota7
            // 
            this.lblNota7.AutoSize = true;
            this.lblNota7.Location = new System.Drawing.Point(426, 12);
            this.lblNota7.Name = "lblNota7";
            this.lblNota7.Size = new System.Drawing.Size(0, 13);
            this.lblNota7.TabIndex = 9;
            // 
            // lblNota5
            // 
            this.lblNota5.AutoSize = true;
            this.lblNota5.Location = new System.Drawing.Point(222, 55);
            this.lblNota5.Name = "lblNota5";
            this.lblNota5.Size = new System.Drawing.Size(0, 13);
            this.lblNota5.TabIndex = 8;
            // 
            // lblNota6
            // 
            this.lblNota6.AutoSize = true;
            this.lblNota6.Location = new System.Drawing.Point(222, 98);
            this.lblNota6.Name = "lblNota6";
            this.lblNota6.Size = new System.Drawing.Size(0, 13);
            this.lblNota6.TabIndex = 7;
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(222, 12);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(0, 13);
            this.lblNota4.TabIndex = 6;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(19, 98);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(0, 13);
            this.lblNota3.TabIndex = 5;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(19, 55);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(0, 13);
            this.lblNota2.TabIndex = 4;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(19, 12);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(0, 13);
            this.lblNota1.TabIndex = 3;
            // 
            // btnSelec
            // 
            this.btnSelec.Location = new System.Drawing.Point(778, 26);
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(75, 23);
            this.btnSelec.TabIndex = 18;
            this.btnSelec.Text = "Selecionar";
            this.btnSelec.UseVisualStyleBackColor = true;
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // combProjDisp
            // 
            this.combProjDisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combProjDisp.FormattingEnabled = true;
            this.combProjDisp.Location = new System.Drawing.Point(286, 23);
            this.combProjDisp.Name = "combProjDisp";
            this.combProjDisp.Size = new System.Drawing.Size(405, 21);
            this.combProjDisp.TabIndex = 17;
            this.combProjDisp.SelectedIndexChanged += new System.EventHandler(this.combProjDisp_SelectedIndexChanged);
            this.combProjDisp.Click += new System.EventHandler(this.cmbClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Projetos disponíveis para avaliação: ";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(778, 191);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 12;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnOk);
            this.tabPage2.Controls.Add(this.cbDesativar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(885, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configurações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(19, 103);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbDesativar
            // 
            this.cbDesativar.AutoSize = true;
            this.cbDesativar.Location = new System.Drawing.Point(25, 55);
            this.cbDesativar.Name = "cbDesativar";
            this.cbDesativar.Size = new System.Drawing.Size(175, 17);
            this.cbDesativar.TabIndex = 1;
            this.cbDesativar.Text = "Desejo desativar meu cadastro.";
            this.cbDesativar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desativar cadastro: ";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(832, 482);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // TelaAvaliador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 517);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaAvaliador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avaliador Externo";
            this.tabControl1.ResumeLayout(false);
            this.tabAvaliar.ResumeLayout(false);
            this.tabAvaliar.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAvaliar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox cbDesativar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.ComboBox cmbQuadros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAvaliar;
        private System.Windows.Forms.ComboBox cmbProjDisp;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private TabPage tabPage1;
        private Button btnSelec;
        private ComboBox combProjDisp;
        private Label label7;
        private Label txtStatus;
        private Label txtMediaPond;
        private Label txtMediaArit;
        private Button btnFinalizar;
        private Label lblNota9;
        private Label lblNota8;
        private Label lblNota7;
        private Label lblNota5;
        private Label lblNota6;
        private Label lblNota4;
        private Label lblNota3;
        private Label lblNota2;
        private Label lblNota1;
        private Label label9;
        private Label label8;
        private Panel panel2;
        private Panel panel1;
    }
}