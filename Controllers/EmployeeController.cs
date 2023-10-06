using FolhaDePagamento.Data;
using FolhaDePagamento.Models;
using Microsoft.AspNetCore.Mvc;

namespace FolhaDePagamento.Controllers;

[ApiController]
[Route("api/funcionario")]
public class EmployeeController : ControllerBase
{
    private readonly ApplicationContext _context;
    public EmployeeController(ApplicationContext context)
    {
        _context= context;
    }

    [HttpPost]
    [Route("cadastrar")]
    public IActionResult registerEmployee(Employee employee)
    {
        _context.Add(employee);
        _context.SaveChanges();

        return Ok(employee);
    }


    [HttpGet]
    [Route("listar")]
    public IActionResult getAllEmployees()
    {
        var employees = _context.Employees.ToList();

        return Ok(employees);
    }
}