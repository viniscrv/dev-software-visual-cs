using System.ComponentModel.DataAnnotations;

namespace FolhaDePagamento.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name{ get; set; }

        [StringLength(12, MinimumLength = 12)]
        public string? Cpf{ get; set; }
        public Payroll Payroll { get; set; }
    }
}
