﻿using Modelo.DAO;
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

        public Dictionary<String, Quadro> dictionary() {

            Dictionary<String, Quadro> dict = new Dictionary<String, Quadro>();
            CanvasEntities2 db = new CanvasEntities2();


            dict.Add("I - Segmento de Clientes",
                        new Quadro("Para quem criamos valor?\r\n" +
                                   "Quais são nossos clientes mais importantes ? "));
            dict.Add("II - Proposta de Valor",
                    new Quadro("Que valor proporcionou a nossos clientes?\r\n" +
                                "Que problemas de nossos clientes estão solucionados ? "));
            dict.Add("III - Canais (Distribuição e Comunicação)",
                    new Quadro("Que meios preferem utilizar nosso segmento de mercado? (ExLoja física, Virtual)\r\n" +
                                "Como estabelecer contato com os clientes ? "));
            dict.Add("IV - Relacionamento com clientes",
                    new Quadro("Que tipo de relacionamento que cada segmento de cliente espera ter para estabelecer e manter sua preferencia ?"));
            dict.Add("V - Receitas",
                    new Quadro("Porque valor os nossos clientes realmente estão dispostos a pagar?\r\n" +
                                "Como gostariam de pagar ? "));
            dict.Add("VI - Recursos Chave",
                    new Quadro("Que recursos físicos, humanos, intelectuais ou econômicos são essenciais ?\r\n" +
                                "Coisas Imprescindíveis ?"));
            dict.Add("VII - Atividades Chave",
                    new Quadro("O que devemos Saber e fazer?"));
            dict.Add("VIII - Parcerias Chave",
                    new Quadro("Quem são nossos parceiros e provedores fundamentais?"));
            dict.Add("IX - Custos",
                    new Quadro("Quais são os custos mais importantes do modelo de negocio(Recursos e Atividades chaves)."));

            Projeto p = db.Projetoes.Find(id);


            if  (p.Status.Equals("Disponivel") ||
                    p.Status.Equals("Em preenchimento") ||
                    p.Status.Equals("Em avaliação"))
            {
                dict["I - Segmento de Clientes"].resposta = p.Resposta_1;
                dict["II - Proposta de Valor"].resposta = p.Resposta_2;
                dict["III - Canais (Distribuição e Comunicação)"].resposta = p.Resposta_3;
                dict["IV - Relacionamento com clientes"].resposta = p.Resposta_4;
                dict["V - Receitas"].resposta = p.Resposta_5;
                dict["VI - Recursos Chave"].resposta = p.Resposta_6;
                dict["VII - Atividades Chave"].resposta = p.Resposta_7;
                dict["VIII - Parcerias Chave"].resposta = p.Resposta_8;
                dict["IX - Custos"].resposta = p.Resposta_9;

            }




            return dict;
        }

        public Dictionary<String, int> dictNotas() {
            Dictionary<String, int> notas = new Dictionary<String, int>();

            CanvasEntities2 db = new CanvasEntities2();

            var idAvaliador = Acesso.getAvaliador().id;

            Avaliacao av = (from aval in db.Avaliacaos
                            join avproj in db.Avaliador_Projeto on aval.Id_Avaliador_Projeto equals avproj.Id
                            where avproj.Id_Avaliador == idAvaliador
                            && avproj.Id_Projeto == id
                            select aval).First();

            notas.Add("I - Segmento de Clientes", av.Nota_Quadro_1.Equals(null) ? -1: av.Nota_Quadro_1.Value );
            notas.Add("II - Proposta de Valor", av.Nota_Quadro_2.Equals(null) ? -1 : av.Nota_Quadro_2.Value);
            notas.Add("III - Canais (Distribuição e Comunicação)", av.Nota_Quadro_3.Equals(null) ? -1 : av.Nota_Quadro_3.Value);
            notas.Add("IV - Relacionamento com clientes", av.Nota_Quadro_4.Equals(null) ? -1 : av.Nota_Quadro_4.Value);
            notas.Add("V - Receitas", av.Nota_Quadro_5.Equals(null) ? -1 : av.Nota_Quadro_5.Value);
            notas.Add("VI - Recursos Chave", av.Nota_Quadro_6.Equals(null) ? -1 : av.Nota_Quadro_6.Value);
            notas.Add("VII - Atividades Chave", av.Nota_Quadro_7.Equals(null) ? -1 : av.Nota_Quadro_7.Value);
            notas.Add("VIII - Parcerias Chave", av.Nota_Quadro_8.Equals(null) ? -1 : av.Nota_Quadro_8.Value);
            notas.Add("IX - Custos", av.Nota_Quadro_9.Equals(null) ? -1 : av.Nota_Quadro_9.Value);

            return notas;
        }

        public Dictionary<String, String> dictComentarios()
        {
            Dictionary<String, String> comentarios = new Dictionary<String, String>();

            CanvasEntities2 db = new CanvasEntities2();

            var idProfessor = Acesso.getProfessor().id;

            Comentario cm = (from com in db.Comentarios
                            join orproj in db.Orientador_Projeto on com.Id_Orientador_Projeto equals orproj.Id
                            where orproj.Id_Orientador == idProfessor
                            && orproj.Id_Projeto == id
                            select com).First();

            comentarios.Add("I - Segmento de Clientes", cm.Quadro_1 == null ? " " : cm.Quadro_1.ToString());
            comentarios.Add("II - Proposta de Valor", cm.Quadro_2 == null ? " " : cm.Quadro_2.ToString());
            comentarios.Add("III - Canais (Distribuição e Comunicação)", cm.Quadro_3 == null ? " " : cm.Quadro_3.ToString());
            comentarios.Add("IV - Relacionamento com clientes", cm.Quadro_4 == null ? " " : cm.Quadro_4.ToString());
            comentarios.Add("V - Receitas", cm.Quadro_5 == null ? " " : cm.Quadro_5.ToString());
            comentarios.Add("VI - Recursos Chave", cm.Quadro_6 == null ? " " : cm.Quadro_6.ToString());
            comentarios.Add("VII - Atividades Chave", cm.Quadro_7 == null ? " " : cm.Quadro_7.ToString());
            comentarios.Add("VIII - Parcerias Chave", cm.Quadro_8 == null ? " " : cm.Quadro_8.ToString());
            comentarios.Add("IX - Custos", cm.Quadro_9 == null ? " " : cm.Quadro_9.ToString());

            return comentarios;
        }

        public bool isNotasPreenchidas() {
            Dictionary<String, int>  notas = dictNotas();

            foreach (var nota in notas)
            {

                if (nota.Value == -1) {
                    return false;
                }
            }

            return true;
        }


        public double getMediaAritimetica() {
            Dictionary<String, int> notas = dictNotas();

            double soma = 0.0;

            foreach (var nota in notas) {
                soma += nota.Value;
            }

            return soma / 9.0;
        }

        public double getMediaPonderada()
        {
            Dictionary<String, int> notas = dictNotas();
            Peso p = PNPeso.getPeso();

            double soma = 0.0;


            
            soma += notas["I - Segmento de Clientes"] * p.Peso_Quadro_1.Value;
            soma += notas["II - Proposta de Valor"] * p.Peso_Quadro_2.Value;
            soma += notas["III - Canais (Distribuição e Comunicação)"] * p.Peso_Quadro_3.Value;
            soma += notas["IV - Relacionamento com clientes"] * p.Peso_Quadro_4.Value;
            soma += notas["V - Receitas"] * p.Peso_Quadro_5.Value;
            soma += notas["VI - Recursos Chave"] * p.Peso_Quadro_6.Value;
            soma += notas["VII - Atividades Chave"] * p.Peso_Quadro_7.Value;
            soma += notas["VIII - Parcerias Chave"] * p.Peso_Quadro_8.Value;
            soma += notas["IX - Custos"] * p.Peso_Quadro_9.Value;

            double somaPeso = 0.0;

            somaPeso += p.Peso_Quadro_1.Value;
            somaPeso += p.Peso_Quadro_2.Value;
            somaPeso += p.Peso_Quadro_3.Value;
            somaPeso += p.Peso_Quadro_4.Value;
            somaPeso += p.Peso_Quadro_5.Value;
            somaPeso += p.Peso_Quadro_6.Value;
            somaPeso += p.Peso_Quadro_7.Value;
            somaPeso += p.Peso_Quadro_8.Value;
            somaPeso += p.Peso_Quadro_9.Value;

            return soma / somaPeso; 
        }

        public bool finalizarAvaliacao() {

            CanvasEntities2 db = new CanvasEntities2();

            var idAvaliador = Acesso.getAvaliador().id;

            Avaliador_Projeto av = (from avProj in db.Avaliador_Projeto
                            where avProj.Id_Avaliador == idAvaliador
                            && avProj.Id_Projeto == id
                            select avProj).First();
            av.Status = "Finalizada";

            av.Media_Aritimetica = (int) Math.Ceiling(getMediaAritimetica());
            av.Media_Ponderada = (int)Math.Ceiling(getMediaPonderada());

            db.SaveChanges();
            //Verifica se ainda existe Avaliação pendente para o projeto
            var num = (from avProj in db.Avaliador_Projeto
                       where avProj.Id_Projeto == id
                       && avProj.Status != "Finalizada"
                       select avProj).Count();

            if (num == 0)
            {
                updateStatus("Avaliação Encerrada");
            }


            return true;

        }

        public bool addNota(String quadro, int nota) {

            CanvasEntities2 db = new CanvasEntities2();

            var idAvaliador = Acesso.getAvaliador().id;


            Avaliacao av = (from aval in db.Avaliacaos
                            join avProj in db.Avaliador_Projeto on aval.Id_Avaliador_Projeto equals avProj.Id
                            where avProj.Id_Avaliador == idAvaliador
                            && avProj.Id_Projeto == id
                            select aval).First();
            switch (quadro)
            {

                case "I - Segmento de Clientes":
                    av.Nota_Quadro_1 = nota;
                    break;
                case "II - Proposta de Valor":
                    av.Nota_Quadro_2 = nota;
                    break;
                case "III - Canais (Distribuição e Comunicação)":
                    av.Nota_Quadro_3 = nota;
                    break;
                case "IV - Relacionamento com clientes":
                    av.Nota_Quadro_4 = nota;
                    break;
                case "V - Receitas":
                    av.Nota_Quadro_5 = nota;
                    break;
                case "VI - Recursos Chave":
                    av.Nota_Quadro_6 = nota;
                    break;
                case "VII - Atividades Chave":
                    av.Nota_Quadro_7 = nota;
                    break;
                case "VIII - Parcerias Chave":
                    av.Nota_Quadro_8 = nota;
                    break;
                case "IX - Custos":
                    av.Nota_Quadro_9 = nota;
                    break;
                default:
                    return false;
            }

            db.SaveChanges();
            return true;

        }

        public bool addComentario(String quadro, String comentario)
        {
            CanvasEntities2 db = new CanvasEntities2();

            var idProfessor = Acesso.getProfessor().id;


            Comentario com = (from comm in db.Comentarios
                            join orProj in db.Orientador_Projeto on comm.Id_Orientador_Projeto equals orProj.Id
                            where orProj.Id_Orientador == idProfessor
                            && orProj.Id_Projeto == id
                            select comm).First();
            switch (quadro)
            {

                case "I - Segmento de Clientes":
                    com.Quadro_1 = comentario;
                    break;
                case "II - Proposta de Valor":
                    com.Quadro_2 = comentario;
                    break;
                case "III - Canais (Distribuição e Comunicação)":
                    com.Quadro_3 = comentario;
                    break;
                case "IV - Relacionamento com clientes":
                    com.Quadro_4 = comentario;
                    break;
                case "V - Receitas":
                    com.Quadro_5 = comentario;
                    break;
                case "VI - Recursos Chave":
                    com.Quadro_6 = comentario;
                    break;
                case "VII - Atividades Chave":
                    com.Quadro_7 = comentario;
                    break;
                case "VIII - Parcerias Chave":
                    com.Quadro_8 = comentario;
                    break;
                case "IX - Custos":
                    com.Quadro_9 = comentario;
                    break;
                default:
                    return false;
            }

            db.SaveChanges();
            return true;

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
            ap.Status = "Em Preenchimento";
            db.Avaliador_Projeto.Add(ap);
            db.SaveChanges();

            //Adiciona avaliação no banco
            Avaliacao al = new Avaliacao();
            al.Id_Avaliador_Projeto = (from aval in db.Avaliador_Projeto
                                       where aval.Id_Avaliador == av.Id
                                         && aval.Id_Projeto == id
                                       select aval).First().Id;
            db.Avaliacaos.Add(al);
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

        public List<String> getNomesQuadro()
        {
            List<String> quadro = new List<String>();

            quadro.Add("I - Segmento de Clientes");
            quadro.Add("II - Proposta de Valor");
            quadro.Add("III - Canais (Distribuição e Comunicação)");
            quadro.Add("IV - Relacionamento com clientes");
            quadro.Add("V - Receitas");
            quadro.Add("VI - Recursos Chave");
            quadro.Add("VII - Atividades Chave");
            quadro.Add("VIII - Parcerias Chave");
            quadro.Add("IX - Custos");

            return quadro;
        }

        public List<DadosAvaliacao> getDadosAvaliacao()
        {
            List<DadosAvaliacao> list = new List<DadosAvaliacao>();

            CanvasEntities2 db = new CanvasEntities2();

            var query = from pessoa in db.Participantes
                        join aval in db.Avaliador_Externo on pessoa.Id equals aval.Id_Participante
                        join avalPro in db.Avaliador_Projeto on aval.Id equals avalPro.Id_Avaliador
                        where avalPro.Id_Projeto == id
                        select new { pessoa, avalPro };

            foreach (var line in query)
            {
                list.Add(new DadosAvaliacao(line.pessoa.Nome, line.avalPro.Media_Aritimetica.Value, line.avalPro.Media_Ponderada.Value));
            }

            return list;
        }

        public int getMediaPondProj()
        {
            List<DadosAvaliacao> dados = getDadosAvaliacao();

            double soma = 0.0;

            foreach (var dado in dados)
            {
                soma += dado.mediaPonderada;
            }

            return (int) Math.Ceiling(soma / dados.Count);

        }

        public String getStatusFinal() {

            if (getMediaPondProj() > 70)
            {
                this.status = "Aprovado";
            }
            else
            {
                this.status = "Reprovado";
            }

            return this.status;
        }

        public bool confirmaStatua()
        {
            return updateStatus(this.status);
            
        }

        public bool finaliza()

        {
            return updateStatus("Encerrado");
        }

    }
}
