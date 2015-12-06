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
            Participante npr = new Participante();

            //Verifica se o email já está cadastrado
            npr = db.Participantes.Where(s => s.Email == pr.email).First();

            if (npr != null)
            {
                return false;
            }

            return pr.Inserir();

        }

    //    public static List<Professor> ListaProfessoresInativos() {

    //        CanvasEntities2 db = new CanvasEntities2();

    //        var query =
    //                   from prof in db.Professors
    //                   join part in db.Participantes on prof.Id_Participante equals part.Id
    //                   where part.Status == "Inativo"
    //                   select new { part.Nome,
    //                                part.Email,
    //                                part.Senha,
    //                                prof.Disciplina_Principal,
    //                                prof.Departamento,
    //                                part.Status };



    //    //    List<PNProfessor> lista = query.ToList<PNProfessor>;

    //}



    //public static bool Ativar(Participante pa) {

      //  }


    }
}
