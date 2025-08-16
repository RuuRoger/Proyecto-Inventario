using Microsoft.EntityFrameworkCore;
using Proyecto_Inventario.Models;

namespace Proyecto_Inventario.Data;

public class InventarioDbContext : DbContext
{
    public InventarioDbContext(DbContextOptions<InventarioDbContext> options)
            : base(options)
    {
    }

    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Marca> Marcas { get; set; }
    public DbSet<Producto> Productos { get; set; }
}