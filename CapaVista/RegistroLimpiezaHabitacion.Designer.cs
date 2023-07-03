namespace CapaVista
{
    partial class RegistroLimpiezaHabitacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroLimpiezaHabitacion));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            comboBoxNumHabitacion = new ComboBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label2 = new Label();
            comboBoxInventario = new ComboBox();
            label4 = new Label();
            comboBoxEmpleado = new ComboBox();
            label6 = new Label();
            txtObservaciones = new TextBox();
            txtEstado = new TextBox();
            ColumnNumHabitacion = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            ColumnEstado = new DataGridViewTextBoxColumn();
            ColumnInventario = new DataGridViewTextBoxColumn();
            ColumnEmpleado = new DataGridViewTextBoxColumn();
            ColumnObservaciones = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(190, 158, 68);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(371, 31);
            label1.Name = "label1";
            label1.Size = new Size(627, 36);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE LIMPIEZA HABITACIONES";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // guna2Button2
            // 
            guna2Button2.BackgroundImage = (Image)resources.GetObject("guna2Button2.BackgroundImage");
            guna2Button2.BackgroundImageLayout = ImageLayout.None;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.FromArgb(190, 158, 68);
            guna2Button2.Location = new Point(56, 579);
            guna2Button2.Margin = new Padding(3, 4, 3, 4);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(173, 53);
            guna2Button2.TabIndex = 9;
            guna2Button2.Text = "REGISTRAR";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(190, 158, 68);
            label3.Location = new Point(27, 224);
            label3.Name = "label3";
            label3.Size = new Size(196, 20);
            label3.TabIndex = 10;
            label3.Text = "Numero de Habitacion";
            // 
            // comboBoxNumHabitacion
            // 
            comboBoxNumHabitacion.FormattingEnabled = true;
            comboBoxNumHabitacion.Location = new Point(29, 253);
            comboBoxNumHabitacion.Margin = new Padding(3, 4, 3, 4);
            comboBoxNumHabitacion.Name = "comboBoxNumHabitacion";
            comboBoxNumHabitacion.Size = new Size(199, 28);
            comboBoxNumHabitacion.TabIndex = 11;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackgroundImage = (Image)resources.GetObject("guna2Panel1.BackgroundImage");
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(40, 31);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(163, 161);
            guna2Panel1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnNumHabitacion, ColumnFecha, ColumnEstado, ColumnInventario, ColumnEmpleado, ColumnObservaciones });
            dataGridView1.GridColor = Color.GreenYellow;
            dataGridView1.Location = new Point(271, 127);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(847, 505);
            dataGridView1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(190, 158, 68);
            label5.Location = new Point(27, 288);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 13;
            label5.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(190, 158, 68);
            label2.Location = new Point(27, 352);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 17;
            label2.Text = "Inventario";
            // 
            // comboBoxInventario
            // 
            comboBoxInventario.FormattingEnabled = true;
            comboBoxInventario.Location = new Point(27, 381);
            comboBoxInventario.Margin = new Padding(3, 4, 3, 4);
            comboBoxInventario.Name = "comboBoxInventario";
            comboBoxInventario.Size = new Size(222, 28);
            comboBoxInventario.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(190, 158, 68);
            label4.Location = new Point(27, 432);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 19;
            label4.Text = "Empleado";
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(29, 461);
            comboBoxEmpleado.Margin = new Padding(3, 4, 3, 4);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(221, 28);
            comboBoxEmpleado.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(190, 158, 68);
            label6.Location = new Point(29, 496);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 21;
            label6.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(29, 525);
            txtObservaciones.Margin = new Padding(3, 4, 3, 4);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(221, 27);
            txtObservaciones.TabIndex = 22;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(29, 317);
            txtEstado.Margin = new Padding(3, 4, 3, 4);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(221, 27);
            txtEstado.TabIndex = 23;
            // 
            // ColumnNumHabitacion
            // 
            ColumnNumHabitacion.DataPropertyName = "numhabitacion";
            dataGridViewCellStyle1.BackColor = Color.Gray;
            ColumnNumHabitacion.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnNumHabitacion.HeaderText = "NUMERO";
            ColumnNumHabitacion.MinimumWidth = 6;
            ColumnNumHabitacion.Name = "ColumnNumHabitacion";
            ColumnNumHabitacion.Width = 125;
            // 
            // ColumnFecha
            // 
            ColumnFecha.DataPropertyName = "FechaLimpieza";
            dataGridViewCellStyle2.BackColor = Color.Gray;
            ColumnFecha.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnFecha.HeaderText = "FECHA Y HORA";
            ColumnFecha.MinimumWidth = 6;
            ColumnFecha.Name = "ColumnFecha";
            ColumnFecha.Width = 125;
            // 
            // ColumnEstado
            // 
            ColumnEstado.DataPropertyName = "estado";
            dataGridViewCellStyle3.BackColor = Color.Gray;
            ColumnEstado.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnEstado.HeaderText = "ESTADO";
            ColumnEstado.MinimumWidth = 6;
            ColumnEstado.Name = "ColumnEstado";
            ColumnEstado.Width = 125;
            // 
            // ColumnInventario
            // 
            ColumnInventario.DataPropertyName = "nombre_objeto";
            dataGridViewCellStyle4.BackColor = Color.Gray;
            ColumnInventario.DefaultCellStyle = dataGridViewCellStyle4;
            ColumnInventario.HeaderText = "INVENTARIO";
            ColumnInventario.MinimumWidth = 6;
            ColumnInventario.Name = "ColumnInventario";
            ColumnInventario.Width = 125;
            // 
            // ColumnEmpleado
            // 
            ColumnEmpleado.DataPropertyName = "empleado";
            dataGridViewCellStyle5.BackColor = Color.Gray;
            ColumnEmpleado.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnEmpleado.HeaderText = "EMPLEADO";
            ColumnEmpleado.MinimumWidth = 6;
            ColumnEmpleado.Name = "ColumnEmpleado";
            ColumnEmpleado.Width = 125;
            // 
            // ColumnObservaciones
            // 
            ColumnObservaciones.DataPropertyName = "Observaciones";
            dataGridViewCellStyle6.BackColor = Color.Gray;
            ColumnObservaciones.DefaultCellStyle = dataGridViewCellStyle6;
            ColumnObservaciones.HeaderText = "OBSERVACIONES";
            ColumnObservaciones.MinimumWidth = 6;
            ColumnObservaciones.Name = "ColumnObservaciones";
            ColumnObservaciones.Width = 200;
            // 
            // RegistroLimpiezaHabitacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1152, 648);
            Controls.Add(txtEstado);
            Controls.Add(txtObservaciones);
            Controls.Add(label6);
            Controls.Add(comboBoxEmpleado);
            Controls.Add(label4);
            Controls.Add(comboBoxInventario);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(guna2Panel1);
            Controls.Add(label5);
            Controls.Add(comboBoxNumHabitacion);
            Controls.Add(label3);
            Controls.Add(guna2Button2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistroLimpiezaHabitacion";
            Text = "RegistroLimpiezaHabitacion";
            Load += RegistroLimpiezaHabitacion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label label3;
        private ComboBox comboBoxNumHabitacion;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label2;
        private ComboBox comboBoxInventario;
        private Label label4;
        private ComboBox comboBoxEmpleado;
        private Label label6;
        private TextBox txtObservaciones;
        private TextBox txtEstado;
        private DataGridViewTextBoxColumn ColumnNumHabitacion;
        private DataGridViewTextBoxColumn ColumnFecha;
        private DataGridViewTextBoxColumn ColumnEstado;
        private DataGridViewTextBoxColumn ColumnInventario;
        private DataGridViewTextBoxColumn ColumnEmpleado;
        private DataGridViewTextBoxColumn ColumnObservaciones;
    }
}