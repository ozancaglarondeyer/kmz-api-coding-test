using Libraries.Core.Models;
using Libraries.Services.KategoriIslemleri;
using Libraries.Services.UrunIslemleri;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;

namespace AkilliTicaretWebApp.Extension
{
    public static class DependencyResolver
    {
        public static IServiceCollection DependencySolve(this IServiceCollection service)
        {
            service.AddScoped<ApplicationDbContext, ApplicationDbContext>();
            service.AddScoped<IUrunService, UrunService>();
            service.AddScoped<IKategoriService, KategoriService>();
            return service;
        }


    }
}   
