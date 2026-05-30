using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSCafeteria.DAL
{
    public static class ConexionDB
    {
        public static string CadenaConexion = "Server=HIDALGOLAPTOP;Database=POS_Cafeteria;Trusted_Connection=True;TrustServerCertificate=True;";
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
