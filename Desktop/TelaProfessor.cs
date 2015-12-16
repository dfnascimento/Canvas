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
    public partial class TelaProfessor : Form
    {
        public TelaProfessor()
        {
            InitializeComponent();


            this.Name = Acesso.acesso + " : " + Acesso.nome;

            populaProjetosDisponiveis();
        }


        public void populaProjetosDisponiveis()
        {
            List<String> list = Acesso.getProfessor().listarProjetosCom();

            this.cmbProjDisp.DataSource = list;
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

        private void projs(object sender, EventArgs e)
        {

            if (Acesso.getProfessor().listarProjetosCom().Count() == 0)
            {
                MessageBox.Show("Não existe nenhum projeto disponível associado ao seu usuário");
            }
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
                textBox2.Text = (dict[cmbQuadros.Text].resposta == null) ? " ": dict[cmbQuadros.Text].resposta;

                Dictionary<String, String> coment = pn.dictComentarios();
                txtComentario.Text = coment[cmbQuadros.Text].ToString();

            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbProjDisp.Text.Equals("") || cmbQuadros.Text.Equals(""))
            {
                MessageBox.Show("Um projeto precisa estar selecionado");
            }
            else if (txtComentario.Text.Equals(""))
            {
                MessageBox.Show("Digite uma comentario");
            }
            else
            {
                
                PNProjeto pn = CadastroProjeto.getProjeto(cmbProjDisp.Text);

               if (pn.addComentario(cmbQuadros.Text, txtComentario.Text))
               {
                        MessageBox.Show("Comentario atualizado com sucesso");
               }
                
            }
        }
    }
}
