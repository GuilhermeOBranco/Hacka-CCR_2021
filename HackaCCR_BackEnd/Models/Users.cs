using System;
using HackaCCR_BackEnd.Models.Enums;

namespace HackaCCR_BackEnd.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public AcessoTipoEnum TipoAcesso { get; set; }
    }
}