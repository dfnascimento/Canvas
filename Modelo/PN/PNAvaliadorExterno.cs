using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class PNAvaliadorExterno
    {
        public int id { get; set; } // id avaliador
        public String nome { get; set; }
        public String email { get; set; }
        public String senha { get; set; }
        public String areaAtuacao { get; set; }
        public String formacao { get; set; }
        public String status { get; set; }
        
        public bool Inserir()
        {

            CanvasEntities2 db = new CanvasEntities2();

            Avaliador_Externo a = new Avaliador_Externo();
            Participante p = new Participante();

            p.Nome = this.nome;
            p.Senha = Util.HashValue(this.senha);
            p.Email = this.email;
            p.Status = "Inativo";

            //Insere no banco

            db.Participantes.Add(p);
            db.SaveChanges();

            a.Id_Participante = db.Participantes.Where(s => s.Email == p.Email).FirstOrDefault<Participante>().Id;

            a.Area_Atuacao = this.areaAtuacao;
            a.Formacao = this.formacao;

            db.Avaliador_Externo.Add(a);
            db.SaveChanges();

            return true;

        }

        //Retorna nome dos projetos disponiveis para avaliação
        public List<String> listarProjetosDisp()
        {

            try
            {
                CanvasEntities2 db = new CanvasEntities2();

                var query =
                           from proj in db.Projetoes
                           join avalproj in db.Avaliador_Projeto on proj.Id equals avalproj.Id_Projeto
                           where proj.Status == "Em avaliação" &&
                                 avalproj.Id_Avaliador == this.id
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
