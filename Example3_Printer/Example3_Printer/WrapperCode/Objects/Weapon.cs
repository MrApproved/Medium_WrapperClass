using System.Text;

namespace Example3_Printer.WrapperCode.Objects
{
    public class Weapon : Job
    {
        public string Title { get; set; }
        public WeaponType Type { get; set; }
        public Rarity Rarity { get; set; }
        public int BaseDamage { get; set; }

        public override string Print()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Rarity: {Rarity}");
            sb.AppendLine($"Power: {BaseDamage}");
            return sb.ToString();
        }
    }

    public enum WeaponType
    {
        Sword,
        Axe,
        Bow,
        Mace,
        Staff
    }

    public enum Rarity
    {
        Uncommon,
        Common,
        Rare,
        Epic,
        Legendary
    }
}