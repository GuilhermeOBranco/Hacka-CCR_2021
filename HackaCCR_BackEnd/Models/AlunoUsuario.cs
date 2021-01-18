using System;

namespace HackaCCR_BackEnd.Models
{
    public class AlunoUsuario
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Logradouro { get; set; }
        public int NumeroCasa { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string TrilhaOpcao { get; set; }
                
    }
}