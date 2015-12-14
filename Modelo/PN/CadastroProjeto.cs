using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class CadastroProjeto
    {
        //Verifica se o aluno pode criar um novo projeto
        //Retorna false se pode criar projeto
        //False se já é lider de projeto
        public static bool verificaCriacao() {
            try
            {
                CanvasEntities2 db = new CanvasEntities2();

                if ((from lider in db.Liderancas
                    where lider.Id_Aluno == Acesso.id 
                    && lider.Data_Final == null
                    select lider).Count() > 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static PNProjeto criarProjeto(String nome) {
            try
            {
                return new PNProjeto(nome);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static PNProjeto getProjeto(String nome) {

            try
            {
                CanvasEntities2 db = new CanvasEntities2();

                var query =
                           from proj in db.Projetoes
                           where proj.Nome == nome
                           select new
                           {
                               proj
                           };

                PNProjeto pr = new PNProjeto();
                pr.nome = query.First().proj.Nome;
                pr.id = query.First().proj.Id;
                pr.status = query.First().proj.Status;

                return pr;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static List<String> listarProjetosDisp() {

            try
            {
                CanvasEntities2 db = new CanvasEntities2();

                var query =
                           from proj in db.Projetoes
                           where proj.Status == "Disponivel"
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

        public static List<String> listarProjetosAvaliacaoEncerrada()
        {

            try
            {
                CanvasEntities2 db = new CanvasEntities2();

                var query =
                           from proj in db.Projetoes
                           where proj.Status == "Avaliação Encerrada"
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

        public static Avaliador_Externo getAvaliador(String nome)
        {
            try
            {
                CanvasEntities2 db = new CanvasEntities2();

                var query =
                           from part in db.Participantes
                           join aval in db.Avaliador_Externo on part.Id equals aval.Id_Participante
                           where part.Nome == nome
                           select new
                           {
                               aval
                           };

                return query.First().aval;
            }
            catch
            {
                throw;
            }
        }
    }
}
