using Modelo.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public static class Acesso
    {
        public static String email { get; set; }
        public static String nome { get; set; }
        public static int id { get; set; }
        public static String acesso { get; set; }

        public static String logar(String login, String senha)
        {
            try
            {
                CanvasEntities2 db = new CanvasEntities2();

                //Recupera paricipante
                var p = db.Participantes.FirstOrDefault(s => s.Email == login);

                if (p == null)
                {
                    return "Email não cadastrado";
                }

                if (!p.Senha.Equals(senha))
                {
                    return "Senha incorreta";
                }

                email = p.Email;
                nome = p.Nome;
                id = p.Id;

                if ((from aluno in db.Alunoes where aluno.Id_Participante == p.Id select aluno).Count() > 0)
                {
                    acesso = "Aluno";
                }
                else if ((from prof in db.Professors where prof.Id_Participante == p.Id select prof).Count() > 0)
                {
                    acesso = "Professor";
                }
                else if ((from ava in db.Avaliador_Externo where ava.Id_Participante == p.Id select ava).Count() > 0)
                {
                    acesso = "Avaliador";
                }
                else if ((from adm in db.Admins where adm.Id_Participante == p.Id select adm).Count() > 0)
                {
                    acesso = "Administrador";
                }
                else
                {
                    acesso = "Erro";
                }

                return "Sucesso";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
