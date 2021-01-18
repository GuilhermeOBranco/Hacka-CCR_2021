using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiUsuarios.Context;
using HackaCCR_BackEnd.Models;

namespace HackaCCR_BackEnd.Service
{
    public class UserService
    {
        private readonly ApplicationContext _context;

        public UserService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<bool> CriarUsuario(Users user)
        {
            try
            {
                await _context.Usuario.AddAsync(user);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }

        public Users BuscarUsuario(int id)
        {
            try
            {
                return _context.Usuario.FirstOrDefault(obj => obj.Id == 0);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}