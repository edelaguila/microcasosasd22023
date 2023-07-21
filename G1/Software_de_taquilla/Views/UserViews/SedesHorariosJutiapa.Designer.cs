namespace Software_de_taquilla.Views.UserViews
{
    partial class SedesHorariosJutiapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SedesHorariosJutiapa));
            label1 = new Label();
            cmbFecha = new ComboBox();
            cmbLugar = new ComboBox();
            btnNotificacion = new Button();
            dtFecha = new DateTimePicker();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(82, 101, 113);
            label1.Location = new Point(22, 146);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 31;
            label1.Text = "MC Jutiapa";
            // 
            // cmbFecha
            // 
            cmbFecha.FormattingEnabled = true;
            cmbFecha.Location = new Point(244, 90);
            cmbFecha.Name = "cmbFecha";
            cmbFecha.Size = new Size(165, 23);
            cmbFecha.TabIndex = 30;
            // 
            // cmbLugar
            // 
            cmbLugar.FormattingEnabled = true;
            cmbLugar.Location = new Point(22, 90);
            cmbLugar.Name = "cmbLugar";
            cmbLugar.Size = new Size(181, 23);
            cmbLugar.TabIndex = 29;
            // 
            // btnNotificacion
            // 
            btnNotificacion.FlatAppearance.BorderSize = 0;
            btnNotificacion.FlatStyle = FlatStyle.Flat;
            btnNotificacion.Image = (Image)resources.GetObject("btnNotificacion.Image");
            btnNotificacion.Location = new Point(646, 12);
            btnNotificacion.Name = "btnNotificacion";
            btnNotificacion.Size = new Size(38, 39);
            btnNotificacion.TabIndex = 28;
            btnNotificacion.UseVisualStyleBackColor = true;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(428, 31);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(200, 23);
            dtFecha.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(12, 64, 76);
            label2.Location = new Point(22, 31);
            label2.Name = "label2";
            label2.Size = new Size(221, 28);
            label2.TabIndex = 26;
            label2.Text = "Sedes y Horarios";
            // 
            // SedesHorariosJutiapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(696, 346);
            Controls.Add(label1);
            Controls.Add(cmbFecha);
            Controls.Add(cmbLugar);
            Controls.Add(btnNotificacion);
            Controls.Add(dtFecha);
            Controls.Add(label2);
            Name = "SedesHorariosJutiapa";
            Text = "SedesHorariosJutiapa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbFecha;
        private ComboBox cmbLugar;
        private Button btnNotificacion;
        private DateTimePicker dtFecha;
        private Label label2;
    }
}