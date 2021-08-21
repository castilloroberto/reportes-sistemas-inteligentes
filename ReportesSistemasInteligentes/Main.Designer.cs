
namespace ReportesSistemasInteligentes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_reporteProductos = new System.Windows.Forms.Button();
            this.btn_reporteFiltro = new System.Windows.Forms.Button();
            this.txt_parametro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_reporteProductos
            // 
            this.btn_reporteProductos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_reporteProductos.FlatAppearance.BorderSize = 0;
            this.btn_reporteProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporteProductos.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporteProductos.ForeColor = System.Drawing.Color.White;
            this.btn_reporteProductos.Location = new System.Drawing.Point(580, 228);
            this.btn_reporteProductos.Name = "btn_reporteProductos";
            this.btn_reporteProductos.Size = new System.Drawing.Size(210, 54);
            this.btn_reporteProductos.TabIndex = 0;
            this.btn_reporteProductos.Text = "Reporte Productos";
            this.btn_reporteProductos.UseVisualStyleBackColor = false;
            this.btn_reporteProductos.Click += new System.EventHandler(this.btn_reporteProductos_Click);
            // 
            // btn_reporteFiltro
            // 
            this.btn_reporteFiltro.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_reporteFiltro.FlatAppearance.BorderSize = 0;
            this.btn_reporteFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporteFiltro.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporteFiltro.ForeColor = System.Drawing.Color.White;
            this.btn_reporteFiltro.Location = new System.Drawing.Point(580, 357);
            this.btn_reporteFiltro.Name = "btn_reporteFiltro";
            this.btn_reporteFiltro.Size = new System.Drawing.Size(210, 54);
            this.btn_reporteFiltro.TabIndex = 2;
            this.btn_reporteFiltro.Text = "Reporte Filtro";
            this.btn_reporteFiltro.UseVisualStyleBackColor = false;
            this.btn_reporteFiltro.Click += new System.EventHandler(this.btn_reporteFiltro_Click);
            // 
            // txt_parametro
            // 
            this.txt_parametro.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parametro.Location = new System.Drawing.Point(580, 312);
            this.txt_parametro.Name = "txt_parametro";
            this.txt_parametro.Size = new System.Drawing.Size(210, 34);
            this.txt_parametro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(629, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1446, 100);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1446, 812);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_parametro);
            this.Controls.Add(this.btn_reporteFiltro);
            this.Controls.Add(this.btn_reporteProductos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_reporteProductos;
        private System.Windows.Forms.Button btn_reporteFiltro;
        public  System.Windows.Forms.TextBox txt_parametro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

