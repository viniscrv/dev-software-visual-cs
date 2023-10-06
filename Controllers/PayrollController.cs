using FolhaDePagamento.Data;
using FolhaDePagamento.Models;
using Microsoft.AspNetCore.Mvc;

namespace FolhaDePagamento.Controllers;



[ApiController]
[Route("api/folha")]
public class PayrollController : ControllerBase
{

    private readonly ApplicationContext _context;
    public PayrollController(ApplicationContext context)
    {
        _context = context;
    }


    [HttpPost]
    [Route("cadastrar")]
    public IActionResult registerPayroll(Payroll payroll)
    {
        _context.Add(payroll);
        _context.SaveChanges();

        return Created("", payroll);
    }

    [HttpGet]
    [Route("listar")]
    public IActionResult getAllPayroll()
    {
        var payrolls = _context.Payrolls.ToList();

        return Ok(payrolls);
    }

    [HttpGet]
    [Route("buscar/{cpf}/{mes}/{ano}")]
    public IActionResult getUniquePayroll(
        [FromRoute] string cpf, [FromRoute] int month, [FromRoute] int year)
    {
        var payroll = _context.Payrolls
            .Where(p => p.Month == month && p.Year == year).ToList();

        return Ok(payroll);
    }
}
