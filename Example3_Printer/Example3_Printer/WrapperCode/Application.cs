using Example3_Printer.WrapperCode.Objects;

namespace Example3_Printer.WrapperCode
{
    public class Application
    {
        public void Run()
        {
            var printer = new Printer();

            printer.Add(new Employee()
            {
                EmployeeReference = "EMPREF-0001",
                Name = "Amy Rose",
                YearlySalary = 1000000
            });

            printer.Add(new Square()
            {
                Size = 10
            });

            printer.Add(new Weapon()
            {
                BaseDamage = 15,
                Rarity = Rarity.Epic,
                Title = "Battleaxe",
                Type = WeaponType.Axe
            });

            printer.Print();
        }
    }
}
