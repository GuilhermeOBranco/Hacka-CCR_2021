using System;

namespace HackaCCR_BackEnd.Models
{
    public class Perfil
    {
        public int Id { get; set; }
        public int AlunoUsuarioId { get; set; }
        public string Direcionamento { get; set; }
    }
}