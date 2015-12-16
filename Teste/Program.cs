using Modelo.DAO;
using Modelo.PN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            //PNAluno a1 = new PNAluno();
            //a1.nome = "Aluno Teste 1";
            //a1.email = "aluno01";
            //a1.senha = "aluno";
            //a1.curso = "Curso 1";
            //a1.periodo = 3;
            //a1.campus = "Campus 1";
            //CadastroUsuario.InserirAluno(a1);

            //PNAluno a2 = new PNAluno();
            //a2.nome = "Aluno Teste 2";
            //a2.email = "aluno02";
            //a2.senha = "aluno";
            //a2.curso = "Curso 2";
            //a2.periodo = 3;
            //a2.campus = "Campus 2";
            //CadastroUsuario.InserirAluno(a2);

            //PNAluno a3 = new PNAluno();
            //a1.nome = "Aluno Teste 3";
            //a1.email = "aluno03";
            //a1.senha = "aluno";
            //a1.curso = "Curso 3";
            //a1.periodo = 3;
            //a1.campus = "Campus 3";
            //CadastroUsuario.InserirAluno(a1);

            //PNAluno a4 = new PNAluno();
            //a1.nome = "Aluno Teste 4";
            //a1.email = "aluno04";
            //a1.senha = "aluno";
            //a1.curso = "Curso 4";
            //a1.periodo = 3;
            //a1.campus = "Campus 4";
            //CadastroUsuario.InserirAluno(a1);

            Acesso.logar("aluno01", "aluno");

            PNProjeto pn = CadastroProjeto.criarProjeto("Projeto Teste 2");

            
        }
    }
}
