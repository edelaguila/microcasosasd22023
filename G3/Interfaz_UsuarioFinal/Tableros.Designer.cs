
namespace Interfaz_UsuarioFinal
{
    partial class Tableros
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
            this.Lsv_Tableros = new System.Windows.Forms.ListView();
            this.Btn_MostrarTablero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tablero";
            // 
            // Lsv_Tableros
            // 
            this.Lsv_Tableros.HideSelection = false;
            this.Lsv_Tableros.Location = new System.Drawing.Point(79, 110);
            this.Lsv_Tableros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lsv_Tableros.Name = "Lsv_Tableros";
            this.Lsv_Tableros.Size = new System.Drawing.Size(147, 250);
            this.Lsv_Tableros.TabIndex = 1;
            this.Lsv_Tableros.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_MostrarTablero
            // 
            this.Btn_MostrarTablero.Location = new System.Drawing.Point(79, 368);
            this.Btn_MostrarTablero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_MostrarTablero.Name = "Btn_MostrarTablero";
            this.Btn_MostrarTablero.Size = new System.Drawing.Size(95, 32);
            this.Btn_MostrarTablero.TabIndex = 2;
            this.Btn_MostrarTablero.Text = "Mostrar";
            this.Btn_MostrarTablero.UseVisualStyleBackColor = true;
            this.Btn_MostrarTablero.Click += new System.EventHandler(this.Btn_MostrarTablero_Click);
            // 
            // Tableros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Btn_MostrarTablero);
            this.Controls.Add(this.Lsv_Tableros);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tableros";
            this.Text = "Tableros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Lsv_Tableros;
        private System.Windows.Forms.Button Btn_MostrarTablero;
    }
}