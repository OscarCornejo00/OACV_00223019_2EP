using System;
using System.Collections.Generic;
using System.Data;
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
            cmbAdmin.DataSource = new List<String>() {"Admin", "User"};
            
        }

        private void actualizarControles()
        {
            //actualizar combo box empresa 
            cmbNegocio.DataSource = null;
            cmbNegocio.ValueMember = "idN";
            cmbNegocio.DisplayMember = "NameN";
            cmbNegocio.DataSource = NegocioDAO.GetNegocio();

            //actualizar combo box Producto
            cmbProducto.DataSource = null;
            cmbProducto.ValueMember = "idP";
            cmbProducto.DisplayMember = "nameP";
            cmbProducto.DataSource = ProductoDAO.getProducto();

            //actualizar usuarios
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idUser";
            comboBox1.DisplayMember = "Username";
            comboBox1.DataSource = UsuarioDAO.getLista();

            //actualizar combobox de empresa para eliminar
            cmbNegocio1.DataSource = null;
            cmbNegocio1.ValueMember = "idN";
            cmbNegocio1.DisplayMember = "NameN";
            cmbNegocio1.DataSource = NegocioDAO.GetNegocio();
            
        }
        
        private void Admin_Load(object sender, EventArgs e)
        {
            actualizarControles();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            int x = 0;

            switch (cmbAdmin.SelectedIndex)
            {
                case 0:
                    x = 1;
                    break;
                case 1:
                    x = 0;
                    break;

            }

            if (txtNuevoNombre.Text.Equals("") ||
                txtNuevoUsuario.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    if (x == 1)
                    {
                        Conexion.realizarAccion($"INSERT INTO APPUSER(fullname, username, password, usertype) VALUES(" +
                                                $" '{txtNuevoNombre.Text}'," +
                                                $" '{txtNuevoUsuario.Text}'," +
                                                $" '{txtNuevoUsuario.Text}'," +
                                                $"  true )");

                        MessageBox.Show("Se ha registrado el usuario");
                    }
                    else
                    {
                        Conexion.realizarAccion($"INSERT INTO APPUSER(fullname, username, password, usertype) VALUES(" +
                                                $" '{txtNuevoNombre.Text}'," +
                                                $" '{txtNuevoUsuario.Text}'," +
                                                $" '{txtNuevoUsuario.Text}'," +
                                                $"  false )");

                        MessageBox.Show("Se ha registrado el usuario");   
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }

            actualizarControles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar al usuario " + comboBox1.Text + "?",
                "Clase GUI 06", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Conexion.realizarAccion($"DELETE FROM APPUSER WHERE iduser = {comboBox1.SelectedValue}");
                    MessageBox.Show("¡Usuario eliminado exitosamente!",
                        "Parcial2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
                actualizarControles();
            }
        }

        private void btnCrearNegocio_Click(object sender, EventArgs e)
        {
            if (txtNombreN.Text.Equals("") ||
                txtDescripciom.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    Conexion.realizarAccion($"INSERT INTO BUSINESS(name, \"description\") VALUES(" +
                                            $" '{txtNombreN.Text}'," +
                                            $" '{txtNuevoUsuario.Text}')");

                    MessageBox.Show("Se ha registrado el negocio");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }

            actualizarControles();
            
            
        }



        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    Conexion.realizarAccion($"insert into PRODUCT(idBusiness, name) " +
                                            $"VALUES ({cmbNegocio1.SelectedValue},'{textBox3.Text}')");
                    MessageBox.Show("Se ha registrado el producto");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            actualizarControles();;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.realizarAccion($"DELETE FROM PRODUCT WHERE idproduct = {cmbProducto.SelectedValue}");
                MessageBox.Show("Se ha eliminado el producto");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            actualizarControles();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.realizarAccion($"DELETE FROM BUSINESS WHERE idbusiness = {cmbNegocio.SelectedValue}");
                Conexion.realizarAccion($"DELETE FROM PRODUCT WHERE idbusiness = {cmbNegocio.SelectedValue}");
                MessageBox.Show("Se ha eliminado la empresa");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            actualizarControles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = Conexion.realizarConsulta($"SELECT * FROM APPUSER;");

                dataGridView1.DataSource = dt;
                MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error"); 
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = Conexion.realizarConsulta($"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address "+ 
                                               $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au "+
                                               $"WHERE ao.idProduct = pr.idProduct "+
                                               $"AND ao.idAddress = ad.idAddress "+
                                               $"AND ad.idUser = au.idUser ");

                dgvPedidos.DataSource = dt;
                MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error"); 
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = Conexion.realizarConsulta($"SELECT * FROM BUSINESS;");

                dataGridView2.DataSource = dt;
                MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error"); 
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = Conexion.realizarConsulta($"SELECT p.idProduct, p.name FROM PRODUCT p WHERE idBusiness = '{1}'");

                dataGridView3.DataSource = dt;
                MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error"); 
            }
        }


        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, " + usuario.Username + "?",
                "Parcial2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
            
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
    }
}