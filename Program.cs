namespace ProductInventoryManagement
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // open the SearchProduct form by default
            Application.Run(new Form()); 
        } 
    }
}