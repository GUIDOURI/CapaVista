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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            comboBoxNumHabitacion = new ComboBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            dataGridView1 = new DataGridView();
            ColumnNumHabitacion = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            ColumnEstado = new DataGridViewTextBoxColumn();
            ColumnInventario = new DataGridViewTextBoxColumn();
            ColumnEmpleado = new DataGridViewTextBoxColumn();
            ColumnObservaciones = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label2 = new Label();
            comboBoxInventanrio = new ComboBox();
            label4 = new Label();
            comboBoxEmpleado = new ComboBox();
            label6 = new Label();
            txtObservaciones = new TextBox();
            txtEstado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Alegreya", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(190, 158, 68);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(413, 23);
            label1.Name = "label1";
            label1.Size = new Size(274, 35);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE LIMPIEZA";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BackgroundImage = (Image)resources.GetObject("guna2Button2.BackgroundImage");
            guna2Button2.BackgroundImageLayout = ImageLayout.None;
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.Font = new Font("Alegreya", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.FromArgb(190, 158, 68);
            guna2Button2.Location = new Point(79, 434);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(151, 40);
            guna2Button2.TabIndex = 9;
            guna2Button2.Text = "REGISTRAR";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Alegreya", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(190, 158, 68);
            label3.Location = new Point(24, 168);
            label3.Name = "label3";
            label3.Size = new Size(132, 19);
            label3.TabIndex = 10;
            label3.Text = "Numero de Habitacion";
            // 
            // comboBoxNumHabitacion
            // 
            comboBoxNumHabitacion.FormattingEnabled = true;
            comboBoxNumHabitacion.Location = new Point(25, 190);
            comboBoxNumHabitacion.Name = "comboBoxNumHabitacion";
            comboBoxNumHabitacion.Size = new Size(175, 23);
            comboBoxNumHabitacion.TabIndex = 11;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackgroundImage = (Image)resources.GetObject("guna2Panel1.BackgroundImage");
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Location = new Point(35, 23);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(143, 121);
            guna2Panel1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnNumHabitacion, ColumnFecha, ColumnEstado, ColumnInventario, ColumnEmpleado, ColumnObservaciones });
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(312, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(771, 379);
            dataGridView1.TabIndex = 16;
            // 
            // ColumnNumHabitacion
            // 
            ColumnNumHabitacion.HeaderText = "NumHabitacion";
            ColumnNumHabitacion.Name = "ColumnNumHabitacion";
            // 
            // ColumnFecha
            // 
            ColumnFecha.HeaderText = "FECHA y HORA";
            ColumnFecha.Name = "ColumnFecha";
            // 
            // ColumnEstado
            // 
            ColumnEstado.HeaderText = "ESTADO";
            ColumnEstado.Name = "ColumnEstado";
            // 
            // ColumnInventario
            // 
            ColumnInventario.HeaderText = "INVENTARIO";
            ColumnInventario.Name = "ColumnInventario";
            // 
            // ColumnEmpleado
            // 
            ColumnEmpleado.HeaderText = "EMPLEANDO";
            ColumnEmpleado.Name = "ColumnEmpleado";
            // 
            // ColumnObservaciones
            // 
            ColumnObservaciones.HeaderText = "OBSERVACIONES";
            ColumnObservaciones.Name = "ColumnObservaciones";
            ColumnObservaciones.Width = 200;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Alegreya", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(190, 158, 68);
            label5.Location = new Point(24, 216);
            label5.Name = "label5";
            label5.Size = new Size(46, 19);
            label5.TabIndex = 13;
            label5.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Alegreya", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(190, 158, 68);
            label2.Location = new Point(24, 264);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 17;
            label2.Text = "Inventario";
            // 
            // comboBoxInventanrio
            // 
            comboBoxInventanrio.FormattingEnabled = true;
            comboBoxInventanrio.Location = new Point(24, 286);
            comboBoxInventanrio.Name = "comboBoxInventanrio";
            comboBoxInventanrio.Size = new Size(272, 23);
            comboBoxInventanrio.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Alegreya", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(190, 158, 68);
            label4.Location = new Point(24, 324);
            label4.Name = "label4";
            label4.Size = new Size(64, 19);
            label4.TabIndex = 19;
            label4.Text = "Empleado";
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(25, 346);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(272, 23);
            comboBoxEmpleado.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Alegreya", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(190, 158, 68);
            label6.Location = new Point(25, 372);
            label6.Name = "label6";
            label6.Size = new Size(88, 19);
            label6.TabIndex = 21;
            label6.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(25, 394);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(271, 23);
            txtObservaciones.TabIndex = 22;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(24, 238);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(271, 23);
            txtEstado.TabIndex = 23;
            // 
            // RegistroLimpiezaHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1095, 486);
            Controls.Add(txtEstado);
            Controls.Add(txtObservaciones);
            Controls.Add(label6);
            Controls.Add(comboBoxEmpleado);
            Controls.Add(label4);
            Controls.Add(comboBoxInventanrio);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(guna2Panel1);
            Controls.Add(label5);
            Controls.Add(comboBoxNumHabitacion);
            Controls.Add(label3);
            Controls.Add(guna2Button2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
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
        private ComboBox comboBoxInventanrio;
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