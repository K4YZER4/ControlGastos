namespace ControlGastos.Logica
{
    public class Gasto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
