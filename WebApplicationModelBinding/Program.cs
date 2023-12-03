namespace WebApplicationModelBinding
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapControllerRoute(name:"default",pattern: "{controller=students}/{action=index}/{id?}");

            app.Run();
        }
    }
}