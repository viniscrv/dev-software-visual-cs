namespace FolhaDePagamento.Models
{
    public class Payroll
    {
        public int Id { get; set; }
        public double Value{ get; set; }
        public double Quantity{ get; set; }
        public int Month{ get; set; }
        public int Year{ get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
