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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
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
            comboBoxInventario = new ComboBox();
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
            label1.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(190, 158, 68);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(325, 23);
            label1.Name = "label1";
            label1.Size = new Size(505, 29);
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
            guna2Button2.Location = new Point(49, 445);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(151, 40);
            guna2Button2.TabIndex = 9;
            guna2Button2.Text = "REGISTRAR";
            guna2Button2.TextAlign = HorizontalAlignment.Right;
            guna2Button2.Click += guna2Button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(190, 158, 68);
            label3.Location = new Point(24, 168);
            label3.Name = "label3";
            label3.Size = new Size(162, 16);
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
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(35, 23);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(143, 121);
            guna2Panel1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(227, 167, 30);
            dataGridViewCellStyle1.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnNumHabitacion, ColumnFecha, ColumnEstado, ColumnInventario, ColumnEmpleado, ColumnObservaciones });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(237, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(229, 217, 182);
            dataGridViewCellStyle8.Font = new Font("Gill Sans MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(13, 13, 13);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(957, 379);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnNumHabitacion
            // 
            ColumnNumHabitacion.DataPropertyName = "numhabitacion";
            dataGridViewCellStyle2.BackColor = Color.Gray;
            ColumnNumHabitacion.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnNumHabitacion.HeaderText = "NUMERO";
            ColumnNumHabitacion.MinimumWidth = 6;
            ColumnNumHabitacion.Name = "ColumnNumHabitacion";
            // 
            // ColumnFecha
            // 
            ColumnFecha.DataPropertyName = "FechaLimpieza";
            dataGridViewCellStyle3.BackColor = Color.Gray;
            ColumnFecha.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnFecha.HeaderText = "FECHA Y HORA";
            ColumnFecha.MinimumWidth = 6;
            ColumnFecha.Name = "ColumnFecha";
            // 
            // ColumnEstado
            // 
            ColumnEstado.DataPropertyName = "estado";
            dataGridViewCellStyle4.BackColor = Color.Gray;
            ColumnEstado.DefaultCellStyle = dataGridViewCellStyle4;
            ColumnEstado.HeaderText = "ESTADO";
            ColumnEstado.MinimumWidth = 6;
            ColumnEstado.Name = "ColumnEstado";
            // 
            // ColumnInventario
            // 
            ColumnInventario.DataPropertyName = "nombre_objeto";
            dataGridViewCellStyle5.BackColor = Color.Gray;
            ColumnInventario.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnInventario.HeaderText = "INVENTARIO";
            ColumnInventario.MinimumWidth = 6;
            ColumnInventario.Name = "ColumnInventario";
            // 
            // ColumnEmpleado
            // 
            ColumnEmpleado.DataPropertyName = "empleado";
            dataGridViewCellStyle6.BackColor = Color.Gray;
            ColumnEmpleado.DefaultCellStyle = dataGridViewCellStyle6;
            ColumnEmpleado.HeaderText = "EMPLEADO";
            ColumnEmpleado.MinimumWidth = 6;
            ColumnEmpleado.Name = "ColumnEmpleado";
            // 
            // ColumnObservaciones
            // 
            ColumnObservaciones.DataPropertyName = "Observaciones";
            dataGridViewCellStyle7.BackColor = Color.Gray;
            ColumnObservaciones.DefaultCellStyle = dataGridViewCellStyle7;
            ColumnObservaciones.HeaderText = "OBSERVACIONES";
            ColumnObservaciones.MinimumWidth = 6;
            ColumnObservaciones.Name = "ColumnObservaciones";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(190, 158, 68);
            label5.Location = new Point(24, 216);
            label5.Name = "label5";
            label5.Size = new Size(56, 16);
            label5.TabIndex = 13;
            label5.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(190, 158, 68);
            label2.Location = new Point(24, 264);
            label2.Name = "label2";
            label2.Size = new Size(75, 16);
            label2.TabIndex = 17;
            label2.Text = "Inventario";
            // 
            // comboBoxInventario
            // 
            comboBoxInventario.FormattingEnabled = true;
            comboBoxInventario.Location = new Point(24, 286);
            comboBoxInventario.Name = "comboBoxInventario";
            comboBoxInventario.Size = new Size(195, 23);
            comboBoxInventario.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(190, 158, 68);
            label4.Location = new Point(24, 324);
            label4.Name = "label4";
            label4.Size = new Size(78, 16);
            label4.TabIndex = 19;
            label4.Text = "Empleado";
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(25, 346);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(194, 23);
            comboBoxEmpleado.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(190, 158, 68);
            label6.Location = new Point(25, 382);
            label6.Name = "label6";
            label6.Size = new Size(112, 16);
            label6.TabIndex = 21;
            label6.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(25, 404);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(194, 23);
            txtObservaciones.TabIndex = 22;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(25, 238);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(194, 23);
            txtEstado.TabIndex = 23;
            // 
            // RegistroLimpiezaHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1241, 512);
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