using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using NuGet.Configuration;
using TurkishLocalFlavors.DataAccess.Concrete;
using TurkishLocalFlavors.Entity.Entities;

internal class Program
{
	private static void Main(string[] args)
	{
		var requireAuthorizePolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();


        var builder = WebApplication.CreateBuilder(args);

		builder.Services.AddDbContext<FlavorsContext>();
		builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<FlavorsContext>();

		builder.Services.AddHttpClient();
		// Add services to the container.
		builder.Services.AddControllersWithViews(opt=>
		{
			opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy));
		});

		builder.Services.ConfigureApplicationCookie(x =>
		{
			x.LoginPath = "/Login/Index";
		});

		var app = builder.Build();

		app.UseStatusCodePages(async x =>
		{
			if (x.HttpContext.Response.StatusCode == 404)
			{
				x.HttpContext.Response.Redirect("/Error/NotFound404Page/");
			}
		});

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
		app.UseAuthentication();
		app.UseAuthorization();

		app.MapControllerRoute(
			name: "default",
			pattern: "{controller=Home}/{action=Index}/{id?}");

		app.Run();
	}
}