using FluentValidation;
using FluentValidationPractice_MVC.FluentValidators;
using FluentValidationPractice_MVC.ViewModels;
using System;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IValidatorFactory,ValidatorFactory>(); //Registrated fluentvalidation
builder.Services.AddTransient<IValidator<ProductVM>, ProductVMValidator>();

var app = builder.Build();



if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
   
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
