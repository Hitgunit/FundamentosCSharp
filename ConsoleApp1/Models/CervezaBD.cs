using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    internal class CervezaBD
    {
        //Conector que brinda los datos para la conexion a la base de datos
        private string connectionString = "Data Source = DESKTOP-MNU5NTI\\NOVACAJA2; Initial Catalog = FundamentosCSharp; User=sa; Password=NOVACAJA";

        //Listado que guardara la informacion de lo obtenido de la base de datos
        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            //Instruccion en SQL de lo que quiere que hagamos
            string query = "select nombre, marca, alcohol, cantidad from cerveza";

            //Realiza la conexion a la base de datos con lo parametros del conector
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Sirve para mandar consultas
                SqlCommand cmd = new SqlCommand(query, connection);

                //Abre la conexion a la base de datos
                connection.Open();
                //Lee el resultado uno a uno
                SqlDataReader reader = cmd.ExecuteReader();
                //Se utiliza para leer cada objeto dentro de la tabla
                while (reader.Read())
                {
                    //Se obtiene los parametros de la base de datos
                    int Cantidad = reader.GetInt32(3);
                    string Nombre = reader.GetString(0);
                    Cerveza cerveza = new Cerveza(Cantidad, Nombre);
                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.Marca = reader.GetString(1);
                    cervezas.Add(cerveza);
                }
                //Se cierra el parametro reader
                reader.Close();
                //Se cierra la conexion a la base de datos
                connection.Close();
            }
            //Devuelve el objeto cerveza con los parametros requeridos
            return cervezas;
        }


        public void Add(Cerveza cerveza)
        {
            //Se realzia el query seleccionado pero con un "@" antes de cada insercion ya que asis e evita la inyeccion
            string query = "Insert into cerveza (nombre, marca, alcohol, cantidad) values (@nombre, @marca, @alcohol, @cantidad)";

            using (var connection = new SqlConnection(connectionString))
            {

                var command = new SqlCommand(query, connection);
                //Se utiliza addWithValue para poder acceder a los valores sin miedo a la inyeccion SQL
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);

                connection.Open();
                //Este parametro indica que se hara una insercion de datos al SQL
                command.ExecuteNonQuery();

                connection.Close();

            }

        }

        public void Edit(Cerveza cerveza, int Id)
        {
            //Se modifica la sentencia
            string query = "update cerveza set nombre=@nombre, marca=@marca, alcohol=@alcohol, cantidad=@cantidad where id = @id";

            using (var connection = new SqlConnection(connectionString))
            {

                var command = new SqlCommand(query, connection);
                //Se utiliza addWithValue para poder acceder a los valores sin miedo a la inyeccion SQL
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);
                //Se agrega la variable id para selecionar el que queremos modificar
                command.Parameters.AddWithValue("@id", Id);
                connection.Open();
                //Este parametro indica que se hara una insercion de datos al SQL
                command.ExecuteNonQuery();

                connection.Close();

            }



        }

        public void Delete(int Id)
        {
            //Se modifica la sentencia
            string query = "delete from cerveza where id = @id";

            using (var connection = new SqlConnection(connectionString))
            {

                var command = new SqlCommand(query, connection);
                //Se agrega la variable id para selecionar el que queremos modificar
                command.Parameters.AddWithValue("@id", Id);
                connection.Open();
                //Este parametro indica que se hara una insercion de datos al SQL
                command.ExecuteNonQuery();

                connection.Close();

            }



        }

    }
}
