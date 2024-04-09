namespace Example3_Printer.OriginalCode
{
    public class Application
    {
        public void Run()
        {
            var printer = new Printer();

            printer.Add(new Job()
            {
                Content = "First job..."
            });
            printer.Add(new Job()
            {
                Content = "Second job..."
            });

            printer.Print();
        }
    }
}
