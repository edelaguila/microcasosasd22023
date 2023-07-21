namespace Software_de_taquilla.Views.UserViews
{
    partial class SedesHorariosXela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SedesHorariosXela));
            label3 = new Label();
            label1 = new Label();
            cmbFecha = new ComboBox();
            cmbLugar = new ComboBox();
            btnNotificacion = new Button();
            dtFecha = new DateTimePicker();
            label2 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(82, 101, 113);
            label3.Location = new Point(389, 144);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 25;
            label3.Text = "Interplaza Xela";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(82, 101, 113);
            label1.Location = new Point(12, 144);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 24;
            label1.Text = "Utz Ulew Mall";
            // 
            // cmbFecha
            // 
            cmbFecha.FormattingEnabled = true;
            cmbFecha.Location = new Point(234, 88);
            cmbFecha.Name = "cmbFecha";
            cmbFecha.Size = new Size(165, 23);
            cmbFecha.TabIndex = 23;
            // 
            // cmbLugar
            // 
            cmbLugar.FormattingEnabled = true;
            cmbLugar.Location = new Point(12, 88);
            cmbLugar.Name = "cmbLugar";
            cmbLugar.Size = new Size(181, 23);
            cmbLugar.TabIndex = 22;
            // 
            // btnNotificacion
            // 
            btnNotificacion.FlatAppearance.BorderSize = 0;
            btnNotificacion.FlatStyle = FlatStyle.Flat;
            btnNotificacion.Image = (Image)resources.GetObject("btnNotificacion.Image");
            btnNotificacion.Location = new Point(624, 8);
            btnNotificacion.Name = "btnNotificacion";
            btnNotificacion.Size = new Size(38, 39);
            btnNotificacion.TabIndex = 21;
            btnNotificacion.UseVisualStyleBackColor = true;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(418, 29);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(200, 23);
            dtFecha.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(12, 64, 76);
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(221, 28);
            label2.TabIndex = 19;
            label2.Text = "Sedes y Horarios";
            // 
            // SedesHorariosXela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(676, 427);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cmbFecha);
            Controls.Add(cmbLugar);
            Controls.Add(btnNotificacion);
            Controls.Add(dtFecha);
            Controls.Add(label2);
            Name = "SedesHorariosXela";
            Text = "SedesHorariosXela";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private ComboBox cmbFecha;
        private ComboBox cmbLugar;
        private Button btnNotificacion;
        private DateTimePicker dtFecha;
        private Label label2;
    }
}