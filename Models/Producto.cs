using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Inventario.Models;

public class Producto
{
    [Key]
    public int ProductoID { get; set; }

    [Required]
    public string Nombre { get; set; } = string.Empty;

    public string? Descripcion { get; set; }

    [ForeignKey("Marca")]
    public int MarcaId { get; set; }

    public virtual Marca? Marca { get; set; }
    
    public decimal Precio { get; set; }
}