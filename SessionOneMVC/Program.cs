using SessionOneMVC.Middlewares;

namespace SessionOneMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            app.UseMiddleware<RequestTimingMiddleware>();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            //Inline middleware [Custom middleware]
            //app.Use(async (context, next) =>
            //{
            //    //Before next [Request]
            //    Console.WriteLine($"Hello");
            //    //next
            //    await next(context);
            //    //After next [Response]
            //    Console.WriteLine($"Bye");
            //});

            app.UseAuthorization();

            app.MapStaticAssets();
            //app.MapControllerRoute(
            //    name:"shop",
            //    pattern: "{controller}/{action}/{id}",
            //    defaults: new
            //    {
            //        controller = "Products",
            //        action = "TestRouting"
            //    },
            //    constraints: new
            //    {
            //        id = new IntRouteConstraint()
            //    }
            //    );

            //app.MapControllerRoute(
            //name: "shop",
            //pattern: "{controller=Products}/{action=TestRouting}/{id:int?}"
            //);
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
