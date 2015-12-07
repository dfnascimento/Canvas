using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Modelo.DAO;
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
    public partial class Canvas : Form
    {
        //UserManager<IdentityUser> _userManager;

        public Canvas()
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
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Informe o login e a senha.");
                return;
            }
            try
            {
                Participante usuario = new Participante();
                usuario.Email = txtUsuario.Text;
                usuario.Senha = System.Text.Encoding.Default.GetBytes(txtSenha.Text);
                //string cifra = Cifrar(txtSenha.Text);
                //usuario.UsuarioSenha = dal.Cifrar(txtSenha.Text);
                if (UsuarioDAL.GetUsuarioPorLoginSenha(usuario) != null)
                {
                    MessageBox.Show("BemVindo");
                }
                else
                {
                    MessageBox.Show("Erro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }

            var user = _userManager.Find(txtUsuario.Text, txtSenha.Text);

            if (user != null)
            {
                MessageBox.Show("Usuário autenticado!");
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválidos!");
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            var result = _userManager.Create(new IdentityUser(txtUsuario.Text), txtSenha.Text);

            if (result.Succeeded)
            {
                MessageBox.Show("Usuário criado com sucesso!");
            }
            else
            {
                MessageBox.Show(string.Format("Erro criando usuário:\n{0}", string.Join("\n", result.Errors)));
            }
        }
    }
}
