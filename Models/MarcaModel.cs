using System.ComponentModel.DataAnnotations;

namespace Proyecto_Inventario.Models;

public class MarcaModel
{
    [Key]
    public int MarcaID { get; set; }

    [Required]
    public string Nombre { get; set; } = string.Empty;

    public virtual ICollection<Producto>? Productos { get; set; }
}