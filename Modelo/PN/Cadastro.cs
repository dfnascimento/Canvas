using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class Cadastro
    {

        public static bool InserirProfessor(PNProfessor pr)
        {
            try
            {
                CanvasEntities2 db = new CanvasEntities2();
                
                //Verifica se o email já está cadastrado
                var npr = (from part in db.Participantes
                           where part.Email == pr.email
                           select part).Count();


                if (npr > 0)
                {
                    return false;
                }
                
                return pr.Inserir();
            }
            catch (Exception) {
                throw;
            }
        }

        public static bool InserirAvaliadorExterno(PNAvaliadorExterno ae)
        {
            try
            {
                CanvasEntities2 db = new CanvasEntities2();

                //Verifica se o email já está cadastrado
                var npr = (from part in db.Participantes
                           where part.Email == ae.email
                           select part).Count();


                if (npr > 0)
                {
                    return false;
                }

                return ae.Inserir();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool InserirAluno(PNAluno al)
        {
            try
            {
                CanvasEntities2 db = new CanvasEntities2();

                //Verifica se o email já está cadastrado
                var npr = (from part in db.Participantes
                           where part.Email == al.email
                           select part).Count();


                if (npr > 0)
                {
                    return false;
                }

                return al.Inserir();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<PNProfessor> ListaProfessoresInativos()
        {

            try
            {
                CanvasEntities2 db = new CanvasEntities2();

                var query =
                           from prof in db.Professors
                           join part in db.Participantes on prof.Id_Participante equals part.Id
                           where part.Status == "Inativo"
                           select new
                           {
                               prof,
                               part
                           };

                List<PNProfessor> lista = new List<PNProfessor>();

                foreach (var result in query)
                {
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
            catch (Exception) {
                throw;
            }
        }



        public static bool Ativar(Participante pa) {

            try
            {
                CanvasEntities2 db = new CanvasEntities2();

                Participante par = db.Participantes.First(p => p.Email == pa.Email);

                par.Status = "Ativo";

                db.SaveChanges();

                return true;
                    
            }
            catch (Exception){
                throw;       
            }
        }

        public static bool Inativar(Participante pa)
        {

            try
            {
                CanvasEntities2 db = new CanvasEntities2();

                Participante par = db.Participantes.First(p => p.Email == pa.Email);

                par.Status = "Inativo";

                db.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}
