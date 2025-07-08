using ControlGastos.Logica;
using MySql.Data.MySqlClient;
namespace ControlGastos.Datos
{
    public class GastoDAL
    {
        private string connectionString = "server=localhost;database=control_gastos;uid=root;pwd=;";

        public List<Gasto> ObtenerGastos()
        {
            List<Gasto> lista = new List<Gasto>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM gastos ORDER BY fecha DESC";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Gasto
                        {
                            Id = reader.GetInt32("id"),
                            Descripcion = reader.GetString("descripcion"),
                            Categoria = reader.GetString("categoria"),
                            Monto = reader.GetDecimal("monto"),
                            Fecha = reader.GetDateTime("fecha")
                        });
                    }
                }
            }
            return lista;
        }
        public void InsertarGasto(Gasto gasto)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO gastos (descripcion, categoria, monto, fecha) 
                         VALUES (@descripcion, @categoria, @monto, @fecha)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@descripcion", gasto.Descripcion);
                cmd.Parameters.AddWithValue("@categoria", gasto.Categoria);
                cmd.Parameters.AddWithValue("@monto", gasto.Monto);
                cmd.Parameters.AddWithValue("@fecha", gasto.Fecha);

                cmd.ExecuteNonQuery(); // Ejecuta la consulta sin devolver resultados
            }
        }


    }
}
