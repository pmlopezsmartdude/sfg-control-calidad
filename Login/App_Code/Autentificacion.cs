using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
public static class Autentificacion
{
    
    public static bool Autenticar(string usuario, string password)
    {
        //consulta a la base de datos
        string sql = @"SELECT COUNT(*)
                              FROM usuario
                              WHERE usurutusu = @user AND usupasswo = @pass";
        
        //cadena conexion
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
        {
            conn.Open();//abrimos conexion

            SqlCommand cmd = new SqlCommand(sql,conn); //ejecutamos la instruccion
            cmd.Parameters.AddWithValue("@user", usuario); //enviamos los parametros
            cmd.Parameters.AddWithValue("@pass", password);
            int count = Convert.ToInt32(cmd.ExecuteScalar()); //devuelve la fila afectada
            conn.Close();

            if (count == 0)
                return false;
            else
                return true;
        }
    }
    public static string strname(string input)
    {
        string strmessage = input;
        string sql1 = @"SELECT usunombre FROM usuario WHERE usurutusu = @user";
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@user", input);
            string nom = Convert.ToString(cmd1.ExecuteReader());
            strmessage = nom;
        }
        return strmessage;
    }
	
}