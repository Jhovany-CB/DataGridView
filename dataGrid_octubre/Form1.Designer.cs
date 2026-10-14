namespace dataGrid_octubre
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
            this.btn_insertar = new System.Windows.Forms.Button();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnAgregarFilas = new System.Windows.Forms.Button();
            this.btnValorCelda = new System.Windows.Forms.Button();
            this.btnObtenerValor = new System.Windows.Forms.Button();
            this.btnValorCeldaSeleccionada = new System.Windows.Forms.Button();
            this.btnCoordenadas = new System.Windows.Forms.Button();
            this.btnCantidadFilasColumnas = new System.Windows.Forms.Button();
            this.btnLlenarMatriz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(707, 17);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(131, 50);
            this.btn_insertar.TabIndex = 1;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dg1.Location = new System.Drawing.Point(43, 12);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(615, 394);
            this.dg1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Edad";
            this.Column3.Name = "Column3";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(707, 196);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 50);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Agregar Datos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(708, 85);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(130, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(708, 120);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(707, 157);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(130, 20);
            this.txtEdad.TabIndex = 6;
            // 
            // btnAgregarFilas
            // 
            this.btnAgregarFilas.Location = new System.Drawing.Point(708, 266);
            this.btnAgregarFilas.Name = "btnAgregarFilas";
            this.btnAgregarFilas.Size = new System.Drawing.Size(131, 50);
            this.btnAgregarFilas.TabIndex = 7;
            this.btnAgregarFilas.Text = "Agregar Filas";
            this.btnAgregarFilas.UseVisualStyleBackColor = true;
            this.btnAgregarFilas.Click += new System.EventHandler(this.btnAgregarFilas_Click);
            // 
            // btnValorCelda
            // 
            this.btnValorCelda.Location = new System.Drawing.Point(707, 332);
            this.btnValorCelda.Name = "btnValorCelda";
            this.btnValorCelda.Size = new System.Drawing.Size(131, 50);
            this.btnValorCelda.TabIndex = 8;
            this.btnValorCelda.Text = "Valor Celda";
            this.btnValorCelda.UseVisualStyleBackColor = true;
            this.btnValorCelda.Click += new System.EventHandler(this.btnValorCelda_Click);
            // 
            // btnObtenerValor
            // 
            this.btnObtenerValor.Location = new System.Drawing.Point(708, 388);
            this.btnObtenerValor.Name = "btnObtenerValor";
            this.btnObtenerValor.Size = new System.Drawing.Size(131, 50);
            this.btnObtenerValor.TabIndex = 9;
            this.btnObtenerValor.Text = "Obtener Valor";
            this.btnObtenerValor.UseVisualStyleBackColor = true;
            this.btnObtenerValor.Click += new System.EventHandler(this.btnObtenerValor_Click);
            // 
            // btnValorCeldaSeleccionada
            // 
            this.btnValorCeldaSeleccionada.Location = new System.Drawing.Point(863, 196);
            this.btnValorCeldaSeleccionada.Name = "btnValorCeldaSeleccionada";
            this.btnValorCeldaSeleccionada.Size = new System.Drawing.Size(131, 50);
            this.btnValorCeldaSeleccionada.TabIndex = 10;
            this.btnValorCeldaSeleccionada.Text = "Valor Celda Seleccionada";
            this.btnValorCeldaSeleccionada.UseVisualStyleBackColor = true;
            this.btnValorCeldaSeleccionada.Click += new System.EventHandler(this.btnValorCeldaSeleccionada_Click);
            // 
            // btnCoordenadas
            // 
            this.btnCoordenadas.Location = new System.Drawing.Point(863, 266);
            this.btnCoordenadas.Name = "btnCoordenadas";
            this.btnCoordenadas.Size = new System.Drawing.Size(131, 50);
            this.btnCoordenadas.TabIndex = 11;
            this.btnCoordenadas.Text = "Coordenadas";
            this.btnCoordenadas.UseVisualStyleBackColor = true;
            this.btnCoordenadas.Click += new System.EventHandler(this.btnCoordenadas_Click);
            // 
            // btnCantidadFilasColumnas
            // 
            this.btnCantidadFilasColumnas.Location = new System.Drawing.Point(863, 332);
            this.btnCantidadFilasColumnas.Name = "btnCantidadFilasColumnas";
            this.btnCantidadFilasColumnas.Size = new System.Drawing.Size(131, 50);
            this.btnCantidadFilasColumnas.TabIndex = 12;
            this.btnCantidadFilasColumnas.Text = "Cantidad Filas Columnas";
            this.btnCantidadFilasColumnas.UseVisualStyleBackColor = true;
            this.btnCantidadFilasColumnas.Click += new System.EventHandler(this.btnCantidadFilasColumnas_Click);
            // 
            // btnLlenarMatriz
            // 
            this.btnLlenarMatriz.Location = new System.Drawing.Point(863, 388);
            this.btnLlenarMatriz.Name = "btnLlenarMatriz";
            this.btnLlenarMatriz.Size = new System.Drawing.Size(131, 50);
            this.btnLlenarMatriz.TabIndex = 13;
            this.btnLlenarMatriz.Text = "Llenar Matriz";
            this.btnLlenarMatriz.UseVisualStyleBackColor = true;
            this.btnLlenarMatriz.Click += new System.EventHandler(this.btnLlenarMatriz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.btnLlenarMatriz);
            this.Controls.Add(this.btnCantidadFilasColumnas);
            this.Controls.Add(this.btnCoordenadas);
            this.Controls.Add(this.btnValorCeldaSeleccionada);
            this.Controls.Add(this.btnObtenerValor);
            this.Controls.Add(this.btnValorCelda);
            this.Controls.Add(this.btnAgregarFilas);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.btn_insertar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnAgregarFilas;
        private System.Windows.Forms.Button btnValorCelda;
        private System.Windows.Forms.Button btnObtenerValor;
        private System.Windows.Forms.Button btnValorCeldaSeleccionada;
        private System.Windows.Forms.Button btnCoordenadas;
        private System.Windows.Forms.Button btnCantidadFilasColumnas;
        private System.Windows.Forms.Button btnLlenarMatriz;
    }
}

