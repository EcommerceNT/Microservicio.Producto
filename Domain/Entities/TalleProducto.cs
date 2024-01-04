namespace Domain.Entities
{
    public class TalleProducto
    {
        public int TalleProductoId { set; get; }
        public int Stock { set; get; }

        public int TalleId { set; get; }
        public Talle Talle { set; get; }

        public int ProductoId { set; get; }
        public Producto Producto { set; get; }
    }
}
