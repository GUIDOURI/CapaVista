﻿namespace CapaVista
{
    partial class FormEmpleados
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            BtnRegistrarHab = new Guna.UI2.WinForms.Guna2Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(30, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(779, 320);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellidos";
            Column3.Name = "Column3";
            Column3.Width = 120;
            // 
            // Column4
            // 
            Column4.HeaderText = "Celular";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Direccion";
            Column5.Name = "Column5";
            Column5.Width = 110;
            // 
            // Column6
            // 
            Column6.HeaderText = "Fecha";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Rubro";
            Column7.Name = "Column7";
            // 
            // BtnRegistrarHab
            // 
            BtnRegistrarHab.CustomizableEdges = customizableEdges1;
            BtnRegistrarHab.DisabledState.BorderColor = Color.DarkGray;
            BtnRegistrarHab.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnRegistrarHab.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnRegistrarHab.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnRegistrarHab.FillColor = Color.Transparent;
            BtnRegistrarHab.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRegistrarHab.ForeColor = Color.White;
            BtnRegistrarHab.Image = (Image)resources.GetObject("BtnRegistrarHab.Image");
            BtnRegistrarHab.Location = new Point(687, 66);
            BtnRegistrarHab.Name = "BtnRegistrarHab";
            BtnRegistrarHab.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnRegistrarHab.Size = new Size(122, 23);
            BtnRegistrarHab.TabIndex = 12;
            BtnRegistrarHab.Text = "BUSCAR";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(575, 23);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Alegreya", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(190, 158, 68);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(332, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 35);
            label1.TabIndex = 10;
            label1.Text = "EMPLEADOS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(837, 474);
            Controls.Add(BtnRegistrarHab);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormEmpleados";
            Text = "FormEmpleados";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Guna.UI2.WinForms.Guna2Button BtnRegistrarHab;
        private TextBox textBox1;
        private Label label1;
    }
}