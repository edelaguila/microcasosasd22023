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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.txt_notarjeta = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_cvv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fechav = new System.Windows.Forms.TextBox();
            this.rb_pago = new System.Windows.Forms.RadioButton();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.btn_cobro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pago";
            // 
            // txt_correo
            // 
            this.txt_correo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_correo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_correo.Location = new System.Drawing.Point(38, 137);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(331, 30);
            this.txt_correo.TabIndex = 1;
            this.txt_correo.Text = "ejemplo@gmail.com";
            this.txt_correo.Click += new System.EventHandler(this.txt_correo_Click);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_telefono.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_telefono.Location = new System.Drawing.Point(427, 141);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(276, 30);
            this.txt_telefono.TabIndex = 2;
            this.txt_telefono.Text = "Teléfono";
            this.txt_telefono.Click += new System.EventHandler(this.txt_telefono_Click);
            this.txt_telefono.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txt_telefono.Leave += new System.EventHandler(this.txt_telefono_Leave);
            // 
            // txt_monto
            // 
            this.txt_monto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_monto.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_monto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_monto.Location = new System.Drawing.Point(38, 203);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(331, 30);
            this.txt_monto.TabIndex = 3;
            this.txt_monto.Text = "Q.245.00 ";
            this.txt_monto.Click += new System.EventHandler(this.txt_monto_Click);
            this.txt_monto.Leave += new System.EventHandler(this.txt_monto_Leave);
            // 
            // txt_notarjeta
            // 
            this.txt_notarjeta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_notarjeta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_notarjeta.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_notarjeta.Location = new System.Drawing.Point(38, 263);
            this.txt_notarjeta.Name = "txt_notarjeta";
            this.txt_notarjeta.Size = new System.Drawing.Size(331, 30);
            this.txt_notarjeta.TabIndex = 4;
            this.txt_notarjeta.Text = "Número de Tarjeta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(412, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txt_cvv
            // 
            this.txt_cvv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cvv.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cvv.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_cvv.Location = new System.Drawing.Point(38, 338);
            this.txt_cvv.Name = "txt_cvv";
            this.txt_cvv.Size = new System.Drawing.Size(331, 30);
            this.txt_cvv.TabIndex = 6;
            this.txt_cvv.Text = "CVV";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "CVV";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(427, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de vencimiento";
            // 
            // txt_fechav
            // 
            this.txt_fechav.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fechav.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_fechav.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_fechav.Location = new System.Drawing.Point(427, 337);
            this.txt_fechav.Name = "txt_fechav";
            this.txt_fechav.Size = new System.Drawing.Size(276, 30);
            this.txt_fechav.TabIndex = 9;
            this.txt_fechav.Text = "dd/mm/yyyy";
            // 
            // rb_pago
            // 
            this.rb_pago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_pago.AutoSize = true;
            this.rb_pago.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_pago.Location = new System.Drawing.Point(427, 204);
            this.rb_pago.Name = "rb_pago";
            this.rb_pago.Size = new System.Drawing.Size(278, 25);
            this.rb_pago.TabIndex = 10;
            this.rb_pago.TabStop = true;
            this.rb_pago.Text = "Pago con tarjeta de credito";
            this.rb_pago.UseVisualStyleBackColor = true;
            // 
            // pic1
            // 
            this.pic1.Image = global::Software_de_taquilla.Properties.Resources.visa;
            this.pic1.Location = new System.Drawing.Point(437, 238);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(50, 35);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic1.TabIndex = 17;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::Software_de_taquilla.Properties.Resources.card;
            this.pic2.Location = new System.Drawing.Point(529, 238);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(62, 35);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic2.TabIndex = 18;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Image = global::Software_de_taquilla.Properties.Resources.american_express;
            this.pic3.Location = new System.Drawing.Point(630, 238);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(58, 35);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic3.TabIndex = 19;
            this.pic3.TabStop = false;
            // 
            // pic6
            // 
            this.pic6.Image = global::Software_de_taquilla.Properties.Resources.american_express;
            this.pic6.Location = new System.Drawing.Point(255, 407);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(58, 36);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic6.TabIndex = 25;
            this.pic6.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.Image = global::Software_de_taquilla.Properties.Resources.card;
            this.pic5.Location = new System.Drawing.Point(143, 407);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(62, 36);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic5.TabIndex = 24;
            this.pic5.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Image = global::Software_de_taquilla.Properties.Resources.visa;
            this.pic4.Location = new System.Drawing.Point(53, 407);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(50, 36);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic4.TabIndex = 23;
            this.pic4.TabStop = false;
            // 
            // btn_cobro
            // 
            this.btn_cobro.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_cobro.FlatAppearance.BorderSize = 0;
            this.btn_cobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cobro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cobro.ForeColor = System.Drawing.Color.White;
            this.btn_cobro.Location = new System.Drawing.Point(452, 412);
            this.btn_cobro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cobro.Name = "btn_cobro";
            this.btn_cobro.Size = new System.Drawing.Size(203, 31);
            this.btn_cobro.TabIndex = 26;
            this.btn_cobro.Text = "Realizar Cobro";
            this.btn_cobro.UseVisualStyleBackColor = false;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 505);
            this.Controls.Add(this.btn_cobro);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.rb_pago);
            this.Controls.Add(this.txt_fechav);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cvv);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_notarjeta);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagos";
            this.Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_correo;
        private TextBox txt_telefono;
        private TextBox txt_monto;
        private TextBox txt_notarjeta;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_cvv;
        private Label label2;
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