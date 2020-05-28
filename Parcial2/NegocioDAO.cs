using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial2
{
    public class NegocioDAO
    {
        public static List<Negocio> GetNegocio(){
            string sql = "SELECT * FROM BUSINESS";

            DataTable dt = Conexion.realizarConsulta(sql);
            List<Negocio> lista = new List<Negocio>();
            foreach (DataRow fila in dt.Rows)
            {
                Negocio u = new Negocio();
                u.idN = Convert.ToInt32(fila[0].ToString());
                u.NameN = fila[1].ToString();
                u.Description = fila[2].ToString();
                lista.Add(u);
            }
            return lista;
        }
    }
}