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

                if ((from lider in db.Lideranca
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

        public PNProjeto criarProjeto(String nome) {
            try
            {
                return new PNProjeto(nome);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
