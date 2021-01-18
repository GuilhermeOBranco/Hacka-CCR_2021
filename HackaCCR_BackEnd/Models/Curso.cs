using System;

namespace HackaCCR_BackEnd.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public int TrilhaId { get; set; }
        public string EmpresaParceira { get; set; }
        public int Horas { get; set; }
        public string LinkCurso { get; set; }
    }
}