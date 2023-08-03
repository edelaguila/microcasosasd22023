
namespace Interfaz_UsuarioFinal
{
    partial class Equipos
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
            this.Lsv_Equipos = new System.Windows.Forms.ListView();
            this.Btn_MostrarEquipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipos";
            // 
            // Lsv_Equipos
            // 
            this.Lsv_Equipos.HideSelection = false;
            this.Lsv_Equipos.Location = new System.Drawing.Point(68, 97);
            this.Lsv_Equipos.Name = "Lsv_Equipos";
            this.Lsv_Equipos.Size = new System.Drawing.Size(126, 196);
            this.Lsv_Equipos.TabIndex = 1;
            this.Lsv_Equipos.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_MostrarEquipo
            // 
            this.Btn_MostrarEquipo.Location = new System.Drawing.Point(68, 299);
            this.Btn_MostrarEquipo.Name = "Btn_MostrarEquipo";
            this.Btn_MostrarEquipo.Size = new System.Drawing.Size(83, 28);
            this.Btn_MostrarEquipo.TabIndex = 2;
            this.Btn_MostrarEquipo.Text = "Mostrar";
            this.Btn_MostrarEquipo.UseVisualStyleBackColor = true;
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_MostrarEquipo);
            this.Controls.Add(this.Lsv_Equipos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Equipos";
            this.Text = "Equipos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Lsv_Equipos;
        private System.Windows.Forms.Button Btn_MostrarEquipo;
    }
}