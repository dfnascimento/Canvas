using Modelo.PN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Cadastro : Form
    {
        
        public Cadastro()
        {
            InitializeComponent();

            this.txtFormacao = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.lblFormacao = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
        }

        private void rbProfessor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProfessor.Checked)
            {

                // 
                // txtDepartamento
                // 
                this.txtDepartamento.Location = new System.Drawing.Point(114, 45);
                this.txtDepartamento.Name = "txtDepartamento";
                this.txtDepartamento.Size = new System.Drawing.Size(279, 20);
                this.txtDepartamento.TabIndex = 16;
                // 
                // txtDisciplina
                // 
                this.txtDisciplina.Location = new System.Drawing.Point(114, 9);
                this.txtDisciplina.Name = "txtDisciplina";
                this.txtDisciplina.Size = new System.Drawing.Size(279, 20);
                this.txtDisciplina.TabIndex = 15;
                // 
                // lblDepartamento
                // 
                this.lblDepartamento.AutoSize = true;
                this.lblDepartamento.Location = new System.Drawing.Point(9, 48);
                this.lblDepartamento.Name = "lblDepartamento";
                this.lblDepartamento.Size = new System.Drawing.Size(80, 13);
                this.lblDepartamento.TabIndex = 14;
                this.lblDepartamento.Text = "Departamento: ";
                // 
                // lblDisciplina
                // 
                this.lblDisciplina.AutoSize = true;
                this.lblDisciplina.Location = new System.Drawing.Point(9, 12);
                this.lblDisciplina.Name = "lblDisciplina";
                this.lblDisciplina.Size = new System.Drawing.Size(97, 13);
                this.lblDisciplina.TabIndex = 13;
                this.lblDisciplina.Text = "Disciplina principal:";


                this.panelDinamico.Controls.Add(this.txtDisciplina);
                this.panelDinamico.Controls.Add(this.txtDepartamento);
                this.panelDinamico.Controls.Add(this.lblDepartamento);
                this.panelDinamico.Controls.Add(this.lblDisciplina);


            }

            else
            {
                panelDinamico.Controls.Clear();
            }

        }

        private void rbAvaliador_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAvaliador.Checked)
            {
                // 
                // txtFormacao
                // 
                this.txtFormacao.Location = new System.Drawing.Point(114, 45);
                this.txtFormacao.Name = "txtFormacao";
                this.txtFormacao.Size = new System.Drawing.Size(279, 20);
                this.txtFormacao.TabIndex = 16;
                // 
                // txtArea
                // 
                this.txtArea.Location = new System.Drawing.Point(114, 9);
                this.txtArea.Name = "txtArea";
                this.txtArea.Size = new System.Drawing.Size(279, 20);
                this.txtArea.TabIndex = 15;
                // 
                // lblFormacao
                // 
                this.lblFormacao.AutoSize = true;
                this.lblFormacao.Location = new System.Drawing.Point(9, 48);
                this.lblFormacao.Name = "lblFormacao";
                this.lblFormacao.Size = new System.Drawing.Size(60, 13);
                this.lblFormacao.TabIndex = 14;
                this.lblFormacao.Text = "Formação: ";
                this.lblFormacao.Click += new System.EventHandler(this.label5_Click);
                // 
                // lblArea
                // 
                this.lblArea.AutoSize = true;
                this.lblArea.Location = new System.Drawing.Point(9, 12);
                this.lblArea.Name = "lblArea";
                this.lblArea.Size = new System.Drawing.Size(77, 13);
                this.lblArea.TabIndex = 13;
                this.lblArea.Text = "Area atuação: ";


                this.panelDinamico.Controls.Add(this.txtFormacao);
                this.panelDinamico.Controls.Add(this.txtArea);
                this.panelDinamico.Controls.Add(this.lblFormacao);
                this.panelDinamico.Controls.Add(this.lblArea);
            }

            else
            {
                panelDinamico.Controls.Clear();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") ||
                txtEmail.Text.Equals("") ||
                txtSenha.Text.Equals("") ||
                txtRepetirSenha.Text.Equals("") ||
                (rbAvaliador.Checked && txtArea.Text.Equals("")) ||
                (rbAvaliador.Checked && txtFormacao.Text.Equals("")) ||
                (rbProfessor.Checked && txtDisciplina.Text.Equals("")) ||
                (rbProfessor.Checked && txtDepartamento.Text.Equals("")))
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório.");
            }
            else if (!txtSenha.Text.Equals(txtRepetirSenha.Text))
            {
                MessageBox.Show("Campos de senha não conferem.");
                txtSenha.Text = "";
                txtRepetirSenha.Text = "";
            }
            else
            {
                if (rbAvaliador.Checked)
                {
                    PNAvaliadorExterno ae = new PNAvaliadorExterno();
                    ae.nome = txtNome.Text;
                    ae.email = txtEmail.Text;
                    ae.senha = txtSenha.Text;
                    ae.areaAtuacao = txtArea.Text;
                    ae.formacao = txtFormacao.Text;

                    if (CadastroUsuario.InserirAvaliadorExterno(ae))
                    {
                        MessageBox.Show("Cadastrado com sucesso");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro no cadastro: email já cadastrado");
                        this.txtEmail.Text = "";
                    }

                    

                }
                else if (rbProfessor.Checked) {
                    PNProfessor pr = new PNProfessor();
                    pr.nome = txtNome.Text;
                    pr.email = txtEmail.Text;
                    pr.senha = txtSenha.Text;
                    pr.departamento = txtDepartamento.Text;
                    pr.disciplinaPrincipal = txtDisciplina.Text;
                    

                    if (CadastroUsuario.InserirProfessor(pr))
                    {
                        MessageBox.Show("Cadastrado com sucesso");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro no cadastro: email já cadastrado");
                        this.txtEmail.Text = "";
                    }

                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panelDinamico_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
