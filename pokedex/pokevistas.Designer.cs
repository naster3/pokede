
using System;

namespace pokedex
{
    partial class Pokevistas
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombre = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.ubicacionpoke = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(54, 133);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(35, 13);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "label1";
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Location = new System.Drawing.Point(180, 27);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(35, 13);
            this.tipo.TabIndex = 2;
            this.tipo.Text = "label1";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Location = new System.Drawing.Point(177, 91);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(35, 13);
            this.fecha.TabIndex = 3;
            this.fecha.Text = "label2";
            // 
            // ubicacionpoke
            // 
            this.ubicacionpoke.Location = new System.Drawing.Point(198, 133);
            this.ubicacionpoke.Name = "ubicacionpoke";
            this.ubicacionpoke.Size = new System.Drawing.Size(104, 23);
            this.ubicacionpoke.TabIndex = 5;
            this.ubicacionpoke.Text = "mapa pokemon";
            this.ubicacionpoke.UseVisualStyleBackColor = true;
            this.ubicacionpoke.Click += new System.EventHandler(this.Ubicacionpoke_Click);
            // 
            // imagen
            // 
            this.imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagen.Location = new System.Drawing.Point(3, 16);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(139, 114);
            this.imagen.TabIndex = 0;
            this.imagen.TabStop = false;
            this.imagen.Click += new System.EventHandler(this.Imagen_Click);
            // 
            // Pokevistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ubicacionpoke);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.imagen);
            this.Name = "Pokevistas";
            this.Size = new System.Drawing.Size(318, 173);
            this.Load += new System.EventHandler(this.Pokevistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Pokevistas_Load(object sender, EventArgs e) => throw new NotImplementedException();

        private void Imagen_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Button ubicacionpoke;
    }
}
