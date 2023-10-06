using FolhaDePagamento.Data;
using FolhaDePagamento.Models;
using FolhaDePagamento.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        {
            payroll.GrossSalary = Calculate.CalcGrossSalary(payroll.QuantityHour, payroll.ValueHour);
            payroll.IncomeTax = Calculate.CalcIncomeTax(payroll.GrossSalary);
            payroll.InssTax = Calculate.CalcInssTax(payroll.GrossSalary);
            payroll.FgtsTax= Calculate.CalcFgtsTax(payroll.GrossSalary);
            payroll.NetSalary= Calculate.CalcNetSalary(payroll.GrossSalary, payroll.IncomeTax, payroll.InssTax);
        }

        _context.Add(payroll);
        _context.SaveChanges();

        return Created("", payroll);
    }

    [HttpGet]
    [Route("listar")]
    public IActionResult getAllPayroll()
    {
        List<Payroll> payrolls = _context.Payrolls.Include(e => e.Employee).ToList();

        if (payrolls.Count == 0) return NotFound();

        return Ok(payrolls);
    }

    [HttpGet]
    [Route("buscar/{cpf}/{mes}/{ano}")]
    public IActionResult getUniquePayroll(
        [FromRoute] string cpf, int mes, int ano)
    {
        var payroll = _context.Payrolls.Include(p => p.Employee)
            .FirstOrDefault(p =>
                p.Employee.Cpf == cpf &&
                p.Year == ano &&
                p.Month == mes
            );

        return Ok(payroll);
    }
}
