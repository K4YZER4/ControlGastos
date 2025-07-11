using ControlGastos.Entidades;
using ControlGastos.Datos;
namespace ControlGastos.Logica
{
    public class GastoManager
    {   
        private GastoDAL gastoDAL = new Datos.GastoDAL();
        public void InsertarGasto(Gasto gasto)
        {
            if (gasto.Monto <= 0)
                throw new Exception("El monto debe ser mayor a cero.");

            gastoDAL.InsertarGasto(gasto);
            //if (gasto == null)
            //{
            //    throw new ArgumentNullException(nameof(gasto), "El gasto no puede ser nulo.");
            //}
            //if (int.IsNegative(gasto.Monto))
            //gastoDAL.InsertarGasto(gasto);
        }
        public List<Gasto> ObtenerTodos()
        {
            return gastoDAL.ObtenerGastos();
        }
    }
}
