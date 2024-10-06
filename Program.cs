using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NewQuizApp.Components;
using NewQuizApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<QuizDbContext>((provider, options) =>
{
    options.UseSqlServer("data source=DESKTOP-KNK93V5\\SQLEXPRESS;initial catalog=DBTest;trusted_connection=true;Encrypt=True;TrustServerCertificate=True");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
