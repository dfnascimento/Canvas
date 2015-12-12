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

    }
}
