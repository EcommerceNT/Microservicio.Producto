namespace Domain.Entities
{
    public class Color
    {
        public int ColorId { get; set; }
        public string Descripcion { get; set; }

        public ICollection<ColorProducto> ColoresProductos { get; set; }
    }
}
