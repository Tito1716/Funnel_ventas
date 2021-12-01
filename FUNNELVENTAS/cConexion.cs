using System;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using FUNNELVENTAS.Clases;
using System.Collections.Generic;

public class cConexion
{
    const String var_ruta = "server=localhost;user id=root;password=24505147St*;persist security info=True;database=funnel_ventas2";
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
                command.CommandText = "select * from  usuario where(nombre=@nombre and password=@pass)";
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
                        usu.Tipo_usuario = reader.GetInt32(3);
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

    public void Guardar(Venta venta)
    {
        try
        {
            var connection = cnSQL;
            connection.Open();
            using (var command = new MySqlCommand())
            {
                command.Connection = connection;
                command.CommandText = "INSERT INTO ventas (nombre_cliente, Ejecutivo_Cuentas, tipo_gestion, tipo_estado," +
                    "prox_Gestion, fecha_inicial, cantidad_equipo, tipo_equipo, marca_equipo, detalle_equipo, monto_equipo," +
                    "cantidad_enlace, tipo_enlace, tipo_ancho, detalle_enlace, monto_enlace, cantidad_consultoria, " +
                    "tipo_consultoria, tipo_consultoria2, detalle_consultoria, monto_consultoria, total, " +
                    "tipo_proyecion) values (@nombre_cliente, @Ejecutivo_Cuentas, @tipo_gestion, @tipo_estado," +
                    "@prox_Gestion, @fecha_inicial, @cantidad_equipo, @tipo_equipo, @marca_equipo, @detalle_equipo, @monto_equipo," +
                    "@cantidad_enlace, @tipo_enlace, @tipo_ancho, @detalle_enlace, @monto_enlace, @cantidad_consultoria," +
                    "@tipo_consultoria, @tipo_consultoria2, @detalle_consultoria, @monto_consultoria, @total, " +
                    "@tipo_proyecion)";
                command.Parameters.AddWithValue("@nombre_cliente", venta.nombre_cliente);
                command.Parameters.AddWithValue("@Ejecutivo_Cuentas", venta.Ejecutivo_Cuentas);
                command.Parameters.AddWithValue("@tipo_gestion", venta.tipo_gestion);
                command.Parameters.AddWithValue("@tipo_estado", venta.tipo_estado);
                command.Parameters.AddWithValue("@prox_Gestion", venta.prox_Gestion);
                command.Parameters.AddWithValue("@fecha_inicial", venta.fecha_inicial);
                command.Parameters.AddWithValue("@cantidad_equipo", venta.cantidad_equipo);
                command.Parameters.AddWithValue("@tipo_equipo", venta.tipo_equipo);
                command.Parameters.AddWithValue("@marca_equipo", venta.marca_equipo);
                command.Parameters.AddWithValue("@detalle_equipo", venta.detalle_equipo);
                command.Parameters.AddWithValue("@monto_equipo", venta.monto_equipo);
                command.Parameters.AddWithValue("@cantidad_enlace", venta.cantidad_enlace);
                command.Parameters.AddWithValue("@tipo_enlace", venta.tipo_enlace);
                command.Parameters.AddWithValue("@tipo_ancho", venta.tipo_ancho);
                command.Parameters.AddWithValue("@detalle_enlace", venta.detalle_enlace);
                command.Parameters.AddWithValue("@monto_enlace", venta.monto_enlace);
                command.Parameters.AddWithValue("@cantidad_consultoria", venta.cantidad_consultoria);
                command.Parameters.AddWithValue("@tipo_consultoria", venta.tipo_consultoria);
                command.Parameters.AddWithValue("@tipo_consultoria2", venta.tipo_consultoria2);
                command.Parameters.AddWithValue("@detalle_consultoria", venta.detalle_consultoria);
                command.Parameters.AddWithValue("@monto_consultoria", venta.monto_consultoria);
                command.Parameters.AddWithValue("@total", venta.total);
               
                command.Parameters.AddWithValue("@tipo_proyecion", venta.tipo_proyecion);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

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
