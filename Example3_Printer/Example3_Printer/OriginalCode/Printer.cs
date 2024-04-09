using System.Text;

namespace Example3_Printer.OriginalCode
{
    public class Printer
    {
        private ICollection<Job> Jobs;

        public Printer() => ResetJobs();

        public void Add(Job job)
            => Jobs.Add(job);

        public void Print()
        {
            var output = new StringBuilder();
            foreach (var job in Jobs)
                output.AppendLine(job.Print());

            ResetJobs();
            Console.Write(output.ToString());
        }

        private void ResetJobs()
            => Jobs = new List<Job>();
    }
}