namespace TDModels
{
    public class Producto
    {
        // Product Data Fields
        [Key]
        public int IdProducto { get; set; }
        [Required(ErrorMessage = "Debe indicar un código de barras")]
        public string? Codigo { get; set; }
        [Required(ErrorMessage = "Debe indicar un nombre para el producto")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un precio de producto")]
        [Range(0, float.MaxValue, ErrorMessage = "Debe ingresar un precio válido")]
        public int Precio { get; set; }
        [Required(ErrorMessage = "Debe indicar un tipo de medida")]
        [ForeignKey("IdMedida")]
        public int IdMedida { get; set; }
        [Required(ErrorMessage = "Debe proporcionar el monto de tipo de medida")]
        public string? Cantidad { get; set; }

    }
}