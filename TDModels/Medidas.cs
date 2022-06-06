namespace TDModels
{
    public class Medidas
    {
        [Key]
        public int IdMedida { get; set; }
        [Required(ErrorMessage = "Debe indicar un nombre para la medida")]
        public string? Nombre { get; set; }
    }
}
