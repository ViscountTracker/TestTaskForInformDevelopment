using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TestTaskForInformDevelopment.Data;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
      

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
        }

       //app.CalculateCurrentValue(); // TODO: 

        app.UseStaticFiles();

        app.UseRouting();

        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

        app.Run();
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
    public void CalculateCurrentValue()
    {
        var daysOwned = DateTime.Now - PurchaseDateTime; 

        int periodCount = 0;
        int periodDays = PeriodDays;
        double totalDays = daysOwned.TotalDays;

        if (periodDays > 0)
        {
            periodCount = (int)(totalDays / periodDays);
        }
        CurrentValue = InitialValue - (DepreciationPerPeriod * periodCount);
    }
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<InformDevDB>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("\"Server=<DESKTOP-VHS34O0\\\\User>;Database=<(localdb)\\\\MSSQLLocalDB>;User Id=<default>;\"")));
    }
}