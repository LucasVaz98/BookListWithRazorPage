using BookListWithRazor.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=BooklistsRazor;Trusted_Connection=True;MultipleActiveResultSets=True"));
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//these lines are for middleware
app.UseHttpsRedirection();
app.UseStaticFiles(); //this methods allow us to use css, javaScript

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
