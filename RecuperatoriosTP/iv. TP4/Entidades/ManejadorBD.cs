using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ManejadorBD 
    {
        static string connectionString;
        static SqlCommand comando;
        static SqlConnection con;
        
        /// <summary>
        /// constructor estatico de la clase estatica ManejadorDB, setea los elementos relacionados con la conexion a la base de datos de clientes
        /// </summary>
        static ManejadorBD()
        {
            connectionString= "Data Source=.;Database=CLIENTES_DB;Trusted_Connection = True;";
            comando = new SqlCommand();
            con=new SqlConnection(connectionString);
            comando.CommandType=System.Data.CommandType.Text;
            comando.Connection=con;
        }
        
        /// <summary>
        /// Levanta los registros de todos los clientes guardados en la base de datos, retorna una lista de clientes con los registros levantados
        /// </summary>
        /// <returns></returns>
        public static List<Cliente> Leer()
        {
            try
            {
                List<Cliente> listaClientes = new List<Cliente>();
                con.Open();
                comando.CommandText = "SELECT * FROM Clientes_Data";
                using(SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        listaClientes.Add(new Cliente(dataReader["Email"].ToString(), dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString(), dataReader["ID"].ToString(), Convert.ToInt32(dataReader["activo"])));
                    }
                }
                return listaClientes;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Modifica de forma segura y parametrizada la informacion de un cliente en la base de datos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <param name="activo"></param>
        public static void ModificarCliente(string nombre, string apellido, string email, int id, bool activo)
        {
            try
            {
                con.Open();
                comando.CommandText = "UPDATE Clientes_Data SET Nombre = @0, Apellido = @1, Email = @2, activo = @4 WHERE ID = @3";
                comando.Parameters.AddWithValue("@0", nombre);
                comando.Parameters.AddWithValue("@1", apellido);
                comando.Parameters.AddWithValue("@2", email);
                comando.Parameters.AddWithValue("@3", id);
                if (activo)
                {
                    comando.Parameters.AddWithValue("@4", 1);
                }
                else
                {
                    comando.Parameters.AddWithValue("@4", 0);
                }
                
                comando.ExecuteNonQuery();
               
            }
            catch (Exception)
            {
                throw;
            }
            finally { con.Close(); }
        }

        /// <summary>
        /// Realiza la baja logica y borrado del mail de un cliente en la base de datos
        /// </summary>
        /// <param name="id"></param>
        public static void BajaCliente(int id)
        {
            try
            {
                con.Open();
                comando.CommandText = "UPDATE Clientes_Data SET Email = null, activo = 0 WHERE ID = @0";
                comando.Parameters.AddWithValue("@0",id);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Agrega de forma segura y parametrizada un cliente a la base de datos 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <param name="activo"></param>
        public static void AgregarCliente(string nombre, string apellido, string email, int id, bool activo)
        {
            try
            {
                con.Open();
                comando.CommandText = "INSERT INTO Clientes_Data (Nombre,Apellido,Email,ID,activo) VALUES (@0,@1,@2,@3,@4)";
                comando.Parameters.AddWithValue("@0", nombre);
                comando.Parameters.AddWithValue("@1", apellido);
                comando.Parameters.AddWithValue("@2", email);
                comando.Parameters.AddWithValue("@3", id);
                if (activo)
                {
                    comando.Parameters.AddWithValue("@4", 1);
                }
                else
                {
                    comando.Parameters.AddWithValue("@4", 0);
                }

                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally { con.Close(); }
        }

    }
}
