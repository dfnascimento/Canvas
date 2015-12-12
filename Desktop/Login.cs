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
    public partial class Login : Form
    {
        //UserManager<IdentityUser> _userManager;

        public Login()
        {
            InitializeComponent();

            //_userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityDbContext()));
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Canvas_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var ret = Acesso.logar(txtUsuario.Text, txtSenha.Text);

            if (!ret.Equals("Sucesso"))
            {
                MessageBox.Show("Erro ao logar: " + ret);
                this.txtUsuario.Text = "";
                this.txtSenha.Text = "";
            }
            else {
                var formLogado = new Form();
                if (Acesso.acesso.Equals("Admin"))
                {
                    formLogado = new TelaAdmin();
                }
                else if (Acesso.acesso.Equals("Professor"))
                {
                    formLogado = new TelaProfessor();
                }
                else if (Acesso.acesso.Equals("Avaliador")) {
                    formLogado = new TelaAvaliador();
                }

                this.Hide();
                formLogado.ShowDialog();
                this.Show();
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            var cadastrar = new Cadastro();
            this.Hide();
            cadastrar.ShowDialog();
            this.Show();
        }
    }
}
