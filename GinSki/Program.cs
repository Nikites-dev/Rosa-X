using GinSki.Components;
using GinSki.Data;
using GinSki.Models;
using GinSki.Pages;
using GinSki.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MudBlazor;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<BehaviourService>();

builder.Services.AddSingleton<Admin>();
builder.Services.AddSingleton<Client>();
builder.Services.AddSingleton<InvertoryType>();
builder.Services.AddSingleton<Inventory>();
builder.Services.AddSingleton<Inventory>();
builder.Services.AddSingleton<InventoryRental>();
builder.Services.AddSingleton<Skipass>();

builder.Services.AddSingleton<SkipassComponent>();
builder.Services.AddSingleton<HeaderMenu>();
builder.Services.AddSingleton<ActiveGuest>();
builder.Services.AddSingleton<SignIn>();
builder.Services.AddSingleton<RentalInventory>();
builder.Services.AddSingleton<InventoryComponent>();
builder.Services.AddSingleton<AddInventory>();

builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomLeft;

    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.VisibleStateDuration = 10000;
    config.SnackbarConfiguration.HideTransitionDuration = 500;
    config.SnackbarConfiguration.ShowTransitionDuration = 500;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
});



var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
