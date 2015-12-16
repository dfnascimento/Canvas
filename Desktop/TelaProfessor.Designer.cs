using Modelo.PN;

namespace Desktop
{
    partial class TelaProfessor
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
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbDesativar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtComentario);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnConfirmar);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnSelecionar);
            this.tabPage1.Controls.Add(this.cmbQuadros);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnAvaliar);
            this.tabPage1.Controls.Add(this.cmbProjDisp);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comentar Projeto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(128, 293);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(733, 72);
            this.txtComentario.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Comentário: ";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(786, 381);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 192);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(733, 72);
            this.textBox2.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Resposta: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(733, 55);
            this.textBox1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Enunciado: ";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(786, 50);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 18;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // cmbQuadros
            // 
            this.cmbQuadros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuadros.FormattingEnabled = true;
            this.cmbQuadros.Location = new System.Drawing.Point(294, 50);
            this.cmbQuadros.Name = "cmbQuadros";
            this.cmbQuadros.Size = new System.Drawing.Size(405, 21);
            this.cmbQuadros.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quadro: ";
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.Location = new System.Drawing.Point(786, 7);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(75, 23);
            this.btnAvaliar.TabIndex = 15;
            this.btnAvaliar.Text = "Avaliar";
            this.btnAvaliar.UseVisualStyleBackColor = true;
            this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
            // 
            // cmbProjDisp
            // 
            this.cmbProjDisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjDisp.FormattingEnabled = true;
            this.cmbProjDisp.Location = new System.Drawing.Point(294, 4);
            this.cmbProjDisp.Name = "cmbProjDisp";
            this.cmbProjDisp.Size = new System.Drawing.Size(405, 21);
            this.cmbProjDisp.TabIndex = 14;
            this.cmbProjDisp.Click += new System.EventHandler(this.projs);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Projetos vinculados: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnOk);
            this.tabPage2.Controls.Add(this.cbDesativar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 423);
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
            this.btnLogout.Location = new System.Drawing.Point(832, 468);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // TelaProfessor
            // 
            this.ClientSize = new System.Drawing.Size(919, 503);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbDesativar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.ComboBox cmbQuadros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAvaliar;
        private System.Windows.Forms.ComboBox cmbProjDisp;
        private System.Windows.Forms.Label label2;
    }
}