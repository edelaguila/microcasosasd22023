namespace Software_de_taquilla.Views.UserViews
{
    partial class ListingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListingView));
            this.btnNotificacion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flow_container = new System.Windows.Forms.FlowLayoutPanel();
            this.combo_city = new System.Windows.Forms.ComboBox();
            this.combo_cine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNotificacion
            // 
            this.btnNotificacion.FlatAppearance.BorderSize = 0;
            this.btnNotificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnNotificacion.Image")));
            this.btnNotificacion.Location = new System.Drawing.Point(842, 49);
            this.btnNotificacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNotificacion.Name = "btnNotificacion";
            this.btnNotificacion.Size = new System.Drawing.Size(43, 52);
            this.btnNotificacion.TabIndex = 25;
            this.btnNotificacion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(64)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(159, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cartelera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(159, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bienvenido";
            // 
            // flow_container
            // 
            this.flow_container.AutoScroll = true;
            this.flow_container.Location = new System.Drawing.Point(37, 167);
            this.flow_container.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flow_container.Name = "flow_container";
            this.flow_container.Size = new System.Drawing.Size(849, 399);
            this.flow_container.TabIndex = 26;
            // 
            // combo_city
            // 
            this.combo_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_city.FormattingEnabled = true;
            this.combo_city.Location = new System.Drawing.Point(465, 61);
            this.combo_city.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_city.Name = "combo_city";
            this.combo_city.Size = new System.Drawing.Size(138, 28);
            this.combo_city.TabIndex = 27;
            // 
            // combo_cine
            // 
            this.combo_cine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cine.FormattingEnabled = true;
            this.combo_cine.Location = new System.Drawing.Point(665, 63);
            this.combo_cine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_cine.Name = "combo_cine";
            this.combo_cine.Size = new System.Drawing.Size(138, 28);
            this.combo_cine.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label3.Location = new System.Drawing.Point(465, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label4.Location = new System.Drawing.Point(665, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cine";
            // 
            // ListingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_cine);
            this.Controls.Add(this.combo_city);
            this.Controls.Add(this.flow_container);
            this.Controls.Add(this.btnNotificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListingView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnNotificacion;
        private Label label2;
        private Label label1;
        public FlowLayoutPanel flow_container;
        public ComboBox combo_city;
        public ComboBox combo_cine;
        private Label label3;
        private Label label4;
    }
}