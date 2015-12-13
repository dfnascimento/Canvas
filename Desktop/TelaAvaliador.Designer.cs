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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbDesativar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAvaliar.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAvaliar);
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
            this.txtNota.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.tabControl1.ResumeLayout(false);
            this.tabAvaliar.ResumeLayout(false);
            this.tabAvaliar.PerformLayout();
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
    }
}