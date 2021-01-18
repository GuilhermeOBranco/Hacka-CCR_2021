using System;
using System.Collections.Generic;
using System.Linq;
using ApiUsuarios.Context;
using HackaCCR_BackEnd.Models;

namespace HackaCCR_BackEnd.Service
{
    public class TrilhaService
    {
        private readonly ApplicationContext _context;

        public TrilhaService(ApplicationContext context)
        {
            _context = context;
        }

        public List<Curso> IndicarTrilha(AlunoUsuario usuario)
        {
            //Recebo o aluno que está logado e revalido ele no Banco de Dados
            var aluno = _context.UsuarioAluno.Where(obj => obj.Id == usuario.Id).FirstOrDefault();

            //Vejo qual o perfil dele, para que possa ser enviada uma trilha de acordo com aquilo que ele marcou como opção
            var perfil = _context.Perfil.Where(obj => obj.AlunoUsuarioId == aluno.Id).FirstOrDefault();

            //Faço a leitura das trilhas cadastradas disponiveis
            var trilhaIndicada = _context.Trilha.Where(obj => obj.PerfilId == perfil.Id).FirstOrDefault();
            
            // Verifico todos os cursos que temos dentro da trilha e retorno para o usuario as opções.
            var cursos = _context.Curso.Where(obj => obj.TrilhaId == trilhaIndicada.Id).ToList();

            return cursos;
        }
    }
}