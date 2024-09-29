namespace TPFinalPOO
{
    partial class FormProducto
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
            btnGuardarProducto = new Button();
            txtStockProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            txtNombreProducto = new TextBox();
            txtIDProducto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            cmbTipo = new ComboBox();
            SuspendLayout();
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Location = new Point(298, 290);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(129, 56);
            btnGuardarProducto.TabIndex = 19;
            btnGuardarProducto.Text = "Guardar Producto";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            // 
            // txtStockProducto
            // 
            txtStockProducto.Location = new Point(198, 234);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(229, 27);
            txtStockProducto.TabIndex = 18;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(198, 201);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(229, 27);
            txtPrecioProducto.TabIndex = 17;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(198, 168);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(229, 27);
            txtNombreProducto.TabIndex = 15;
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(198, 102);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(229, 27);
            txtIDProducto.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 171);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 10;
            label5.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 237);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 11;
            label4.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 138);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 12;
            label3.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 204);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 13;
            label2.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 62);
            label6.Name = "label6";
            label6.Size = new Size(213, 20);
            label6.TabIndex = 8;
            label6.Text = "Ingrese los datos del Producto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 105);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(198, 135);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(229, 28);
            cmbTipo.TabIndex = 20;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 450);
            Controls.Add(cmbTipo);
            Controls.Add(btnGuardarProducto);
            Controls.Add(txtStockProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtIDProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "FormProducto";
            Text = "FormProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarProducto;
        private TextBox txtStockProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtNombreProducto;
        private TextBox txtIDProducto;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label1;
        private ComboBox cmbTipo;
    }
}