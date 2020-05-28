using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial2
{
    public class OrdenesDAO
    {
        public static List<Ordenes> getOrdenes(){
            string sql = "SELECT * FROM APPORDER";

            DataTable dt = Conexion.realizarConsulta(sql);
            List<Ordenes> lista = new List<Ordenes>();
            foreach (DataRow fila in dt.Rows)
            {
                Ordenes u = new Ordenes();
                u.idOrder = Convert.ToInt32(fila[0].ToString());
                u.idProduct = Convert.ToInt32(fila[1].ToString());
                u.idAddress = Convert.ToInt32(fila[2].ToString());
                u.createDate = fila[3].ToString();
                lista.Add(u);
            }
            return lista;
        }
        
        public static DataTable verMisOrdenes(Usuario us)
        {
            DataTable dt = null;
            try
            {
                dt = Conexion.realizarConsulta(string.Format("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                                                             " FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct " +
                                                             " AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser AND au.idUser = {0};",
                    us.idUser));
                
            }
            catch (Exception)
            {
                return null;
            }

            return dt;
            
        }
        
        public static void CrearOrden(string time, Producto pro, Dirección ad)
        {
            string sql = String.Format(
                "INSERT INTO APPORDER(createDate, idProduct, idAddress)" +
                "VALUES('{0}', {1}, {2})", time, pro.idProduct, ad.idAddress);
            
            Conexion.realizarAccion(sql);
        }
        public static void eliminarOrden(int orden)
        {
            string sql = String.Format(
                "DELETE FROM APPORDER WHERE idOrder = {0};",
                orden);
                  
            Conexion.realizarAccion(sql);
        }
    }
}