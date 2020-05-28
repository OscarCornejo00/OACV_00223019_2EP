using System.ComponentModel;

namespace Parcial2
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button15 = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.cmbPedido = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDirección1 = new System.Windows.Forms.ComboBox();
            this.button11 = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.dgvDireccion = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cmbDirección = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvPedidos)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDireccion)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage4.Controls.Add(this.button15);
            this.tabPage4.Controls.Add(this.dgvPedidos);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(546, 395);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pedidos";
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Indigo;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button15.Location = new System.Drawing.Point(8, 356);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(532, 31);
            this.button15.TabIndex = 12;
            this.button15.Text = "Actualizar";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.Indigo;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(6, 8);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(534, 339);
            this.dgvPedidos.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(546, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Realizar/Terminar Pedidos";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button13);
            this.groupBox6.Controls.Add(this.cmbPedido);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox6.Location = new System.Drawing.Point(8, 159);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(530, 102);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Eliminar Pedido";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Indigo;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(400, 65);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(124, 31);
            this.button13.TabIndex = 24;
            this.button13.Text = "Cancelar Pedido";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // cmbPedido
            // 
            this.cmbPedido.FormattingEnabled = true;
            this.cmbPedido.Location = new System.Drawing.Point(92, 37);
            this.cmbPedido.Name = "cmbPedido";
            this.cmbPedido.Size = new System.Drawing.Size(109, 21);
            this.cmbPedido.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(28, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 16);
            this.label23.TabIndex = 23;
            this.label23.Text = "Id pedido:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.cmbDirección1);
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Controls.Add(this.cmbProducto);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Location = new System.Drawing.Point(8, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(530, 112);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Realizar pedido";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Dirección::";
            // 
            // cmbDirección1
            // 
            this.cmbDirección1.FormattingEnabled = true;
            this.cmbDirección1.Location = new System.Drawing.Point(92, 66);
            this.cmbDirección1.Name = "cmbDirección1";
            this.cmbDirección1.Size = new System.Drawing.Size(154, 21);
            this.cmbDirección1.TabIndex = 11;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Indigo;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(400, 66);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(124, 31);
            this.button11.TabIndex = 10;
            this.button11.Text = "Ordenar";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(92, 31);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(233, 21);
            this.cmbProducto.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(28, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "Producto:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.dgvDireccion);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar Dirección";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Indigo;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(8, 358);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(529, 31);
            this.button9.TabIndex = 9;
            this.button9.Text = "Actualizar";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // dgvDireccion
            // 
            this.dgvDireccion.BackgroundColor = System.Drawing.Color.Indigo;
            this.dgvDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDireccion.Location = new System.Drawing.Point(8, 113);
            this.dgvDireccion.Name = "dgvDireccion";
            this.dgvDireccion.Size = new System.Drawing.Size(529, 240);
            this.dgvDireccion.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.txtDireccion);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(8, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(530, 102);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar dirección";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Indigo;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(400, 65);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 31);
            this.button8.TabIndex = 8;
            this.button8.Text = "Agregar";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(79, 25);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(422, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Calle:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modificar Dirección";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.cmbDirección);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(8, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 143);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar dirección";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Indigo;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(399, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 31);
            this.button6.TabIndex = 11;
            this.button6.Text = "Eliminar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cmbDirección
            // 
            this.cmbDirección.FormattingEnabled = true;
            this.cmbDirección.Location = new System.Drawing.Point(118, 33);
            this.cmbDirección.Name = "cmbDirección";
            this.cmbDirección.Size = new System.Drawing.Size(131, 21);
            this.cmbDirección.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(19, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Id dirección:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(554, 421);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "User";
            this.Text = "User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.User_FormClosed);
            this.Load += new System.EventHandler(this.User_Load);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvPedidos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvDireccion)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox cmbDirección;
        private System.Windows.Forms.ComboBox cmbDirección1;
        private System.Windows.Forms.ComboBox cmbPedido;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.DataGridView dgvDireccion;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtDireccion;

        #endregion
    }
}