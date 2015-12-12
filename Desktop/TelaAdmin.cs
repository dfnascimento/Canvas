using Modelo.DAO;
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
    public partial class TelaAdmin : Form
    {
        public TelaAdmin()
        {
            InitializeComponent();


            this.Name = Acesso.acesso + " : " + Acesso.nome;

            populaGridProfessor();
            populaGridAvaliador();
        }

        private void populaGridProfessor() {

            this.dataGridView1.Rows.Clear();

            List<PNProfessor> list = CadastroUsuario.ListaProfessoresInativos();

            string[] linha = new string[4];

            foreach(var value in list) {
                
                linha[0] = value.nome;
                linha[1] = value.email;
                linha[2] = value.disciplinaPrincipal;
                linha[3] = value.departamento;

                this.dataGridView1.Rows.Add(linha);
            }
        }

        private void populaGridAvaliador()
        {

            this.dataGridView2.Rows.Clear();

            List<PNAvaliadorExterno> list = CadastroUsuario.ListaAvaliadoresExternosInativos();

            string[] linha = new string[4];

            foreach (var value in list)
            {

                linha[0] = value.nome;
                linha[1] = value.email;
                linha[2] = value.areaAtuacao;
                linha[3] = value.formacao;

                this.dataGridView2.Rows.Add(linha);
            }
        }

        private void btnAtivar_Click_1(object sender, EventArgs e)
        {
            var cont = 0;
            foreach (DataGridViewRow dr in this.dataGridView1.Rows)
            {

                if (dr.Selected)
                {
                    cont++;

                    Participante p = new Participante();
                    p.Nome = dr.Cells[0].Value.ToString();
                    p.Email = dr.Cells[1].Value.ToString();

                    if(CadastroUsuario.Ativar(p))
                    {
                        MessageBox.Show("Usuário " + p.Nome + " ativado com sucesso.");
                        this.populaGridProfessor();
                    }
                    
               }
            }

            if (cont == 0)
            {
                MessageBox.Show("Selecione pelo menos um Usuário");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cont = 0;
            foreach (DataGridViewRow dr in this.dataGridView2.Rows)
            {

                if (dr.Selected)
                {
                    cont++;
                    Participante p = new Participante();
                    p.Nome = dr.Cells[0].Value.ToString();
                    p.Email = dr.Cells[1].Value.ToString();

                    if (CadastroUsuario.Ativar(p))
                    {
                        MessageBox.Show("Usuário " + p.Nome + " ativado com sucesso.");
                        this.populaGridAvaliador();
                    }

                }
            }
            if (cont == 0)
            {
                MessageBox.Show("Selecione pelo menos um Usuário");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
