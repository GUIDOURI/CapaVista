namespace CapaVista
{
    partial class FormLimpieza
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLimpieza));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelContenedor = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            BtnRegistrarHab = new Guna.UI2.WinForms.Guna2Button();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(26, 26, 26);
            panelContenedor.Controls.Add(dataGridView1);
            panelContenedor.Controls.Add(guna2Button5);
            panelContenedor.Controls.Add(guna2Button4);
            panelContenedor.Controls.Add(guna2Button3);
            panelContenedor.Controls.Add(BtnRegistrarHab);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Margin = new Padding(3, 4, 3, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1000, 513);
            panelContenedor.TabIndex = 4;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(35, 8);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(927, 393);
            dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nro. Hab.";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tipo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Estado";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // guna2Button5
            // 
            guna2Button5.CustomizableEdges = customizableEdges9;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FillColor = Color.Transparent;
            guna2Button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button5.ForeColor = Color.White;
            guna2Button5.Image = (Image)resources.GetObject("guna2Button5.Image");
            guna2Button5.Location = new Point(824, 436);
            guna2Button5.Margin = new Padding(3, 4, 3, 4);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button5.Size = new Size(114, 35);
            guna2Button5.TabIndex = 4;
            guna2Button5.Text = "REGRESAR";
            guna2Button5.Click += guna2Button5_Click;
            // 
            // guna2Button4
            // 
            guna2Button4.CustomizableEdges = customizableEdges11;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.Transparent;
            guna2Button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button4.ForeColor = Color.White;
            guna2Button4.Image = (Image)resources.GetObject("guna2Button4.Image");
            guna2Button4.Location = new Point(607, 436);
            guna2Button4.Margin = new Padding(3, 4, 3, 4);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Button4.Size = new Size(114, 35);
            guna2Button4.TabIndex = 3;
            guna2Button4.Text = "MODIFICAR";
            // 
            // guna2Button3
            // 
            guna2Button3.CustomizableEdges = customizableEdges13;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.Transparent;
            guna2Button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Image = (Image)resources.GetObject("guna2Button3.Image");
            guna2Button3.Location = new Point(394, 436);
            guna2Button3.Margin = new Padding(3, 4, 3, 4);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Button3.Size = new Size(114, 35);
            guna2Button3.TabIndex = 2;
            guna2Button3.Text = "ELIMINAR";
            // 
            // BtnRegistrarHab
            // 
            BtnRegistrarHab.CustomizableEdges = customizableEdges15;
            BtnRegistrarHab.DisabledState.BorderColor = Color.DarkGray;
            BtnRegistrarHab.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnRegistrarHab.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnRegistrarHab.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnRegistrarHab.FillColor = Color.Transparent;
            BtnRegistrarHab.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRegistrarHab.ForeColor = Color.White;
            BtnRegistrarHab.Image = (Image)resources.GetObject("BtnRegistrarHab.Image");
            BtnRegistrarHab.Location = new Point(35, 436);
            BtnRegistrarHab.Margin = new Padding(3, 4, 3, 4);
            BtnRegistrarHab.Name = "BtnRegistrarHab";
            BtnRegistrarHab.ShadowDecoration.CustomizableEdges = customizableEdges16;
            BtnRegistrarHab.Size = new Size(114, 35);
            BtnRegistrarHab.TabIndex = 1;
            BtnRegistrarHab.Text = "REGISTRAR";
            BtnRegistrarHab.Click += guna2Button2_Click;
            // 
            // FormLimpieza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 513);
            Controls.Add(panelContenedor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLimpieza";
            Text = "FormLimpieza";
            Load += FormLimpieza_Load;
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContenedor;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button BtnRegistrarHab;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}