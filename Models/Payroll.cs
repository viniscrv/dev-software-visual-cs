namespace FolhaDePagamento.Models
{
    public class Payroll
    {
        public int Id { get; set; }
        public double ValueHour{ get; set; }
        public int QuantityHour{ get; set; }
        public int Month{ get; set; }
        public int Year{ get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public double GrossSalary { get; set; }
        public double IncomeTax { get; set; }
        public double InssTax { get; set; }
        public double FgtsTax { get; set; }
        public double NetSalary { get; set; }
    }
}
