namespace Software_de_taquilla.Views.AdminViews
{
    partial class Cartelera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartelera));
            groupBox1 = new GroupBox();
            txtSinopsis = new TextBox();
            txtDuracion = new TextBox();
            txtPublico = new TextBox();
            txtProductora = new TextBox();
            txtNombre = new TextBox();
            pctPelicula = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctPelicula).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSinopsis);
            groupBox1.Controls.Add(txtDuracion);
            groupBox1.Controls.Add(txtPublico);
            groupBox1.Controls.Add(txtProductora);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(pctPelicula);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(51, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 268);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información";
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(170, 197);
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(208, 23);
            txtSinopsis.TabIndex = 10;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(170, 161);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(208, 23);
            txtDuracion.TabIndex = 9;
            // 
            // txtPublico
            // 
            txtPublico.Location = new Point(170, 120);
            txtPublico.Name = "txtPublico";
            txtPublico.Size = new Size(208, 23);
            txtPublico.TabIndex = 8;
            // 
            // txtProductora
            // 
            txtProductora.Location = new Point(170, 77);
            txtProductora.Name = "txtProductora";
            txtProductora.Size = new Size(208, 23);
            txtProductora.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(170, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(208, 23);
            txtNombre.TabIndex = 6;
            // 
            // pctPelicula
            // 
            pctPelicula.Location = new Point(409, 50);
            pctPelicula.Name = "pctPelicula";
            pctPelicula.Size = new Size(151, 144);
            pctPelicula.TabIndex = 5;
            pctPelicula.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 197);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 4;
            label5.Text = "Sinopsis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 161);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Duración";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 120);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 2;
            label3.Text = "Público dirigido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 80);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Productora";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 40);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(51, 309);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(581, 129);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Gainsboro;
            btnEliminar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(387, 51);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 45);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Gainsboro;
            btnModificar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(219, 51);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(104, 45);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Gainsboro;
            btnAgregar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(58, 51);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(104, 45);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Cartelera
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(701, 462);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Cartelera";
            Text = "Cartelera";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctPelicula).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pctPelicula;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private TextBox txtSinopsis;
        private TextBox txtDuracion;
        private TextBox txtPublico;
        private TextBox txtProductora;
        private TextBox txtNombre;
    }
}