using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HackaCCR_BackEnd.Models;
using HackaCCR_BackEnd.Service;
using System.Drawing;

namespace HackaCCR_BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CertificadoController : ControllerBase
    {
        private readonly CertificadoService _service;
        public CertificadoController(CertificadoService service)
        {
            _service = service;
        }


        /*

            https://localhost:5001/api/Certificado/link1/link2/EmpresaCursoParceira

        */

        [HttpGet]
        [Route("/{fname1}/{fname2}/{empresaParceira}")]
        public IActionResult LerCertificado([FromQuery] string cert1, [FromQuery] string cert2, string empresaParceira)
        {

            //Certificado 1 é obrigatoriamente passado pelo frontend
            //Modelo padrão do parceiro
            
            switch (empresaParceira)
            {
                case "Udemy":
                    if (_service.ValidaCertificadoUdemy(cert1, cert2)) return Ok("Certificado validado");
                    return BadRequest("Utilize o mecanismo da Udemy para baixar o certificaod como .JPG");
                case "Dio":
                    if (_service.ValidaCertificadoDio(cert1, cert2)) return Ok("Certificado validado");
                    return BadRequest("Utilize o mecanismo da Dio para baixar o certificaod como .JPG");
            }
            return BadRequest("Escolha um parceiro válido");




        }

    }
}
