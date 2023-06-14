namespace mvcGiris
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //Projenin main tarafının çalışması için hazır bir kod
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<StartUp>();
                    //mutlaka bir UseStartup oluşturmamız lazım İçerideki bizim verdiğimiz isim
                });
    }
}