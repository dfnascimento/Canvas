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
            populaComboBoxProjetosAv();
        }

        private void populaComboBoxProjetosAv() {

            List<String> list = CadastroProjeto.listarProjetosDisp();

            this.cbProjDisp.DataSource = list;

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (this.cbProjDisp.Text.Equals(""))
            {
                MessageBox.Show("Selecione um Projeto");
            }
            else {
                PNProjeto proj = CadastroProjeto.getProjeto(cbProjDisp.Text);

                this.lblStatus.Text = "Status : " + proj.status;
                populaGridAlunosProjeto(proj);
                populaGridOrientadorProjeto(proj);
                populaGridAvaliadorProjeto(proj);
                popularListBoxAvaliadores(proj);
            }
        }

        private void populaGridAlunosProjeto(PNProjeto proj)
        {

            this.gridAlunosParicipantesProj.Rows.Clear();

            List<PNAluno> list = proj.ListMembros();

            string[] linha = new string[6];

            foreach (var value in list)
            {

                linha[0] = value.nome;
                linha[1] = value.email;
                linha[2] = value.status;
                linha[3] = value.curso;
                linha[4] = value.periodo.ToString();
                linha[5] = value.campus;

                this.gridAlunosParicipantesProj.Rows.Add(linha);
            }
        }

        private void populaGridOrientadorProjeto(PNProjeto proj)
        {

            this.gridOrientadoresProj.Rows.Clear();

            List<PNProfessor> list = proj.ListOrientadores();

            string[] linha = new string[5];

            foreach (var value in list)
            {

                linha[0] = value.nome;
                linha[1] = value.email;
                linha[2] = value.status;
                linha[3] = value.disciplinaPrincipal;
                linha[4] = value.departamento;

                this.gridOrientadoresProj.Rows.Add(linha);
            }
        }

        private void populaGridAvaliadorProjeto(PNProjeto proj)
        {

            this.gridAvaliadoresProj.Rows.Clear();

            List<PNAvaliadorExterno> list = proj.ListAvaliadores();

            string[] linha = new string[5];

            foreach (var value in list)
            {

                linha[0] = value.nome;
                linha[1] = value.email;
                linha[2] = value.status;
                linha[3] = value.areaAtuacao;
                linha[4] = value.formacao;

                this.gridAvaliadoresProj.Rows.Add(linha);
            }
        }



        public void popularListBoxAvaliadores(PNProjeto proj)
        {
            List<String> list = proj.getAvaliadoresDisp();

            this.combAvaliadoresDisp.DataSource = list;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            PNProjeto proj = CadastroProjeto.getProjeto(cbProjDisp.Text);

            if (proj.addAvaliador(CadastroProjeto.getAvaliador(combAvaliadoresDisp.Text))) {
                MessageBox.Show(combAvaliadoresDisp.Text + " adicionado com sucesso!");
                this.lblStatus.Text = "Status : " + proj.status;
                populaGridAvaliadorProjeto(proj);
                popularListBoxAvaliadores(proj);
            }


        }
    }
}
