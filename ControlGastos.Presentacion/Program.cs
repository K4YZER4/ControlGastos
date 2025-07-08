using ControlGastos.Logica;
using ControlGastos.Datos;

Console.WriteLine("Agregar nuevo gasto:");
Console.Write("Descripción: ");
string desc = Console.ReadLine();

Console.Write("Categoría: ");
string cat = Console.ReadLine();

Console.Write("Monto: ");
decimal monto = decimal.Parse(Console.ReadLine());

DateTime fecha = DateTime.Now;

Gasto nuevo = new Gasto
{
    Descripcion = desc,
    Categoria = cat,
    Monto = monto,
    Fecha = fecha
};

GastoDAL dal = new GastoDAL();
dal.InsertarGasto(nuevo);

Console.WriteLine("✅ Gasto guardado exitosamente.");
