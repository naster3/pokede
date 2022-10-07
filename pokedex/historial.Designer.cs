
namespace pokedex
{
    partial class Historial
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boton_borrar_historial = new System.Windows.Forms.Button();
            this.boton_guardar_historial = new System.Windows.Forms.Button();
            this.caragar_tabla = new System.Windows.Forms.Button();
            this.exportar_html = new System.Windows.Forms.Button();
            this.exportar_csv = new System.Windows.Forms.Button();
            this.exportar_txt = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.idPokemonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPokemonDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.pokemonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // boton_borrar_historial
            // 
            this.boton_borrar_historial.Location = new System.Drawing.Point(855, 41);
            this.boton_borrar_historial.Name = "boton_borrar_historial";
            this.boton_borrar_historial.Size = new System.Drawing.Size(87, 23);
            this.boton_borrar_historial.TabIndex = 1;
            this.boton_borrar_historial.Text = "borrar historial";
            this.boton_borrar_historial.UseVisualStyleBackColor = true;
            this.boton_borrar_historial.Click += new System.EventHandler(this.Boton_borrar_historial_Click);
            // 
            // boton_guardar_historial
            // 
            this.boton_guardar_historial.Location = new System.Drawing.Point(855, 91);
            this.boton_guardar_historial.Name = "boton_guardar_historial";
            this.boton_guardar_historial.Size = new System.Drawing.Size(87, 23);
            this.boton_guardar_historial.TabIndex = 2;
            this.boton_guardar_historial.Text = "guardar ";
            this.boton_guardar_historial.UseVisualStyleBackColor = true;
            this.boton_guardar_historial.Click += new System.EventHandler(this.Boton_guardar_historial_Click);
            // 
            // caragar_tabla
            // 
            this.caragar_tabla.Location = new System.Drawing.Point(855, 141);
            this.caragar_tabla.Name = "caragar_tabla";
            this.caragar_tabla.Size = new System.Drawing.Size(87, 23);
            this.caragar_tabla.TabIndex = 3;
            this.caragar_tabla.Text = "cargar tabla";
            this.caragar_tabla.UseVisualStyleBackColor = true;
            this.caragar_tabla.Click += new System.EventHandler(this.Button1_Click);
            // 
            // exportar_html
            // 
            this.exportar_html.Location = new System.Drawing.Point(17, 338);
            this.exportar_html.Name = "exportar_html";
            this.exportar_html.Size = new System.Drawing.Size(89, 23);
            this.exportar_html.TabIndex = 4;
            this.exportar_html.Text = "exportar en html";
            this.exportar_html.UseVisualStyleBackColor = true;
            this.exportar_html.Click += new System.EventHandler(this.Exportar_html_Click);
            // 
            // exportar_csv
            // 
            this.exportar_csv.Location = new System.Drawing.Point(137, 338);
            this.exportar_csv.Name = "exportar_csv";
            this.exportar_csv.Size = new System.Drawing.Size(89, 23);
            this.exportar_csv.TabIndex = 5;
            this.exportar_csv.Text = "exportar de csv";
            this.exportar_csv.UseVisualStyleBackColor = true;
            this.exportar_csv.Click += new System.EventHandler(this.Exportar_csv_Click);
            // 
            // exportar_txt
            // 
            this.exportar_txt.Location = new System.Drawing.Point(257, 338);
            this.exportar_txt.Name = "exportar_txt";
            this.exportar_txt.Size = new System.Drawing.Size(89, 23);
            this.exportar_txt.TabIndex = 6;
            this.exportar_txt.Text = "exportar de txt";
            this.exportar_txt.UseVisualStyleBackColor = true;
            this.exportar_txt.Click += new System.EventHandler(this.Exportar_txt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // idPokemonDataGridViewTextBoxColumn
            // 
            this.idPokemonDataGridViewTextBoxColumn.DataPropertyName = "idPokemon";
            this.idPokemonDataGridViewTextBoxColumn.FillWeight = 150F;
            this.idPokemonDataGridViewTextBoxColumn.HeaderText = "idPokemon";
            this.idPokemonDataGridViewTextBoxColumn.Name = "idPokemonDataGridViewTextBoxColumn";
            this.idPokemonDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 150F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.FillWeight = 150F;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.FillWeight = 150F;
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.Width = 150;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "image";
            this.imageDataGridViewImageColumn.FillWeight = 150F;
            this.imageDataGridViewImageColumn.HeaderText = "image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            this.imageDataGridViewImageColumn.Width = 150;
            // 
            // pokemonBindingSource
            // 
            this.pokemonBindingSource.DataSource = typeof(pokedex.pokemon);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exportar_txt);
            this.Controls.Add(this.exportar_csv);
            this.Controls.Add(this.exportar_html);
            this.Controls.Add(this.caragar_tabla);
            this.Controls.Add(this.boton_guardar_historial);
            this.Controls.Add(this.boton_borrar_historial);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Historial";
            this.Size = new System.Drawing.Size(962, 377);
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button boton_borrar_historial;
        private System.Windows.Forms.Button boton_guardar_historial;
        private System.Windows.Forms.Button caragar_tabla;
        private System.Windows.Forms.Button exportar_html;
        private System.Windows.Forms.Button exportar_csv;
        private System.Windows.Forms.Button exportar_txt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource pokemonBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPokemonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
    }
}
