using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proyecto_Inventario.Data;
using Proyecto_Inventario.Models;

namespace Proyecto_Inventario.Pages.Marca;

public class IndexModel : PageModel
{
    private readonly InventarioDbContext _context;

    public IndexModel(InventarioDbContext context)
    {
        _context = context;
    }

    public IList<MarcaModel> MarcasViewModel { get; set; } = new List<MarcaModel>();

    public async Task OnGetAsync()
    {
        MarcasViewModel = await _context.Marca.ToListAsync();
    }
}