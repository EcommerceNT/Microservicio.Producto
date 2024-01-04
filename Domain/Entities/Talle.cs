namespace Domain.Entities
{
    public class Talle
    {
        public int TalleId { get; set; }
        public string Descripcion { get; set; }

        public ICollection<TalleProducto> TallesProductos { get; set; }
    }
}
