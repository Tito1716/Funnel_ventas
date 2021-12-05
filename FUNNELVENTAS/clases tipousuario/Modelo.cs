using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNNELVENTAS
{
    class Modelo
    {
        public int registro(Usuarios usuario)
        {
            
            const String var_ruta = "server=localhost;user id=root;password=2021;persist security info=True;database=funnel_ventas2";
         
            MySql.Data.MySqlClient.MySqlConnection cnSQL = new MySql.Data.MySqlClient.MySqlConnection(var_ruta);
            MySql.Data.MySqlClient.MySqlCommand cmSQL = new MySql.Data.MySqlClient.MySqlCommand();
            cnSQL.Open();

            string sql = "INSERT INTO usuario (password, nombre, id_tipo) VALUES( @password, @nombre, @id_tipo)";
            MySqlCommand comando = new MySqlCommand(sql, cnSQL);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@id_tipo", usuario.Id_tipo);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        

        public int eliminar(Usuarios usuario)
        {

            const String var_ruta = "server=localhost;user id=root;password=2021;persist security info=True;database=funnel_ventas2";

            MySql.Data.MySqlClient.MySqlConnection cnSQL = new MySql.Data.MySqlClient.MySqlConnection(var_ruta);
            MySql.Data.MySqlClient.MySqlCommand cmSQL = new MySql.Data.MySqlClient.MySqlCommand();
            cnSQL.Open();

            string sql = "delete from usuario where (`id_usuario` = @id_usuario)";
            MySqlCommand comando = new MySqlCommand(sql, cnSQL);
            
            comando.Parameters.AddWithValue("@id", usuario.Id);


            int resultado = comando.ExecuteNonQuery();


            return resultado;


        }
        public int modificar(Usuarios usuario)
        {

            const String var_ruta = "server=localhost;user id=root;password=2021;persist security info=True;database=funnel_ventas2";

            MySql.Data.MySqlClient.MySqlConnection cnSQL = new MySql.Data.MySqlClient.MySqlConnection(var_ruta);
            MySql.Data.MySqlClient.MySqlCommand cmSQL = new MySql.Data.MySqlClient.MySqlCommand();
            cnSQL.Open();

            string sql = "UPDATE `usuario` SET `nombre` = @nombre, `password` = @password, `usuario` = @usuario, `tipo_usuario` = @id_tipo WHERE (`id_usuario` = @id_usuario)";
            MySqlCommand comando = new MySqlCommand(sql, cnSQL);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@tipo_usuario", usuario.Id_tipo);
            comando.Parameters.AddWithValue("@id_usuario", usuario.Id);


            int resultado = comando.ExecuteNonQuery();

           
            return resultado;

            
        }

        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            const String var_ruta = "server=localhost;user id=root;password=2021;persist security info=True;database=funnel_ventas2";

            MySql.Data.MySqlClient.MySqlConnection cnSQL = new MySql.Data.MySqlClient.MySqlConnection(var_ruta);
            MySql.Data.MySqlClient.MySqlCommand cmSQL = new MySql.Data.MySqlClient.MySqlCommand();
            cnSQL.Open();

            string sql = "SELECT id_usuario FROM usuario WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, cnSQL);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public Usuarios porUsuario(string usuario)
        {
            MySqlDataReader reader;
            const String var_ruta = "server=localhost;user id=root;password=24505147St*;persist security info=True;database=funnel_ventas2";

            MySql.Data.MySqlClient.MySqlConnection cnSQL = new MySql.Data.MySqlClient.MySqlConnection(var_ruta);
            MySql.Data.MySqlClient.MySqlCommand cmSQL = new MySql.Data.MySqlClient.MySqlCommand();
            cnSQL.Open();

            string sql = "SELECT id_usuario, password, nombre, tipo_usuario FROM usuario WHERE nombre LIKE @nombre";
            MySqlCommand comando = new MySqlCommand(sql, cnSQL);
            comando.Parameters.AddWithValue("@nombre", usuario);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Id = int.Parse(reader["id_usuario"].ToString());
                usr.Password = reader["password"].ToString();
                usr.Nombre = reader["nombre"].ToString();
                usr.Id_tipo = int.Parse(reader["tipo_usuario"].ToString());
            }
            return usr;
        }
    }
}
