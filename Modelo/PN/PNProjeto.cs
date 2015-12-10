using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class PNProjeto
    {
        public String nome { get; set; }
        public int id { get; set; }

        public PNProjeto(String nome) {

            CanvasEntities2 db = new CanvasEntities2();

            Projeto p = new Projeto();
            p.Nome = nome;
            p.Status = "Novo";

            db.Projetoes.Add(p);
            db.SaveChanges();

            id = db.Projetoes.Where(s => s.Nome == nome).FirstOrDefault<Projeto>().Id;

            Lideranca l = new Lideranca();
            l.Id_Aluno = Acesso.id;
            l.Id_Projeto = id;
            l.Data_Inicio = DateTime.Now;
            l.Data_Final = null;

            db.Liderancas.Add(l);
            db.SaveChanges();
        }

        public bool addMembro(Aluno a) {

            CanvasEntities2 db = new CanvasEntities2();

            Aluno_Projeto ap = new Aluno_Projeto();
            ap.Id_Aluno = a.Id;
            ap.Id_Projeto = id;
            db.Aluno_Projeto.Add(ap);
            db.SaveChanges();

            return true;
        }

        public bool addOrientador(Professor p)
        {

            CanvasEntities2 db = new CanvasEntities2();

            Orientador_Projeto op = new Orientador_Projeto();
            op.Id_Orientador = p.Id;
            op.Id_Projeto = id;
            db.Orientador_Projeto.Add(op);
            db.SaveChanges();

            return true;

        }


    }
}
