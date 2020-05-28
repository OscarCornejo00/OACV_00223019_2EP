using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial2
{
    public class DirecciónDAO
    {
        public static List<Dirección> getDirección(){
            string sql = "SELECT * FROM ADDRESS";

            DataTable dt = Conexion.realizarConsulta(sql);
            List<Dirección> lista = new List<Dirección>();
            foreach (DataRow fila in dt.Rows)
            {
                Dirección u = new Dirección();
                u.idAddress = Convert.ToInt32(fila[0].ToString());
                u.idUser = Convert.ToInt32(fila[1].ToString());
                u.address = fila[2].ToString();
                lista.Add(u);
            }
            return lista;
        }
        
        public static List<Dirección> GetDirecciónS(Usuario u)
        {
            string sql = string.Format("SELECT ad.idAddress, ad.address FROM ADDRESS ad " +
                                       "WHERE idUser = {0}", u.idUser);
           
            DataTable dt = Conexion.realizarConsulta(sql);

            List<Dirección> lista = new List<Dirección>();
            
            foreach (DataRow fila in dt.Rows)
            {
                Dirección address = new Dirección();
                address.idAddress = Convert.ToInt32(fila[0].ToString());
                address.idUser = u.idUser;
                address.address = fila[1].ToString();
                
                lista.Add(address);
            }
            return lista;
        }
        
        public static void agregarDireccion(string address, string name)
        {
            string sql = String.Format(
                "INSERT INTO ADDRESS(iduser, address) SELECT us.iduser, '{0}'" +
                "FROM APPUSER us WHERE us.username = '{1}';",
                address, name);
            
            Conexion.realizarAccion(sql);
        }

    }
}
