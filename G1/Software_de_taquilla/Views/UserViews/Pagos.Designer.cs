namespace Software_de_taquilla.Views.UserViews
{
    partial class Pagos
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
            label1 = new Label();
            txt_correo = new TextBox();
            txt_telefono = new TextBox();
            txt_monto = new TextBox();
            txt_notarjeta = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txt_cvv = new TextBox();
            label3 = new Label();
            txt_fechav = new TextBox();
            rb_pago = new RadioButton();
            pic1 = new PictureBox();
            pic2 = new PictureBox();
            pic3 = new PictureBox();
            pic6 = new PictureBox();
            pic5 = new PictureBox();
            pic4 = new PictureBox();
            btn_cobro = new Button();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(12, 62, 85);
            label1.Location = new Point(24, 52);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 0;
            label1.Text = "Pago";
            // 
            // txt_correo
            // 
            txt_correo.Anchor = AnchorStyles.None;
            txt_correo.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_correo.ForeColor = SystemColors.WindowFrame;
            txt_correo.Location = new Point(33, 103);
            txt_correo.Margin = new Padding(3, 2, 3, 2);
            txt_correo.Name = "txt_correo";
            txt_correo.PlaceholderText = "ejemplo@gmail.com";
            txt_correo.Size = new Size(290, 25);
            txt_correo.TabIndex = 1;
            // 
            // txt_telefono
            // 
            txt_telefono.Anchor = AnchorStyles.None;
            txt_telefono.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefono.ForeColor = SystemColors.WindowFrame;
            txt_telefono.Location = new Point(374, 106);
            txt_telefono.Margin = new Padding(3, 2, 3, 2);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.PlaceholderText = "Telefono";
            txt_telefono.Size = new Size(242, 25);
            txt_telefono.TabIndex = 2;
            // 
            // txt_monto
            // 
            txt_monto.Anchor = AnchorStyles.None;
            txt_monto.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_monto.ForeColor = SystemColors.WindowFrame;
            txt_monto.Location = new Point(33, 152);
            txt_monto.Margin = new Padding(3, 2, 3, 2);
            txt_monto.Name = "txt_monto";
            txt_monto.PlaceholderText = "Q.";
            txt_monto.ReadOnly = true;
            txt_monto.Size = new Size(290, 25);
            txt_monto.TabIndex = 3;
            // 
            // txt_notarjeta
            // 
            txt_notarjeta.Anchor = AnchorStyles.None;
            txt_notarjeta.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_notarjeta.ForeColor = SystemColors.WindowFrame;
            txt_notarjeta.Location = new Point(33, 197);
            txt_notarjeta.Margin = new Padding(3, 2, 3, 2);
            txt_notarjeta.Name = "txt_notarjeta";
            txt_notarjeta.PlaceholderText = "Número de Tarjeta";
            txt_notarjeta.Size = new Size(290, 25);
            txt_notarjeta.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(374, 62);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 22);
            dateTimePicker1.TabIndex = 5;
            // 
            // txt_cvv
            // 
            txt_cvv.Anchor = AnchorStyles.None;
            txt_cvv.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cvv.ForeColor = SystemColors.WindowFrame;
            txt_cvv.Location = new Point(33, 254);
            txt_cvv.Margin = new Padding(3, 2, 3, 2);
            txt_cvv.Name = "txt_cvv";
            txt_cvv.PlaceholderText = "CVV";
            txt_cvv.Size = new Size(290, 25);
            txt_cvv.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(374, 232);
            label3.Name = "label3";
            label3.Size = new Size(175, 20);
            label3.TabIndex = 8;
            label3.Text = "Fecha de vencimiento";
            // 
            // txt_fechav
            // 
            txt_fechav.Anchor = AnchorStyles.None;
            txt_fechav.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_fechav.ForeColor = SystemColors.WindowFrame;
            txt_fechav.Location = new Point(374, 253);
            txt_fechav.Margin = new Padding(3, 2, 3, 2);
            txt_fechav.Name = "txt_fechav";
            txt_fechav.PlaceholderText = "dd/mm/yyyy";
            txt_fechav.Size = new Size(242, 25);
            txt_fechav.TabIndex = 9;
            // 
            // rb_pago
            // 
            rb_pago.Anchor = AnchorStyles.None;
            rb_pago.AutoSize = true;
            rb_pago.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rb_pago.Location = new Point(374, 153);
            rb_pago.Margin = new Padding(3, 2, 3, 2);
            rb_pago.Name = "rb_pago";
            rb_pago.Size = new Size(232, 24);
            rb_pago.TabIndex = 10;
            rb_pago.TabStop = true;
            rb_pago.Text = "Pago con tarjeta de credito";
            rb_pago.UseVisualStyleBackColor = true;
            // 
            // pic1
            // 
            pic1.Image = Properties.Resources.visa;
            pic1.Location = new Point(382, 178);
            pic1.Margin = new Padding(3, 2, 3, 2);
            pic1.Name = "pic1";
            pic1.Size = new Size(44, 26);
            pic1.SizeMode = PictureBoxSizeMode.CenterImage;
            pic1.TabIndex = 17;
            pic1.TabStop = false;
            // 
            // pic2
            // 
            pic2.Image = Properties.Resources.card;
            pic2.Location = new Point(463, 178);
            pic2.Margin = new Padding(3, 2, 3, 2);
            pic2.Name = "pic2";
            pic2.Size = new Size(54, 26);
            pic2.SizeMode = PictureBoxSizeMode.CenterImage;
            pic2.TabIndex = 18;
            pic2.TabStop = false;
            // 
            // pic3
            // 
            pic3.Image = Properties.Resources.american_express;
            pic3.Location = new Point(551, 178);
            pic3.Margin = new Padding(3, 2, 3, 2);
            pic3.Name = "pic3";
            pic3.Size = new Size(51, 26);
            pic3.SizeMode = PictureBoxSizeMode.CenterImage;
            pic3.TabIndex = 19;
            pic3.TabStop = false;
            // 
            // pic6
            // 
            pic6.Image = Properties.Resources.american_express;
            pic6.Location = new Point(223, 305);
            pic6.Margin = new Padding(3, 2, 3, 2);
            pic6.Name = "pic6";
            pic6.Size = new Size(51, 27);
            pic6.SizeMode = PictureBoxSizeMode.CenterImage;
            pic6.TabIndex = 25;
            pic6.TabStop = false;
            // 
            // pic5
            // 
            pic5.Image = Properties.Resources.card;
            pic5.Location = new Point(125, 305);
            pic5.Margin = new Padding(3, 2, 3, 2);
            pic5.Name = "pic5";
            pic5.Size = new Size(54, 27);
            pic5.SizeMode = PictureBoxSizeMode.CenterImage;
            pic5.TabIndex = 24;
            pic5.TabStop = false;
            // 
            // pic4
            // 
            pic4.Image = Properties.Resources.visa;
            pic4.Location = new Point(46, 305);
            pic4.Margin = new Padding(3, 2, 3, 2);
            pic4.Name = "pic4";
            pic4.Size = new Size(44, 27);
            pic4.SizeMode = PictureBoxSizeMode.CenterImage;
            pic4.TabIndex = 23;
            pic4.TabStop = false;
            // 
            // btn_cobro
            // 
            btn_cobro.BackColor = Color.SeaGreen;
            btn_cobro.FlatAppearance.BorderSize = 0;
            btn_cobro.FlatStyle = FlatStyle.Flat;
            btn_cobro.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cobro.ForeColor = Color.White;
            btn_cobro.Location = new Point(396, 309);
            btn_cobro.Name = "btn_cobro";
            btn_cobro.Size = new Size(178, 23);
            btn_cobro.TabIndex = 26;
            btn_cobro.Text = "Realizar Cobro";
            btn_cobro.UseVisualStyleBackColor = false;
            btn_cobro.Click += btn_cobro_Click;
            // 
            // Pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(635, 379);
            Controls.Add(btn_cobro);
            Controls.Add(pic6);
            Controls.Add(pic5);
            Controls.Add(pic4);
            Controls.Add(pic3);
            Controls.Add(pic2);
            Controls.Add(pic1);
            Controls.Add(rb_pago);
            Controls.Add(txt_fechav);
            Controls.Add(label3);
            Controls.Add(txt_cvv);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_notarjeta);
            Controls.Add(txt_monto);
            Controls.Add(txt_telefono);
            Controls.Add(txt_correo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Pagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_correo;
        private TextBox txt_telefono;
        private TextBox txt_monto;
        private TextBox txt_notarjeta;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_cvv;
        private Label label3;
        private TextBox txt_fechav;
        private RadioButton rb_pago;
        private PictureBox pic1;
        private PictureBox pic2;
        private PictureBox pic3;
        private PictureBox pic6;
        private PictureBox pic5;
        private PictureBox pic4;
        public Button btn_cobro;
    }
}