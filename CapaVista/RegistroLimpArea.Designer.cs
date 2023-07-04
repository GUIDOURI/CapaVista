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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroLimpArea));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelContenedor = new Panel();
            CbxUbicacion = new ComboBox();
            txtObservaciones = new TextBox();
            label6 = new Label();
            comboBoxEmpleado = new ComboBox();
            label4 = new Label();
            comboBoxInventario = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ColumnIdArea = new DataGridViewTextBoxColumn();
            ColumnUbicacion = new DataGridViewTextBoxColumn();
            ColumnInventario = new DataGridViewTextBoxColumn();
            ColumnEmpleado = new DataGridViewTextBoxColumn();
            ColumnObservaciones = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label5 = new Label();
            BtnRegLimpiezaArea = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(26, 26, 26);
            panelContenedor.Controls.Add(CbxUbicacion);
            panelContenedor.Controls.Add(txtObservaciones);
            panelContenedor.Controls.Add(label6);
            panelContenedor.Controls.Add(comboBoxEmpleado);
            panelContenedor.Controls.Add(label4);
            panelContenedor.Controls.Add(comboBoxInventario);
            panelContenedor.Controls.Add(label2);
            panelContenedor.Controls.Add(dataGridView1);
            panelContenedor.Controls.Add(guna2Panel1);
            panelContenedor.Controls.Add(label5);
            panelContenedor.Controls.Add(BtnRegLimpiezaArea);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(965, 514);
            panelContenedor.TabIndex = 4;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // CbxUbicacion
            // 
            CbxUbicacion.FormattingEnabled = true;
            CbxUbicacion.Location = new Point(2, 213);
            CbxUbicacion.Name = "CbxUbicacion";
            CbxUbicacion.Size = new Size(195, 23);
            CbxUbicacion.TabIndex = 37;
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
            label6.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(190, 158, 68);
            label6.Location = new Point(3, 344);
            label6.Name = "label6";
            label6.Size = new Size(112, 16);
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
            label4.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(190, 158, 68);
            label4.Location = new Point(5, 296);
            label4.Name = "label4";
            label4.Size = new Size(78, 16);
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
            label2.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(190, 158, 68);
            label2.Location = new Point(3, 239);
            label2.Name = "label2";
            label2.Size = new Size(75, 16);
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
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(741, 379);
            dataGridView1.TabIndex = 30;
            // 
            // ColumnIdArea
            // 
            ColumnIdArea.DataPropertyName = "Id";
            dataGridViewCellStyle1.BackColor = Color.Gray;
            ColumnIdArea.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnIdArea.HeaderText = "ID AREA";
            ColumnIdArea.MinimumWidth = 6;
            ColumnIdArea.Name = "ColumnIdArea";
            ColumnIdArea.Width = 125;
            // 
            // ColumnUbicacion
            // 
            ColumnUbicacion.DataPropertyName = "Ubicacion";
            dataGridViewCellStyle2.BackColor = Color.Gray;
            ColumnUbicacion.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnUbicacion.HeaderText = "UBICACION";
            ColumnUbicacion.MinimumWidth = 6;
            ColumnUbicacion.Name = "ColumnUbicacion";
            ColumnUbicacion.Width = 125;
            // 
            // ColumnInventario
            // 
            ColumnInventario.DataPropertyName = "Inventario";
            dataGridViewCellStyle3.BackColor = Color.Gray;
            ColumnInventario.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnInventario.HeaderText = "INVENTARIO";
            ColumnInventario.MinimumWidth = 6;
            ColumnInventario.Name = "ColumnInventario";
            ColumnInventario.Width = 125;
            // 
            // ColumnEmpleado
            // 
            ColumnEmpleado.DataPropertyName = "Empleado";
            dataGridViewCellStyle4.BackColor = Color.Gray;
            ColumnEmpleado.DefaultCellStyle = dataGridViewCellStyle4;
            ColumnEmpleado.HeaderText = "EMPLEADO";
            ColumnEmpleado.MinimumWidth = 6;
            ColumnEmpleado.Name = "ColumnEmpleado";
            ColumnEmpleado.Width = 125;
            // 
            // ColumnObservaciones
            // 
            ColumnObservaciones.DataPropertyName = "ObservacionesArea";
            dataGridViewCellStyle5.BackColor = Color.Gray;
            ColumnObservaciones.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnObservaciones.HeaderText = "OBSERVACIONES";
            ColumnObservaciones.MinimumWidth = 6;
            ColumnObservaciones.Name = "ColumnObservaciones";
            ColumnObservaciones.Width = 200;
            // 
            // ColumnFecha
            // 
            ColumnFecha.DataPropertyName = "FechaLimpiezaArea";
            dataGridViewCellStyle6.BackColor = Color.Gray;
            ColumnFecha.DefaultCellStyle = dataGridViewCellStyle6;
            ColumnFecha.HeaderText = "FECHA Y HORA";
            ColumnFecha.MinimumWidth = 6;
            ColumnFecha.Name = "ColumnFecha";
            ColumnFecha.Width = 125;
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
            label5.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(190, 158, 68);
            label5.Location = new Point(3, 181);
            label5.Name = "label5";
            label5.Size = new Size(77, 16);
            label5.TabIndex = 28;
            label5.Text = "Ubicacion";
            // 
            // BtnRegLimpiezaArea
            // 
            BtnRegLimpiezaArea.BackgroundImage = (Image)resources.GetObject("BtnRegLimpiezaArea.BackgroundImage");
            BtnRegLimpiezaArea.BackgroundImageLayout = ImageLayout.None;
            BtnRegLimpiezaArea.CustomizableEdges = customizableEdges3;
            BtnRegLimpiezaArea.DisabledState.BorderColor = Color.DarkGray;
            BtnRegLimpiezaArea.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnRegLimpiezaArea.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnRegLimpiezaArea.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnRegLimpiezaArea.FillColor = Color.Transparent;
            BtnRegLimpiezaArea.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRegLimpiezaArea.ForeColor = Color.FromArgb(190, 158, 68);
            BtnRegLimpiezaArea.Location = new Point(26, 423);
            BtnRegLimpiezaArea.Name = "BtnRegLimpiezaArea";
            BtnRegLimpiezaArea.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnRegLimpiezaArea.Size = new Size(151, 40);
            BtnRegLimpiezaArea.TabIndex = 25;
            BtnRegLimpiezaArea.Text = "REGISTRAR";
            BtnRegLimpiezaArea.Click += BtnRegLimpiezaArea_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(190, 158, 68);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(371, 27);
            label1.Name = "label1";
            label1.Size = new Size(383, 29);
            label1.TabIndex = 24;
            label1.Text = "REGISTRO DE LIMPIEZA AREA";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // RegistroLimpArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 514);
            Controls.Add(panelContenedor);
            Name = "RegistroLimpArea";
            Text = "FormLimpieza";
            Load += Form_Load;
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
        private Guna.UI2.WinForms.Guna2Button BtnRegLimpiezaArea;
        private Label label1;
        private ComboBox CbxUbicacion;
        private DataGridViewTextBoxColumn ColumnIdArea;
        private DataGridViewTextBoxColumn ColumnUbicacion;
        private DataGridViewTextBoxColumn ColumnInventario;
        private DataGridViewTextBoxColumn ColumnEmpleado;
        private DataGridViewTextBoxColumn ColumnObservaciones;
        private DataGridViewTextBoxColumn ColumnFecha;
    }
}