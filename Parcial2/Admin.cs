using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Admin : Form
    {
        
        private Usuario usuario;
        
        public Admin(Usuario pUsuario)
        {
            InitializeComponent();
            usuario = pUsuario;
        }


        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            
            if (txtNuevoNombre.Text.Equals("") ||
                txtNuevoUsuario) 
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    
                    Conexion.realizarConsulta($"INSERT INTO APPUSER VALUES(" +
                                              $" '{txtNuevoNombre.Text}'," +
                                              $" '{txtNuevoUsuario.Text}'," +
                                              $" '{txtNuevoUsuario.Text}'," +
                                              $"  {} )");
                    
                    MessageBox.Show("Se ha registrado el estudiante");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error"); 
                }
                
            }
        }
    }
}