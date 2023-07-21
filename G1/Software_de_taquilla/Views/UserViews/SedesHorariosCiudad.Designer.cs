namespace Software_de_taquilla.Views.UserViews
{
    partial class SedesHorariosCiudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SedesHorariosCiudad));
            btnNotificacion = new Button();
            dtFecha = new DateTimePicker();
            label2 = new Label();
            cmbLugar = new ComboBox();
            cmbFecha = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnNotificacion
            // 
            btnNotificacion.FlatAppearance.BorderSize = 0;
            btnNotificacion.FlatStyle = FlatStyle.Flat;
            btnNotificacion.Image = (Image)resources.GetObject("btnNotificacion.Image");
            btnNotificacion.Location = new Point(649, 12);
            btnNotificacion.Name = "btnNotificacion";
            btnNotificacion.Size = new Size(38, 39);
            btnNotificacion.TabIndex = 12;
            btnNotificacion.UseVisualStyleBackColor = true;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(443, 33);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(200, 23);
            dtFecha.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(12, 64, 76);
            label2.Location = new Point(37, 33);
            label2.Name = "label2";
            label2.Size = new Size(221, 28);
            label2.TabIndex = 10;
            label2.Text = "Sedes y Horarios";
            // 
            // cmbLugar
            // 
            cmbLugar.FormattingEnabled = true;
            cmbLugar.Location = new Point(37, 73);
            cmbLugar.Name = "cmbLugar";
            cmbLugar.Size = new Size(181, 23);
            cmbLugar.TabIndex = 13;
            cmbLugar.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbFecha
            // 
            cmbFecha.FormattingEnabled = true;
            cmbFecha.Location = new Point(254, 73);
            cmbFecha.Name = "cmbFecha";
            cmbFecha.Size = new Size(165, 23);
            cmbFecha.TabIndex = 14;
            cmbFecha.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(82, 101, 113);
            label1.Location = new Point(37, 127);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 15;
            label1.Text = "Miraflores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(82, 101, 113);
            label3.Location = new Point(414, 127);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 16;
            label3.Text = "Dinamia Cayalá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(82, 101, 113);
            label4.Location = new Point(37, 282);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 17;
            label4.Text = "Pradera Concepción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(82, 101, 113);
            label5.Location = new Point(414, 282);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 18;
            label5.Text = "Oakland Mall";
            // 
            // SedesHorariosCiudad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(706, 460);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cmbFecha);
            Controls.Add(cmbLugar);
            Controls.Add(btnNotificacion);
            Controls.Add(dtFecha);
            Controls.Add(label2);
            Name = "SedesHorariosCiudad";
            Text = "SedesHorariosCiudad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNotificacion;
        private DateTimePicker dtFecha;
        private Label label2;
        private ComboBox cmbLugar;
        private ComboBox cmbFecha;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}