using Data;
using Lab3.Models;

namespace Lab3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

           // builder.Services.AddDefaultIdentity<IdentityUser>
                //.AddRoles<IdentityRole>()
                //.

            // Add services to the container.
            //nowy
            builder.Services.AddRazorPages();
            builder.Services.AddSession();
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IContactService, MemoryContactService>();
            builder.Services.AddSingleton<IAlbumService, MemoryAlbumService>();
            builder.Services.AddSingleton<IDateTimeProvider, CurrentDateTimeProvider>();
            builder.Services.AddTransient<IContactService, EFContactService>();
            builder.Services.AddTransient<IAlbumService, EFAlbumService>();
            builder.Services.AddDbContext<AppDbContext>();
            
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();  
            app.UseStaticFiles();

            app.UseRouting();
            app.UseMiddleware<LastVisitCookie>();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            app.MapRazorPages();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}