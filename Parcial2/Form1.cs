using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void poblarControles()
        {
            // Actualizar ComboBox
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "contrasena";
            comboBox1.DisplayMember = "usuario";
            comboBox1.DataSource = UsuarioDAO.getLista();
        }

               
        
        //Cambiar Contraseña
        private void button1_Click(object sender, EventArgs e)
        {
            Cambiar_Contraseña unaVentana = new Cambiar_Contraseña();
            unaVentana.ShowDialog();
            poblarControles();
        }
        //Login
        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue.Equals(textBox2.Text))
            {
                
                Usuario u = (Usuario) comboBox1.SelectedItem;

                //if (u.activo)
                //{
                    //RegistroDAO.iniciarSesion(u.usuario);
                    
                    MessageBox.Show("¡Bienvenido!", 
                        "Parcial2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Admin ventana = new Admin(u);
                    ventana.Show();
                    this.Hide();
                //}
                //else
                //   MessageBox.Show("Su cuenta se encuentra inactiva, favor hable con el administrador", 
                //        "Clase GUI 05", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "Clase GUI 05",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            poblarControles();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button2_Click(sender, e);
        }
    }
}