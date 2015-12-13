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
        public String status { get; set; }

        public PNProjeto() {
        }

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

        public bool addAvaliador(Avaliador_Externo av)
        {
            CanvasEntities2 db = new CanvasEntities2();

            Avaliador_Projeto ap = new Avaliador_Projeto();
            ap.Id_Avaliador = av.Id;
            ap.Id_Projeto = id;
            ap.Status = "Novo";
            db.Avaliador_Projeto.Add(ap);
            db.SaveChanges();

            var count = (from proj in db.Avaliador_Projeto
                        where proj.Id_Projeto == this.id
                        select proj).Count();
            if (count > 2)
            {
                updateStatus("Em avaliação");
            }
                        

            return true;
        }

        public bool updateStatus(String stat)
        {
            CanvasEntities2 db = new CanvasEntities2();

            Projeto pr = db.Projetoes.Find(this.id);

            this.status = stat;
            pr.Status = stat;

            db.SaveChanges();

            return true;
        }

        public List<PNAluno> ListMembros() {

            CanvasEntities2 db = new CanvasEntities2();

            var query =
                       from part in db.Participantes
                       join aluno in db.Alunoes on part.Id equals aluno.Id_Participante 
                       join alpart in db.Aluno_Projeto on aluno.Id equals alpart.Id_Aluno 
                       where alpart.Id_Projeto == this.id
                       select new
                       {
                           aluno,
                           part
                       };

            List<PNAluno> lista = new List<PNAluno>();

            foreach (var result in query)
            {
                PNAluno p = new PNAluno();
                p.nome = result.part.Nome;
                p.email = result.part.Email;
                p.senha = result.part.Senha;
                p.status = result.part.Status;
                p.periodo = result.aluno.Periodo;
                p.curso = result.aluno.Curso;
                p.campus = result.aluno.Campus;
                lista.Add(p);

            }
            return lista;
        }


        public List<PNProfessor> ListOrientadores()
        {

            CanvasEntities2 db = new CanvasEntities2();

            var query =
                       from part in db.Participantes
                       join profe in db.Professors on part.Id equals profe.Id_Participante
                       join orProj in db.Orientador_Projeto on profe.Id equals orProj.Id_Orientador
                       where orProj.Id_Projeto == this.id
                       select new
                       {
                           profe,
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
                p.disciplinaPrincipal = result.profe.Disciplina_Principal;
                p.departamento = result.profe.Departamento;
                lista.Add(p);

            }
            return lista;
        }

        public List<PNAvaliadorExterno> ListAvaliadores()
        {

            CanvasEntities2 db = new CanvasEntities2();

            var query =
                       from part in db.Participantes
                       join aval in db.Avaliador_Externo on part.Id equals aval.Id_Participante
                       join avalProj in db.Avaliador_Projeto on aval.Id equals avalProj.Id_Avaliador
                       where avalProj.Id_Projeto == this.id
                       select new
                       {
                           aval,
                           part
                       };

            List<PNAvaliadorExterno> lista = new List<PNAvaliadorExterno>();

            foreach (var result in query)
            {
                PNAvaliadorExterno p = new PNAvaliadorExterno();
                p.nome = result.part.Nome;
                p.email = result.part.Email;
                p.senha = result.part.Senha;
                p.status = result.part.Status;
                p.areaAtuacao = result.aval.Area_Atuacao;
                p.formacao = result.aval.Formacao;
                lista.Add(p);

            }
            return lista;
        }

        public List<String> getAvaliadoresDisp() {
            List<String> list = new List<String>();

            CanvasEntities2 db = new CanvasEntities2();

            var query =
                       from part in db.Participantes
                       join aval in db.Avaliador_Externo on part.Id equals aval.Id_Participante
                       where !(from avalProj in db.Avaliador_Projeto
                               where avalProj.Id_Projeto == this.id
                               select avalProj.Id_Avaliador).Contains(aval.Id)
                              && part.Status == "Ativo"
                       select new
                       {
                           part
                       };

            foreach (var result in query)
            {
                list.Add(result.part.Nome);

            }
            return list;
        }

    }
}
