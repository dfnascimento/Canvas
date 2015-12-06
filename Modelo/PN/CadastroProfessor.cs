using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class CadastroProfessor
    {

        public static bool Inserir(PNProfessor pr)
        {
            CanvasEntities2 db = new CanvasEntities2();
            //Participante npr = new Participante();

            //Verifica se o email já está cadastrado
            var npr = (from part in db.Participantes
                  where part.Email == pr.email
                  select  part).Count();


            if (npr > 0)
            {
                return false;
            }
            //Teste commit
            return pr.Inserir();

        }

        public static List<PNProfessor> ListaProfessoresInativos()
        {

            CanvasEntities2 db = new CanvasEntities2();

            var query =
                       from prof in db.Professors
                       join part in db.Participantes on prof.Id_Participante equals part.Id
                       where part.Status == "Inativo"
                       select new
                       {
                           prof, part
                       };

            List<PNProfessor> lista = new List<PNProfessor>();

            foreach (var result in query) {
                PNProfessor p = new PNProfessor();
                p.nome = result.part.Nome;
                p.email = result.part.Email;
                p.senha = result.part.Senha;
                p.status = result.part.Status;
                p.disciplinaPrincipal = result.prof.Disciplina_Principal;
                p.departamento = result.prof.Departamento;

                lista.Add(p);

            }
            return lista;
            

        }



        //public static bool Ativar(Participante pa) {

        //  }


    }
}
