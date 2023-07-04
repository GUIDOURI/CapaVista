﻿namespace CapaVista
{
    partial class FormInspeccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInspeccion));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            panel1 = new Panel();
            comboBoxIDarea = new ComboBox();
            label2 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            dataGridView1 = new DataGridView();
            comboBoxNumHabitacion = new ComboBox();
            label3 = new Label();
            ColumnNumHabitacion = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ColumnObvHabitacion = new DataGridViewTextBoxColumn();
            ColumnIDarea = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ColumnObvArea = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(190, 158, 68);
            label1.Location = new Point(352, 7);
            label1.Name = "label1";
            label1.Size = new Size(344, 25);
            label1.TabIndex = 0;
            label1.Text = "FORMULARIO DE INSPECCION";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(23, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 87);
            panel1.TabIndex = 1;
            // 
            // comboBoxIDarea
            // 
            comboBoxIDarea.FormattingEnabled = true;
            comboBoxIDarea.Location = new Point(23, 248);
            comboBoxIDarea.Margin = new Padding(3, 2, 3, 2);
            comboBoxIDarea.Name = "comboBoxIDarea";
            comboBoxIDarea.Size = new Size(242, 23);
            comboBoxIDarea.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(190, 158, 68);
            label2.Location = new Point(36, 141);
            label2.Name = "label2";
            label2.Size = new Size(85, 16);
            label2.TabIndex = 4;
            label2.Text = "HABITACIONES";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(363, 376);
            guna2Button1.Margin = new Padding(3, 2, 3, 2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(181, 28);
            guna2Button1.TabIndex = 6;
            guna2Button1.Text = "CARGAR INSPECCION";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnNumHabitacion, Column1, ColumnObvHabitacion, ColumnIDarea, Column2, ColumnObvArea, ColumnFecha });
            dataGridView1.Location = new Point(289, 68);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(868, 289);
            dataGridView1.TabIndex = 7;
            // 
            // comboBoxNumHabitacion
            // 
            comboBoxNumHabitacion.FormattingEnabled = true;
            comboBoxNumHabitacion.Location = new Point(23, 179);
            comboBoxNumHabitacion.Name = "comboBoxNumHabitacion";
            comboBoxNumHabitacion.Size = new Size(242, 23);
            comboBoxNumHabitacion.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(190, 158, 68);
            label3.Location = new Point(36, 218);
            label3.Name = "label3";
            label3.Size = new Size(42, 16);
            label3.TabIndex = 13;
            label3.Text = "AREAS";
            // 
            // ColumnNumHabitacion
            // 
            ColumnNumHabitacion.DataPropertyName = "numhabitacion";
            ColumnNumHabitacion.HeaderText = "Numero Habitacion";
            ColumnNumHabitacion.MinimumWidth = 6;
            ColumnNumHabitacion.Name = "ColumnNumHabitacion";
            ColumnNumHabitacion.Width = 125;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id_inventario";
            Column1.HeaderText = "InventarioHabitacion";
            Column1.Name = "Column1";
            // 
            // ColumnObvHabitacion
            // 
            ColumnObvHabitacion.DataPropertyName = "Observaciones";
            ColumnObvHabitacion.HeaderText = "ObservacionHabitacion";
            ColumnObvHabitacion.MinimumWidth = 6;
            ColumnObvHabitacion.Name = "ColumnObvHabitacion";
            ColumnObvHabitacion.Width = 125;
            // 
            // ColumnIDarea
            // 
            ColumnIDarea.DataPropertyName = "id_limpieza_area";
            ColumnIDarea.HeaderText = "ID Area";
            ColumnIDarea.MinimumWidth = 6;
            ColumnIDarea.Name = "ColumnIDarea";
            ColumnIDarea.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "id_inventario";
            Column2.HeaderText = "InventarioArea";
            Column2.Name = "Column2";
            // 
            // ColumnObvArea
            // 
            ColumnObvArea.DataPropertyName = "ObservacionesArea";
            ColumnObvArea.HeaderText = "ObservacionArea";
            ColumnObvArea.MinimumWidth = 6;
            ColumnObvArea.Name = "ColumnObvArea";
            ColumnObvArea.Width = 125;
            // 
            // ColumnFecha
            // 
            ColumnFecha.DataPropertyName = "FechaInspeccion";
            ColumnFecha.HeaderText = "FECHA INSPECCION";
            ColumnFecha.MinimumWidth = 6;
            ColumnFecha.Name = "ColumnFecha";
            ColumnFecha.Width = 125;
            // 
            // FormInspeccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1169, 437);
            Controls.Add(label3);
            Controls.Add(comboBoxNumHabitacion);
            Controls.Add(dataGridView1);
            Controls.Add(guna2Button1);
            Controls.Add(label2);
            Controls.Add(comboBoxIDarea);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormInspeccion";
            Text = "FormInspeccion";
            Load += FormInspeccion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox comboBoxIDarea;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private DataGridView dataGridView1;
        private ComboBox comboBoxNumHabitacion;
        private Label label3;
        private DataGridViewTextBoxColumn ColumnNumHabitacion;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColumnObvHabitacion;
        private DataGridViewTextBoxColumn ColumnIDarea;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn ColumnObvArea;
        private DataGridViewTextBoxColumn ColumnFecha;
    }
}