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
            populaComboBoxProjetosDispAv();
            populaPesos();
        }

        private void populaPesos() {
            Peso p = PNPeso.getPeso();

            txtNota1.Text = p.Peso_Quadro_1.ToString();
            txtNota2.Text = p.Peso_Quadro_2.ToString();
            txtNota3.Text = p.Peso_Quadro_3.ToString();
            txtNota4.Text = p.Peso_Quadro_4.ToString();
            txtNota5.Text = p.Peso_Quadro_5.ToString();
            txtNota6.Text = p.Peso_Quadro_6.ToString();
            txtNota7.Text = p.Peso_Quadro_7.ToString();
            txtNota8.Text = p.Peso_Quadro_8.ToString();
            txtNota9.Text = p.Peso_Quadro_9.ToString();


        }

        private void populaComboBoxProjetosAv() {

            List<String> list = CadastroProjeto.listarProjetosDisp();

            this.cbProjDisp.DataSource = list;

        }




        private void populaComboBoxProjetosDispAv()
        {
            List<String> list = CadastroProjeto.listarProjetosAvaliacaoEncerrada();
            this.combProjDisp.DataSource = list;
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
        

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNota1.Text.Equals("") ||
                txtNota2.Text.Equals("") ||
                txtNota3.Text.Equals("") ||
                txtNota4.Text.Equals("") ||
                txtNota5.Text.Equals("") ||
                txtNota6.Text.Equals("") ||
                txtNota7.Text.Equals("") ||
                txtNota8.Text.Equals("") ||
                txtNota9.Text.Equals(""))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }

            else if (Convert.ToInt32(txtNota1.Text) > 10 ||
                Convert.ToInt32(txtNota2.Text) > 10 ||
                Convert.ToInt32(txtNota3.Text) > 10 ||
                Convert.ToInt32(txtNota4.Text) > 10 ||
                Convert.ToInt32(txtNota5.Text) > 10 ||
                Convert.ToInt32(txtNota6.Text) > 10 ||
                Convert.ToInt32(txtNota7.Text) > 10 ||
                Convert.ToInt32(txtNota8.Text) > 10 ||
                Convert.ToInt32(txtNota9.Text) > 10)
            {
                MessageBox.Show("Intervalo de valores perimitido: [0 ~ 10]");
            }
            else
            {
                Peso p = new Peso();
                p.Peso_Quadro_1 = Convert.ToInt32(txtNota1.Text);
                p.Peso_Quadro_2 = Convert.ToInt32(txtNota2.Text);
                p.Peso_Quadro_3 = Convert.ToInt32(txtNota3.Text);
                p.Peso_Quadro_4 = Convert.ToInt32(txtNota4.Text);
                p.Peso_Quadro_5 = Convert.ToInt32(txtNota5.Text);
                p.Peso_Quadro_6 = Convert.ToInt32(txtNota6.Text);
                p.Peso_Quadro_7 = Convert.ToInt32(txtNota7.Text);
                p.Peso_Quadro_8 = Convert.ToInt32(txtNota8.Text);
                p.Peso_Quadro_9 = Convert.ToInt32(txtNota9.Text);

                if (PNPeso.setPeso(p))
                {
                    MessageBox.Show("Pesos atualizados com sucesso");
                }
            }
        }
        
        private void numberKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.combProjDisp.Text.Equals(""))
            {
                MessageBox.Show("Selecione um projeto");
            }
            else
            {
                PNProjeto proj = CadastroProjeto.getProjeto(combProjDisp.Text);

                if (proj.finaliza())
                {

                    MessageBox.Show("Projeto encerrado");
                }

            }
        }

        private void clickComb(object sender, EventArgs e)
        {
            if (CadastroProjeto.listarProjetosAvaliacaoEncerrada().Count() == 0) {
                MessageBox.Show("Nenhum projeto com avaliação encerrada disponível");
            }
        }

        private void combProjEmAva(object sender, EventArgs e)
        {
            if (CadastroProjeto.listarProjetosDisp().Count() == 0)
            {
                MessageBox.Show("Nenhum projeto com disponível para atribuir avaliador");
            }
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            if (this.combProjDisp.Text.Equals(""))
            {
                MessageBox.Show("Selecione um projeto");
            }
            else
            {
                PNProjeto proj = CadastroProjeto.getProjeto(combProjDisp.Text);

                populaGridNotas(proj);

                lblNota.Text = "Média final : " + proj.getMediaPondProj().ToString();
                lblSta.Text = "Status : " + proj.getStatusFinal();
            }
        }

        private void populaGridNotas(PNProjeto proj) {
            this.dataGridView3.Rows.Clear();

            List<DadosAvaliacao> list = proj.getDadosAvaliacao();

            string[] linha = new string[3];

            foreach (var value in list)
            {

                linha[0] = value.nomeAvaliador;
                linha[1] = value.mediaAritimetica.ToString();
                linha[2] = value.mediaPonderada.ToString();

                this.dataGridView3.Rows.Add(linha);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.combProjDisp.Text.Equals(""))
            {
                MessageBox.Show("Selecione um projeto");
            }
            else
            {
                PNProjeto proj = CadastroProjeto.getProjeto(combProjDisp.Text);

                if (proj.confirmaStatua()) {
                    MessageBox.Show("Status confimado");
                }
                
            }
        }
    }
}
