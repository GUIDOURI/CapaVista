namespace CapaVista
{
    partial class RegistroLimpArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroLimpArea));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelContenedor = new Panel();
            txtObservaciones = new TextBox();
            label6 = new Label();
            comboBoxEmpleado = new ComboBox();
            label4 = new Label();
            comboBoxInventario = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label5 = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ColumnIdArea = new DataGridViewTextBoxColumn();
            ColumnUbicacion = new DataGridViewTextBoxColumn();
            ColumnInventario = new DataGridViewTextBoxColumn();
            ColumnEmpleado = new DataGridViewTextBoxColumn();
            ColumnObservaciones = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(26, 26, 26);
            panelContenedor.Controls.Add(comboBox1);
            panelContenedor.Controls.Add(txtObservaciones);
            panelContenedor.Controls.Add(label6);
            panelContenedor.Controls.Add(comboBoxEmpleado);
            panelContenedor.Controls.Add(label4);
            panelContenedor.Controls.Add(comboBoxInventario);
            panelContenedor.Controls.Add(label2);
            panelContenedor.Controls.Add(dataGridView1);
            panelContenedor.Controls.Add(guna2Panel1);
            panelContenedor.Controls.Add(label5);
            panelContenedor.Controls.Add(guna2Button2);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(965, 514);
            panelContenedor.TabIndex = 4;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(0, 366);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(194, 23);
            txtObservaciones.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Alegreya", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(190, 158, 68);
            label6.Location = new Point(3, 344);
            label6.Name = "label6";
            label6.Size = new Size(88, 19);
            label6.TabIndex = 35;
            label6.Text = "Observaciones";
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(0, 318);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(194, 23);
            comboBoxEmpleado.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Alegreya", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(190, 158, 68);
            label4.Location = new Point(5, 296);
            label4.Name = "label4";
            label4.Size = new Size(64, 19);
            label4.TabIndex = 33;
            label4.Text = "Empleado";
            // 
            // comboBoxInventario
            // 
            comboBoxInventario.FormattingEnabled = true;
            comboBoxInventario.Location = new Point(3, 261);
            comboBoxInventario.Name = "comboBoxInventario";
            comboBoxInventario.Size = new Size(195, 23);
            comboBoxInventario.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Alegreya", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(190, 158, 68);
            label2.Location = new Point(3, 239);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 31;
            label2.Text = "Inventario";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnIdArea, ColumnUbicacion, ColumnInventario, ColumnEmpleado, ColumnObservaciones, ColumnFecha });
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(214, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(741, 379);
            dataGridView1.TabIndex = 30;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackgroundImage = (Image)resources.GetObject("guna2Panel1.BackgroundImage");
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(12, 12);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(143, 121);
            guna2Panel1.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Alegreya", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(190, 158, 68);
            label5.Location = new Point(3, 181);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 28;
            label5.Text = "Ubicacion";
            // 
            // guna2Button2
            // 
            guna2Button2.BackgroundImage = (Image)resources.GetObject("guna2Button2.BackgroundImage");
            guna2Button2.BackgroundImageLayout = ImageLayout.None;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.Font = new Font("Alegreya", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.FromArgb(190, 158, 68);
            guna2Button2.Location = new Point(26, 423);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(151, 40);
            guna2Button2.TabIndex = 25;
            guna2Button2.Text = "REGISTRAR";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Alegreya", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(190, 158, 68);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(371, 27);
            label1.Name = "label1";
            label1.Size = new Size(337, 35);
            label1.TabIndex = 24;
            label1.Text = "REGISTRO DE LIMPIEZA AREA";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(2, 213);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 23);
            comboBox1.TabIndex = 37;
            // 
            // ColumnIdArea
            // 
            ColumnIdArea.HeaderText = "ID AREA";
            ColumnIdArea.Name = "ColumnIdArea";
            // 
            // ColumnUbicacion
            // 
            ColumnUbicacion.HeaderText = "UBICACION";
            ColumnUbicacion.Name = "ColumnUbicacion";
            // 
            // ColumnInventario
            // 
            ColumnInventario.HeaderText = "INVENTARIO";
            ColumnInventario.Name = "ColumnInventario";
            // 
            // ColumnEmpleado
            // 
            ColumnEmpleado.HeaderText = "EMPLEADO";
            ColumnEmpleado.Name = "ColumnEmpleado";
            // 
            // ColumnObservaciones
            // 
            ColumnObservaciones.HeaderText = "OBSERVACIONES";
            ColumnObservaciones.Name = "ColumnObservaciones";
            ColumnObservaciones.Width = 200;
            // 
            // ColumnFecha
            // 
            ColumnFecha.HeaderText = "FECHA Y HORA";
            ColumnFecha.Name = "ColumnFecha";
            // 
            // RegistroLimpArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 514);
            Controls.Add(panelContenedor);
            Name = "RegistroLimpArea";
            Text = "FormLimpieza";
            Load += FormLimpieza_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContenedor;
        private TextBox txtObservaciones;
        private Label label6;
        private ComboBox comboBoxEmpleado;
        private Label label4;
        private ComboBox comboBoxInventario;
        private Label label2;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label label1;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn ColumnIdArea;
        private DataGridViewTextBoxColumn ColumnUbicacion;
        private DataGridViewTextBoxColumn ColumnInventario;
        private DataGridViewTextBoxColumn ColumnEmpleado;
        private DataGridViewTextBoxColumn ColumnObservaciones;
        private DataGridViewTextBoxColumn ColumnFecha;
    }
}