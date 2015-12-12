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
    }
}
