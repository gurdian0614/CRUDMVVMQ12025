
using CRUDMVVMQ12025.Models;
using SQLite;

namespace CRUDMVVMQ12025.Services
{
    public class EmpleadoService
    {
        private readonly SQLiteConnection _connection;

        public EmpleadoService()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Empleado.db3");
            // Initialize connection and create database
            _connection = new SQLiteConnection(dbPath);
            // Create table
            _connection.CreateTable<Empleado>();

            /*Empleado empleado = new Empleado();
            empleado.Nombre = "Juan Perez";
            empleado.Direccion = "Choloma";
            empleado.Email = "juancito.perez@gamil.com";
            Insert(empleado);*/
        }

        public List<Empleado> GetAll()
        {
            // It's equal to SELECT * FROM Empleado
            return _connection.Table<Empleado>().ToList();
        }

        public int Insert(Empleado Empleado)
        {
            // It's equal to INSERT Empleado VALUES(id,....)
            return _connection.Insert(Empleado);
        }

        public int Update(Empleado Empleado)
        {
            // It's equal to UPDATE Empleado SET x=1 WHERE id = 1
            return _connection.Update(Empleado);
        }

        public int Delete(Empleado Empleado)
        {
            // // It's equal to DELETE FROM Empleado WHERE id = 1
            return _connection.Delete(Empleado);
        }
    }
}
