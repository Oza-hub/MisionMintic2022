using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class ListAeropuertosModel : PageModel
    {
       
    private readonly RepositorioAeropuertos repositorioAeropuertos;
    public IEnumerable<Aeropuertos> Aeropuertos {get;set;}
    [BindProperty]
    public Aeropuertos Aeropuerto {get;set;}
    [TempData]
    public bool Error {get;set;}

    public ListAeropuertosModel(RepositorioAeropuertos repositorioAeropuertos)
    {
        this.repositorioAeropuertos=repositorioAeropuertos;
     }
 
    public void OnGet()
    {
        Aeropuertos=repositorioAeropuertos.GetAll();
    }

    public IActionResult OnPost()
    {
        if(Aeropuerto.id>0)
        {
            Error = repositorioAeropuertos.Delete(Aeropuerto.id);
        }
        return RedirectToPage("./List");
    }

    }
}
