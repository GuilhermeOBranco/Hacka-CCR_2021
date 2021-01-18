using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HackaCCR_BackEnd.Models;
using HackaCCR_BackEnd.Service;

namespace HackaCCR_BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly UserService _service;
        public UserController(UserService service)
        {
           _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult ValidaUsuario([FromQuery]int id)
        {
            
            var user = _service.BuscarUsuario(id);
            System.Console.WriteLine("Usuário: " + user);
/*
            switch(user.TipoAcesso)
            {
                case Models.Enums.AcessoTipoEnum.Administrador: return Ok("Administrador"); 
                case Models.Enums.AcessoTipoEnum.AlunoUsuario: return Ok("Aluno"); 
                case Models.Enums.AcessoTipoEnum.EmpresaUsuario: return Ok("Empresa"); 
            }*/
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CriarUsuario(Users user)
        {
            System.Console.WriteLine(user.Id);
            if(await _service.CriarUsuario(user)) return Ok("Usuario criado");
            return NotFound("Erro ao criar");
        }
    }
}
