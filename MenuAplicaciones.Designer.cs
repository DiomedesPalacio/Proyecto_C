namespace Evaluacion_Final
{
    partial class MenuAplicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAplicaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFase2 = new System.Windows.Forms.Button();
            this.btnFase3 = new System.Windows.Forms.Button();
            this.btnFase4 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECCIONE LA APLICACION QUE DESEA EJECUTAR";
            // 
            // btnFase2
            // 
            this.btnFase2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFase2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFase2.ForeColor = System.Drawing.Color.White;
            this.btnFase2.Location = new System.Drawing.Point(132, 76);
            this.btnFase2.Name = "btnFase2";
            this.btnFase2.Size = new System.Drawing.Size(258, 37);
            this.btnFase2.TabIndex = 2;
            this.btnFase2.Text = "Aplicación Fase 2";
            this.btnFase2.UseVisualStyleBackColor = false;
            this.btnFase2.Click += new System.EventHandler(this.btnFase2_Click);
            // 
            // btnFase3
            // 
            this.btnFase3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFase3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFase3.ForeColor = System.Drawing.Color.White;
            this.btnFase3.Location = new System.Drawing.Point(135, 133);
            this.btnFase3.Name = "btnFase3";
            this.btnFase3.Size = new System.Drawing.Size(258, 37);
            this.btnFase3.TabIndex = 3;
            this.btnFase3.Text = "Aplicaciones Fase 3";
            this.btnFase3.UseVisualStyleBackColor = false;
            this.btnFase3.Click += new System.EventHandler(this.btnFase3_Click);
            // 
            // btnFase4
            // 
            this.btnFase4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFase4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFase4.ForeColor = System.Drawing.Color.White;
            this.btnFase4.Location = new System.Drawing.Point(132, 194);
            this.btnFase4.Name = "btnFase4";
            this.btnFase4.Size = new System.Drawing.Size(258, 37);
            this.btnFase4.TabIndex = 4;
            this.btnFase4.Text = "Aplicaciones Fase 4";
            this.btnFase4.UseVisualStyleBackColor = false;
            this.btnFase4.Click += new System.EventHandler(this.btnFase4_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(146, 252);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(231, 27);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR DE LA APLICACIÓN";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(529, 302);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFase4);
            this.Controls.Add(this.btnFase3);
            this.Controls.Add(this.btnFase2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAplicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de saelección de aplicaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFase2;
        private System.Windows.Forms.Button btnFase3;
        private System.Windows.Forms.Button btnFase4;
        private System.Windows.Forms.Button btnSalir;
    }
}