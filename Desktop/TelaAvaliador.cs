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
    public partial class TelaAvaliador : Form
    {
        public TelaAvaliador()
        {
            InitializeComponent();

            this.Name = Acesso.acesso + " : " + Acesso.nome;

            populaProjetosDisponiveis();
        }

        public void populaProjetosDisponiveis() {
            List<String> list = Acesso.getAvaliador().listarProjetosDisp();

            this.cmbProjDisp.DataSource = list;
            this.combProjDisp.DataSource = list;
        }

       

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbDesativar.CheckState.Equals(CheckState.Checked))
            {

                Participante part = new Participante();

                part.Email = Acesso.email;

                if (CadastroUsuario.Inativar(part))
                {
                    MessageBox.Show("Usuário desativado com sucesso");
                    this.Close();
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
      

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbProjDisp_Click(object sender, EventArgs e)
        {
            if (Acesso.getAvaliador().listarProjetosDisp().Count() == 0)
            {
                MessageBox.Show("Não existe nenhum projeto disponível associado ao seu usuário");
            }
        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            if (cmbProjDisp.Text.Equals(""))
            {
                MessageBox.Show("Um projeto precisa estar selecionado");
            }
            else {
                PNProjeto pn = CadastroProjeto.getProjeto(cmbProjDisp.Text);

                populaQuadros(pn);
            }
        }

        public void populaQuadros(PNProjeto pn)
        {
            List<String> list = pn.getNomesQuadro();

            this.cmbQuadros.DataSource = list;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (cmbProjDisp.Text.Equals("") || cmbQuadros.Text.Equals(""))
            {
                MessageBox.Show("Um projeto precisa estar selecionado");
            }
            else {
                PNProjeto pn = CadastroProjeto.getProjeto(cmbProjDisp.Text);

                Dictionary<String, Quadro> dict = pn.dictionary();

                textBox1.Text = dict[cmbQuadros.Text].enunciado;
                textBox2.Text = dict[cmbQuadros.Text].resposta;

                Dictionary<String, int> notas = pn.dictNotas();
                txtNota.Text = notas[cmbQuadros.Text].ToString().Equals("-1") ? "" : notas[cmbQuadros.Text].ToString();

            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbProjDisp.Text.Equals("") || cmbQuadros.Text.Equals(""))
            {
                MessageBox.Show("Um projeto precisa estar selecionado");
            }
            else if (txtNota.Text.Equals(""))
            {
                MessageBox.Show("Digite uma nota");
            }
            else
            { 
                int nota = Convert.ToInt32(txtNota.Text);

                if (nota > 100 || nota < 0)
                {
                    MessageBox.Show("Nota deve estar no intervalo [0 ~ 100] ");
                    txtNota.Text = "";
                }
                else
                { 
                    PNProjeto pn = CadastroProjeto.getProjeto(cmbProjDisp.Text);

                    if (pn.addNota(cmbQuadros.Text, nota))
                    {
                        MessageBox.Show("Nota inserida com sucesso");
                    }
                }
            }

        }
        

        private void btnSelec_Click(object sender, EventArgs e)
        {
            if (combProjDisp.Text.Equals(""))
            {
                MessageBox.Show("Um projeto precisa estar selecionado");
            }
            else {
                PNProjeto pn = CadastroProjeto.getProjeto(cmbProjDisp.Text);
                Dictionary<String, int> notas = pn.dictNotas();

                lblNota1.Text = "I - Segmento de Clientes : " + (notas["I - Segmento de Clientes"].ToString().Equals("-1") ? "" : notas["I - Segmento de Clientes"].ToString());
                lblNota2.Text = "II - Proposta de Valor : " + (notas["II - Proposta de Valor"].ToString().Equals("-1") ? "" : notas["II - Proposta de Valor"].ToString());
                lblNota3.Text = "III - Canais : " + (notas["III - Canais (Distribuição e Comunicação)"].ToString().Equals("-1") ? "" : notas["III - Canais (Distribuição e Comunicação)"].ToString());
                lblNota4.Text = "IV - Relacionamento com clientes : " + (notas["IV - Relacionamento com clientes"].ToString().Equals("-1") ? "" : notas["IV - Relacionamento com clientes"].ToString());
                lblNota5.Text = "V - Receitas : " + (notas["V - Receitas"].ToString().Equals("-1") ? "" : notas["V - Receitas"].ToString());
                lblNota6.Text = "VI - Recursos Chave : " + (notas["VI - Recursos Chave"].ToString().Equals("-1") ? "" : notas["VI - Recursos Chave"].ToString());
                lblNota7.Text = "VII - Atividades Chave : " + (notas["VII - Atividades Chave"].ToString().Equals("-1") ? "" : notas["VII - Atividades Chave"].ToString());
                lblNota8.Text = "VIII - Parcerias Chave : " + (notas["VIII - Parcerias Chave"].ToString().Equals("-1") ? "" : notas["VIII - Parcerias Chave"].ToString());
                lblNota9.Text = "IX - Custos : " + (notas["IX - Custos"].ToString().Equals("-1") ? "" : notas["IX - Custos"].ToString());
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (combProjDisp.Text.Equals(""))
            {
                MessageBox.Show("Um projeto precisa estar selecionado");
            }
            else {
                PNProjeto pn = CadastroProjeto.getProjeto(combProjDisp.Text);

                if (!pn.isNotasPreenchidas())
                {
                    MessageBox.Show("Todas as notas devem estar preenchidas para finalizar avaliação");
                }
                else {
                    pn.finalizarAvaliacao();

                    txtMediaArit.Text = "Média artimética: " + Math.Ceiling(pn.getMediaAritimetica()).ToString();
                    txtMediaPond.Text = "Média ponderada: " + Math.Ceiling(pn.getMediaPonderada()).ToString();
                    txtStatus.Text = "Status : " + pn.status;

                    populaProjetosDisponiveis();
                }
            }
        }

        private void tabAvaliar_Click(object sender, EventArgs e)
        {

        }

        private void combProjDisp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbClick(object sender, EventArgs e)
        {
            if (Acesso.getAvaliador().listarProjetosDisp().Count() == 0)
            {
                MessageBox.Show("Não existe nenhum projeto disponível associado ao seu usuário");
            }
        }
    }
}
