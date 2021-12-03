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
    public void ConsultaExcel()
    {
        try
        {
            SLDocument sl = new SLDocument();

            int celdacabecera = 5;
            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "VENTAS");
            sl.SetCellValue("B" + celdacabecera, "Id");
            sl.SetCellValue("C" + celdacabecera, "Cliente");
            sl.SetCellValue("D" + celdacabecera, "Ejecutivo");
            sl.SetCellValue("E" + celdacabecera, "Gestion");
            sl.SetCellValue("F" + celdacabecera, "Estado");
            sl.SetCellValue("G" + celdacabecera, "Proxima Gestion");
            sl.SetCellValue("I" + celdacabecera, "Fecha Inicial");
            sl.SetCellValue("J" + celdacabecera, "Cantidad Equipo");
            sl.SetCellValue("K" + celdacabecera, "Tipo Equipo");
            sl.SetCellValue("L" + celdacabecera, "Marca Equipo");
            sl.SetCellValue("M" + celdacabecera, "Detalle Equipo");
            sl.SetCellValue("N" + celdacabecera, "Monto Equipo");
            sl.SetCellValue("O" + celdacabecera, "Cantidad Enlace");
            sl.SetCellValue("P" + celdacabecera, "Tipo Enlace");
            sl.SetCellValue("Q" + celdacabecera, "Tipo Ancho");
            sl.SetCellValue("R" + celdacabecera, "Detalle Enlace");
            sl.SetCellValue("S" + celdacabecera, "Monto Enlace");
            sl.SetCellValue("T" + celdacabecera, "Cantidad consultoria");
            sl.SetCellValue("U" + celdacabecera, "Tipo Consultoria");
            sl.SetCellValue("V" + celdacabecera, "Tipo Conslturia 2");
            sl.SetCellValue("W" + celdacabecera, "Monto Consultoria");
            sl.SetCellValue("X" + celdacabecera, "Total");
            sl.SetCellValue("Y" + celdacabecera, "Clase");
            sl.SetCellValue("Z" + celdacabecera, "Proyeccion");

            string query = "select id_venta, nombre_cliente, Ejecutivo_Cuentas, tipo_gestion, tipo_estado ,prox_Gestion, fecha_inicial, cantidad_equipo, tipo_equipo," +
                "marca_equipo, detalle_equipo,  monto_equipo,cantidad_enlace, tipo_enlace, tipo_ancho,detalle_enlace, monto_enlace, cantidad_consultoria, " +
                "tipo_consultoria, tipo_consultoria2, detalle_consultoria, monto_consultoria, total, tipo_clase, tipo_proyecion from ventas";

            
            cnSQL.Open();
            MySql.Data.MySqlClient.MySqlCommand cmSQL = new MySql.Data.MySqlClient.MySqlCommand(query, cnSQL);
            MySqlDataReader reader = cmSQL.ExecuteReader();
            while (reader.Read())
            {
                celdacabecera++;
                sl.SetCellValue("B" + celdacabecera, reader["id_venta"].ToString());
                sl.SetCellValue("C" + celdacabecera, reader["nombre_cliente"].ToString());
                sl.SetCellValue("D" + celdacabecera, reader["Ejecutivo_Cuentas"].ToString());
                sl.SetCellValue("E" + celdacabecera, reader["tipo_gestion"].ToString());
                sl.SetCellValue("F" + celdacabecera, reader["tipo_estado"].ToString());
                sl.SetCellValue("G" + celdacabecera, reader["prox_Gestion"].ToString());
                sl.SetCellValue("I" + celdacabecera, reader["fecha_inicial"].ToString());
                sl.SetCellValue("J" + celdacabecera, reader["cantidad_equipo"].ToString());
                sl.SetCellValue("K" + celdacabecera, reader["tipo_equipo"].ToString());
                sl.SetCellValue("L" + celdacabecera, reader["marca_equipo"].ToString());
                sl.SetCellValue("M" + celdacabecera, reader["detalle_equipo"].ToString());
                sl.SetCellValue("N" + celdacabecera, reader["monto_equipo"].ToString());
                sl.SetCellValue("O" + celdacabecera, reader["cantidad_enlace"].ToString());
                sl.SetCellValue("P" + celdacabecera, reader["tipo_enlace"].ToString());
                sl.SetCellValue("Q" + celdacabecera, reader["tipo_ancho"].ToString());
                sl.SetCellValue("R" + celdacabecera, reader["detalle_enlace"].ToString());
                sl.SetCellValue("S" + celdacabecera, reader["monto_enlace"].ToString());
                sl.SetCellValue("T" + celdacabecera, reader["cantidad_consultoria"].ToString());
                sl.SetCellValue("U" + celdacabecera, reader["tipo_consultoria"].ToString());
                sl.SetCellValue("V" + celdacabecera, reader["tipo_consultoria2"].ToString());
                sl.SetCellValue("W" + celdacabecera, reader["detalle_consultoria"].ToString());
                sl.SetCellValue("X" + celdacabecera, reader["monto_consultoria"].ToString());
                sl.SetCellValue("Y" + celdacabecera, reader["total"].ToString());
                sl.SetCellValue("Z" + celdacabecera, reader["tipo_clase"].ToString());
            }
            sl.SaveAs("Prueba1.xlsx");
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
                    "tipo_consultoria, tipo_consultoria2, detalle_consultoria, monto_consultoria, total, tipo_clase, " +
                    "tipo_proyecion) values (@nombre_cliente, @Ejecutivo_Cuentas, @tipo_gestion, @tipo_estado," +
                    "@prox_Gestion, @fecha_inicial, @cantidad_equipo, @tipo_equipo, @marca_equipo, @detalle_equipo, @monto_equipo," +
                    "@cantidad_enlace, @tipo_enlace, @tipo_ancho, @detalle_enlace, @monto_enlace, @cantidad_consultoria," +
                    "@tipo_consultoria, @tipo_consultoria2, @detalle_consultoria, @monto_consultoria, @total, @tipo_clase, " +
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
                command.Parameters.AddWithValue("@tipo_clase", venta.tipo_clase);
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
