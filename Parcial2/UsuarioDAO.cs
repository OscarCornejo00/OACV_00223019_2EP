using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial2
{
        public static class UsuarioDAO
    {
        public static List<Usuario> getLista()
        {
            
            
            string sql = "SELECT * FROM APPUSER";

            DataTable dt = Conexion.realizarConsulta(sql);
            List<Usuario> lista = new List<Usuario>();
            foreach (DataRow fila in dt.Rows)
            {
                Usuario u = new Usuario();
                u.idUser = Convert.ToInt32(fila[0].ToString());
                u.Fullname = fila[1].ToString();
                u.contrasena = fila[3].ToString();
                u.userType = Convert.ToBoolean(fila[4].ToString());
                u.Username = fila[2].ToString();
                lista.Add(u);
            }
            return lista;
        }

        public static void actualizarContra(string usuario, string nuevaContra)
        {
            string sql = String.Format(
                "UPDATE APPUSER SET password ='{0}' WHERE username='{1}';",
                nuevaContra, usuario);
            
            //UPDATE APPUSER SET password = 'nueva' WHERE idUser = 1
            
            Conexion.realizarAccion(sql);
        }
    }
}