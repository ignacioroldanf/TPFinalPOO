namespace TPFinalPOO
{
    partial class FormCliente
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtIDCliente = new TextBox();
            txtNombreCliente = new TextBox();
            txtApellidoCliente = new TextBox();
            txtEdadCliente = new TextBox();
            txtEmailCliente = new TextBox();
            btnGuardarCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 102);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 201);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 135);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 234);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 1;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 168);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 1;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 59);
            label6.Name = "label6";
            label6.Size = new Size(199, 20);
            label6.TabIndex = 0;
            label6.Text = "Ingrese los datos del Cliente:";
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(198, 99);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(229, 27);
            txtIDCliente.TabIndex = 2;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(198, 132);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(229, 27);
            txtNombreCliente.TabIndex = 3;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(198, 165);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(229, 27);
            txtApellidoCliente.TabIndex = 4;
            // 
            // txtEdadCliente
            // 
            txtEdadCliente.Location = new Point(198, 198);
            txtEdadCliente.Name = "txtEdadCliente";
            txtEdadCliente.Size = new Size(229, 27);
            txtEdadCliente.TabIndex = 5;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(198, 231);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(229, 27);
            txtEmailCliente.TabIndex = 6;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.Location = new Point(302, 283);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(125, 47);
            btnGuardarCliente.TabIndex = 7;
            btnGuardarCliente.Text = "Guardar Cliente";
            btnGuardarCliente.UseVisualStyleBackColor = true;
            btnGuardarCliente.Click += btnGuardarCliente_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 400);
            Controls.Add(btnGuardarCliente);
            Controls.Add(txtEmailCliente);
            Controls.Add(txtEdadCliente);
            Controls.Add(txtApellidoCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtIDCliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "FormCliente";
            Text = "Datos del Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtIDCliente;
        private TextBox txtNombreCliente;
        private TextBox txtApellidoCliente;
        private TextBox txtEdadCliente;
        private TextBox txtEmailCliente;
        private Button btnGuardarCliente;
    }
}