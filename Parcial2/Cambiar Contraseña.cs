using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Cambiar_Contraseña : Form
    {
        public Cambiar_Contraseña()
        {
            InitializeComponent();
        }

        private void Cambiar_Contraseña_Load(object sender, EventArgs e)
        {
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "contrasena";
            cmbUsuario.DisplayMember = "usuario";
            cmbUsuario.DataSource = UsuarioDAO.getLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool actualIgual = cmbUsuario.SelectedValue.Equals(txtActual.Text);
            bool nuevaIgual = txtNueva.Text.Equals(txtRepetir.Text);
            bool nuevaValida = txtNueva.Text.Length > 0;

            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                    UsuarioDAO.actualizarContra(cmbUsuario.Text, txtNueva.Text);

                    MessageBox.Show("¡Contraseña actualizada exitosamente!",
                        "Parcial2", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Contraseña no actualizada! Favor intente mas tarde.",
                        "Parcial2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("¡¡Favor verifique que los datos sean correctos!",
                    "Parcial2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}