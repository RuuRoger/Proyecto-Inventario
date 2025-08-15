using System.ComponentModel.DataAnnotations;

namespace Proyecto_Inventario.Models;

public class Producto
{
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; } = string.Empty;

    public string? Descripcion { get; set; }

    public int MarcaId { get; set; }

    public virtual Marca? Marca { get; set; }
    
    public decimal Precio { get; set; }
}