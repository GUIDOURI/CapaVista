namespace CapaVista
{
    partial class FormInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            BtnRegistrarHab = new Guna.UI2.WinForms.Guna2Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(43, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(804, 350);
            dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Objeto";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Fecha";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 300;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Alegreya", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(190, 158, 68);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(338, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 35);
            label1.TabIndex = 7;
            label1.Text = "INVENTARIO";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnRegistrarHab
            // 
            BtnRegistrarHab.CustomizableEdges = customizableEdges3;
            BtnRegistrarHab.DisabledState.BorderColor = Color.DarkGray;
            BtnRegistrarHab.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnRegistrarHab.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnRegistrarHab.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnRegistrarHab.FillColor = Color.Transparent;
            BtnRegistrarHab.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRegistrarHab.ForeColor = Color.White;
            BtnRegistrarHab.Image = (Image)resources.GetObject("BtnRegistrarHab.Image");
            BtnRegistrarHab.Location = new Point(693, 66);
            BtnRegistrarHab.Name = "BtnRegistrarHab";
            BtnRegistrarHab.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnRegistrarHab.Size = new Size(122, 23);
            BtnRegistrarHab.TabIndex = 9;
            BtnRegistrarHab.Text = "BUSCAR";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(575, 23);
            textBox1.TabIndex = 8;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(877, 507);
            Controls.Add(BtnRegistrarHab);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormInventario";
            Text = "FormInventario";
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
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnRegistrarHab;
        private TextBox textBox1;
    }
}