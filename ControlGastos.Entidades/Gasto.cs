namespace ControlGastos.Entidades
{
    public class Gasto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        //public Gasto(int id, string descripcion, string categoria, decimal monto, DateTime fecha)
        //{
        //    Id = id;
        //    Descripcion = descripcion;
        //    Categoria = categoria;
        //    Monto = monto;
        //    Fecha = fecha;
        //}

    }
}
