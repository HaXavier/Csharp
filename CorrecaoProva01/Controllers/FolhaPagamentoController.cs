using System.Collections.Generic;
using System.Linq;
using API.Models;
using API.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/folha")]

    public class FolhaPagamentoController : ControllerBase
    {
        private readonly DataContext _context;
        public FolhaPagamentoController(DataContext context) =>
            _context = context;


        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] FolhaPagamento folha)
        {
            folha.SalarioBruto = Calculos.CalcularSalarioBruto(folha.QuantidadeHoras, folha.ValorHora);
            folha.ImpostoRenda = Calculos.CalcularImpostoRenda(folha.SalarioBruto);
            folha.ImpostoInss = Calculos.CalcularInss(folha.SalarioBruto);
            folha.ImpostoFgts = Calculos.CalcularFgts(folha.SalarioBruto);
            folha.SalarioLiquido = Calculos.CalcularSalarioLiquido(folha.SalarioBruto, folha.ImpostoRenda, folha.ImpostoInss);

            folha.Funcionario = _context.Funcionarios.Find(folha.FuncionarioId);
            _context.Folhas.Add(folha);
            _context.SaveChanges();
            return Created("", folha);
        }

        // GET: /api/folha/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() =>  
            _context.Folhas.Count() != 0 ? 
            Ok(_context.Folhas.Include(f => f.Funcionario).ToList()) : NotFound();


        // GET: /api/folha/filtrar
        [HttpGet]
        [Route("filtrar/{mes}/{ano}")]
        public IActionResult Filtrar([FromRoute] string cpf, int mes, int ano)
        {
            return Ok(
                _context.Folhas
                .Include(f => f.Funcionario)
                .FirstOrDefault
                (f => f.CriadoEm.Month == mes && 
                    f.CriadoEm.Year == ano && 
                    f.Funcionario.Cpf.Equals(cpf)));
            // return Ok(_context.Folhas.Where(f => f.Mes == mes && f.Ano == ano).ToList());
        } 

    }
}