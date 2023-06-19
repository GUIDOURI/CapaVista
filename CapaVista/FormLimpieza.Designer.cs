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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLimpieza));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(26, 26, 26);
            panelContenedor.Controls.Add(guna2Button1);
            panelContenedor.Controls.Add(textBox1);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Controls.Add(dataGridView1);
            panelContenedor.Controls.Add(guna2Button5);
            panelContenedor.Controls.Add(guna2Button4);
            panelContenedor.Controls.Add(guna2Button3);
            panelContenedor.Controls.Add(BtnRegistrarHab);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(875, 514);
            panelContenedor.TabIndex = 4;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(30, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(811, 295);
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
            Column2.Width = 200;
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
            Column4.Width = 300;
            // 
            // guna2Button5
            // 
            guna2Button5.CustomizableEdges = customizableEdges3;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FillColor = Color.Transparent;
            guna2Button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button5.ForeColor = Color.White;
            guna2Button5.Image = (Image)resources.GetObject("guna2Button5.Image");
            guna2Button5.Location = new Point(720, 445);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button5.Size = new Size(100, 26);
            guna2Button5.TabIndex = 4;
            guna2Button5.Text = "REGRESAR";
            guna2Button5.Click += guna2Button5_Click;
            // 
            // guna2Button4
            // 
            guna2Button4.CustomizableEdges = customizableEdges5;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.Transparent;
            guna2Button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button4.ForeColor = Color.White;
            guna2Button4.Image = (Image)resources.GetObject("guna2Button4.Image");
            guna2Button4.Location = new Point(530, 445);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button4.Size = new Size(100, 26);
            guna2Button4.TabIndex = 3;
            guna2Button4.Text = "MODIFICAR";
            // 
            // guna2Button3
            // 
            guna2Button3.CustomizableEdges = customizableEdges7;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.Transparent;
            guna2Button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Image = (Image)resources.GetObject("guna2Button3.Image");
            guna2Button3.Location = new Point(344, 445);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button3.Size = new Size(100, 26);
            guna2Button3.TabIndex = 2;
            guna2Button3.Text = "ELIMINAR";
            guna2Button3.Click += guna2Button3_Click;
            // 
            // BtnRegistrarHab
            // 
            BtnRegistrarHab.CustomizableEdges = customizableEdges9;
            BtnRegistrarHab.DisabledState.BorderColor = Color.DarkGray;
            BtnRegistrarHab.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnRegistrarHab.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnRegistrarHab.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnRegistrarHab.FillColor = Color.Transparent;
            BtnRegistrarHab.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRegistrarHab.ForeColor = Color.White;
            BtnRegistrarHab.Image = (Image)resources.GetObject("BtnRegistrarHab.Image");
            BtnRegistrarHab.Location = new Point(30, 445);
            BtnRegistrarHab.Name = "BtnRegistrarHab";
            BtnRegistrarHab.ShadowDecoration.CustomizableEdges = customizableEdges10;
            BtnRegistrarHab.Size = new Size(100, 26);
            BtnRegistrarHab.TabIndex = 1;
            BtnRegistrarHab.Text = "REGISTRAR";
            BtnRegistrarHab.Click += guna2Button2_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.Location = new Point(682, 66);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(122, 23);
            guna2Button1.TabIndex = 12;
            guna2Button1.Text = "BUSCAR";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 66);
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
            label1.Location = new Point(327, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 35);
            label1.TabIndex = 10;
            label1.Text = "LIMPIEZA";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormLimpieza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 514);
            Controls.Add(panelContenedor);
            Name = "FormLimpieza";
            Text = "FormLimpieza";
            Load += FormLimpieza_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private TextBox textBox1;
        private Label label1;
    }
}