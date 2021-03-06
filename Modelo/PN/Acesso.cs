﻿using Modelo.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public static class Acesso
    {
        public static String email { get; set; }
        public static String nome { get; set; }
        public static int id { get; set; }
        public static String acesso { get; set; }
        public static String status { get; set; }

        public static String logar(String login, String senha)
        {
            try
            {
                CanvasEntities2 db = new CanvasEntities2();

                //Recupera paricipante
                var p = db.Participantes.FirstOrDefault(s => s.Email == login);

                if (p == null)
                {
                    return "Email não cadastrado";
                }

                if (!p.Senha.Equals(Util.HashValue(senha)))
                {
                    return "Senha incorreta";
                }

                email = p.Email;
                nome = p.Nome;
                id = p.Id;
                status = p.Status;

                if ((from aluno in db.Alunoes where aluno.Id_Participante == p.Id select aluno).Count() > 0)
                {
                    acesso = "Aluno";
                }
                else if ((from prof in db.Professors where prof.Id_Participante == p.Id select prof).Count() > 0)
                {
                    acesso = "Professor";
                }
                else if ((from ava in db.Avaliador_Externo where ava.Id_Participante == p.Id select ava).Count() > 0)
                {
                    acesso = "Avaliador";
                }
                else if ((from adm in db.Admins where adm.Id_Participante == p.Id select adm).Count() > 0)
                {
                    acesso = "Admin";
                }
                else
                {
                    acesso = "Erro";
                }

                if (status.Equals("Inativo"))
                {
                    return "Usuário inativo. Contate o Administrador do sistema para ativar seu cadastro";
                }

                return "Sucesso";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static PNAvaliadorExterno getAvaliador()
        {

            try
            {


                PNAvaliadorExterno ae = new PNAvaliadorExterno();

                ae.nome = nome;
                ae.email = email;
                ae.status = status;

                CanvasEntities2 db = new CanvasEntities2();

                var query = (from aval in db.Avaliador_Externo
                             where aval.Id_Participante == id
                             select aval).First();

                ae.id = query.Id;
                ae.formacao = query.Formacao;
                ae.areaAtuacao = query.Area_Atuacao;

                return ae;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static PNProfessor getProfessor()
        {

            try
            {


                PNProfessor ae = new PNProfessor();

                ae.nome = nome;
                ae.email = email;
                ae.status = status;

                CanvasEntities2 db = new CanvasEntities2();

                var query = (from aval in db.Professors
                             where aval.Id_Participante == id
                             select aval).First();

                ae.id = query.Id;
                ae.disciplinaPrincipal = query.Disciplina_Principal;
                ae.departamento = query.Departamento;

                return ae;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
