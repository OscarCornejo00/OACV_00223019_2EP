using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class User : Form
    {

        private Usuario usuario;

        public User(Usuario pUsuario)
        {
            InitializeComponent();
            usuario = pUsuario;
        }

        private void actualizarControles()
        {

            //actualizar Producto
            cmbProducto.DataSource = null;
            cmbProducto.ValueMember = "idP";
            cmbProducto.DisplayMember = "nameP";
            cmbProducto.DataSource = ProductoDAO.getProducto();

            //actualizar Dirección

            cmbDirección.DataSource = null;
            cmbDirección.ValueMember = "idaddress";
            cmbDirección.DisplayMember = "address";
            cmbDirección.DataSource = DirecciónDAO.GetDirecciónS(usuario);

            cmbDirección1.DataSource = null;
            cmbDirección1.ValueMember = "idaddress";
            cmbDirección1.DisplayMember = "address";
            cmbDirección1.DataSource = DirecciónDAO.getDirección();

            //Actualizar Ordenes

            cmbPedido.DataSource = null;
            cmbPedido.ValueMember = "idorder";
            cmbPedido.DisplayMember = "idorder";
            cmbPedido.DataSource = OrdenesDAO.verMisOrdenes(usuario);


        }

        private void User_Load(object sender, EventArgs e)
        {
            actualizarControles();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DirecciónDAO.agregarDireccion(txtDireccion.Text, usuario.Username);
                MessageBox.Show("Se ha eliminado la dirección");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            actualizarControles();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {

                DirecciónDAO.agregarDireccion(txtDireccion.Text, usuario.Username);

                MessageBox.Show("Se ha registrado el Dirección");

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = Conexion.realizarConsulta(
                    $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                    $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                    $"WHERE ao.idProduct = pr.idProduct " +
                    $"AND ao.idAddress = ad.idAddress " +
                    $"AND ad.idUser = au.idUser " +
                    $"AND au.idUser = '{Convert.ToInt32(usuario.idUser)}'");


                dgvPedidos.DataSource = dt;
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
                DateTime fecha = DateTime.Now;
                string fecha2 = Convert.ToString(fecha);

                Producto pro = (Producto) cmbProducto.SelectedItem;
                Dirección ad = (Dirección) cmbDirección.SelectedItem;

                OrdenesDAO.CrearOrden(fecha2, pro, ad);

                MessageBox.Show("La orden ha sido creada exitosamente", "Parcial2",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarControles();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Parcial2",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Seguro que desea eliminar al Pedido " + cmbPedido.Text + "?",
                "Parcial2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    OrdenesDAO.eliminarOrden(Convert.ToInt16(cmbPedido.SelectedValue));
                    MessageBox.Show("¡Pedidp eliminado exitosamente!",
                        "Parcial2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }

                actualizarControles();

            }
        }


        private void User_FormClosing(object sender, FormClosingEventArgs e)
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


        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}