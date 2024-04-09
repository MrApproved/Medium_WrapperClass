namespace Example3_Printer.WrapperCode.Objects
{
    public class Employee : Job
    {
        public string Name { get; set; }
        public string EmployeeReference { get; set; }
        public decimal YearlySalary { get; set; }

        public override string Print()
            => $"Name: {Name} ({EmployeeReference}) - Yearly Salary: {YearlySalary}";
    }
}