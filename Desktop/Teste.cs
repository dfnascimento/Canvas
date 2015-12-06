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
  
  //Classe pública
    public class Participante
        {
            //Construtor da classe
            public Participante()
            {
                MessageBox.Show("Objeto Criado com sucesso!");
            }
            //Destrutor da classe
            ~Participante()
            {
            }
        //Atributos/Propriedades Privadas Encapsuladas

            private int id;
            private string nome;
            private string email;
            private PasswordPropertyTextAttribute senha;
            private string status;
        //Atributos/Propriedades Públicas Encapsuladas

        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
            {
                get { return email; }
                set { email = value; }
            }

         public PasswordPropertyTextAttribute Senha
            {
                get { return senha; }
                set { senha = value; }
            }
         public string Status
        {
            get { return status; }
            set { status = value; }
        }
           
            //Métodos públicos
            public void Cadastrar()
            {
                MessageBox.Show(string.Format("Cadastrando participante...\r\nNome: {0}, - Email: {1}, Senha: {2}", nome));
            }

            public bool ConfirmarCadastro(int tipo)
            {
                if (tipo == 1)
                    return true;
                else
                    return true;
            }
            public bool ValidarParticipante(int tipo)
            {
                if (tipo == 1)
                    return true;
                else
                    return true;
            }
            public void Alterar()
            {
                MessageBox.Show("Alterando Participante...");

            }
        }
    }








