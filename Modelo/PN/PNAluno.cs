using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class PNAluno
    {
        public String nome { get; set; }
        public String email { get; set; }
        public String senha { get; set; }
        public String curso { get; set; }
        public int periodo { get; set; }
        public String campus { get; set; }
        public String status { get; set; }


        public bool Inserir()
        {

            DAO.CanvasEntities2 db = new CanvasEntities2();

            Participante p = new Participante();
            Aluno al = new Aluno();

            p.Nome = this.nome;
            p.Senha = this.senha;
            p.Email = this.email;
            p.Status = "Ativo";

            //Insere no banco

            db.Participantes.Add(p);
            db.SaveChanges();

            al.Id_Participante = db.Participantes.Where(s => s.Email == p.Email).FirstOrDefault<Participante>().Id;
            al.Periodo = this.periodo;
            al.Campus = this.campus;
            al.Curso = this.curso;
            
            db.Alunoes.Add(al);
            db.SaveChanges();

            return true;

        }

    }
}
