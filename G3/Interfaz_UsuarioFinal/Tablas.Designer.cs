
namespace Interfaz_UsuarioFinal
{
    partial class Tablas
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
            this.Lsv_Tablas = new System.Windows.Forms.ListView();
            this.Btn_MostrarTab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tablas";
            // 
            // Lsv_Tablas
            // 
            this.Lsv_Tablas.HideSelection = false;
            this.Lsv_Tablas.Location = new System.Drawing.Point(79, 110);
            this.Lsv_Tablas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lsv_Tablas.Name = "Lsv_Tablas";
            this.Lsv_Tablas.Size = new System.Drawing.Size(147, 250);
            this.Lsv_Tablas.TabIndex = 1;
            this.Lsv_Tablas.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_MostrarTab
            // 
            this.Btn_MostrarTab.ForeColor = System.Drawing.Color.Black;
            this.Btn_MostrarTab.Location = new System.Drawing.Point(79, 368);
            this.Btn_MostrarTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_MostrarTab.Name = "Btn_MostrarTab";
            this.Btn_MostrarTab.Size = new System.Drawing.Size(95, 32);
            this.Btn_MostrarTab.TabIndex = 2;
            this.Btn_MostrarTab.Text = "Mostrar";
            this.Btn_MostrarTab.UseVisualStyleBackColor = true;
            // 
            // Tablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Btn_MostrarTab);
            this.Controls.Add(this.Lsv_Tablas);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tablas";
            this.Text = "Tablas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Lsv_Tablas;
        private System.Windows.Forms.Button Btn_MostrarTab;
    }
}