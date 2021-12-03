using System;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using FUNNELVENTAS.Clases;
using System.Windows.Forms;
using System.Collections.Generic;

public class cConexion
{
    const String var_ruta = "server=localhost;user id=root;password=2021;persist security info=True;database=funnel_ventas2";
    DataSet ds = new DataSet();
    MySql.Data.MySqlClient.MySqlConnection cnSQL = new MySql.Data.MySqlClient.MySqlConnection(var_ruta);
    MySql.Data.MySqlClient.MySqlCommand cmSQL = new MySql.Data.MySqlClient.MySqlCommand();

    public DataSet buscar(String strSQL, String tabla) {
        DataSet ds = new DataSet();
        try
        {
            cnSQL.Open();
            MySql.Data.MySqlClient.MySqlDataAdapter daSQL = new MySql.Data.MySqlClient.MySqlDataAdapter(strSQL, cnSQL);
            daSQL.Fill(ds, tabla);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cnSQL.Close();
        }
        return ds;
    }
    public void operacion(String strsql) {
        try {
            cnSQL.Open();
            MySql.Data.MySqlClient.MySqlCommand cmSQL = new MySql.Data.MySqlClient.MySqlCommand(strsql, cnSQL);
            cmSQL.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cnSQL.Close();
        }
    }
     
   

    public DataTable getCombo(string query)
    {
        DataTable dt = new DataTable();
        try
        {
            cnSQL.Open();
            MySql.Data.MySqlClient.MySqlCommand cmSQL = new MySql.Data.MySqlClient.MySqlCommand(query, cnSQL);
            MySqlDataAdapter data = new MySqlDataAdapter(cmSQL);
           
            data.Fill(dt);

            

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cnSQL.Close();
        }
        return dt;
    }

    


    public bool login(string nombre, string pass)
    {
        usuario usu = new usuario();
        try
        {
            var connection = cnSQL;
            connection.Open();

            using (var command = new MySqlCommand())
            {
                command.Connection = connection;
                command.CommandText = "select * from  usuario where(nombre=@nombre and password=@pass )";
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@pass", pass);
          
                command.CommandType = CommandType.Text;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                { 
                    while (reader.Read())
                    {
                        usu.Id_usuario = reader.GetInt32(0);
                        usu.Nombre = reader.GetString(1);
                        usu.Password = reader.GetString(2);
                        usu.Usuario = reader.GetString(3);
                        usu.Tipo_usuario = reader.GetInt32(4);
                        
                    }
                    return true;
                }
                else
                    return false;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cnSQL.Close();
        }

    }

    

    public double escalar_double(String strsql){
        try{
            cnSQL.Open();
            MySql.Data.MySqlClient.MySqlCommand cmsSQL=new MySql.Data.MySqlClient.MySqlCommand(strsql,cnSQL);
            return Convert.ToDouble(cmsSQL.ExecuteScalar());
        }
        catch(Exception ex)
        {
           throw ex;
        }
        finally
        {
            cnSQL.Close();
        }
    }
    public String escalar_cadena(String strsql)
    {
        try
        {
            cnSQL.Open();
            MySql.Data.MySqlClient.MySqlCommand cmsSQL = new MySql.Data.MySqlClient.MySqlCommand(strsql, cnSQL);
            return Convert.ToString(cmsSQL.ExecuteScalar());
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cnSQL.Close();
        }
    }
    public Int64 valor(String strsql)
    {
        try
        {
            cnSQL.Open();
            MySql.Data.MySqlClient.MySqlCommand cmsSQL = new MySql.Data.MySqlClient.MySqlCommand(strsql, cnSQL);
            return Convert.ToInt64(cmsSQL.ExecuteScalar());
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cnSQL.Close();
        }
    }
}
