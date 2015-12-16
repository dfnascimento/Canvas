using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class PNProfessor
    {
        public int id { get; set; }
        public String nome { get; set; }
        public String email { get; set; }
        public String senha { get; set; }
        public String disciplinaPrincipal { get; set; }
        public String departamento { get; set; }
        public String status { get; set; }


        public bool Inserir() {

            DAO.CanvasEntities2 db = new CanvasEntities2();

            Participante p = new Participante();
            Professor pr = new Professor();

            p.Nome = this.nome;
            p.Senha = Util.HashValue(this.senha);
            p.Email = this.email;
            p.Status = "Inativo";
            
            //Insere no banco

            db.Participantes.Add(p);
            db.SaveChanges();

            pr.Id_Participante = db.Participantes.Where(s => s.Email == p.Email).FirstOrDefault<Participante>().Id;
            pr.Departamento = this.departamento;
            pr.Disciplina_Principal = this.disciplinaPrincipal;

            db.Professors.Add(pr);
            db.SaveChanges();

            return true;

        }

        //Retorna nome dos projetos disponiveis para comentar
        public List<String> listarProjetosCom()
        {

            try
            {
                CanvasEntities2 db = new CanvasEntities2();
                var query =
                           from proj in db.Projetoes
                           join orProj in db.Orientador_Projeto on proj.Id equals orProj.Id_Projeto
                           join coment in db.Comentarios on orProj.Id equals coment.Id_Orientador_Projeto
                           where orProj.Id_Orientador == id
                           select new
                           {
                               proj
                           };

                List<String> lista = new List<String>();

                foreach (var result in query)
                {
                    lista.Add(result.proj.Nome);

                }
                return lista;

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
