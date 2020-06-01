using Preparcial.Controlador;
using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preparcial.Vista
{
    //Correción: Alinear el codigo con la función 'Reformat Code'

    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("../../Recursos/UCA.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            ActualizarControlers();
        }

        private void ActualizarControlers()
        {
            comboBox1.ValueMember = "Contrasena";
            comboBox1.DataSource = ControladorUsuario.GetUsuarios();
            comboBox1.DisplayMember = "NombreUsuario";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Correción: modificando if no se puede dejar como vacia la nueva contraseña
            if (txtOldPassword.Text.Equals(comboBox1.SelectedValue.ToString()) && txtNewPassword.Text.Length > 0)
            {
                var obtenerUsuario = (Usuario) comboBox1.SelectedItem;

                ActualizarControlers();

                ControladorUsuario.ActualizarContrasena(obtenerUsuario.IdUsuario,
                    txtNewPassword.Text);
            }//Correción: Modicando el 'message box' en el else, por si deja un campo vacio o dato erroneo
            else
                MessageBox.Show("¡Favor verifique que los datos sean correctos!");
        }
    }
}