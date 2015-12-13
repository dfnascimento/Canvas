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
        }


        private void label1_Click(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {

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
            PNProjeto pn = CadastroProjeto.getProjeto(cmbProjDisp.Text);

            populaQuadros(pn);
        }

        public void populaQuadros(PNProjeto pn)
        {
            List<String> list = pn.getNomesQuadro();

            this.cmbQuadros.DataSource = list;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            PNProjeto pn = CadastroProjeto.getProjeto(cmbProjDisp.Text);

            Dictionary<String, Quadro> dict = pn.dictionary();

            textBox1.Text = dict[cmbQuadros.Text].enunciado;
            textBox2.Text = dict[cmbQuadros.Text].resposta;

            Dictionary<String, int> notas = pn.dictNotas();
            txtNota.Text = notas[cmbQuadros.Text].ToString().Equals("-1") ? "" : notas[cmbQuadros.Text].ToString();


        }

        private void btnConfirmar_Click(object sender, EventArgs e)
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
}
