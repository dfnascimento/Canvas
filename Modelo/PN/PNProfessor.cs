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
        public String nome { get; set; }
        public String email { get; set; }
        public byte[] senha { get; set; }
        public String disciplinaPrincipal { get; set; }
        public String departamento { get; set; }
        public String status { get; set; }


        public bool Inserir() {

            DAO.CanvasEntities2 db = new CanvasEntities2();

            Participante p = new Participante();
            Professor pr = new Professor();

            p.Nome = this.nome;
            p.Senha = this.senha;
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

    }
}
