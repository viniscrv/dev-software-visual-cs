namespace FolhaDePagamento.Utils
{
    public class Calculate
    {
        public static double CalcGrossSalary(int quantityHour, double valueHour)
        {
            return quantityHour * valueHour;
        }
        public static double CalcIncomeTax(double grossSalary)
        {
            if (grossSalary <= 1903.98) return 0;
            if (grossSalary <= 2826.65) return grossSalary * 0.075 - 142.8;
            if (grossSalary <= 3751.05) return grossSalary * 0.15 - 354.8;
            if (grossSalary <= 4664.68) return grossSalary * 0.225 - 636.13;

            return grossSalary * 0.275 - 869.36;
        }
        public static double CalcInssTax(double grossSalary)
        {
            if (grossSalary <= 1693.72) return grossSalary * 0.08;
            if (grossSalary <= 2822.90) return grossSalary * 0.09;
            if (grossSalary <= 5645.80) return grossSalary * 0.11;

            return 621.03;
        }
        public static double CalcFgtsTax(double grossSalary)
        {
            return grossSalary * 0.08;
        }
        public static double CalcNetSalary(double grossSalary, double incomeTax, double inssTax)
        {
            return grossSalary - incomeTax - inssTax;
        }
    }
}
