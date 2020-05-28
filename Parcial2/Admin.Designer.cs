using System.ComponentModel;

namespace Parcial2
{
    partial class Admin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAdmin = new System.Windows.Forms.ComboBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.cmbNegocio1 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.groupBoxU = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCrearNegocio = new System.Windows.Forms.Button();
            this.txtDescripciom = new System.Windows.Forms.TextBox();
            this.txtNombreN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNegocio = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxU.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TabControl2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 421F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.tabPage1);
            this.TabControl2.Controls.Add(this.tabPage2);
            this.TabControl2.Controls.Add(this.tabPage3);
            this.TabControl2.Controls.Add(this.tabPage4);
            this.TabControl2.Controls.Add(this.tabPage5);
            this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2.Location = new System.Drawing.Point(3, 3);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(548, 415);
            this.TabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Usuario";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(7, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(522, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 226);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAdmin);
            this.groupBox1.Controls.Add(this.btnCrearUsuario);
            this.groupBox1.Controls.Add(this.txtNuevoUsuario);
            this.groupBox1.Controls.Add(this.txtNuevoNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Usuario";
            // 
            // cmbAdmin
            // 
            this.cmbAdmin.FormattingEnabled = true;
            this.cmbAdmin.Location = new System.Drawing.Point(10, 64);
            this.cmbAdmin.Name = "cmbAdmin";
            this.cmbAdmin.Size = new System.Drawing.Size(182, 21);
            this.cmbAdmin.TabIndex = 5;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.Indigo;
            this.btnCrearUsuario.FlatAppearance.BorderSize = 0;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Location = new System.Drawing.Point(403, 62);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(113, 37);
            this.btnCrearUsuario.TabIndex = 4;
            this.btnCrearUsuario.Text = "Agregar Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Location = new System.Drawing.Point(364, 23);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(140, 20);
            this.txtNuevoUsuario.TabIndex = 3;
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(98, 23);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNuevoNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(258, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Usuario:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBoxU);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(540, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.cmbNegocio1);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Location = new System.Drawing.Point(6, 271);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(527, 109);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Eliminar Negocio";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Indigo;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(213, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 42);
            this.button5.TabIndex = 0;
            this.button5.Text = "Eliminar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cmbNegocio1
            // 
            this.cmbNegocio1.FormattingEnabled = true;
            this.cmbNegocio1.Location = new System.Drawing.Point(158, 19);
            this.cmbNegocio1.Name = "cmbNegocio1";
            this.cmbNegocio1.Size = new System.Drawing.Size(208, 21);
            this.cmbNegocio1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.cmbProducto);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(6, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 109);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Producto";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Indigo;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(213, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 42);
            this.button4.TabIndex = 0;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(158, 19);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(208, 21);
            this.cmbProducto.TabIndex = 2;
            // 
            // groupBoxU
            // 
            this.groupBoxU.Controls.Add(this.button3);
            this.groupBoxU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxU.Location = new System.Drawing.Point(6, 38);
            this.groupBoxU.Name = "groupBoxU";
            this.groupBoxU.Size = new System.Drawing.Size(528, 112);
            this.groupBoxU.TabIndex = 0;
            this.groupBoxU.TabStop = false;
            this.groupBoxU.Text = "Eliminar Usuario";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Indigo;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(415, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 42);
            this.button3.TabIndex = 0;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(540, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Crear Negocio";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Indigo;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(9, 356);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(519, 27);
            this.button8.TabIndex = 6;
            this.button8.Text = "Actualizar";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 103);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(519, 247);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCrearNegocio);
            this.groupBox6.Controls.Add(this.txtDescripciom);
            this.groupBox6.Controls.Add(this.txtNombreN);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox6.Location = new System.Drawing.Point(7, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(522, 87);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Crear Usuario";
            // 
            // btnCrearNegocio
            // 
            this.btnCrearNegocio.BackColor = System.Drawing.Color.Indigo;
            this.btnCrearNegocio.Location = new System.Drawing.Point(409, 46);
            this.btnCrearNegocio.Name = "btnCrearNegocio";
            this.btnCrearNegocio.Size = new System.Drawing.Size(102, 27);
            this.btnCrearNegocio.TabIndex = 5;
            this.btnCrearNegocio.Text = "Crear";
            this.btnCrearNegocio.UseVisualStyleBackColor = false;
            this.btnCrearNegocio.Click += new System.EventHandler(this.btnCrearNegocio_Click);
            // 
            // txtDescripciom
            // 
            this.txtDescripciom.Location = new System.Drawing.Point(76, 44);
            this.txtDescripciom.Name = "txtDescripciom";
            this.txtDescripciom.Size = new System.Drawing.Size(257, 20);
            this.txtDescripciom.TabIndex = 3;
            // 
            // txtNombreN
            // 
            this.txtNombreN.Location = new System.Drawing.Point(76, 18);
            this.txtNombreN.Name = "txtNombreN";
            this.txtNombreN.Size = new System.Drawing.Size(257, 20);
            this.txtNombreN.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(540, 389);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Crear Producto";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Indigo;
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Location = new System.Drawing.Point(9, 349);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(519, 27);
            this.button11.TabIndex = 8;
            this.button11.Text = "Actualizar";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(9, 96);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(519, 247);
            this.dataGridView3.TabIndex = 7;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.cmbNegocio);
            this.groupBox7.Controls.Add(this.button9);
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(522, 84);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Crear Producto";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Negocio:";
            // 
            // cmbNegocio
            // 
            this.cmbNegocio.FormattingEnabled = true;
            this.cmbNegocio.Location = new System.Drawing.Point(76, 17);
            this.cmbNegocio.Name = "cmbNegocio";
            this.cmbNegocio.Size = new System.Drawing.Size(257, 21);
            this.cmbNegocio.TabIndex = 6;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Indigo;
            this.button9.Location = new System.Drawing.Point(409, 46);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(102, 27);
            this.button9.TabIndex = 5;
            this.button9.Text = "Crear";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(257, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre:";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage5.Controls.Add(this.button7);
            this.tabPage5.Controls.Add(this.dgvPedidos);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(540, 389);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Pedidos";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Indigo;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(8, 346);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(522, 37);
            this.button7.TabIndex = 8;
            this.button7.Text = "Actualizar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(11, 6);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(519, 334);
            this.dgvPedidos.TabIndex = 7;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(554, 421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBoxU.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCrearNegocio;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox cmbAdmin;
        private System.Windows.Forms.ComboBox cmbNegocio;
        private System.Windows.Forms.ComboBox cmbNegocio1;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBoxU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl TabControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtDescripciom;
        private System.Windows.Forms.TextBox txtNombreN;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.TextBox txtNuevoUsuario;

        #endregion
    }
}