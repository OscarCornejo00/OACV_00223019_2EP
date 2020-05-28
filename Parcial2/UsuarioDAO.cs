﻿using System;
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
                //u.id = fila[1].ToString();
                u.usuario = fila[2].ToString();
                u.contrasena = fila[3].ToString();
                //u.admin = Convert.ToBoolean(fila[2].ToString());
                //u.activo = Convert.ToBoolean(fila[3].ToString());

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

        public static void crearNuevo(string usuario, string nombre, string tel)
        {
//            string sql = String.Format(
//                "insert into usuario(usuario, contrasena, admin, activo) " +
//                "values('{0}', '{1}', false, true);",
//                usuario, Encriptador.CrearMD5(usuario));
            
//            Conexion.realizarAccion(sql);

            
        }

        public static void actualizarPermisos(string usuario, bool admin, bool activo)
        {
            string sql = String.Format(
                "update usuario set admin={0}, activo={1} where usuario='{2}';",
                admin ? "true" : "false", activo ? "true" : "false", usuario);
            
            Conexion.realizarAccion(sql);
        }

        public static void eliminar(string usuario)
        {
            string sql = String.Format(
                "delete from registro where usuario ='{0}'; " +
                "delete from usuario where usuario='{0}';",
                usuario);
            
            Conexion.realizarAccion(sql);
        }
        
        public static List<Frecuencia> getEstadisticas()
        {
            string sql = "select count(id_registro), usuario " +
                         "from registro " +
                         "where entrar = true " +
                         "group by usuario;";

            DataTable dt = Conexion.realizarConsulta(sql);

            List<Frecuencia> lista = new List<Frecuencia>();
            foreach (DataRow fila in dt.Rows)
            {
                Frecuencia f = new Frecuencia();
                f.cantidad = Convert.ToInt32(fila[0].ToString());
                f.usuario = fila[1].ToString();

                lista.Add(f);
            }
            return lista;
        }
    }
}