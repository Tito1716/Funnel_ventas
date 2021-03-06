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
        cConexion con = new cConexion();
        public int registro(Usuarios usuario)
        {
           

            const String var_ruta = "server=localhost;user id=root;password=2021;persist security info=True;database=funnel_ventas2";

           
            con.cnSQL.Open();

            string sql = "INSERT INTO usuario (usuario, password, nombre, id_tipo) VALUES(@usuario, @password, @nombre, @id_tipo)";
            MySqlCommand comando = new MySqlCommand(sql, con.cnSQL);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@id_tipo", usuario.Id_tipo);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }


        public int eliminar(Usuarios usuario)
        {
            con.cnSQL.Open();

            string sql = "delete from usuario where (`id` = @id)";
            MySqlCommand comando = new MySqlCommand(sql, con.cnSQL);

            comando.Parameters.AddWithValue("@id", usuario.Id);


            int resultado = comando.ExecuteNonQuery();


            return resultado;


        }
        public int modificar(Usuarios usuario)
        {
            con.cnSQL.Open();

            string sql = "UPDATE `usuario` SET `nombre` = @nombre, `password` = @password, `usuario` = @usuario, `id_tipo` = @id_tipo WHERE (`id` = @id)";
            MySqlCommand comando = new MySqlCommand(sql, con.cnSQL);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@id_tipo", usuario.Id_tipo);
            comando.Parameters.AddWithValue("@id", usuario.Id);


            int resultado = comando.ExecuteNonQuery();


            return resultado;


        }

        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;

            con.cnSQL.Open();

            string sql = "SELECT id FROM usuario WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, con.cnSQL);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuarios porUsuario(string usuario)
        {
            MySqlDataReader reader;
            const String var_ruta = "server=localhost;user id=root;password=2021;persist security info=True;database=funnel_ventas2";


            con.cnSQL.Open();

            string sql = "SELECT id, password, nombre, id_tipo FROM usuario WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, con.cnSQL);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Id = int.Parse(reader["id"].ToString());
                usr.Password = reader["password"].ToString();
                usr.Nombre = reader["nombre"].ToString();
                usr.Id_tipo = int.Parse(reader["id_tipo"].ToString());
            }
            return usr;
        }
    }
}