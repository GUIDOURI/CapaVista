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
            dateTimePicker1 = new DateTimePicker();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            comboBoxNumHabitacion = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBoxEstado = new ComboBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            dataGridView1 = new DataGridView();
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
            label1.Location = new Point(291, 23);
            label1.Name = "label1";
            label1.Size = new Size(274, 35);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE LIMPIEZA";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(25, 232);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(272, 23);
            dateTimePicker1.TabIndex = 1;
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
            guna2Button2.Location = new Point(25, 419);
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
            label3.Location = new Point(25, 267);
            label3.Name = "label3";
            label3.Size = new Size(132, 19);
            label3.TabIndex = 10;
            label3.Text = "Numero de Habitacion";
            // 
            // comboBoxNumHabitacion
            // 
            comboBoxNumHabitacion.FormattingEnabled = true;
            comboBoxNumHabitacion.Location = new Point(24, 306);
            comboBoxNumHabitacion.Name = "comboBoxNumHabitacion";
            comboBoxNumHabitacion.Size = new Size(175, 23);
            comboBoxNumHabitacion.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Alegreya", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(190, 158, 68);
            label4.Location = new Point(25, 191);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 12;
            label4.Text = "Fecha";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Alegreya", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(190, 158, 68);
            label5.Location = new Point(24, 332);
            label5.Name = "label5";
            label5.Size = new Size(46, 19);
            label5.TabIndex = 13;
            label5.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(24, 365);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(272, 23);
            comboBoxEstado.TabIndex = 14;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackgroundImage = (Image)resources.GetObject("guna2Panel1.BackgroundImage");
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Location = new Point(35, 23);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(97, 83);
            guna2Panel1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(317, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(570, 364);
            dataGridView1.TabIndex = 16;
            // 
            // RegistroLimpiezaHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(899, 486);
            Controls.Add(dataGridView1);
            Controls.Add(guna2Panel1);
            Controls.Add(comboBoxEstado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxNumHabitacion);
            Controls.Add(label3);
            Controls.Add(guna2Button2);
            Controls.Add(dateTimePicker1);
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
        private DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label label3;
        private ComboBox comboBoxNumHabitacion;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxEstado;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private DataGridView dataGridView1;
    }
}