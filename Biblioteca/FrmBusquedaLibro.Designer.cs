namespace Biblioteca
{
    partial class FrmBusquedaLibro
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
            label1 = new Label();
            btnBuscar = new Button();
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtEditorial = new TextBox();
            txtPais = new TextBox();
            label7 = new Label();
            lblDisp = new Label();
            btnActualizar = new Button();
            label8 = new Label();
            txtAnio = new TextBox();
            groupBox1 = new GroupBox();
            btnBorrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(165, 20);
            label1.Name = "label1";
            label1.Size = new Size(222, 32);
            label1.TabIndex = 0;
            label1.Text = "Busqueda de libro";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(379, 76);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 27);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(296, 76);
            txtId.Name = "txtId";
            txtId.Size = new Size(52, 27);
            txtId.TabIndex = 2;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 78);
            label2.Name = "label2";
            label2.Size = new Size(182, 25);
            label2.TabIndex = 3;
            label2.Text = "Ingrese el id del libro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 44);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 4;
            label3.Text = "Título:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 92);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 5;
            label4.Text = "Autor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 138);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 6;
            label5.Text = "Editorial:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(66, 186);
            label6.Name = "label6";
            label6.Size = new Size(46, 25);
            label6.TabIndex = 7;
            label6.Text = "País:";
            // 
            // txtTitulo
            // 
            txtTitulo.Enabled = false;
            txtTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(129, 42);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(147, 27);
            txtTitulo.TabIndex = 8;
            txtTitulo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAutor
            // 
            txtAutor.Enabled = false;
            txtAutor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAutor.Location = new Point(129, 90);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(147, 27);
            txtAutor.TabIndex = 9;
            txtAutor.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEditorial
            // 
            txtEditorial.Enabled = false;
            txtEditorial.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEditorial.Location = new Point(129, 136);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(147, 27);
            txtEditorial.TabIndex = 10;
            txtEditorial.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPais
            // 
            txtPais.Enabled = false;
            txtPais.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPais.Location = new Point(129, 184);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(147, 27);
            txtPais.TabIndex = 11;
            txtPais.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(11, 279);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 12;
            label7.Text = "Disponible:";
            // 
            // lblDisp
            // 
            lblDisp.AutoSize = true;
            lblDisp.Enabled = false;
            lblDisp.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisp.ForeColor = SystemColors.ControlText;
            lblDisp.Location = new Point(129, 284);
            lblDisp.Name = "lblDisp";
            lblDisp.Size = new Size(0, 20);
            lblDisp.TabIndex = 13;
            lblDisp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.Location = new Point(310, 176);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(109, 43);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(63, 236);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 15;
            label8.Text = "Año:";
            // 
            // txtAnio
            // 
            txtAnio.Enabled = false;
            txtAnio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnio.Location = new Point(129, 234);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(147, 27);
            txtAnio.TabIndex = 16;
            txtAnio.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(txtAnio);
            groupBox1.Controls.Add(lblDisp);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAutor);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEditorial);
            groupBox1.Controls.Add(txtPais);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(47, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 333);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del libro";
            // 
            // btnBorrar
            // 
            btnBorrar.Enabled = false;
            btnBorrar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Location = new Point(310, 236);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(109, 43);
            btnBorrar.TabIndex = 17;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // FrmBusquedaLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 486);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmBusquedaLibro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar libro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;

        // Clase que trata el archivo de texto.
        private LibroFileText libFileText;

        // Árbol binario de busqueda accesible a lo largo de toda la aplicación
        // mientras está en ejecución.
        private ABB abb;
        private Button btnBuscar;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtEditorial;
        private TextBox txtPais;
        private Label label7;
        private Label lblDisp;
        private Button btnActualizar;
        private Label label8;
        private TextBox txtAnio;
        private Libro l;
        private GroupBox groupBox1;
        private Button btnBorrar;
    }
}