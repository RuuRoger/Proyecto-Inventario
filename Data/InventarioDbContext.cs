using Microsoft.EntityFrameworkCore;
using Proyecto_Inventario.Models;

namespace Proyecto_Inventario.Data;

public class InventarioDbContext : DbContext
{
    public InventarioDbContext(DbContextOptions<InventarioDbContext> options)
            : base(options)
    {
    }

    public DbSet<Departamento> Departamento { get; set; }
    public DbSet<Marca> Marca { get; set; }
    public DbSet<Producto> Producto { get; set; }
}