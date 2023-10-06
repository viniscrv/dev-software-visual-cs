using System.ComponentModel.DataAnnotations;

namespace FolhaDePagamento.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name{ get; set; }

        [StringLength(11, MinimumLength = 11)]
        public string? Cpf{ get; set; }
    }
}
