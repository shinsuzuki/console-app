namespace console_app_fw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = ConsoleApp.Create(args);
            app.AddAllCommandType();
            app.Run();
        }
    }

}



