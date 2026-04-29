using System.ComponentModel.DataAnnotations;

public class Estudiante
{
    [Required(ErrorMessage = "El nombre no debe estar vacío")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El correo no debe estar vacío")]
    [EmailAddress(ErrorMessage = "Correo no válido")]
    public string Correo { get; set; }

    [Required(ErrorMessage = "La calificación no debe estar vacía")]
    [Range(0, 10, ErrorMessage = "La calificación debe estar entre 0 y 10")]
    public double? Calificacion { get; set; } = 0;
}