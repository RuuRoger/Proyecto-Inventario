using System.ComponentModel.DataAnnotations;

namespace Proyecto_Inventario.Models;

public class Departamento
{
    public int Id { get; set; }
    
    [Required]
    public string Nombre { get; set; } = string.Empty;
}