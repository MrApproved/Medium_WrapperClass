using System.Text;

namespace Example3_Printer.WrapperCode.Objects
{
    public class Square : Job
    {
        public int Size { get; set; }

        public override string Print()
        {
            var sb = new StringBuilder();
            for (var y = 0; y < Size; y++)
            {
                for (var x = 0; x < Size; x++)
                {
                    sb.Append("#");
                }

                if(y != (Size -1))
                    sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}