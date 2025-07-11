using ControlGastos.Entidades;
using ControlGastos.Datos;
using ControlGastos.Logica;
//Console.WriteLine("Agregar nuevo gasto:");
//Console.Write("Descripción: ");
//string desc = Console.ReadLine();

//Console.Write("Categoría: ");
//string cat = Console.ReadLine();

//Console.Write("Monto: ");
//decimal monto = decimal.Parse(Console.ReadLine());

//DateTime fecha = DateTime.Now;

//Gasto nuevo = new Gasto
//{
//    Descripcion = desc,
//    Categoria = cat,
//    Monto = monto,
//    Fecha = fecha
//};

//GastoDAL dal = new GastoDAL();
//dal.InsertarGasto(nuevo);

//Console.WriteLine("✅ Gasto guardado exitosamente.");
//GastoDAL gastoDAL = new GastoDAL();
//List<Gasto> lista = gastoDAL.ObtenerGastos();

//foreach (var gasto in lista)
//{
//    Console.WriteLine($"{gasto.Fecha:dd/MM/yyyy} - {gasto.Categoria} - {gasto.Descripcion} - ${gasto.Monto}");
//}

//Console.ReadKey();
GastoManager manager = new GastoManager();
        try
        {
            manager.InsertarGasto(new Gasto
            {
                Descripcion = "Test",
                Categoria = "Test",
                Monto = -80, // Esto debería fallar
                Fecha = DateTime.Now
            });

            Console.WriteLine("❌ No se lanzó la excepción esperada.");
        }
        catch
        {
            Console.WriteLine("✅ Prueba exitosa: monto inválido detectado.");
        }
//Comentario para ver historial 1
// Comentario para ver historial 2