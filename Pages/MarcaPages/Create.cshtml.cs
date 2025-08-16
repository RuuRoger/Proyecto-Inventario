using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto_Inventario.Data;
using Proyecto_Inventario.Models;

namespace Proyecto_Inventario.Pages.Marca;

public class CreateModel : PageModel
{
    private readonly InventarioDbContext _context;

    [BindProperty]
    public MarcaModel MarcaForm { get; set; } = new MarcaModel();

    public CreateModel(InventarioDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
            return Page();

        _context.Marca.Add(MarcaForm);
        await _context.SaveChangesAsync();

        return RedirectToPage("Index");
    }

}